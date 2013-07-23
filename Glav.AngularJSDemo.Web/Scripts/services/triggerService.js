window.app.service('triggerService', ['$rootScope', function ($rootScope) {
    this.slideChangedKey = "triggerSlideChanged";
    this.slideNavigationKey = "triggerSlideNavigation";

    // Slide has been changed to slideNumber
    this.triggerSlideChange = function (slideNumber) {
        $rootScope.$broadcast(this.slideChangedKey, slideNumber);
    };

}]);