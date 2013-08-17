window.app.directive('slideKeyboardNavigation', ['$location',
    function ($location) {
        return {
            restrict: 'A',
            link: function (scope, element, attributes) {
                var bodyEl = $("body");
                bodyEl.on('keydown', function (event) {
                    if (event.keyCode === 32 || event.keyCode === 8 || event.keyCode === 37 || event.keyCode === 39) {
                        event.stopPropagation();
                        var nextRoute = null;
                        if (event.keyCode === 32 || event.keyCode == 39) {
                            // Space bar -advance next slide
                            nextRoute = $("#next-slide").attr('href').replace(/#/gi, '');
                        } else {
                            nextRoute = $("#prev-slide").attr('href').replace(/#/gi, '');
                        }
                        if (nextRoute !== null && nextRoute !== '' && nextRoute.length && nextRoute.length > 0) {
                            scope.$apply(function() {
                                $location.path(nextRoute).replace();

                            });
                        }
                    }
                });
            }
        };
    }]);
