function ValidateGalleryItem {
    param(
        [Parameter(Mandatory = $true)]
        $GalleryItem
    )

    $GalleryItem          | Should Not Be $null

    # Resource
    $GalleryItem.Id       | Should Not Be $null
    $GalleryItem.Name     | Should Not Be $null
    $GalleryItem.Type     | Should Not Be $null

    # Gallery Item
    $GalleryItem.Artifact				| Should Not Be $null
    $GalleryItem.ChangedTime			| Should Not Be $null
    $GalleryItem.CreatedTime			| Should Not Be $null
    $GalleryItem.Description			| Should Not Be $null
    $GalleryItem.Identity				| Should Not Be $null
    $GalleryItem.Image  				| Should Not Be $null
    $GalleryItem.ItemDisplayName		| Should Not Be $null
    $GalleryItem.ItemName				| Should Not Be $null
    $GalleryItem.ItemType				| Should Not Be $null
    $GalleryItem.LongSummary			| Should Not Be $null
    $GalleryItem.Publisher				| Should Not Be $null
    $GalleryItem.PublisherDisplayName	| Should Not Be $null
    $GalleryItem.Summary				| Should Not Be $null
    $GalleryItem.UiDefinitionUri		| Should Not Be $null
    $GalleryItem.Version				| Should Not Be $null

}

function AssertGalleryItemsAreSame {
    param(
        [Parameter(Mandatory = $true)]
        $Expected,

        [Parameter(Mandatory = $true)]
        $Found
    )
    if ($Expected -eq $null) {
        $Found | Should Be $null
    } else {
        $Found                  | Should Not Be $null

        # Resource
        $Found.Id               | Should Be $Expected.Id
        $Found.Location         | Should Be $Expected.Location
        $Found.Name             | Should Be $Expected.Name
        $Found.Type             | Should Be $Expected.Type

        # Gallery Item
        if ($Expected.CategoryIds -and $Found.CategoryIds) {
            $Found.CategoryIds				| Should Be $Expected.CategoryIds
        } elseif (($null -ne $Expected.CategoryIds) -and ($null -eq $Found.CategoryIds)) {
            throw "Category Ids do not match Expected: $($Expected.CategoryIds)"
        }
        $Found.Description				| Should Be $Expected.Description
        $Found.LongSummary				| Should Be $Expected.LongSummary
        $Found.Publisher				| Should Be $Expected.Publisher
        $Found.PublisherDisplayName		| Should Be $Expected.PublisherDisplayName
        $Found.UiDefinitionUri			| Should Be $Expected.UiDefinitionUri
        $Found.Version					| Should Be $Expected.Version

    }
}
