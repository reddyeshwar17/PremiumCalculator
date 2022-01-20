angular.module("PremiumCalculator.controllers", []).
    controller("CalculatePremiumController", function ($scope, PremiumService) {

        $scope.message = "Please enter your details";

        $scope.CalculatePremium = function () {
            PremiumService.CalculatePremium($scope.Prem);
        }
    })
    .factory("PremiumService", ["$http", function ($http) {
        var fac = [];
        fac.CalculatePremium = function (prem) {
            $http.post("/PremiumCalculator/CalculatePremium", prem).success(function (response) {
                alert(response.status);
            })
        }
        return fac;
    }])