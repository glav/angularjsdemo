/// <reference path="../jquery-1.6.2-vsdoc.js" />
/// <reference path="slideDeckManager.js" />
/// <reference path="uiBinder.js" />

$(document).ready(function () {

	function bindFeedbackSubmitButton() {
		// Make sure the input does not fire the 
		$("#slide-feedback").bind("keydown", function (evt) {
			evt.stopPropagation();
			if (evt.which === 13) {
				window.slideDeckManager.getAndSubmitFeedback();
			}
		});
		$("#submit-slide-feedback").bind("click", function () {
			window.slideDeckManager.getAndSubmitFeedback();
		});
	}

	function bindSlideListButton() {
		var slideListToggle = function () {
			var listEl = $("#slide-list");
			if (listEl.css("display") === "none") {
				$("#slide-list").fadeIn("slow");
			} else {
				$("#slide-list").fadeOut("slow");
			}
		};

		$("#slide-list-action").bind("click", function () {
			slideListToggle();
		});

		$("#slide-list ul li a").bind("click", function () {
			var anchorEl = $(this);
			var slide = anchorEl.attr("href").replace(/#/gi, "").replace("/", "");
			slideListToggle();
			window.slideDeckManager.getSlide(slide, window.uiBinder.mapDataToView);
		});

	}

	function getSlideNumberFromUrl() {
		var slide = 0;
		if (window.location.hash && window.location.hash !== "") {
			var bookmarkedSlide = parseInt(window.location.hash.replace(/#/gi, ""), 10);
			if (!isNaN(bookmarkedSlide)) {
				slide = bookmarkedSlide;
			}
		}
		return slide;
	}

	function refreshPage() {
		window.slideDeckManager.getSlide(getSlideNumberFromUrl(), window.uiBinder.mapDataToView);
	}

	refreshPage();

	bindFeedbackSubmitButton();
	bindSlideListButton();
});