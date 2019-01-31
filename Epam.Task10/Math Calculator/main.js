

(function Calc(text){
    var text = "2*10 + 31 + 10.1 / 3 - 5 * 9  = ";
    var pos = 0,
        num,
        sign = [],
        arrNum = [],
        result;
    
    for(var i = 0; i < text.length; i++){
        if(text[i] == "+" ||text[i] == "-" || text[i] == "*" || text[i] == "/" || text[i] == "="){
            num = +text.substring(pos, i);
            if(isNaN(num)){
                alert("Entered not arithmetic expression");
                return;
            } 
            
            arrNum.push(num);
            sign.push(text[i]);
            ++i;
            pos = i;
        }
    }
    
    
    for(var i = 0; i < sign.length; i++){
        if(sign[i] == "*"){
            arrNum[i] *= arrNum[i+1];
            arrNum.splice(i+1, 1);
            sign.splice(i, 1);
            --i;
        }
        else if(sign[i] == "/"){
            arrNum[i] /= arrNum[i+1];
            arrNum.splice(i+1, 1);
            sign.splice(i, 1);
            --i;
        }
        else if (sign[i] == "="){
            break;
        }
    }
    
    for(var i = 0; i < sign.length; i++){
        if(sign[i] == "+"){
            arrNum[i] += arrNum[i+1];
            arrNum.splice(i+1, 1);
            sign.splice(i, 1);
            --i;
        }
        else if(sign[i] == "-"){
            arrNum[i] -= arrNum[i+1];
            arrNum.splice(i+1, 1);
            sign.splice(i, 1);
            --i;
        }
        
        else if (sign[i] == "="){
            break;
        }
    }

    result = arrNum[0];
    
    alert(result);
    
})();