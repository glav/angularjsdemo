window.app.service('triggerService', ['$rootScope', function ($rootScope) {
    this.slideChangedKey = "triggerSlideChanged";

    this.triggerSlideChange = function (slide) {
        $rootScope.$broadcast(this.slideChangedKey, slide);
    };

}]);