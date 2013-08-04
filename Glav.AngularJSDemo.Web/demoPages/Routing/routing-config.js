/// <reference path="../_references.js" />
window.app = angular.config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {
    //$locationProvider.html5Mode(false);
    //$locationProvider.hashPrefix = '!';
    var partialViewUrl = '/demoPages/routing/partial-view1.tpl.html';

    $routeProvider
        .when('/view', { templateUrl: partialViewUrl, controller: 'routingController' })
        .when('/view/:viewno', { templateUrl: partialViewUrl, controller: 'routingController' })

    .otherwise({ redirectTo: '/' });


}]);