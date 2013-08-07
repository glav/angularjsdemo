window.app.directive('simpleClicker',
    function () {
        return {
            restrict: 'AECM', // (Attribute, element, class, comment)

            link: function (scope, element, attributes) {

                element.bind('click', function () {
                    alert('clicked!');
                });
            }
        };
    });