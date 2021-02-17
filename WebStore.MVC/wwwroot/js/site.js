//Show image name in Input field
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

function updateItemsInCart(items) {
    document.getElementById("items-in-cart").innerHTML = items;
};

//----------------Pick Product Type from Category----------------------->
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

//-------------------------CreateOrder----------------------------->
//ShippingAddress Same As Billing
function check() {
    var checkbox = document.getElementById('ShippingSameAsBillingCheck');
    var form = document.getElementById('address-form');
    if (checkbox.checked == true) {
        form.hidden = true;
    } else {
        form.hidden = false;
    }
}    

//-------------------------Paging----------------------------->
//Go to specified page
function paging(pageNumber) {
    var e = document.getElementById("sortId");
    var sortId = e.options[e.selectedIndex].text;
    var productTypeId = $('#productTypeId').attr('data-value');

    $.ajax({
        type: 'GET',
        url: "/products/index",
        data: { "pageNumber": pageNumber, "productTypeId": productTypeId, "sortBy": sortId },
        success: function (result) {
            $("body").html(result);
        }
    });
}

//-------------------------Sorting----------------------------->
$(document).ready(function () {
    $('#sortId').change(function () {
        var sortId = $(this).val();
        var productTypeId = $('#productTypeId').attr('data-value');
        $.ajax({
            type: 'GET',
            url: "/products/index",
            data: { "productTypeId": productTypeId, "sortBy": sortId },
            success: function (result) {
                $("body").html(result);
            }
        });
    });
})
