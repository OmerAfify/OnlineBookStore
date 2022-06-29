
let bookItemsList = [];

let BookService = {

    LoadItems: function () {

        Helper.AjaxCallGet("/api/BookItems", {}, "json", function (data) {

         
            for (var i = 0; i <= data.length; i++) {
                bookItemsList.push(data);
                var bookItem = AddBookItem(data[i]);
                $(".productBoxDetailsPage").append(bookItem);
            }

            console.log(bookItemsList)
        }, function () { });
    },

 DrawItemsFilteredWithCategory : function (categoryName) {

         let all = "";
         console.log(categoryName)
         console.log(bookitemsList)
 

        //for (var i = 0; i <= bookitemsList.length; i++) {

        //    let bookItem = AddBookItem(bookitemsList[i]);
        //    all = all + bookItem;
        //}
        //$(".productBoxDetailsPage").html(all);
    }


};

BookService.LoadItems();

  let AddBookItem = function (bookItem) {

    var bookBox = "<div class='col-xl-3 col-6 col-grid-box'>" +
        "<div class='product-box'>" +
        "<div class='img-wrapper'>" +
        "<div class='front'>" +
        "<a href='#'><img src='../UploadedFiles/Images/BookItemsImages/" + bookItem.bookItemImageName + "' class='img-fluid blur-up lazyload bg-img' alt=''></a></div>" +
        "<div class='back'>" +
        "<a href='#'><img src='../UploadedFiles/Images/BookItemsImages/" + bookItem.bookItemImageName + "' class='img-fluid blur-up lazyload bg-img' alt=''></a></div>" +
        "<div class='cart-info cart-wrap'>" +
        "<button data-toggle='modal' data-target='#addtocart' title='Add to cart'>" +
        "<a href='/ShoppingCart/AddToCart/" + bookItem.bookItemId + "'><i class='ti-shopping-cart'></i></a>" +
        "</button> <a href='javascript:void(0)' title='Add to Wishlist'>" +
        "<i class=''ti-heart' aria-hidden='true'></i>" +
        "</a> <a href='#' data-toggle='modal' data-target='#quick-view' title='Quick View'>" +
        "<i class='ti-search' aria-hidden='true'></i>" +
        "</a> <a href='compare.html' title='Compare'>" +
        "<i class='ti-reload' aria-hidden='true'></i>" +
        "</a></div> </div>" +
        "<div class='product-detail'><div>" +
        "<div class='rating'><i class='fa fa-star'></i> <i class='fa fa-star'></i> <i class='fa fa-star'></i> <i class='fa fa-star'></i> <i class='fa fa-star'></i></div>" +
        "<a href='product-page(no-sidebar).html'>" +
        "<h6>" + bookItem.bookItemName + "</h6></a>" +
        "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text galley" +
        "</p><h4>" + bookItem.purchasePrice + "EGP</h4> <ul class='color-variant'>" +
        "<li class='bg-light0'></li>" +
        "<li class='bg-light1'></li>" +
        "<li class='bg-light2'></li>" +
        "</ul></div></div></div></div>"


    return bookBox;
}

let FilterByCategory= function (categoryName) {

    // let new_arr = $.grep(bookItemsList, function (n, i) {
    //    return n.bookCategoryId = categoryId
    //});

    //return new_arr;
}


