
(function(){
    
    var buttonLeft = document.getElementsByClassName("left")[0];
    var buttonRight = document.getElementsByClassName("right")[0];
    window.arrPage = ["index.html", "second.html", "third.html", "fourth.html", "fifth.html"];
    window.interval = 5; 
    var timeOnPage = document.getElementById('time');
    var stopButton = document.getElementsByClassName("stop")[0];
    var startButton = document.getElementsByClassName("start")[0];
    
   
    
    timeOnPage.innerHTML = interval;
    
    var timeId = setInterval(function(){
        interval--;
        if(interval == 0){
            moveRight();
        } else{
            timeOnPage.innerHTML = interval;
        }
    }, 1000);
    
    
        
    stopButton.onclick = function(){
        clearInterval(timeId);
        this.style.display = 'none';
        startButton.style.display = "inline-block";
    }
    
    startButton.onclick = function(){
        timeId = setInterval(function(){
            interval--;
            if(interval == 0){
                moveRight();
            } else{
                timeOnPage.innerHTML = interval;
            }
        }, 1000);
    }
    
    buttonLeft.onclick = moveLeft;
    
    buttonRight.onclick = moveRight;
    
    
    
    
})();


function moveRight(){
    var nowPageHref = document.location.href;
    var nowPage = nowPageHref.substring(nowPageHref.lastIndexOf('/')+1, nowPageHref.length);
    var pos = arrPage.indexOf(nowPage);
    if(pos != arrPage.length-1){
        window.open(arrPage[pos+1]);
        for(var i = 0; i < 10000; i++){}
        window.close();
    } else{
        if(confirm("Вы хотите запустить заново?")){
            window.open(arrPage[0]);
            window.close();
        } else{
            window.close();
        }
    }
    
}

function moveLeft(){
    var nowPageHref = document.location.href;
    var nowPage = nowPageHref.substring(nowPageHref.lastIndexOf('/')+1, nowPageHref.length);
    var pos = arrPage.indexOf(nowPage);
    if(pos != 0){
        document.location.href = arrPage[pos-1];
    } else{
        document.location.href = arrPage[arrPage.length-1];
    }
}



