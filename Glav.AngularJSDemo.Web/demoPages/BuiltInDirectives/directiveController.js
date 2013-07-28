window.app.controller('directiveController',
    function ($scope) {

        function setupScopeData() {
            $scope.showSection = false;
            $scope.numberValue = 0;
            $scope.isNumberValueInvalid = false;

            $scope.listOfData = ["one", "two", "three", "four", "five"];
        }

        $scope.feedbackMessage = function() {
            var parsedNum = parseInt($scope.numberValue, 10);
            if (isNaN(parsedNum)) {
                $scope.isNumberValueInvalid = true;
                return "I said enter a number idiot";
            }
            $scope.isNumberValueInvalid = false;
            if (parsedNum > 100 || parsedNum < 0) {
                return "I said a number between 0 and 100. Its not that hard.";
            }

            return parsedNum < 50 ? "Less than fifty" : "In between 50 and 100 inclusive";
        };

        setupScopeData();

        $scope.buttonClickCount = 0;
        $scope.divClickCount = 0;

        $scope.buttonClickHandler = function () {
            $scope.buttonClickCount++;
        };
        $scope.divClickHandler = function () {
            $scope.divClickCount++;
        };
    });