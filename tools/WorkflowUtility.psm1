# Function to convert an array of strings into a Json array of strings.
function Convert-FromArrayToJsonArrayString
{
    param
    (
        [Parameter(Mandatory = $true)]
        [AllowEmptyCollection()]
        [String[]] $ArrayOfStrings
    )
    $result = ($ArrayOfStrings | ForEach-Object {"`"${_}`""}) -join ","
    $result = "[${result}]"
    return $result
}