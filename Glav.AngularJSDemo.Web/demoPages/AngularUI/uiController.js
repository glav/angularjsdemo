window.app.controller('uiController', ['$scope','$timeout',
    function ($scope,$timeout) {
        $scope.open = function () {
            $timeout(function () {
                $scope.opened = true;
            });
        };

        $scope.dateOptions = {
            'year-format': "'yy'",
            'starting-day': 1
        };

        $scope.dataData = new Date();
    }]);