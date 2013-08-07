window.app.controller('selectViewController',
    function ($scope, $route) {
        console.log('hello');

        function getViewNoFromRoute() {
            var param = null;
            if ($route.current && $route.current.params.hasOwnProperty("viewno")) {
                param = $route.current.params.viewno;
            }

            if (param !== undefined && param !== null && param !== '') {
                return param;
            }
            return "-Not specified-";
        }

        $scope.viewNumber = getViewNoFromRoute();
    }
);