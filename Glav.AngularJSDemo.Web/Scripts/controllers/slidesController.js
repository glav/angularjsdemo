window.app.controller('slidesController', ['$rootScope', '$scope', 'slideFactory', 'triggerService', '$route',
    function ($rootScope, $scope, slideFactory, triggerService, $route) {

        $scope.detailPointClassNames = ['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten'];
        $scope.highlightPointClassNames = ["", "info-point-blue", "info-point-purple", "info-point-teal", "info-point-orange"];

        initialise();

        function initialise() {
            setSlideNumberFromRoute();
            getSlide($rootScope.slideNumber);
            $scope.getSlide = getSlide;
        }

        $scope.slideChange = function(slideNumber) {
            getSlide(slideNumber);
        };

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
                .success(function (data, status, headers, config) {
                    $rootScope.slide = data;
                    setImageStatusAndListWidth(data);
                    triggerService.triggerSlideChange(data.SequenceNumber);
                    //setupNavigation(data);
                })
                .error(function (data, status, headers, config) {
                    alert('Aghast, an error! The demo gods require a sacrifice....now!');
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

    }]);