function prevSlides(pid, selector) {
    var imgIndex = $(selector).siblings('img').attr('data-imgId');
    loadPicture(pid, imgIndex);
}

function nextSlide(pid, selector) {
    loadPicture(id, true);
}

function loadPicture(postingId, imgIndex) {
    var urlStr = $("#LoadImgUrl").val();
    
    $.ajax({
        url: urlStr,
        type: "get",
        data: {
            postingId, imgIndex
            
        },
        success: function (res) {
            if (!res == "") {
                
            }
        }
    });
}