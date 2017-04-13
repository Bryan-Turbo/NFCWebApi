var tags = null;
var green = "#10e33e";
var red =  "#e33e10";

var changeTables = function(){
    request(setvar);
    if(tags != null){
        //console.log(tags[0]['isOccupied'])
        for(i = 0; i < tags.length; i++){
            var tag = tags[i];
            if(tag['isOccupied']){
                changeColor(green, i);
            }else{
                changeColor(red, i);
            }
        }
    }
}

function request(retvar){
    $.ajax({
        type:"GET", 
        url: "http://localhost:2700/api/tags/", 
        success: function(data) {
            retvar(data);
        }, 
        error: function(jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status);
        },
        dataType: 'json'
    });
}

var setvar = function(data){
    tags = data;
}

var changeColor = function(color, index){
    document.getElementById("box" + index).style.backgroundColor = color;
}