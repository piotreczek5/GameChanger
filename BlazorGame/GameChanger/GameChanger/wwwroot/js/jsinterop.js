function setElementDisabledStatus(elementId,boolValue) {
    document.getElementById(elementId).disabled = boolValue;    
}

function setElementHidden(elementId, boolValue) {
    document.getElementById(elementId).hidden = boolValue;
}

function setElementText(elementId, text) {
    document.getElementById(elementId).textContent = text;
}

function startTimer(countDownDate, elementId) {

   
    if (document.getElementById(elementId) == null) {
        return;
    }
       
    var x = setInterval(function () {
        
        var now = new Date().getTime();
        var countDownTime = Date.parse(countDownDate);
        // Find the distance between now and the count down date
        var distance = countDownTime - now;

        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        if (document.getElementById(elementId) == null) {
            clearInterval(x);
            return;
        }
        // Display the result in the element with id="demo"
        document.getElementById(elementId).innerHTML =
            (days != 0 ? days + "d ":"") +
            (hours != 0 ? hours + "h ":"") +
            (minutes != 0 ? minutes + "m ": "") +
            seconds + "s ";

        // If the count down is finished, write some text
        if (distance < 0) {
            clearInterval(x);

            if (document.getElementById(elementId) == null) {
                return;
            }
            document.getElementById(elementId).innerHTML = "FINISHED";
        }
    }, 1000);
}