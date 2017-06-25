/// <reference path="../angular/angular.js" />
var myModule = angular.module("myModule", []);

//register controller
myModule.controller("schoolController", schoolController);
myModule.controller("teacherController", teacherController);
myModule.controller("studentController", studentController);

schoolController.$inject("$rootScope,$scope");
teacherController.$inject("$scope");
studentController.$inject("$scope");
//declare controller

function schoolController($rootScope,$scope) {
    $rootScope.message = "Anouncement from school";
}

function teacherController($scope) {
    $scope.message="Anouncement from teacher";
}

function studentController($scope) {
    $scope.message = "Anouncement from student";
}