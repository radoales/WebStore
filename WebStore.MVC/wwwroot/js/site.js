//Show image name in Input field
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

//$(".searchString").change(function () {
//    $(this).closest('form').submit();
//});

function updateItemsInCart(items) {
    document.getElementById("items-in-cart").innerHTML = items;
};

//----------------Product types dropdown----------------------->
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

//Hide ProductType dropdown when no category is selected
function hideProductTypeDropdown() {
    var x = document.getElementById("CategoryId").value;
    if (x === "0") {
        document.getElementById("productTypes").style.visibility = "hidden";
    }

}

//------------------------------------------------------//


//------------------------Modal------------------------->
function addModal(name, price, image) {
    const div = document.createElement('div');

    div.className = 'row';

    div.innerHTML = `
     <!-- Modal content -->

        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <img style="max-width:100%" src="${image}" />
                </div>
                <div class="col-sm-9">
                     <h4>"${name}" (${price} kr.) was added to your cart</h4>
                </div>
            </div>
        </div>
  `;

    document.getElementById('modal-input').appendChild(div);

    //When Click outside the Modal, Remove the Modal
    window.onclick = function () {
        var list = document.getElementById("modal-input");
        list.removeChild(list.childNodes[0]);
    }

}

//------------------Add to Card--------------------------------->
function addToCart(id, name, price, image) {
    $.ajax({
        type: 'POST',
        url: "/cart/AddToCart",
        data: { "productId": id },
        success: function (result) {
            updateItemsInCart(result);
            addModal(name, price, image)
        }
    });
};

//-----------------Carousel Slideshow--------------------------->
$(document).ready(function () {
    $('.carousel').carousel({
        interval: 5000
    });
});

//-------------------------Searchbar----------------------------->
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Products/GetAllProductNames",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            $("#searchString").keyup(function (e) {
                $("#searchString").autocomplete({
                    source: response
                });
            });
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
});


//Cart.Index

//function deleteItem(id) {
//    $.ajax({
//        type: 'POST',
//        url: "/cart/DeleteCartItem",
//        data: { "id": id },
//        success: function (result) {
//            $("body").html(result);
//        }
//    });
//}


//$(".change-quantity").change(function () {
//    var id;
//    var productId;
//    var quantity;
//    var arr = [];

//    $(this).children("input").each(function () {
//        arr.push(this.value);
//    });
//    id = arr[0];
//    productId = arr[1];
//    quantity = arr[2];

//    $.ajax({
//        type: 'POST',
//        url: "/Cart/EditCartItemQuantity",
//        data: { "id": id, "productId": productId, "quantity": quantity },
//        success: function (result) {
//            $("body").html(result);
//        }
//    });
//});