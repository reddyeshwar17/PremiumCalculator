angular.module('myApp').controller('premCalcCtrl', ['$scope', '$window', '$http', '$sce', '$location', function ($scope, $window, $http, $sce, $location) {

    $scope.onChange = function () {
        debugger;
        var viewModel = { Name: $scope.Name, Age: $scope.Age, OccupationVal: $scope.Occupation, SumInsured: $scope.SumInsured };
        $http.post('/PremiumCalculator/CalculatePremium', { name: $scope.Name, age: $scope.Age, occupation: $scope.Occupation, sumInsured: $scope.SumInsured})
            .success(function (data) {
                alert(data.Message);
                //$location.url('/alert/alert-list/pageid/' + i + '/searchparams/' + JSON.stringify(j) + '/sortParam/' + k + '/sortDirection/' + l + '/d/' + $.now() + '');
            }
            );
    }
}]);