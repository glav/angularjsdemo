/// <reference path="../_references.js" />

$(document).ready(function () {
	function defaultGetOptions() {
		return {
			type: "GET",
			success: function (result) { alert("Ok. Returned [" + result + "]"); },
			error: function () { alert("Failed"); }
		};
	}

	function getOptions(defaultOpts) {

		var postType = $("#post-arg-type").val();
		var opts = defaultOpts;
		if (postType === "xml") {
			$.extend(opts, {
				contentType: 'application/xhtml+xml',
				dataType: "xml"
			});
		}
		if (postType === "json") {
			$.extend(opts, {
				contentType: 'application/json',
				dataType: "json"
			});
		}
		return opts;
	}

	$("#get-default").bind("click", function () {
		var opts = getOptions(defaultGetOptions());
		$.ajax("/api/Simple", opts);
	});

	$("#get-with-id").bind("click", function () {
		var opts = getOptions(defaultGetOptions());
		var dataId = $("#get-with-id-data").val();
		$.ajax("/api/Simple/?id=" + dataId, opts);
	});

	$("#get-with-text").bind("click", function () {
		var opts = getOptions(defaultGetOptions());
		var dataId = $("#get-with-text-data").val();
		$.ajax("/api/Simple/?someText=" + dataId, opts);
	});

	$("#get-with-kindofbeer").bind("click", function () {
		var opts = getOptions(defaultGetOptions());
		var dataId = $("#get-with-kindofbeer-data").val();
		$.ajax("/beer/" + dataId, opts);
	});

	function sendRequestToServer(method, withoutData, dataType) {
		var dataArg1 = $("#post-arg1-data").val();
		var dataArg2 = $("#post-arg2-data").val();
		var dataArg3 = $("#post-arg3-data").val();
		var basicOptions = {
			type: method,
			success: function (result) {
				if (typeof result !== 'undefined' && result !== null && typeof result.WasSuccessfull !== 'undefined') {
					var msg = result.WasSuccessfull === true ? "Worked." : "Call failed.";
					msg += " " + result.Result;
					alert(msg);
				} else {
					alert("Ok. Returned [" + result + "]");
				}
			},
			error: function () { alert("Failed"); }
		};

		if (typeof dataType !== 'undefined') {
			$("#post-arg-type option[value='" + dataType + "']")[0].selected = "selected";
		}

		var postType = $("#post-arg-type").val();
		var data, contentType;
		if (postType === "form") {
			data = 'argOne=' + dataArg1 + '&argTwo=' + dataArg2 + '&argThree=' + dataArg3;
		}

		if (postType === "xml") {
			data = '';
		}
		if (postType === "json") {
			data = JSON.stringify({
				argOne: dataArg1,
				argTwo: dataArg2,
				argThree: dataArg3
			});
		}

		var opts;
		if (typeof withoutData !== 'undefined' && withoutData === false
				|| typeof withoutData === 'undefined') {
			xtraOptions = {
				data: data
			};
			opts = $.extend(getOptions(basicOptions), xtraOptions);
		} else {
			opts = getOptions(basicOptions);
		}

		$.ajax("/api/Simple/", opts);
	}

	$("#post-with-args").bind("click", function () {
		sendRequestToServer("POST", false, "json");
	});
	$("#put-with-args").bind("click", function () {
		sendRequestToServer("PUT", false, "json");
	});
	$("#head-request").bind("click", function () {
		sendRequestToServer("HEAD", false);
	});

	$("#generic-get").bind("click", function () {
		var opts = getOptions(defaultGetOptions());
		opts.type = "POST";
		opts.data = "{stuff: 'blah'}";
		opts.contentType = "application/json";
		opts.dataType = "json";
		$.ajax("/api/Generic/", opts);

	});


	// need a delete button to finish thisslide demo
});