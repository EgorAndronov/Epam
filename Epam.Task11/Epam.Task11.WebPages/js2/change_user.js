(function () {
    console.log("change-by-id func");
    $(".change-by-id").submit(function (event) {
        $blockResult = $("#result-block");
        console.log("change-by-id");
        event.preventDefault();
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    name: $("input[name=nameOfUser]").val(),
                    year: $("select[name=yearOfUser] option:selected").val(),
                    month: $("select[name=monthOfUser] option:selected").val(),
                    day: $("select[name=dayOfUser] option:selected").val(),
                    id: $("input[name=idOfUser]").val(),
                    classForm: "change-by-id",
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
    })
})();
