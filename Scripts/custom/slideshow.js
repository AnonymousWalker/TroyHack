function prevSlides(pid) {
    loadPicture(pid, false);
}

function nextSlide(pid) {
    loadPicture(id, true);
}

function loadPicture(postingId, isNext) {
    var urlStr = $("#LoadImgUrl").val();
    
    $.ajax({
        url: urlStr,
        type: "get",
        data: {
            postingId, picId
            
        }
        success: function (res) {

        }
    });
}