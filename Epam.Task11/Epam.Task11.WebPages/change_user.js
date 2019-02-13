(function () {
    $(".change-by-id").submit(function (event) {
        $blockResult = $("#result-block");
        event.preventDefault();
            $.ajax({
                method: "POST",
                url: "/ChangeUserAjax.cshtml",
                data: {
                    name: $("input[name=nameOfUser]").val(),
                    year: $("select[name=yearOfUser] option:selected").val(),
                    month: $("select[name=monthOfUser] option:selected").val(),
                    day: $("select[name=dayOfUser] option:selected").val(),
                    id: $("input[name=idOfUser]").val(),
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
    })
})();
