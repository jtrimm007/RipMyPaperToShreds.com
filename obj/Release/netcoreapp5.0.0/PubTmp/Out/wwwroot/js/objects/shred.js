'use strict';

function markFixedButton(shredId) {
    var fixedOne = document.getElementById('fixed-1-' + shredId);
    var fixedTwo = document.getElementById('fixed-2-' + shredId);

    //console.log(fixedOne);

    if (fixedOne.getAttribute('fill') == 'Gainsboro' || fixedTwo.getAttribute('fill') == 'Gainsboro') {

        fixedOne.setAttribute("fill", "LimeGreen");
        fixedTwo.setAttribute("fill", "LimeGreen");

        return;
    }

    if (fixedOne.getAttribute('fill') == 'LimeGreen' || fixedTwo.getAttribute('fill') == 'LimeGreen') {
        fixedOne.setAttribute("fill", "Gainsboro");
        fixedTwo.setAttribute("fill", "Gainsboro");

        return;
    }

}

function unauthorizedFixedButtonClick() {
    window.alert("You are not this papers author, you cannot mark this shred as fixed.");
}