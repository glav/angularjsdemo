/// <reference path="../jquery-1.6.2-vsdoc.js" />

$(document).ready(function () {
	var slideDeckManager = function () {

		var getAndSubmitFeedback = function () {
			var feedback = $("#slide-feedback").val();
			var slideNumber = $("#current-slide-number").val();
			if (typeof feedback !== 'undefined' && feedback !== "") {
				window.slideDeckManager.postSlideFeedback(slideNumber, feedback, function () {
					$("#slide-feedback").val("");
					var feedbackEl = $("#feedback-posted-message");
					feedbackEl.text("Thanks for the feedback!")
								.fadeIn("slow", function () {
									window.setTimeout(function () {
										feedbackEl.fadeOut("slow");
									}, 2000);
								});
				}, function () {
					alert("Damn, the demo gods smote me!");
				});
			}
		};

		var postSlideFeedback = function (slideNumber, feedback, onSuccess, onFailure) {
			var postData = {
				slide: slideNumber,
				feedback: feedback
			};
			$.ajax("api/slide", {
				data: JSON.stringify(postData),
				type: "POST",
				dataType: "json",
				contentType: "application/json; charset=utf-8",
				success: function () {
					if (typeof onSuccess !== 'undefined') {
						onSuccess();
					}
				},
				error: function () {
					if (typeof onFailure !== 'undefined') {
						onFailure();
					}
				}
			});
		};

		var updateUriWithSlide = function (slideNumber) {
			window.location.hash = "#" + slideNumber;
		};

		var getSlide = function (slideNumber, onSuccess, onFailure) {
			var actualNum = 0;
			if (typeof slideNumber !== 'undefined') {
				actualNum = slideNumber;
			}

			$.ajax("api/slide/" + actualNum, {
				success: function (result) {
					updateUriWithSlide(actualNum);
					if (typeof onSuccess !== 'undefined') {
						onSuccess(result);
					} else {
						alert("You got a slide but did nothing with it");
					}
				},
				error: function () {
					if (typeof onFailure !== 'undefined') {
						onFailure();
					} else {
						// Dont do anything. Probably the end of the deck
						//alert("woops, had a little problem getting the requested slide");
					}
				}
			});

		};

		return {
			getSlide: function (slideNumber, onSuccess, onFailure) { getSlide(slideNumber, onSuccess, onFailure); },
			postSlideFeedback: function (slideNumber, feedback, onSuccess, onFailure) { postSlideFeedback(slideNumber, feedback, onSuccess, onFailure); },
			getAndSubmitFeedback: function () { getAndSubmitFeedback(); }
		};
	};

	window.slideDeckManager = slideDeckManager();
});

