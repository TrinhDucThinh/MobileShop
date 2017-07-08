(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function productCategoryListController($scope, apiService, notificationService,$ngBootbox) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.flagFirst = true;
        $scope.search = search;
        $scope.getProductCagories = getProductCagories;
        $scope.deleteProductCategory = deleteProductCategory;

        $scope.EnterSearch = function (keyEvent) {
            if (keyEvent.which === 13) {
                search();
            }
        }

        function search() {
            $scope.flagFirst = false;
            getProductCagories();
        }

        function getProductCagories(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 2
                }
            }
            apiService.get('/api/productcategory/getall', config, function (result) {
                if (result.data.TotalCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy.');
                }
                else {
                    if ($scope.flagFirst == false) {
                        notificationService.displaySuccess('Đã tìm thấy ' + result.data.TotalCount + ' bản ghi.');
                        $scope.flagFirst = true;
                    }
                }
                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('Load productcategory failed.');
            });
        }

        function deleteProductCategory(id) {
            $ngBootbox.confirm('Bạn có muốn xóa bản ghi này không?')
            .then(function () {
                var config = { params: { id: id } };
                apiService.del('/api/productcategory/delete', config,
                    function () {
                        notificationService.displaySuccess('Xóa thành công!');
                        getProductCagories();
                    },
                    function () {
                        notificationService.displayError('Xóa không thành công!');
                    })
            });
        }

        $scope.getProductCagories();
    }
})(angular.module('mobileshop.product_categories'));