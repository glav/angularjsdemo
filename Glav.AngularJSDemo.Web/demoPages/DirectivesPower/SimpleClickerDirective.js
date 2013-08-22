window.app.directive('simpleClicker',
    function () {
        return {
            restrict: 'AEC', // (Attribute, element, class, not comment)

            link: function (scope, element, attributes) {

                element.bind('click', function () {
                    alert('clicked!');
                });
            }
        };
    });