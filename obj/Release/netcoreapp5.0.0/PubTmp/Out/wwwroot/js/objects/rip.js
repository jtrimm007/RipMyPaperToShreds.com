'use strict';



    // When user clicks the up vote button this method sets the up vote button color. 
function turnUpVoteRed(shredId) {


        var firstUp = document.getElementById("up1-" + shredId);

        var secondUp = document.getElementById("up2-" + shredId);

        var thirdUp = document.getElementById("up3-" + shredId);

        var firstDown = document.getElementById("down1-" + shredId);

        var secondDown = document.getElementById("down2-" + shredId);

        var thirdDown = document.getElementById("down3-" + shredId);

        // console.log(firstUp + ' ' + secondUp + ' ' + thirdUp);

        if (firstUp.getAttribute('fill') == 'Gainsboro' || secondUp.getAttribute('fill') == 'Gainsboro' || thirdUp.getAttribute('fill') == 'Gainsboro') {

            firstUp.setAttribute("fill", "Crimson");
            secondUp.setAttribute("fill", "Crimson");
            thirdUp.setAttribute("fill", "Crimson");

            firstDown.setAttribute("fill", "Gainsboro");
            secondDown.setAttribute("fill", "Gainsboro");
            thirdDown.setAttribute("fill", "Gainsboro");

            return;
        }

        if (firstUp.getAttribute('fill') == 'Crimson' || secondUp.getAttribute('fill') == 'Crimson' || thirdUp.getAttribute('fill') == 'Crimson') {
            firstUp.setAttribute("fill", "Gainsboro");
            secondUp.setAttribute("fill", "Gainsboro");
            thirdUp.setAttribute("fill", "Gainsboro");
            return;
        }
    }

    // When user clicks the down vote button this method sets the up vote button color. 
function turnDownVoteRed(shredId) {
        var firstUp = document.getElementById("up1-" + shredId);

        var secondUp = document.getElementById("up2-" + shredId);

        var thirdUp = document.getElementById("up3-" + shredId);

        var firstDown = document.getElementById("down1-" + shredId);

        var secondDown = document.getElementById("down2-" + shredId);

        var thirdDown = document.getElementById("down3-" + shredId);

        // console.log(firstUp + ' ' + secondUp + ' ' + thirdUp);

        if (firstDown.getAttribute('fill') == 'Gainsboro' || secondDown.getAttribute('fill') == 'Gainsboro' || thirdDown.getAttribute('fill') == 'Gainsboro') {
            firstUp.setAttribute("fill", "Gainsboro");
            secondUp.setAttribute("fill", "Gainsboro");
            thirdUp.setAttribute("fill", "Gainsboro");

            firstDown.setAttribute("fill", "Crimson");
            secondDown.setAttribute("fill", "Crimson");
            thirdDown.setAttribute("fill", "Crimson");

            return;
        }

        if (firstDown.getAttribute('fill') == 'Crimson' || secondDown.getAttribute('fill') == 'Crimson' || thirdDown.getAttribute('fill') == 'Crimson') {
            firstDown.setAttribute("fill", "Gainsboro");
            secondDown.setAttribute("fill", "Gainsboro");
            thirdDown.setAttribute("fill", "Gainsboro");
            return;
        }
    }

