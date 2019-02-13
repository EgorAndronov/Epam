(function () {
    var $blockResult = $("#result-block");

    $("#main-menu").submit(function (event) {
        event.preventDefault();
        $.ajax({
            method: "POST",
            url: "/IndexAjax.cshtml",
            data: {
                value: $("#list-menu option:selected").val()
            },
            success: function (response) {
                $blockResult.empty();
                $blockResult.append(response);
            }
        })
    })

})();
