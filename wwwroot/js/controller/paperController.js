

function getShredModual(paperId) {

    var addButton = document.getElementById('addButton');
    var shredCards = document.getElementById('shredCards');


    var parent = addButton.parentNode;
    addButton.hidden = true;
    addButton.setAttribute("style", " position: fixed;");
    shredCards.hidden = true;
    shredCards.setAttribute("style", " position: fixed;");

    //while (parent.firstChild) {
    //    parent.removeChild(parent.firstChild);
    //}

    var modual = document.getElementById('shredSection');

    $(document).ready(function _ajax() {
        $.ajax({
            url: "/Home/StartShred/" + paperId,
            success: function _success(data) {
                getSelectedText(data);
        }
        });
    });
}

function getSelectedText(data) {

    modual.innerHTML += data;


    var quotearea = document.getElementById('quote');
    var output = document.getElementById('output');


    quotearea.addEventListener('mouseup', function _getSelectedText() {

        if (!document.getElementById('selectedText')) {
            if (document.getSelection().anchorNode != document.getSelection().focusNode) {
                alert("Please choose within one paragraph.");
                document.getSelection().removeAllRanges();
            } else if (document.getSelection() && output.innerHTML != document.getSelection()) {
                var selectedtext = document.getSelection();


                if (selectedtext.anchorOffset != selectedtext.focusOffset) {

                    var span = document.createElement("span");
                    span.id = "selectedText";
                    span.prepend(selectedtext.toString());

                    output.prepend(span);
                }
            }
        }
    }, false);
}

function removeShredModual(paperId) {
    var element = document.getElementById('output');
    element.parentNode.removeChild(element);

    var modual = document.getElementById('shredSection');

    var addButton = document.getElementById('addButton');
    var shredCards = document.getElementById('shredCards');

    var parent = addButton.parentNode;
    addButton.hidden = false;
    addButton.setAttribute("style", "");
    shredCards.hidden = false;
    shredCards.setAttribute("style", "");

    //Remove all data from the selection object. (What is used to highlight text)
    document.getSelection().removeAllRanges();
 
}

function clearSelected() {

    document.getElementById('selectedText').remove();

}

function submitShred() {
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
}

function getAlartBox() {

    alert("You need to sign in first");
}

function getCommentButton(shredId) {


    var commentButton = document.getElementById('commentButton-' + shredId);
    commentButton.hidden = false;
    commentButton.setAttribute("style", "");

    var commentInput = document.getElementById('commentInput-' + shredId);
    commentInput.hidden = true;
    commentInput.setAttribute("style", "position:absolute");


}

function comment(shredId) {

    var commentButton = document.getElementById('commentButton-' + shredId);
    commentButton.hidden = true;
    commentButton.setAttribute("style", " position: fixed;");

    var commentInput = document.getElementById('commentInput-' + shredId);
    commentInput.hidden = false;
    commentInput.setAttribute("style", "");
}


function submitComment(shredId, screenName) {

    $(document).ready(function _ajaxCommentForm() {

        let $form = $('#CommentForm-' + shredId);
        var subshred = document.getElementById('SubShred-' + shredId).value;
        var date = document.getElementById('Date-' + shredId).value;
        var shredIdTe = document.getElementById('ShredId-' + shredId).value;
        var shrederId = document.getElementById('ShrederId-' + shredId).value;


        console.log("Form Action: " + $form.attr('action') + " subshred value: " + subshred);
        console.log(date);
        console.log(shredIdTe);
        console.log($form.serialize());

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                console.log(response);
                var commentHtml = '<div class="row mt-3 mr-3 ml-3 mb-0">'+
                    '<div class="col">' +
                    '<p class="small"><em>'+screenName+'</em></p>' +
                                        '</div>'+
                                        '<div class="col">'+
                                            '<p class="small">'+date+'</p>'+
                                        '</div>'+
                                   '</div>'+
                        ' <div class="mr-3 ml-3">'+
                          '<div class="col">'+
                    '<p class="small">' + subshred+'</p>'+
                    ' </div>' +
                    '</div>' +
                    ' <div class="small">' +
                    ' <button class="small btn btn-sm btn-link" >edit</button>' +
                    ' </div>';

                document.getElementById('commentSection-' + shredId).innerHTML += commentHtml;

                getCommentButton(shredId);

            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });
}

function sendUpVote(shredId, voterId) {

    var cardHolder = document.getElementById("cardHolder-" + shredId);
    //var ripVote = cardHolder.getElementById('RipVote-' + cardHolderId);
    var ripValue = cardHolder.getElementById("RipValue-" + shredId);

    if (ripValue.value === "true") {

        alert("You have already upvoted this shred.");
        return;
    } else if (ripValue.value === 'false' || ripValue.value === "") {

        $(document).ready(function _submitVote() {

            ripValue.value = true;

            var shrederId = cardHolder.getElementById('ShrederId');
            var shredId = cardHolder.getElementById('ShredId');
            shredId.value = Number(shredId.value);

            console.log("Shred Id: " + shredId.value);
            console.log("Shreder ID: " + shrederId.value);
            console.log("SetUpVote: " + ripValue.value);

            var id = "#RipVote-" + shredId;

            let $formRip = $(id);

            console.log($formRip);

            $.ajax({
                url: $formRip.attr('action'),
                type: $formRip.attr('method'),
                data: $formRip.serialize(),
                success: function _success(response) {
                    console.log(response);


                },
                error: function _error(response) {
                    console.error("Opps! Something didn't work: " + response.responseText);
                }
            });

        });

    } else {

    }

}