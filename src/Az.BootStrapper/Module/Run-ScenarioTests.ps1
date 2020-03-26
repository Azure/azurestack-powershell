#Requires -Modules Az.Bootstrapper, Pester

$defaults = [System.IO.Path]::GetDirectoryName($PSCommandPath)
Set-Location $defaults 

. .\Az.Bootstrapper.ScenarioTests.ps1