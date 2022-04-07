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
  $("#player-level").text(ww);
} else {
  if (ww > 2){
    $("#player-level").text(1);
  }
}
fetch(`http://localhost:5000/Sandwich/Random/`)
  .then (function(response) {
    $("#enemy-name").text(response.name)
  })
});
