(function () {
    $(".result-form").submit(function (event) {
        $blockResult = $("#result-block");
        var arrClass = ["add-user", "delete-user", "add-award", "add-award-user", "change", "delete-award", "add-photo"];
        
        event.preventDefault();
        
        if (event.target.classList.contains(arrClass[0])) {
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    name: $("input[name=nameOfUser]").val(),
                    year: $("select[name=yearOfUser] option:selected").val(),
                    month: $("select[name=monthOfUser] option:selected").val(),
                    day: $("select[name=dayOfUser] option:selected").val(),
                    classForm: arrClass[0],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        } else if (event.target.classList.contains(arrClass[1])) {
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    id: $("input[name=idOfUser]").val(),
                    classForm: arrClass[1],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        } else if (event.target.classList.contains(arrClass[2])) {
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    name: $("input[name=newAward]").val(),
                    classForm: arrClass[2],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        } else if (event.target.classList.contains(arrClass[3])) {
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    idUser: $("input[name=idOfUser]").val(),
                    idAward: $("input[name=idOfAward]").val(),
                    classForm: arrClass[3],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        } else if (event.target.classList.contains(arrClass[4])) {
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    id: $("input[name=idOfUser]").val(),
                    classForm: arrClass[4],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        } else if (event.target.classList.contains(arrClass[5])) {
            var a = confirm("The reward will be removed from all users. You confirm?");
            if(a){
                $.ajax({
                    method: "POST",
                    url: "/ResultFormAjax.cshtml",
                    data: {
                        id: $("input[name=idOfAward]").val(),
                        classForm: arrClass[5],
                    },
                    success: function (response) {
                        $blockResult.empty();
                        $blockResult.append(response);
                    }
                })
            }
        } else if (event.target.classList.contains(arrClass[6])) {
            console.log($("input[name=photo]").val().slice($("input[name=photo]").val().lastIndexOf('\\') + 1))
            $.ajax({
                method: "POST",
                url: "/ResultFormAjax.cshtml",
                data: {
                    id: $("input[name=idOfUser]").val(),
                    pathFile: $("input[name=photo]").val().slice($("input[name=photo]").val().lastIndexOf('\\') + 1),
                    classForm: arrClass[6],
                },
                success: function (response) {
                    $blockResult.empty();
                    $blockResult.append(response);
                }
            })
        }
    })

})();
