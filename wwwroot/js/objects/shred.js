import rip from './rip.js';
'use strict';

const shred = (function () {

    // Use this method onClick to retrive the shred module. The Shred Module is how users select shred text, comments on that text, and submit the shred.
    let submitShred = function () {
        //After shred is validated, users can submit shred. This method sets values to a form. 

        //Shreder review
        var shredDiv = document.getElementById('StartingShred');
        var context = shredDiv.innerText;

        //Shredy text being reviewed
        var shredText = document.getElementById('selectedText');
        var quotedText = shredText.innerHTML;

        if (quotedText == null || quotedText == '') {
            alert("You must write something about the selected text.");
            return;
        }

        if (context == null || context == '') {
            alert("You must select text to shred. Please highlight the section you want to shred. ");
            return;
        }

        //Set form values
        document.getElementById('Shred').value = quotedText;
        document.getElementById('Context').value = context;

        $(document).ready(function _ajaxShredForm() {

            let $form = $('#SubmitShredForm');

            $.ajax({
                url: $form.attr('action'),
                type: $form.attr('method'),
                data: $form.serialize(),
                success: function _success(response) {
                    console.log(response);

                    //Get the output div
                    var modual = document.getElementById('output');

                    //Get the parent div of the output, shredSection.
                    var parent = modual.parentNode;

                    //Remove everything the section
                    while (parent.firstChild) {
                        parent.removeChild(parent.firstChild);
                    }

                    //Remove all data from the selection object. (What is used to highlight text)
                    document.getSelection().removeAllRanges();

                    //Add the response data to the innerHtml
                    parent.innerHTML += response;
                },
                error: function _error(response) {
                    console.error("Opps! Something didn't work: " + response.responseText);
                }
            });

        });
    };

     // Use this method to remove the _StartShred section. Should be set to onClick for the cancel shred button.
    let removeShredModule = function (paperId) {
     
        var element = document.getElementById('output');
        element.parentNode.removeChild(element);

        var modual = document.getElementById('shredSection');

        $(document).ready(function _ajax() {

            //This is for loading in the button
            $.ajax({
                url: "/Home/ShredButton/" + paperId.toString(),
                success: function _success(result) {
                    modual.innerHTML += result;

                    //Remove all data from the selection object. (What is used to highlight text)
                    document.getSelection().removeAllRanges();
                },
                error: function _error(result) {
                    console.error("There was an error getting the ShredButton: " + result);
                }
            });

            $.ajax({
                url: "/Home/ShredSection/" + paperId.toString(),
                success: function _success(result) {
                    modual.innerHTML += result;

                    //Remove all data from the selection object. (What is used to highlight text)
                    document.getSelection().removeAllRanges();
                },
                error: function _error(result) {
                    console.error("Something when wrong: " + result);
                }
            });
        });
    };

    let editShred = function () {

    };

    let deleteShred = function () {

    };

    let clearSelected = function () {

        document.getElementById('selectedText').remove();
    };

    return { rip, submitShred, removeShredModule, editShred, deleteShred, clearSelected };
})();


export default { shred };