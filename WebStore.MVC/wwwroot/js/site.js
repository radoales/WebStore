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

function updateItemsInCart(items) {
    document.getElementById("items-in-cart").innerHTML = items;
};

function addToCart(id) {
    $.ajax({
        type: 'POST',
        url: "/cart/addtocart",
        data: { "productId": id },
        success: function (result) {
            updateItemsInCart(result);
        }
    });
};

function selectProductType(productTypeId) {
    $.ajax({
        type: 'GET',
        url: "/products/index",
        data: { "productTypeId": productTypeId },
        success: function (result) {
            $("body").html(result);
        }
    });
}
