var tags = null;
var green = "#10ff3e";
var red =  "#ff3e10";

var changeTables = function(){
    request();
    if(tags != null){
        colorTables();
    }
}

var colorTables = function(){
    for(i = 0; i < tags.length; i++){
        var tag = tags[i];
        if(tag['isOccupied']){
            changeColor(green, i);
        }else{
            changeColor(red, i);
        }
    }
}

var request = function(){
    $.ajax({
        type:"GET", 
        url: "http://localhost:2700/api/tags/", 
        success: function(data) {
            tags = data;
        }, 
        error: function(jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status);
        },
        dataType: 'json'
    });
}

var changeColor = function(color, index){
    document.getElementById("box" + index).style.backgroundColor = color;
}