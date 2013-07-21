window.app.directive('keyboardNavigation', ['$location',
    function ($location) {
        return {
            restrict: 'A',
            link: function (scope, element, attributes) {
                element.bind('keydown', function(evt) {
                    console.log('element');
                    console.log(evt);
                });
                $("body").on('keydown', function(evt) {
                    console.log('jquery');
                    console.log(evt);
                });
                
                
            }
        };
    }
]);