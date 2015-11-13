
var App = angular.module('angularFormsApp', ["ngRoute","ui.bootstrap"]);

App.config(["$routeProvider", "$locationProvider",
    function ($routeProvider, $locationProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: "App/Home.html",
            controller: "HomeController"
        })
            .when("/newEmployeeForm", {
            templateUrl: "app/EmployeeForm/efTemplate.html",
            controller: "efController"
        })
        .when("/updateEmployeeForm/:id", {
            templateUrl: "app/EmployeeForm/efTemplate.html",
            controller: "efController"
        })
        .otherwise({
            redirectTo: "/home"
        });
    //$locationProvider.html5Mode(true);
}]);

App.controller("HomeController",
    ["$scope", "$location", 
    function ($scope, $location) {
        $scope.showCreateEmployeeForm = function () {
            $location.path('/newEmployeeForm');
        };

        $scope.showUpdateEmployeeForm = function (id) {
            $location.path('/updateEmployeeForm/' + id)
        };

    }]);

