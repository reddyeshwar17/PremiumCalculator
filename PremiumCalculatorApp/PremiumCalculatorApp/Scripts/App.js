var app = angular.module("PremiumCalculator", ["PremiumCalculator.controllers","ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
        when("/", {
            templateUrl: "/Partials/CalculatePremium.html",
            controller:"CalculatePremiumController"
        }).
        otherwise({redirectTo:"/"})
}]);

