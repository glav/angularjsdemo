/// <reference path="../_references.js" />
window.app.config(['$routeProvider',
    function ($routeProvider) {

    $routeProvider
        .when('/view', { templateUrl: '/demoPages/routing/partial-view1.tpl.html', controller: 'partialViewController' })
        .when('/view/1', { templateUrl: '/demoPages/routing/partial-view1.tpl.html', controller: 'partialViewController' })
        .when('/view/2', { templateUrl: '/demoPages/routing/partial-view2.tpl.html', controller: 'partialViewController' })
        .when('/view/3', { templateUrl: '/demoPages/routing/partial-view3.tpl.html', controller: 'partialViewController' })
        .when('/select/:viewno', { templateUrl: '/demoPages/routing/select-view.tpl.html', controller: 'selectViewController' })

    .otherwise({ redirectTo: '/' });


}]);