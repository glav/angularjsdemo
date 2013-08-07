window.app.directive('widget',
    function () {
        return {
            restrict: 'AEM',
            template: '<div class="shape"></div>',
            replace: true,
            link: function (scope, element, attributes) {
                var isCircle = attributes.circle !== undefined || attributes.widget === 'circle';
                var isDisc = attributes.disc !== undefined || attributes.widget === 'disc';
                var isSquare = attributes.square !== undefined || attributes.widget === 'square';
                var isClickable = attributes.clickable !== undefined || attributes.widget === 'clickable';
                var useFx = attributes.useFx !== undefined || attributes.widget === 'useFx';

                console.log('isCicrle=' + isCircle);
                console.log('isSquare=' + isSquare);
                console.log('isClickable=' + isClickable);

                element
                    .css('position', 'relative');

                if (isSquare) {
                    element
                        .css('width', '70px')
                        .css('height', '60px')
                        .css('display','block')
                        .css('border', '1px dotted grey')
                        .css('margin', 'auto');
                } else if (isCircle || isDisc) {
                    $(element).append('<canvas></canvas>');
                    var canvasJq = $("canvas", element);
                    canvasJq.css('width', '90px');
                    var canvasElement = canvasJq[0];
                    var ctx = canvasElement.getContext('2d');
                    ctx.fillStyle = 'black';
                    ctx.beginPath();
                    if (isCircle) {
                        ctx.arc(140, 70, 70, 0, Math.PI * 2, true);
                        ctx.closePath();
                        ctx.fill();
                    } else {
                        ctx.strokeStyle = 'black';
                        ctx.lineWidth = 3;
                        ctx.arc(140, 70, 70, 0, Math.PI * 2, true);
                        ctx.arc(140, 70, 60, 0, Math.PI * 2, true);
                        ctx.closePath();
                        ctx.stroke();
                        //ctx.fillStyle = 'white';
                        //ctx.arc(140, 70, 20, 0, Math.PI * 2, true);
                    }

                }

                if (isClickable) {
                    element.bind('click', function() {
                        var currPos = parseInt(element.css('left').replace(/px/gi, ''), 10);
                        if (isNaN(currPos)) {
                            currPos = 0;
                        }
                        if (currPos >= 0) {
                            $(element).animate({ 'left': '-50px' });
                        } else {
                            $(element).animate({ 'left': '50px' });
                        }

                    });
                }

                if (useFx) {

                }

            }
        };
    });