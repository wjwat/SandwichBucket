function getWeightInSand(sandwichWeight, userWeight) {
  return  sandwichWeight * userWeight;
}

function getHeightInSand(sandwichHeight, userHeight) {
  return  sandwichHeight * userHeight;
}

$(document).ready(function() {
  $("#convert").submit( function() {
    
    event.preventDefault();
    // alert("hay");
    const weight_unit = $('select[name="weight-unit"]').val();
    const height_unit = $("#height-unit").val();
    alert(weight_unit);
    alert(height_unit); 

    const user_weight = $("#user-weight").val();
    const user_height = $("#user-height").val(); 


    if (weight_unit === "lbs") {
      const SANDWICH_WEIGHT = .625; 
    } else {
      const SANDWICH_WEIGHT = .2834952;
    }
    alert(SANDWICH_WEIGHT);
    if (height_unit === "feet") {
    const SANDWICH_LENGTH = 10; 
    } else {
      const SANDWICH_LENGTH = .254;
    }
    alert(SANDWICH_LENGTH);

    

    $("#results").text("You are " + getWeightInSand(user_weight, SANDWICH_WEIGHT) + " sandwiches heavy, and " + getHeightInSand(user_height, SANDWICH_LENGTH) + " sandwiches tall.");
  });
});
