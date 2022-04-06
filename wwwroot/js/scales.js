//import $ from './js/jquery';
// JavaScript to read input from user

// Define your units of Measurement



const user_weight = $("#user-weight").val();
const user_height = $("#user-height").val();

function getSandWeight(sandW, userW) {
  return userW/sandW;
}
function getSandHeight(sandH, userH) {
  return userH/sandW
}
$(document).ready(function() {
  $("#convert").submit( function() {
    event.preventDefault();
    const SANDWICH_WEIGHT = 10; // ounces
    const SANDWICH_LENGTH = 10; // inches
    $("#results").text("You weigh" + getSandWeight(user_weight, SANDWICH_WEIGHT) + "in sandwiches");
  });
});





// Read input, convert to SANDWICH units, display those values back to the user
// EX: 2lbs = 32oz = 3.2sandwiches

/*
function findTriType(length_1, length_2, length_3)
{
  
  if ((length_1 === length_2) && (length_2 === length_3))
  {
    $("#results").text("it's equilateral!!!");
  }

  else if (
     ((length_1 === length_2) && (length_1 != length_3)) 
  || ((length_2 === length_3) && (length_2 != length_1)) 
  || ((length_1 === length_3) && (length_1 != length_2))
  ) 
  {
    $("#results").text("it's isosceles!!!");
  }
  else if ((length_1 != length_2) && (length_1 != length_3) && (length_2 != length_3))
  {
    $("#results").text("it's scalene!!!");
  }
  else if ( 
        ((length_1 + length_2) <= length_3)
    ||  ((length_2 + length_3) <= length_1)
    ||  ((length_1 + length_3) <= length_2)
  )
  {
    $("#results").text("NOT a triangle");
  }
}


$(document).ready(function() {
  $("#formOne").submit( function() {
    event.preventDefault();
    const length1 = $("#side1").val();
    const length2 = $("#side2").val();
    const length3 = $("#side3").val();
    findTriType(length1, length2, length3);
  });
});
*/