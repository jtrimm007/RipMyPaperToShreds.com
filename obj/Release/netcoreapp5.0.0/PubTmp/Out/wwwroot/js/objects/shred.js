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

function getCopiedText() {

    var selectedtext = document.getSelection();

    var span = document.createElement("span");
    span.id = "selectedText";
    span.prepend(selectedtext.toString());

    output.prepend(span);

    document.getSelection().removeAllRanges();
}

function inTextShredButton(event) {

    console.log(event);

    var selectedText = document.getSelection();
    console.log(selectedText);

    var getOffset = selectedText.rangeCount;

    console.log(getOffset);


    if (!document.getElementById('selectedText')) {

        var selectedtext = document.getSelection();


        if (document.getSelection().anchorNode != document.getSelection().focusNode) {

            alert("Please choose within one paragraph.");
            document.getSelection().removeAllRanges();

        } else if (selectedtext.toString().length >= 420) {

            //console.log(selectedtext.toString().length);
            alert("Please choose less characters.");
            document.getSelection().removeAllRanges();

        } else if (document.getSelection() && output.innerHTML != document.getSelection()) {
            //var selectedtext = document.getSelection();


            if (selectedtext.anchorOffset != selectedtext.focusOffset) {

                document.getElementById('selectTextButton').hidden = true;

                var span = document.createElement("span");
                span.id = "selectedText";
                span.prepend(selectedtext.toString());

                output.prepend(span);

                document.getSelection().removeAllRanges();
            }
        }
    }


    //selectedText.getRangeAt(0).insertNode(button);
}

function unauthorizedFixedButtonClick() {
    window.alert("You are not this papers author, you cannot mark this shred as fixed.");
}