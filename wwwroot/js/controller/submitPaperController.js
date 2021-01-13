'use strict';

function uploadPaper(editor) {
    //event.preventDefault();
    $(document).ready(function _uploadPaperForm() {

        let $form = $('#UploadPaper');

        var formData = new FormData($form[0]);

        var File = document.getElementById('File');

        console.log(File.files[0]);
        console.log($form.attr('action'));
        console.log($form.attr('method'));

        
       

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: formData,
            async: true,
            success: function _success(response) {

                console.log(response);

                var paper = response["paper"].paper;
                var css = response["paperUpload"].css;
                var filePath = response["paperUpload"].filePath;
                var uniqueFileName = response["paperUpload"].uniqueFileName;
                var guid = response["paperUpload"].guidId;
                var uploadDate = response["paperUpload"].uploadDate;

                editor.execute('insertHtmlEmbed');
                editor.execute('updateHtmlEmbed', paper);

                $('<style>').text(css).appendTo(document.head);

                var getForm = document.getElementById('form');

                getForm.setAttribute('action', 'DocxInsertedForm');

                var cssInput = document.createElement('input');
                cssInput.setAttribute('value', css);
                cssInput.setAttribute('name', 'Css');
                cssInput.setAttribute('hidden', 'true');

                var filePathInput = document.createElement('input');
                filePathInput.setAttribute('value', filePath);
                filePathInput.setAttribute('name', 'FilePath');
                filePathInput.setAttribute('hidden', 'true');

                var uniqueFileNameInput = document.createElement('input');
                uniqueFileNameInput.setAttribute('value', uniqueFileName);
                uniqueFileNameInput.setAttribute('name', 'UniqueFileName');
                uniqueFileNameInput.setAttribute('hidden', 'true');


                var guidInput = document.createElement('input');
                guidInput.setAttribute('value', guid);
                guidInput.setAttribute('name', 'GuidId');
                guidInput.setAttribute('hidden', 'true');


                //finally, append the inputs to the form
                getForm.appendChild(cssInput);
                getForm.appendChild(filePathInput);
                getForm.appendChild(uniqueFileNameInput);
                getForm.appendChild(guidInput);

                
            },
            cache: false,
            contentType: false,
            processData: false,
            error: function _error(response) {
                console.error("Opps! Something didn't work: " + response.responseText);
            }
        });

    });
}

function submitPaper(event) {

    event.preventDefault();

    $(document).ready(function _uploadPaperForm() {

        var hash = $('#hashTags').val().split(' ');
        var hashArray = [];

        for (var i = 0; i < hash.length; i++) {
            hashArray.push({ ID: 0, HashTag: hash[i] });
        }

        var hashString = JSON.stringify(hashArray);

        let $form = $('#form');
        $form[0][5].value = editor.getData();
        $form[0][6].value = hashString;

        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                console.log(response);
                document.getElementById('UploadPaper').remove();
                document.getElementById('form').remove();
                document.getElementById('formDiv').innerHTML = response;
            },
            error: function _error() {
                console.log(_error);

            }
        }).done(console.log($form.serialize()));
    });

}