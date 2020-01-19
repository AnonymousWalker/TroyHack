function UploadFile(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#pic-preview-wrapper img').attr('src', e.target.result);
        };
        $("#select-photo").text(input.files.length + " selected");
        $("#select-photo").css({ "opacity": 0.6, "background": "#e7d7d7", "border": "5px outset #efefef00"});

        reader.readAsDataURL(input.files[0]);
    }
}

$("#browse-pic").change(function () {
    $("#pic-form").css("background-image", "none");
    UploadFile(this);
});
