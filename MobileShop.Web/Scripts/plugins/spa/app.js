/// <reference path="../angular/angular.js" />
var myModule = angular.module("myModule", []);

//register controller
myModule.controller("myController", myController);
myModule.service("ValidatorService", ValidatorService);
myModule.directive("mobileShopDirective", mobileShopDirective)

myController.$inject = ['$scope', 'ValidatorService'];

function myController($scope,Validator) {
  
    $scope.message = "please enter a number";
    $scope.num = 1;
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }
}

//Create service
function ValidatorService() {

    return {
        checkNumber: checkNumber
    }

    function checkNumber(input) {
        if (input % 2 == 0)
            return input + " is even";
        else
            return input + " is odd";
    }
}


//create custom directive
function mobileShopDirective() {
    return {
        //template:"<h2>This is a custom directive</h2>"
        restrict:"A",
        templateUrl:"/Scripts/customDirective.html"
    }
}