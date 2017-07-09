(function (app) {
    app.controller('productCategoryAddController', productCategoryAddController);
    productCategoryAddController.$inject = ['apiService', '$scope', 'notificationService', '$state','commonService'];

    function productCategoryAddController(apiService,$scope,notificationService,$state,commonService) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status: true,
            Name:"Danh mục 1"
        }

        $scope.AddProductCategory = AddProductCategory;
        $scope.getSeoTitle = getSeoTitle;

        function getSeoTitle() {
            $scope.productCategory.Alias = commonService.getSeoTitle($scope.productCategory.Name);
           
        }

        function AddProductCategory() {
            apiService.post('api/productcategory/create',$scope.productCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới');
                    $state.go('product_categories');
                },
                function (error) {
                    notificationService.displayError('Thêm mới không thành công!');
                });
        }

        function loadParentCategory() {
            apiService.get('api/productcategory/getallparents', null, 
                function (result) {
                    $scope.parentCategories = result.data;
                },
                function (error) {
                    console.log('Cannot get list parent');
                }
            );
        }

        loadParentCategory();
    }

})(angular.module('mobileshop.product_categories'));