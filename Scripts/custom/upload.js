function UploadFile(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#pic-preview-wrapper img').attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);
    }
}

$("#browse-pic").change(function () {
    $("#pic-form").css("background-image", "none");
    UploadFile(this);
});