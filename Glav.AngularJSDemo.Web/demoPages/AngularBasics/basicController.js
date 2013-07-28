window.app.controller('basicController',
    function ($scope) {

        function setupScopeData() {
            $scope.whatAmI = "Angular One way binding";

            $scope.someData = {
                text: "Some text",
                currentDate: new Date(),
                amount: 150
            };

            $scope.listOfStuff = [
                { key: 1, text: "Item 1"},
                { key: 2, text: "Item Two" },
                { key: 3, text: "Three" },
                { key: 4, text: "And four" },
                { key: 5, text: "finally five" }
            ];

            $scope.listSelection = $scope.listOfStuff[2].key;

            $scope.listFilter = ''; // initially, nothing to filter
        }

        setupScopeData();
});