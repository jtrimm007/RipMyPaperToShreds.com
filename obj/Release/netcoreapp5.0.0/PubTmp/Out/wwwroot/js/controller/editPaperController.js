function updatePaper(event) {

    event.preventDefault();

    $(document).ready(function _updatePaperForm() {
        var hash = $('#hashTags').val().split(' ');
        var hashArray = [];

        for (var i = 0; i < hash.length; i++) {
            hashArray.push({ ID: 0, HashTag: hash[i] });
        }

        hashArray = JSON.stringify(hashArray);

        var $form = $('#form');
        $form[0][4].value = editor.getData();
        $form[0][6].value = hashArray;

        console.log($form[0][6].value);

        $('#myModal').on('shown.bs.modal', function () {
            $('#myInput').trigger('focus');
        });

        console.log($form.serialize());

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                    console.log(response);
                    console.log(window.location.origin + "/" + response);
                    console.log(window.location.href);


                    //document.getElementById('form').remove();
                    //document.getElementById('formDiv').innerHTML = response;
            },
            error: function _error() {
                console.log(_error);

            }
        }).done(console.log($form.serialize()));
    });

}

function stayOnPage() {
    var $form = $('#form');
    var obj = JSON.parse($form[0][6].value)

    var stringForInput = "";
    console.log(obj);
    for (var each in obj) {
        console.log(obj[each]["HashTag"]);

        stringForInput += obj[each]["HashTag"] + " ";
    }

    $form[0][6].value = stringForInput;
}