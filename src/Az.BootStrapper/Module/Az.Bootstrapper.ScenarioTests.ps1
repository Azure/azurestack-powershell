Import-Module -Name Az.Bootstrapper
$RollupModule = 'Az'

# Enable PS Remoting for creating new sessions; This setting is required to create new powershell sessions in Core.
Enable-PSRemoting
$psConfig = Get-PSSessionConfiguration
$psConfigName = $psConfig[0].Name

InModuleScope Az.Bootstrapper {
    $ProfileMap = (Get-AzProfileMap)

    # Helper function to uninstall all profiles
    function Remove-InstalledProfile {
        $installedProfiles = Get-ProfilesInstalled -ProfileMap $ProfileMap
        if ($null -ne $installedProfiles.Keys) {
            foreach ($profile in $installedProfiles.Keys) {
                Write-Host "Removing profile $profile"
                Uninstall-AzProfile -Profile $profile -Force -ErrorAction SilentlyContinue
            }
            
            $profiles = (Get-ProfilesInstalled -ProfileMap $ProfileMap)
            if ($profiles.Count -ne 0) {
                Throw "Uninstallation was not successful: Profile(s) $(@($profiles.Keys) -join ',') were not uninstalled correctly."
            }
        }
    }

    Describe "A machine with no profile installed can install profile" {

        # Using Install-AzProfile
        Context "New Profile Install - 2019-03-01-hybrid" {
            # Arrange
            # Uninstall previously installed profiles
            Remove-InstalledProfile

            # Launch the test in a new powershell session
            # Create a new PS session
            $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName
              
            # Keep this for testing private drops
            # Invoke-Command -Session $session -ScriptBlock { Register-PSRepository -Name "azsrepo" -SourceLocation "D:\psrepo" -InstallationPolicy Trusted }
            # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }

            # Act
            # Install 2019-03-01-hybrid version
            Invoke-Command -Session $session -ScriptBlock { Install-AzProfile -Profile '2019-03-01-hybrid' -Force } 

            # Assert; This test will fail if run on PS 5.1; works only on core due to GMO 'Az' returns empty on 5.1 bug.
            It "Should return 2019-03-01-hybrid Profile" {
                $result = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile }
                $result[0].ProfileName.Contains('2019-03-01-hybrid') | Should Be $true
            }

            # Clean up
            Remove-PSSession -Session $session
        } 

        # Using Use-AzProfile
        Context "New Profile Install - 2019-03-01-hybrid using Use-AzProfile" {
            # Arrange
            # Uninstall previously installed profiles
            Remove-InstalledProfile

            # Create a new PS session
            $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

            # Act
            # Install profile '2019-03-01-hybrid'
            # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
            Invoke-Command -Session $session -ScriptBlock { Use-AzProfile -Profile '2019-03-01-hybrid' -Force }

            # Assert
            It "Should return 2019-03-01-hybrid" {
                $result = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile } 
                $result[0].ProfileName.Contains('2019-03-01-hybrid') | Should Be $true
            }

            # Clean up
            Remove-PSSession -Session $session
        }
    }


    Describe "Attempting to use already installed profile will import the modules to the current session" {
        InModuleScope Az.Bootstrapper {
            Context "Profile 2019-03-01-hybrid is installed" {
                # Should import Latest profile to current session
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName


                # Ensure profile 2019-03-01-hybrid is installed
                $profilesInstalled = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile } 
                ($profilesInstalled -like "*hybrid*") -ne $null | Should Be $true

                # Act
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                Invoke-Command -Session $session -ScriptBlock { Use-AzProfile -Profile '2019-03-01-hybrid' -Force }

                # Get the version of the 2019-03-01-hybrid profile
                $ProfileMap = Get-AzProfileMap
                $latestVersion = $ProfileMap.'2019-03-01-hybrid'.$RollupModule

                # Assert
                It "Should return Az module 2019-03-01-hybrid version" {
                    # Get-module script block
                    $getModule = {
                        Param($RollupModule)
                        Get-Module -Name $RollupModule 
                    }

                    $modules = Invoke-Command -Session $session -ScriptBlock $getModule -ArgumentList $RollupModule
                
                    $modules.Name | Should Be $RollupModule
                    $modules.version | Should Be $latestVersion
                }

                # Cleanup
                Remove-PSSession -Session $session
            }
        }
    }

    Describe "User can uninstall a profile" {
        InModuleScope Az.Bootstrapper {
            Context "2019-03-01-hybrid profile is installed" {
                # Should uninstall 2019-03-01-hybrid profile
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

                # Check if '2019-03-01-hybrid' is installed
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                $profilesInstalled = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile } 
                ($profilesInstalled -like "*hybrid*") -ne $null | Should Be $true

                # Get the version of the Latest profile
                $ProfileMap = Get-AzProfileMap
                $latestVersion = $ProfileMap.'2019-03-01-hybrid'.$RollupModule

                # Act
                Invoke-Command -Session $session -ScriptBlock { Uninstall-AzProfile -Profile '2019-03-01-hybrid' -Force }
            
                # Assert
                It "Profile 2019-03-01-hybrid is uninstalled" {
                    $result = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile }
                    if ($result -ne $null) {
                        $result.Contains('2019-03-01-hybrid') | Should Be $false
                    }
                    else {
                        $true
                    }
                }

                It "Available Modules should not contain uninstalled modules" {
                    $getModule = {
                        Param($RollupModule)
                        Get-Module -Name $RollupModule -ListAvailable
                    }
                    $results = Invoke-Command -Session $session -ScriptBlock $getModule -ArgumentList $RollupModule
                    
                    foreach ($result in $results) {
                        $result.Version -eq $latestVersion | Should Be $false
                    }
                        
                }

                # Cleanup
                Remove-PSSession -Session $session
            }
        }
    }

    Describe "Invalid Cases" {
        Context "Install wrong profile name" {
            # Install profile 'abcTest'
            It "Throws Invalid argument error" {
                { Install-AzProfile -Profile 'abcTest' } | Should Throw
            }
        }

        Context "Install null profile name" {
            # Install profile 'null'
            It "Throws Invalid argument error" {
                { Install-AzProfile -Profile $null } | Should Throw
            }
        }

        Context "Install already installed profile" {
            # Arrange
            # Create a new PS session
            $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName
            # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }

            # Ensure profile 2019-03-01-hybrid is installed
            Set-BootStrapRepo -Repo azsrepo
            Install-AzProfile -Profile '2019-03-01-hybrid' -Force
            $installedProfile = Invoke-Command -Session $session -ScriptBlock { Get-AzApiProfile }
            ($installedProfile -like "*hybrid*") -ne $null | Should Be $true
            
            # Act
            # Install profile '2019-03-01-hybrid'
            $result = Invoke-Command -Session $session -ScriptBlock { Install-AzProfile -Profile '2019-03-01-hybrid' -Force } 

            # Get modules imported into the session
            $getModuleList = {
                Param($RollupModule)
                Get-Module -Name $RollupModule
            }
            $modules = Invoke-Command -Session $session -ScriptBlock $getModuleList  -ArgumentList $RollupModule

            It "Doesn't install/import the profile" {
                $result | Should Be $null
                $modules | Should Be $null
            }

            # Cleanup
            Remove-PSSession -Session $session
        }

        Context "Use-AzProfile with wrong profile name" {
            # Install profile 'abcTest'
            It "Throws Invalid argument error" {
                { Use-AzProfile -Profile 'abcTest' } | Should Throw
            }
        }
    }

    Describe "Install profiles using Scope" {
        InModuleScope Az.Bootstrapper {
            Context "Using Install-AzProfile: Scope 'CurrentUser'" {
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

                # Remove installed profiles
                Remove-InstalledProfile 

                # Act
                # Install profile 2019-03-01-hybrid scope as current user
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                Invoke-Command -Session $session -ScriptBlock { Install-AzProfile -Profile '2019-03-01-hybrid' -scope 'CurrentUser' -Force }

                # Assert
                It "Installs & Imports 2019-03-01-hybrid profile to the session" {
                    # Get the version of the Latest profile
                    $ProfileMap = Get-AzProfileMap
                    $latestVersion = $ProfileMap.'2019-03-01-hybrid'.$RollupModule
                    
                    $getModuleList = {
                        Param($RollupModule, $latestVersion)
                        Get-Module -Name $RollupModule -ListAvailable | Where-Object { $_.Version -like $latestVersion }
                    }
                    $modules = Invoke-Command -Session $session -ScriptBlock $getModuleList  -ArgumentList @($RollupModule, $latestVersion)

                    # Are latest modules imported?
                    $modules.Name | Should Be $RollupModule
                    $modules.version | Should Be $latestVersion
                }
            }

            Context "Using Use-AzProfile: Scope 'AllUsers'" {
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

                # Remove installed profiles
                Remove-InstalledProfile 

                # Act
                # Install profile 2019-03-01-hybrid scope as all users
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                Invoke-Command -Session $session -ScriptBlock { Use-AzProfile -Profile '2019-03-01-hybrid' -scope 'AllUsers' -Force }

                # Assert
                It "Installs & Imports 2019-03-01-hybrid profile to the session" {
                    $getModuleList = {
                        Param($RollupModule)
                        Get-Module -Name $RollupModule
                    }
                    $modules = Invoke-Command -Session $session -ScriptBlock $getModuleList  -ArgumentList $RollupModule

                    # Get the version of the 2019-03-01-hybrid profile
                    $ProfileMap = Get-AzProfileMap
                    $version = $ProfileMap.'2019-03-01-hybrid'.$RollupModule
                
                    # Are appropriate modules imported?
                    $modules.Name | Should Be $RollupModule
                    $modules.version | Should Be $version
                }
            }

            Context "Using Update-AzProfile: Scope 'CurrentUser' " {
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

                # Remove installed profiles
                Remove-InstalledProfile 

                # Act
                # Install profile 2019-03-01-hybrid scope as current user
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                Invoke-Command -Session $session -ScriptBlock { Update-AzProfile -Profile '2019-03-01-hybrid' -scope 'CurrentUser' -Force -r }

                # Assert
                It "Installs & Imports 2019-03-01-hybrid profile to the session" {
                    $getModuleList = {
                        Param($RollupModule)
                        Get-Module -Name $RollupModule
                    }
                    $modules = Invoke-Command -Session $session -ScriptBlock $getModuleList  -ArgumentList $RollupModule

                    # Get the version of the 2019-03-01-hybrid profile
                    $ProfileMap = Get-AzProfileMap
                    $version = $ProfileMap.'2019-03-01-hybrid'.$RollupModule
                
                    # Are correct modules imported?
                    $modules.Name | Should Be $RollupModule
                    $modules.version | Should Be $version
                }
            }
        }
    }

    Describe "Load/Import AzProfile modules" {
        InModuleScope Az.Bootstrapper {
            Context "Using Use-AzProfile: Modules are not installed" {
                # Arrange
                # Create a new PS session
                $session = New-PSSession -ComputerName localhost -ConfigurationName $psConfigName

                # Remove installed profiles
                Remove-InstalledProfile 

                # Act
                # Use module from Latest profile scope as current user
                # Invoke-Command -Session $session -ScriptBlock { Set-BootStrapRepo -Repo azsrepo }
                Invoke-Command -Session $session -ScriptBlock { Use-AzProfile -Profile '2019-03-01-hybrid' -Module 'Az.Storage' -Force -scope 'CurrentUser' }

                # Assert
                $RollupModule = 'Az.Storage'
                It "Installs & Imports 2019-03-01-hybrid profile's module to the session" {
                    $getModuleList = {
                        Param($RollupModule)
                        Get-Module -Name $RollupModule
                    }
                    $modules = Invoke-Command -Session $session -ScriptBlock $getModuleList  -ArgumentList $RollupModule

                    # Get the version of the 2019-03-01-hybrid profile
                    $ProfileMap = Get-AzProfileMap
                    $version = $ProfileMap.'2019-03-01-hybrid'.$RollupModule
                
                    # Are 2019-03-01-hybrid modules imported?
                    $modules.Name | Should Be $RollupModule
                    $modules.version | Should Be $version
                }
            }
        }
    }
}