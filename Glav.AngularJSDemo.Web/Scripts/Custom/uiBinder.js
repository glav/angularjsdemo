/// <reference path="../jquery-1.6.2-vsdoc.js" />

$(document).ready(function () {
	var uiBinder = function () {

		var classDescriptions = [];
		classDescriptions[0] = "one";
		classDescriptions[1] = "two";
		classDescriptions[2] = "three";
		classDescriptions[3] = "four";
		classDescriptions[4] = "five";
		classDescriptions[5] = "six";

		var setupDetailPoints = function (slide) {
			var mainContent = $("section.main-content");
			var detailContainer = $("ol", mainContent);
			detailContainer.empty();
			var infoPointClass = ["", "blue", "purple", "teal", "orange"];
			if (typeof slide.DetailPoints !== 'undefined' && slide.DetailPoints.length > 0) {
				var numPoints = slide.DetailPoints.length;
				for (var detailCnt = 0; detailCnt < numPoints; detailCnt++) {
					var detailItem = slide.DetailPoints[detailCnt];

					var pointHeader = "";
					if (detailItem.DetailPointHeader !== "") {
					    var itemTextClass = "";
					    if (detailItem.HighlightClass && detailItem.HighlightClass !== "" && detailItem.HighlightClass !== 0) {
					        pointHeader = "<h5 class='info-point info-point-" + infoPointClass[detailItem.HighlightClass] + "'>";
					    } else {
					        pointHeader = "<h5>";
					    }

					    pointHeader += detailItem.DetailPointHeader + "</h5>";
					}

					var pointText = "&nbsp";
					if (detailItem.DetailPointText !== "") {
						pointText = detailItem.DetailPointText;
					}

					var html = "<li class='" + classDescriptions[detailCnt] + "'>" + pointHeader + pointText + "</li>";
					detailContainer.append(html);
				}
			}
		};

		var bindActionLinks = function (slide) {
			$(document).unbind("keydown");
			// bind next/prev/demo link actions
			if (slide.SequenceNumber > 0) {
				var prevSlideNumber = slide.SequenceNumber - 1;
				$("#prev-slide").show().unbind().bind("click", function () {
					window.slideDeckManager.getSlide(prevSlideNumber, window.uiBinder.mapDataToView);
				});
				$(document).bind("keydown", function (e) {
					if (e.which === 8) {
						window.slideDeckManager.getSlide(prevSlideNumber, window.uiBinder.mapDataToView);
					}
				});
			} else {
				$("#prev-slide").unbind().hide();
			}

			//Next action
			var nextSlide = slide.SequenceNumber + 1;
			$("#next-slide").unbind().bind("click", function () {
				window.slideDeckManager.getSlide(nextSlide, window.uiBinder.mapDataToView);
			});
			$(document).bind("keydown", function (e) {
				if (e.which === 32) {
					window.slideDeckManager.getSlide(nextSlide, window.uiBinder.mapDataToView);
				}
			});
			if (typeof slide.DemoPage !== 'undefined' && slide.DemoPage !== null && slide.DemoPage !== "") {
				var demoPage = "demoPages/" + slide.DemoPage;
				$("#demo-link").unbind().show().bind("click", function () {
					window.open(demoPage, "_blank");
				});
			} else {
				$("#demo-link").unbind().hide();
			}
		};

		var showElementIfHasContent = function (el, content) {
			if (content !== "") {
				el.show();
			} else {
				el.hide();
			}
		};

		var mapDataToView = function (slide) {
			var detailContentContainer = $("#slide-detail-content");
			detailContentContainer.fadeOut("fast", function () {
				if (typeof slide !== 'undefined') {
					$("#current-slide-number").val(slide.SequenceNumber);
					$("h1").text(slide.Title);
					var subTitleEl = $("h2");
					subTitleEl.text(slide.SubTitle);
					showElementIfHasContent(subTitleEl, slide.SubTitle);

					var blurbEl = $("section.heading p");
					blurbEl.text(slide.TitleBlurb);
					showElementIfHasContent(blurbEl, slide.TitleBlurb);

					var mainContent = $("section.main-content");
					$("h3", mainContent).text(slide.DetailHeading);

					if (slide.ImageSource && slide.ImageSource !== null && slide.ImageSource !== "") {
						$("#image-container").html("<img src='" + slide.ImageSource + "' alt='Slide Graphic' />");
					} else {
						$("#image-container").empty();
					}

					setupDetailPoints(slide);
					detailContentContainer.fadeIn("slow");
					bindActionLinks(slide);
				}
				//$("#slide-navigation").fadeIn("fast");
			});
		};


		return {
			mapDataToView: function (slide) { mapDataToView(slide); }
		};
	};

	window.uiBinder = uiBinder();
});

