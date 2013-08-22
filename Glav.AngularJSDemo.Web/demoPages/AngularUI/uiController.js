window.app.controller('uiController', ['$scope', '$timeout',
    function ($scope, $timeout) {
        
        // For the modal dialog
        $scope.closeModal = function () {
            $scope.shouldModalOpen = false;
        };
        $scope.openModal = function () {
            $scope.shouldModalOpen = true;
        };
        $scope.modalOptions = {
            backdropFade: true,
            dialogFade: true
        };

        // For the star rating control
        $scope.ratingMax = 10;
        $scope.starRating = 8;
        $scope.hoveringOver = function (value) {
            $scope.hoverRating = value;
        };

        // Carousel
        $scope.myInterval = 10000;
        $scope.slides = [
            { image: '/images/lmao.jpg', text: "L M A O" },
            { image: '/images/OneMotherOfABook.jpg', text: "Read the manual" },
            { image: '/images/designer-fun.jpg', text: "Designer fun" },
            { image: '/images/darth-vader.jpg', text: "Poor Darth" },
            { image: '/images/whos-awesome.jpg', text: "This presentation" },
            { image: '/images/likaboss.jpg', text: "Own it" }
        ];
    }]);