# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------


$global:SkippedTests = @(
    'TestListInvalidLocation',
    'TestCreateQuotaOnInvalidLocation'
)

$global:Location = "northwest"
$global:ResourceGroupName = "System.local"
$global:Provider = "Microsoft.Compute.Admin"
$global:VHDUri = "https://hamurphystorageaccount.blob.northwest.azs-longhaul-02.selfhost.corp.microsoft.com/hamurphy-blob-for-fixed-vhd/hamurphy-fixed.vhd?sv=2017-04-17&ss=bqt&srt=sco&sp=rwdlacup&se=2020-02-15T02:34:09Z&st=2020-02-14T18:34:09Z&spr=https&sig=e3pFp1m9iU%2F8xptI73cfqO5kVII8cXKFf2gnBxkK3BM%3D"


$global:Client = $null

if (-not $global:RunRaw) {
    $scriptBlock = {
        if ($null -eq $global:Client) {
            $global:Client = Get-MockClient -ClassName 'ComputeAdminClient' -TestName $global:TestName -Verbose
        }
        return $global:Client
    }
    Mock New-ServiceClient $scriptBlock -ModuleName $global:ModuleName
}

if (Test-Path "$PSScriptRoot\Override.ps1") {
    . $PSScriptRoot\Override.ps1
}