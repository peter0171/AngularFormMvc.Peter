
var App = angular.module('angularFormsApp', ["ngRoute"]);

App.config(["$routeProvider", "$locationProvider",
    function ($routeProvider, $locationProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: "App/Home.html",
            controller: "HomeController"
        })
        .otherwise({
            redirectTo: "/home"
        });
    //$locationProvider.html5Mode(true);
}]);

App.controller("HomeController",
    ["$scope", "$location", 
    function ($scope, $location) {
  

    }]);

