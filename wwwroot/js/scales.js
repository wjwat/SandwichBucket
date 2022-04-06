
function getSandWeight(sandW, userW) {
  return userW * sandW;
}
function getSandHeight(sandH, userH) {
  return userH * sandH;
}
$(document).ready(function() {
  $("#convert").submit( function() {
    event.preventDefault();
    const user_weight = $("#user-weight").val();
    const user_height = $("#user-height").val(); 
    const SANDWICH_WEIGHT = .625; //pounds
    const SANDWICH_LENGTH = 10; // inches
    $("#results").text("You are " + getSandWeight(user_weight, SANDWICH_WEIGHT) + " sandwiches heavy, and " + getSandHeight(user_height, SANDWICH_LENGTH) + " sandwiches tall.");
  });
});





