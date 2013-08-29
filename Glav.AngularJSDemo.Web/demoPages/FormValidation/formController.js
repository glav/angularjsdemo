window.app.controller('formController',
    function ($scope) {
        function initialise() {
            // Some defaults;
            $scope.personDetails = {
                age: 18
            };

        }

        initialise();

        $scope.saveForm = function () {
            if ($scope.myForm.$invalid) {
                alert('invalid');
                return;
            }

            alert('Data can be saved');

        };
    }
);