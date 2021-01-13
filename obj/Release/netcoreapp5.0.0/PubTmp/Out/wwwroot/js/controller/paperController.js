function submitFixedButton(shredId) {
    var check = document.getElementById('FixedInput-' + shredId).value;

    if (check === "True") {
        document.getElementById('FixedInput-' + shredId).value = "False";
    } else {
        document.getElementById('FixedInput-' + shredId).value = "True";
    }


    //$form = $('#FixedButton-' + shredId);
    var alteredCheck = document.getElementById('FixedInput-' + shredId).value;

    console.log(alteredCheck);


    $.ajax({
        url: "/Home/FixedButton/" + shredId + "/" + alteredCheck,
        type: "POST",
        success: function _fixedButtonForm(data) {
            console.log(data);
        }

    });
}

function unauthorizedFixedButtonClick() {
    window.alert("You are not this papers author, you cannot mark this shred as fixed.");
}

function getShredModual(paperId) {

    var addButton = document.getElementById('addButton');
    var shredCards = document.getElementById('shredCards');
    var topNav;
    var bottomNav;
    var startShredCard;

    if (window.innerWidth > 768) {
        topNav = document.getElementById('topNav')

        // var parent = addButton.parentNode;
        addButton.hidden = true;
        addButton.setAttribute("style", " position: fixed;");
        shredCards.hidden = true;
        shredCards.setAttribute("style", " position: fixed;");
    } else {
        bottomNav = document.getElementById('bottomNav');
        bottomNav.hidden = true;
    }



 

    //while (parent.firstChild) {
    //    parent.removeChild(parent.firstChild);
    //}

    var modual = document.getElementById('shredSection');

    $(document).ready(function _ajax() {
        $.ajax({
            url: "/Home/StartShred/" + paperId,
            success: function _success(data) {
                modual.innerHTML += data;

                if (window.innerWidth < 768) {

                    //get the start shred card
                    startShredCard = document.getElementById('output');

                    //remove desktop classes
                    startShredCard.classList.remove('position-sticky');
                    startShredCard.classList.remove('shadow');
                    startShredCard.classList.remove('rounded');

                    //add mobile classes
                    startShredCard.classList.add('bg-white');
                    startShredCard.classList.add('shadow-lg');
                    startShredCard.classList.add('fixed-bottom');
                }


                var quotearea = document.getElementById('quote');
                var output = document.getElementById('output');

                //quotearea.addEventListener('mouseup', function _testing() {
                //    console.log();

                //    var selectedText = document.getSelection();
                //    console.log(selectedText);

                //    var getOffset = selectedText.rangeCount;

                //    var button = document.createElement('button');
                //    button.setAttribute('value', 'Button');
                //    button.textContent = 'button';
                //    button.setAttribute('class', 'btn btn-success btn-sm');

                //    console.log(getOffset);

                //    selectedText.getRangeAt(0).insertNode(button);

                //}, false);

                if (window.innerWidth < 768) {

                    var button = document.createElement('button');
                    button.setAttribute('value', 'Button');
                    button.textContent = 'Select Highlighted Text';
                    button.setAttribute('class', 'btn btn-primary');
                    button.setAttribute('onclick', 'inTextShredButton(event)');
                    button.setAttribute('id', 'selectTextButton');

                    output.prepend(button);
                }

                quotearea.addEventListener('mouseup', function _getSelectedText() {


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

                                var span = document.createElement("span");
                                span.id = "selectedText";
                                span.prepend(selectedtext.toString());

                                output.prepend(span);

                                document.getSelection().removeAllRanges();
                            } 
                        }
                    }
                }, false);
            }
        });
    });
}

function getEditShredModual(paperId) {

    var addButton = document.getElementById('addButton');
    var shredCards = document.getElementById('shredCards');

    if (addButton !== null) {
        var parent = addButton.parentNode;
        addButton.hidden = true;
        addButton.setAttribute("style", " position: fixed;");
    }

   
    shredCards.hidden = true;
    shredCards.setAttribute("style", " position: fixed;");

    //while (parent.firstChild) {
    //    parent.removeChild(parent.firstChild);
    //}

    var modual = document.getElementById('shredSection');

    $(document).ready(function _ajax() {
        $.ajax({
            url: "/Home/EditShred/" + paperId,
            success: function _success(data) {
                //console.log(data);
                modual.innerHTML += data;

                if (window.innerWidth < 768) {
                    //hide the bottom menu
                    var bottomNav = document.getElementById('bottomNav');
                    bottomNav.hidden = true;

                    //get the start shred card
                   var startShredCard = document.getElementById('output');

                    //remove desktop classes
                    startShredCard.classList.remove('position-sticky');
                    startShredCard.classList.remove('shadow');
                    startShredCard.classList.remove('rounded');

                    //add mobile classes
                    startShredCard.classList.add('bg-white');
                    startShredCard.classList.add('shadow-lg');
                    startShredCard.classList.add('fixed-bottom');
                }

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
        });
    });
}


function removeShredModual() {
    var element = document.getElementById('output');
    element.parentNode.removeChild(element);


    var topNav;
    var bottomNav;
    

    if (window.innerWidth > 768) {
        topNav = document.getElementById('topNav')
    } else {
        bottomNav = document.getElementById('bottomNav');
        bottomNav.hidden = false;
    }

    var modual = document.getElementById('shredSection');

    var addButton = document.getElementById('addButton');
    var shredCards = document.getElementById('shredCards');

    if (addButton !== null) {
        var parent = addButton.parentNode;
        addButton.hidden = false;
        addButton.setAttribute("style", "");
    }

    shredCards.hidden = false;
    shredCards.setAttribute("style", "");

    //Remove all data from the selection object. (What is used to highlight text)
    document.getSelection().removeAllRanges();
 
}

function clearSelected() {

    document.getElementById('selectedText').remove();

    if (window.innerWidth < 768) {

        var button = document.createElement('button');
        button.setAttribute('value', 'Button');
        button.textContent = 'Select Highlighted Text';
        button.setAttribute('class', 'btn btn-primary');
        button.setAttribute('onclick', 'inTextShredButton(event)');
        button.setAttribute('id', 'selectTextButton');

        output.prepend(button);
    }


}

function updateShred() {
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

    if (window.innerWidth < 768) {
        //hide the bottom menu
        var bottomNav = document.getElementById('bottomNav');
        bottomNav.hidden = false;
    }

    //Set form values
    document.getElementById('Shred').value = quotedText;
    document.getElementById('Context').value = context;

    $(document).ready(function _ajaxShredForm() {

        let $form = $('#UpdateShredForm');

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

function deleteShred(shredId, paperId) {
    $.ajax({
        url: "/Home/DeleteShred/" + shredId,
        type: "POST",
        success: function _success(response) {
            console.log(response);

            var cardHolder = document.getElementById('cardHolder-' + shredId);

            cardHolder.hidden = true;

            if (window.innerWidth < 768) {

                var button = document.createElement('button');
                button.setAttribute('value', 'Button');
                button.textContent = 'Start Shred';
                button.setAttribute('class', 'btn btn-outline-primary btn-sm');
                button.setAttribute('onclick', 'getShredModual(' + paperId+')');
                button.setAttribute('id', 'addButton');

                document.getElementById('bottomNav').append(button);
            }

        },
        error: function _error(response) {
            console.error("Opps! Something didn't work: " + response.responseText);
        }
    });
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
                //console.log(response);

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

                //unhide the bottom nav and remove the shred button
                document.getElementById('bottomNav').hidden = false;
                document.getElementById('addButton').remove();
            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });
}

function editComment(commentId) {

    var commentContainer = document.getElementById('commentContainer-' + commentId);
    commentContainer.hidden = true;
    commentContainer.setAttribute("style", " position: fixed;");

    //var commentInput = document.getElementById('commentInput-' + shredId);
    //commentInput.hidden = false;
    //commentInput.setAttribute("style", "");

    var editComment = document.getElementById('editComment-' + commentId);

    if (editComment === null) {
        $.ajax({
            url: "/Home/EditComment/" + commentId,
            success: function _success(data) {
                console.log(data);
                var commentSection = document.getElementById('comment-' + commentId);
                commentSection.innerHTML += data;
            }

        });
    } else {
        var commentSection = document.getElementById('editComment-' + commentId);
        commentSection.hidden = false;
        commentSection.setAttribute("style", "");
    }


}

function updateComment(commentId) {
    $(document).ready(function _ajaxCommentForm() {

        let $form = $('#updateCommentForm-' + commentId);
        var updatedCommentText = document.getElementById('editCommentText-' + commentId).value;
        var originalCommentText = document.getElementById('SubShred-' + commentId).value;
        var date = document.getElementById('Date-' + commentId).value;
        var shredId = document.getElementById('ShredId-' + commentId).value;
        var shrederId = document.getElementById('ShrederId-' + commentId).value;

        if (updatedCommentText !== originalCommentText) {
            document.getElementById('SubShred-' + commentId).value = updatedCommentText;
            document.getElementById('commentText-' + commentId).innerText = updatedCommentText;
        }


       //console.log("Form Action: " + $form.attr('action') + " subshred value: " + subshred);
        console.log(document.getElementById('SubShred-' + commentId).value);
        console.log(shredId);
        console.log($form.serialize());

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                console.log(response);

                var commentContainer = document.getElementById('commentContainer-' + commentId);
                commentContainer.hidden = false;
                commentContainer.setAttribute("style", "");

                var editComment = document.getElementById('editComment-' + commentId);
                editComment.hidden = true;
                editComment.setAttribute("style", " position: fixed;");

               
            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });

}

function deleteComment(commentId) {


    
    var commentContainer = document.getElementById('editComment-' + commentId);

    if (commentContainer !== null) {
        commentContainer.hidden = true;
        commentContainer.setAttribute("style", "position: fixed;");
    }


    $.ajax({
        url: "/Home/DeleteComment/" + commentId,
        type: "POST",
        success: function _success(data) {
            console.log(data);

            var commentContainer = document.getElementById('comment-' + commentId);
            commentContainer.hidden = true;
            commentContainer.setAttribute("style", "position: fixed;");

            var editComment = document.getElementById('editComment-' + commentId);
            editComment.hidden = true;
            

            editComment.setAttribute("style", "position: fixed;");

        }

    });
}

function cancelCommentEdit(commentId) {
    var commentContainer = document.getElementById('editComment-' + commentId);
    commentContainer.hidden = true;
    commentContainer.setAttribute("style", " position: fixed;");

    var commentContainer = document.getElementById('commentContainer-' + commentId);
    commentContainer.hidden = false;
    commentContainer.setAttribute("style", "");
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

        var $form = $('#CommentForm-' + shredId);
        var newComment = document.getElementById('SubShred-' + shredId).value;
        var date = document.getElementById('Date-' + shredId).value;
        var formShredId = document.getElementById('ShredId-' + shredId).value;
        var shrederId = document.getElementById('ShrederId-' + shredId).value;


        console.log("Form Action: " + $form.attr('action') + " subshred value: " + newComment);
        console.log(date);
        console.log(shredId);
        console.log($form.serialize());

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                //console.log(response);
                document.getElementById('commentSection-' + shredId).innerHTML += response;
                var commentInputSection = document.getElementById('commentInput-' + shredId);
                commentInputSection.hidden = true;
                commentInputSection.setAttribute("style", " position: fixed;");

                getCommentButton(shredId);

            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });
}

function sendUpVote(shredId, voterId) {

    $(document).ready(function _upVote() {
        document.getElementById('Rip-' + shredId).setAttribute("value", "true");
        document.getElementById('RipVoter-' + shredId).setAttribute("value", voterId);

        var id = "#RipForm-" + shredId;

        var $form = $('#RipForm-' + shredId);

        console.log($form);

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                console.log(response);


            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });
    });
}

function sendDownVote(shredId, voterId) {

    $(document).ready(function _upVote() {
        document.getElementById('Rip-' + shredId).setAttribute("value", "false");
        document.getElementById('RipVoter-' + shredId).setAttribute("value", voterId);
        var id = "#RipForm-" + shredId;

        var $form = $('#RipForm-' + shredId);

        console.log($form);

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                console.log(response);


            },
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });
}

function reportWindowSize() {
    console.log(window.innerWidth);
}

function getWindowSize() {

}