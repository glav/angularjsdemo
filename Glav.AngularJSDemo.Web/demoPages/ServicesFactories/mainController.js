window.app.controller('mainController',
    function ($scope, theFactory, theService) {

        $scope.callFactory = function() {
            theFactory.performService();
        };
        $scope.callService = function () {
            theService.performService();
        };

        $scope.factoryPropertyValue = function() {
            return theFactory.factoryProperty;
        };
        $scope.servicePropertyValue = function () {
            return theService.serviceProperty;
        };
    });