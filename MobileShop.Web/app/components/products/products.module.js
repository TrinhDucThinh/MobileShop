/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
	angular.module('mobileshop.products', ['mobileshop.common']).config(config);

	config.$inject = ['$stateProvider', '$urlRouterProvider'];

	function config($stateProvider,$urlRouterProvider) {
		$stateProvider.state('products', {
			url: "/products",
			tempateUrl: "/app/components/products/productListView.html",
			controller:"productListController"
		}).state('product_add', {
			url: "/product_add",
			tempateUrl: "/app/components/products/productAddView.html",
			controller: "productAddController"
		});
	};
})();