window.app.controller('navigationController', ['$scope', '$rootScope', 'triggerService',
    function ($scope,$rootScope, triggerService) {

        $scope.$on(triggerService.slideChangedKey, function (eventObj, slideNumber) {
            setupNavigation(slideNumber);
        });

        function setupNavigation(slideNumber) {
            if (slideNumber === undefined) {
                slideNumber = 0;
            }

            if (slideNumber == 0) {
                $scope.nextSlideNumber = 1;
                $scope.previousSlideNumber = 0;
            } else {
                $scope.nextSlideNumber = slideNumber + 1;
                $scope.previousSlideNumber = slideNumber - 1;
            }

            $scope.showPreviousSlideNav = !($scope.previousSlideNumber === 0 && slideNumber === 0);
            $scope.showNextSlideNav = true;

            var slide = $rootScope.slide;
            if (slide !== undefined) {
                $scope.showDemoNav = (slide.DemoPage !== undefined && slide.DemoPage !== null && slide.DemoPage !== '');
            } else {
                $scope.showDemoNav = false;
            }

        }

}]);