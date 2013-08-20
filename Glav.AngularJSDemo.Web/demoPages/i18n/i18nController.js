window.app.controller('i18nController', ['$scope', '$locale',
    function ($scope, $locale) {

        $scope.currentDateTime = new Date();
        $scope.amount = 123456.78;
        $scope.localeId = $locale.id;

        $scope.attendees = [0, 1, 2,3, 4, 2000, 3000];
        if ($locale.id == 'en-us') {
            $scope.attendeeForms = {
                0: 'No one came',
                one: '{} attendee',
                '2': 'pair of attendees ( {} )',
                '3': 'trio of attendess ( {} )',
                other: '{} attendees'
            };
        } else {
            $scope.attendeeForms = {
                0: 'None',
                one: '{} lonely nerd',
                '2': 'duo ( {} )',
                '3': 'trio ( {} )',
                few: '{} people',
                other: '{} tech geeks'
            };
        }
    }]);