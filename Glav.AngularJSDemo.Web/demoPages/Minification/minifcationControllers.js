
// Bad Bad Bad. This is unsafe and will likely not work when minified
window.app.controller('minifyUnSafeController',
    function ($location, $route, someService) {
        // do something with injected $location, $route, someservice....
    });

// Good good good. This is safe and will work fine when minified
window.app.controller('minifySafeController', ['$location', '$route', 'someService',
    function($location, $route, someService) {
        // do something with injected $location, $route, someservice....
    }]);


