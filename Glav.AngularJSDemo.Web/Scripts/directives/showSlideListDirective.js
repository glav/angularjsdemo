window.app.directive('showSlideList', [function() {
    return {
        restrict: 'A',
        link: function (scope, element, attributes) {
            var listElement = attributes.slideList;
            element.bind('click', function() {
                $(listElement).fadeIn();
            });

            $(listElement + 'ul li a').on('click', function() {
                $(listElement).fadeOut();
            });
        }
    };
}]);
