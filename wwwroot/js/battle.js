$(document).ready(function() {
  $("#player-level").text(1);
  $("#enemy-level").text(1);
})

$("#fight").click(function(){
const p = Math.floor(Math.random() * (parseInt($("#player-level").html()) + 1));
let ww = (parseInt($("#player-level").html()) + 1);
const c = Math.floor(Math.random() * (parseInt($("#enemy-level").html()) + 1));
console.log(p + "||" + c);
if (p > c){
    $('#attack-ball').addClass("animate");
    setTimeout (() => {
      $('#attack-ball').removeClass("animate");
    }, 500);
  $("#player-level").text(ww);
} else {
  $('#eattack-ball').addClass("eanimate");
  setTimeout (() => {
    $('#player-sandwich').addClass("ouchie");
    $('#eattack-ball').removeClass("eanimate");
  }, 500);
  setTimeout (() => {
    $('#player-sandwich').removeClass("ouchie");
  }, 3000);
  if (ww > 2){
    $("#player-level").text(1);
  }
}


const test = fetch(`http://localhost:5000/Sandwiches/Random`, {
  mode: 'cors',
  headers: {
    'Access-Control-Allow-Origin':'*'
  }
})
      .then(function(response) {
        if (!response.ok) {
          throw Error(response.statusText);
        }
      return response.json()
      })
      .catch(function(error) {
        return error;
      })
      .then(resp => {
        $("#enemy-name").text(resp.name);
      }
      
      )});

      // set levels where they're supposed to go
      // have ingredients show from menu (or something)
      // ahref to home on click
      // sound (music) || option turn off sound
      // when fight have a timeout with combat animation 
      // (health goes down, maybe a salami flies [keyframes])
      