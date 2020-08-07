// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    let totalWidth = $(".lent a").length * 100;

    $(".lent").css("width", totalWidth + "%");


    let imgCount = $(".lent a").length;

    let width = $(".lent a").width();


    let position = 0;



    $(document).on("click", ".arrow-right", function () {


        if (position >= (imgCount - 1) * width) {
            $(".lent").css("right", 0)

            position = 0;
        } else {
            position = position + width

            $(".lent").css("right", position);
        }
    })

    $(document).on("click", ".arrow-left", function () {

        if (position < width) {

            $(".lent").css("right", (imgCount - 1) * width)

            position = (imgCount - 1) * width;

        } else {

            position = position - width

            $(".lent").css("right", position);

        }

    })

    window.setInterval(() => {
        if (position >= (imgCount - 1) * width) {
            $(".lent").css("right", 0)

            position = 0;

        } else {
            position = position + width

            $(".lent").css("right", position);
        }
    }, 5000)

    $(".title").css("max-width", width);
    $(".lent a").css("width",width);

    $(document).on("click", ".like", function () {

        $(this).css({
            "background-color": "white",
            "color": "#028F1D"
        })

        $(this).parent().parent().css("pointer-events", "none");

    })

    $(document).on("click", ".unlike", function () {
        $(this).css({
            "background-color": "white",
            "color": "#DE0201"
        })

        $(this).parent().parent().css("pointer-events", "none");

    })

    $(document).on("click", ".like-stat", function () {

        $(".like-stat").css("box-shadow", "inset 0 0 5px black")

        $(".stats").css("pointer-events", "none");

        $(".stats-mobile").css("pointer-events", "none");


    })

    $(document).on("click", ".unlike-stat", function () {

        $(".unlike-stat").css("box-shadow", "inset 0 0 5px black")

        $(".stats").css("pointer-events", "none");

        $(".stats-mobile").css("pointer-events", "none");



    })


    $(document).on("click", ".bar", function () {

        if ($(".burger-menu").css("visibility") === "hidden") {
            $(".burger-menu").css({
                "left": "0",
                "visibility": "visible"
            });
        } else {
            $(".burger-menu").css({
                "left": "-230px",
                "visibility": "hidden"
            });
        }

    })

    $(".custom-file-input").on("change", function () {
        var fileName = $(this).val().split("\\").pop();
        $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });



});