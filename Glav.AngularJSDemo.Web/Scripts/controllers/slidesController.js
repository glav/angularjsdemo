window.app.controller('slidesController', ['$rootScope', '$scope', '$location', 'slideFactory',
    function ($rootScope, $scope, $location, slideFactory) {

        $scope.detailPointClassNames = ['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten'];
        $scope.highlightPointClassNames = ["", "info-point-blue", "info-point-purple", "info-point-teal", "info-point-orange"];

        initialise();

        function initialise() {
            //setSlideNumberFromRoute();
            getSlide();
            $scope.getSlide = getSlide;

            console.log($location);
        }

        function getSlide(slideNumber) {
            if (slideNumber === undefined) {
                slideNumber = 0;
            }
            slideFactory.getSlide(slideNumber)
                // alternative way of getting results
                    //.then(function(results) {
                    //    // can examine results.data, results.status etcc...
                    //    return results.data;
                    //});
                .success(function(data, status, headers, config) {
                    $rootScope.slide = data;
                    setImageStatusAndListWidth(data);
                    setupNavigation(data);
                    //triggerService.triggerSlideChange(data);
                })
                .error(function(data, status, headers, config) {
                    // woops - do something
                });
        }

        function setSlideNumberFromRoute() {
            $rootScope.slideNumber = 0;
            if ($route.current !== undefined && $route.current.params.hasOwnProperty("slideno")) {
                $rootScope.slideNumber = parseInt($route.current.params.slideno, 10);
                if (isNaN($rootScope.slideNumber)) {
                    $rootScope.slideNumber = 0;
                }
            }
        }



        function setImageStatusAndListWidth(slide) {
            var imageSrc = slide.ImageSource;
            $scope.showSlideImage = (imageSrc !== undefined && imageSrc != '' && imageSrc !== null)

            if ($scope.showSlideImage) {
                $scope.listWidth = "half-width";
            } else {
                $scope.listWidth = "full-width";
            }
        }


        $scope.highlightClass = function (detailPoint) {
            if (detailPoint.HighlightClass > 0) {
                return "info-point " + $scope.highlightPointClassNames[detailPoint.HighlightClass];
            }
            return '';
        };
        
        function setupNavigation(slide) {
            if (slide === undefined) {
                return;
            }
            var slideNo = slide.SequenceNumber;

            if (slideNo == 0) {
                $scope.nextSlideNumber = 1;
                $scope.previousSlideNumber = 0;
            } else {
                $scope.nextSlideNumber = slideNo + 1;
                $scope.previousSlideNumber = slideNo - 1;
            }

            $scope.showPreviousSlideNav = !($scope.previousSlideNumber === 0 && slideNo === 0);
            $scope.showNextSlideNav = true;
            if (slide !== undefined) {
                $scope.showDemoNav = (slide.DemoPage !== undefined && slide.DemoPage !== null && slide.DemoPage !== '');
            } else {
                $scope.showDemoNav = false;
            }

        }


    }]);