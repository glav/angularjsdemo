window.app.directive('validationErrorMark', ['$compile',
    function ($compile) {

    var pathToImage = '/images/validation-red.png';

    return {
        require: 'ngModel',
        restrict: 'A',
        compile: function (element, attributes, transclude) {
            return {
                pre: function (scope, iElement, iAttrs, controller) {
                    var cssClassToAppend = attributes.validationErrorMark || '';
                    var validationMessage = attributes.validationErrorMessage;
                    if (!validationMessage || validationMessage === '') {
                        validationMessage = "Field is not valid";
                    }
                    
                    // Find the enclosing form so we can find out its name
                    var formName = jQuery(element).parents('form:first').attr('name');
                    // We can combine  the form name, control name and the $invalid value which angular uses and
                    // provide that as a ng-show attribute so we can let angular hide and show our markup
                    var invalidVariable = formName + "." + attributes.name + ".$invalid";
                    
                    
                    var html = '<div class="validation-error-mark" data-ng-show="'+invalidVariable+'">';
                    if (cssClassToAppend !== '') {
                        html += '<img src="' + pathToImage + '" tooltip="' + validationMessage + '" tooltip-trigger="click" tooltip-placement="bottom" class="' + cssClassToAppend + '" />';
                    } else {
                        html += '<img src="' + pathToImage + '" tooltip="' + validationMessage + '" tooltip-trigger="click" tooltip-placement="bottom" />';
                    }
                    html += '</div>';
                    
                    // Note: Without the compile, the tooltip directive doesn't get hooked up

                    var validationMarkerHtml = $(html);
                    validationMarkerHtml.insertBefore(element);
                    $compile(validationMarkerHtml)(scope);
                }
            };
        }

    };
}]);
