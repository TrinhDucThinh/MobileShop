/// <reference path="../angular/angular.js" />
var myModule = angular.module("myModule", []);

//register controller
myModule.controller("myController", myController);
myModule.service("Validator", Validator);

myController.$inject = ['$scope','Validator'];

function myController($scope,Validator) {
  
    $scope.message = "please enter a number";
    $scope.num = 1;
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }
}

//Create service
function Validator() {

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
