window.app.controller('anotherController',
    function ($scope, servicesFactoriesFactory, servicesFactoriesService) {

        $scope.callFactory = function() {
            servicesFactoriesFactory.performService();
        };
        $scope.callService = function () {
            servicesFactoriesService.performService();
        };

        $scope.factoryPropertyValue = function() {
            return servicesFactoriesFactory.factoryProperty;
        };
        $scope.servicePropertyValue = function () {
            return servicesFactoriesService.serviceProperty;
        };
    });