////function changeInfo(infoId) {
////    // Hide all text containers
////    var infoTexts = document.getElementsByClassName("product__infoText");
////    for (var i = 0; i < infoTexts.length; i++) {
////        infoTexts[i].style.display = "none";
////    }

////    // Show the selected text container
////    var selectedInfo = document.getElementById(infoId);
////    if (selectedInfo) {
////        selectedInfo.style.display = "block";
////    }
////}


function openCity(evt, cityName) {
    var i, x, tablinks;
    x = document.getElementsByClassName("city");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < x.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}
