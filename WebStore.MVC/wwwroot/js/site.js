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

//function addToCart(id) {
//    $.ajax({
//        type: 'POST',
//        url: "/cart/addtocart",
//        data: { "productId": id },
//        success: function (result) {
//            updateItemsInCart(result);
//        }
//    });
//};

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

function addRow(name, price, image) {
    const div = document.createElement('div');

    div.className = 'row';

    div.innerHTML = `
     <!-- Modal content -->
        <div class="modal-content">
            <span class="close"></span>
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
        </div>
  `;

    document.getElementById('myModal').appendChild(div);

    // Get the modal
    var modal = document.getElementById("myModal");

    // Get the button that opens the modal
    // var btn = document.getElementById("addToCardButton");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal

    modal.style.display = "block";


    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        // modal.style.display = "none";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function () {
        var list = document.getElementById("myModal");
        list.removeChild(list.childNodes[0]);
        modal.style.display = "none";
    }

}

function addToCart(id, name, price, image) {
    $.ajax({
        type: 'POST',
        url: "/cart/AddToCart",
        data: { "productId": id },
        success: function (result) {
            updateItemsInCart(result);
            addRow(name, price, image)
        }
    });
};
