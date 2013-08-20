window.app.controller('servicesController',
    function ($scope, dataFactory) {
        $scope.showGetProgressIndicator = false;
        $scope.showPostProgressIndicator = false;
        $scope.getDataResult = "-not set yet-";
        $scope.postDataResult = "-not set yet-";
        $scope.dataToPost = "";

        $scope.getData = function () {
            // turn on progress indicator
            $scope.showGetProgressIndicator = true;

            dataFactory.getData().then(function (result) {
                $scope.getDataResult = result.data;
                $scope.showGetProgressIndicator = false;
            });
        };

        $scope.postData = function () {
            // turn on progress indicator
            $scope.showPostProgressIndicator = true;

            //Note: Can also use the direct .then syntax
            //and process the response directly
            //dataFactory.postData($scope.dataToPost)
            //    .then(function (response) {
            //        if (response.status === 200) {
            //            $scope.postDataResult = response.data;
            //        } else {
            //            $scope.postDataResult = "ErrCode:" + response.status;
            //        }
            //        $scope.showPostProgressIndicator = false;
            //    });
            dataFactory.postData($scope.dataToPost)
                .success(function (data, status, headers, config) {
                    $scope.postDataResult = data;
                    $scope.showPostProgressIndicator = false;
                }).error(function (data, status, headers, config) {
                    var errMsg;
                    if (data && data.ExceptionMessage) {
                        errMsg = data.ExceptionMessage;
                    } else {
                        errMsg = "oops! it failed...";
                    }
                    $scope.postDataResult = errMsg;
                    $scope.showPostProgressIndicator = false;
                });

        };
    });