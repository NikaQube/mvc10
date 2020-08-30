$(function () {
    $("ul img").mouseover(function () {
        $(this).animate({ height: '+=10', width: '+=10' })
    });
});

$(function () {
    $("ul img").mouseout(function () {
        $(this).animate({ height: '-=10', width: '-=10' })
    });
});

$(function () {
    $("#inputphoto").change(function () {
        if (this.files && this.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $("#previewphoto").attr('src', e.target.result);
            }

            reader.readAsDataURL(this.files[0]);
        }
    });
});