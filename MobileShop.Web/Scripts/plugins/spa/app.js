/// <reference path="../angular/angular.js" />
var myModule = angular.module("myModule", []);

//register controller
myModule.controller("myController", myController);

myController.$inject("$scope");

//declare controller

function myController($scope) {
    $scope.message = "This is my message from controller";
}