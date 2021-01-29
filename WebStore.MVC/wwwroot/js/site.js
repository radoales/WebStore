//Show image name in upload field
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

//Hide ProductType dropdown when no category is selected
function hideProductTypeDropdown() {
    var x = document.getElementById("CategoryId").value;
    if (x === "0") {
        document.getElementById("productTypes").style.visibility = "hidden";
    }

}

$(".searchString").change(function () {
    $(this).closest('form').submit();
});
