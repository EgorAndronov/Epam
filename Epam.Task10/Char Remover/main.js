
(function newString(text){
    var text = "У попа была собака";
    var pos = 0;
    var beginPos = 0;
    var count = 0;
    var symPos;
    var symArr = [];
    var arrText = text.split(' ');
    
    for (var i = 0; i < arrText.length; i++){
        var nowWord = arrText[i];
        for( var j = 0; j < nowWord.length; j++){ 
            if(nowWord[j]!=","||nowWord[j]!="!"||nowWord[j]!="?"||nowWord[j]!=":"||nowWord[j]!=";"||nowWord[j]!="."){
                while(true){
                    var foundPosition = nowWord.indexOf(nowWord[j], pos);
                    
                    if (foundPosition == -1){
                        break;
                    }
                    
                    count++;
                    pos = foundPosition+1;
                    symPos = foundPosition;
                }
                
                if(count > 1){
                    if(symArr.indexOf(nowWord[symPos], 0) == -1){
                        symArr.push(nowWord[symPos]);
                    }
                }
                
                pos = 0;
                count = 0;
            }
        }
    }
    
    for(var i = 0; i < symArr.length; i++){
        console.log(symArr[i]);
    }
    
    arrText = text.split('');
    
    for( var i = 0; i < symArr.length; i++){
        while(true){
            foundPosition = arrText.indexOf(symArr[i], pos);
            
            if (foundPosition == -1){
                    break;
            }
            
            arrText.splice(foundPosition, 1, '');
            pos = foundPosition+1;
        }
        pos=0;
    }
    text = arrText.join('');
    
    alert(text);
})();


