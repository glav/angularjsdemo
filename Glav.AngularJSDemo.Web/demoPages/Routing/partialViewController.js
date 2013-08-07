window.app.controller('partialViewController',
    function ($scope, $rootScope) {
        if ($rootScope.data === undefined || $rootScope.data === null) {
            $rootScope.data = { text: 'something' };
        }

        $scope.viewOne = {
            title: 'View Numero Uno',
            blurb: 'Exciting huh?'
        };
        $scope.viewTwo = {
            title: 'Second View',
            blurb: 'Exciting huh?'
        };
        $scope.viewThree = {
            title: 'Third and final view',
            blurb: 'And thats a wrap'
        };
    }
);