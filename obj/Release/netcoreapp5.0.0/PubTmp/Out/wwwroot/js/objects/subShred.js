'use strict';

const subShred = (function () {

    // Used to removed the SubShred Module and get the comment button.
    let getCommentButton = function (shredId) {

        $(document).ready(function _ajax() {
            $.ajax({
                url: "/Home/CommentButton",
                success: function _success(data) {
                    //parent.innerHTML += data;
                    document.getElementById('commentInput').remove();
                    document.getElementById('commentHolder').innerHTML += data;
                }
            });
        });
    };

    // Used to get the comment section after clicking on the comment button.
    let getSubShredModule = function (shredId) {
        $(document).ready(function _ajax() {
            $.ajax({
                url: "/Home/Comment",
                success: function _success(data) {
                    //parent.innerHTML += data;
                    document.getElementById('commentButton').remove();
                    document.getElementById('commentHolder').innerHTML += data;
                }
            });
        });
    };

    return { getCommentButton, getSubShredModule}
})();

export default { subShred };