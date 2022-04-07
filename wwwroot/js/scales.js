function getWeightInSand(sandwichWeight, userWeight) {
  return  sandwichWeight * userWeight;
}

function getHeightInSand(sandwichHeight, userHeight) {
  return  sandwichHeight * userHeight;
}

$(document).ready(function() {
  $("#convert").submit( function() {
    event.preventDefault();
    const user_weight = $("#user-weight").val();
    const user_height = $("#user-height").val(); 
    const SANDWICH_WEIGHT = .625; 
    const SANDWICH_LENGTH = 10; 
    $("#results").text("You are " + getWeightInSand(user_weight, SANDWICH_WEIGHT) + " sandwiches heavy, and " + getHeightInSand(user_height, SANDWICH_LENGTH) + " sandwiches tall.");
  });
});
