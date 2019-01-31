
(function(){
    var buttons = document.getElementsByClassName("buttons")[0];
    var selects = document.getElementsByClassName("select");
    
    buttons.onclick = function(event){
        var target = event.target;
        
        
        if(target.className == "right"){
            var option = selects[0].querySelectorAll("option");
            var flag = false;
            for(var i = 0; i < option.length; i++){
                if(option[i].selected){
                    var moveOption = option[i].cloneNode(true);
                    selects[1].appendChild(moveOption);
                    selects[0].removeChild(option[i]);
                    flag = true;
                } 
                
            }
            if(!flag){
                alert("No options selected");
            }
            
        } else if(target.className == "left"){
            var option = selects[1].querySelectorAll("option");
            var flag = false;
            for(var i = 0; i < option.length; i++){
                if(option[i].selected){
                    var moveOption = option[i].cloneNode(true);
                    selects[0].appendChild(moveOption);
                    selects[1].removeChild(option[i]);
                    flag = true;
                }
                
               
            }
            if(!flag){
                alert("No options selected");
            }
        } else if(target.className == "all-right"){
            var option = selects[0].querySelectorAll("option");
            for(var i = 0; i < option.length; i++){
                var moveOption = option[i].cloneNode(true);
                selects[1].appendChild(moveOption);
                selects[0].removeChild(option[i]);
            }
        } else if(target.className == "all-left"){
            var option = selects[1].querySelectorAll("option");
            for(var i = 0; i < option.length; i++){
                var moveOption = option[i].cloneNode(true);
                selects[0].appendChild(moveOption);
                selects[1].removeChild(option[i]);
            }
        } 
    };
    
})();




