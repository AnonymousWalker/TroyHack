function prevSlides(pid, selector) {
    var $elem = $(selector).siblings('img');
    var imgIndex = $elem.attr('data-imgId');
    loadPicture(pid, parseInt(imgIndex)- 1, $elem);
}

function nextSlides(pid, selector) {
    var $elem = $(selector).siblings('img');
    var imgIndex = $elem.attr('data-imgId');
    loadPicture(pid, parseInt(imgIndex) + 1, $elem);
}

function loadPicture(postingId, imgIndex, $elem) {
    var urlStr = $("#LoadImgUrl").val();
    
    $.ajax({
        url: urlStr,
        type: "get",
        data: {
            postingId, imgIndex
            
        },
        success: function (res) {
            if (!res == "") {
                $elem.attr("src", res);
                $elem.attr('data-imgId', imgIndex);
            }
        }
    });
}