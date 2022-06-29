
let CategoryService = {

    LoadCategories: function () {

        Helper.AjaxCallGet("/api/BookCategories", {}, "json", function (data) {

            for (var i = 0; i <= data.length; i++) {

                let catItem = AddCategory(data[i]);
                $(".collection-brand-filter").append(catItem);

            }

     

        }, function () { });
    }

};

CategoryService.LoadCategories();


var AddCategory = function (category) {

    let categoryBox = "<div onclick='BookService.DrawItemsFilteredWithCategory("+category.bookCategoryName+")' class='custom-control custom-checkbox collection-filter-checkbox'>" +
         "<label  for='" +category.bookCategoryName+ "'>" + category.bookCategoryName+"</label> </div>"
    return categoryBox;

}



