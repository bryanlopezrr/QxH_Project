var QXH = QXH || {};
QXH.RTR = QXH.RTR || {};
QXH.RTR.pages = QXH.RTR.pages || {};
QXH.RTR.pages.variantSummary = {
    self: this,
    date: new Date(),
    currentDateTime: new moment().format("MM/DD/YYY - h:mm a"),
    currentDate: new moment().format("MM/DD/YYYY"),
    currentHour: new moment().format("HH"),
    currentHourLetter: "",
    refreshInterval: "",
    lastItemIdLoadedInPDPage: "",
    lastItemIdLoadedInVariantSummary: "",
    executionTimerStart: new moment(),
    executionTimerEnd: new moment(),
    highlightsValue: 0,
    refreshRateValue: 0,
    refreshClockIntervalId: null,
    mostRecentSystemTimeLoaded: null,
    localTimeOfMostRecentSystemTimeLoad: null,

    init: function () {
        var self = this;
        var timer = -1;
        self.setElements();
        $(window).resize(function () {
            clearTimeout(timer);
            timer = setTimeout(self.maxOutElementHeight(), 100);
        });
        self.highlightsValue = "0";
        self.refreshRateValue = 5000;
        $("#topClockCounter").show();
    },

    setElements: function () {
        var self = this;
        var myDate = new Date();
        topTimer = setInterval(function () {
            var currentMoment = new moment();
            if (self.mostRecentSystemTimeLoaded != null) {
                var intervalFromLastSystemTimeLoad = currentMoment.diff(self.localTimeOfMostRecentSystemTimeLoad);
                var mostRecentSystemTimeCopy = new moment(self.mostRecentSystemTimeLoaded);
                currentMoment = mostRecentSystemTimeCopy.add('milliseconds', intervalFromLastSystemTimeLoad);
            }

            currentSeconds = parseInt(currentMoment.format("ss"));
            secondsLeft = 60 - currentSeconds;
            if (secondsLeft == 60) {
                secondsLeft = 0;
            }
            currentMinutes = parseInt(currentMoment.format("mm"));
            if (secondsLeft > 0) {
                minutesLeft = 59 - currentMinutes;
            } else {
                minutesLeft = 60 - currentMinutes;
            }
            if (secondsLeft < 10) {
                secondsLeft = "0" + secondsLeft;
            }
            if (minutesLeft < 10) {
                minutesLeft = "0" + minutesLeft;
            }
            $("#currentTimeDisplay").html(currentMoment.format("h:mm:ss a"));
            $("#hourCountdown").html(minutesLeft + ":" + secondsLeft);

            //Change countdown timer to yellow when it drops below 5 mins and red when below 2 mins.
            if (parseInt($("hourCountdown").text()) < 2) {
                $("#hourCountdown").css('color', '#FF3030');
            } else if (parseInt($("#hourCountdown").text()) < 5) {
                $("#hourCountdown").css('color', '#FFCC11');
            } else {
                $("#hourCountdown").css('color', '#5DFC0A');
            }
        }, 1000);

        //initial load of system time
        self.loadSystemTime(function () {

        });
        self.refreshClockIntervalId = setInterval(function () {
            self.loadSystemTime(function () {

            })
        }, 30000);
    },

    loadSystemTime: function (callback) {
        var self = this;
        var status = "success"; l
        var url = "/Lookup/GetSystemTime";
        $.getJSON(url, function (response) {
            if (response.DateValue) {
                self.mostRecentSystemTimeLoaded = new moment(new Date(parseInt(response.DateValue.substr(6))));
                self.localTimeOfMostRecentSystemTimeLoad = new moment();
            } else {
                status = "nodata";
            }
            callback(status);
        }).error(function () {
            status = "error";
            callback(status);
        });
    }
};