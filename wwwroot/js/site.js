// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const SONGS = ["cappello", "creed", "eiffel", "impress", "korn", "korn", "korn", "losdelrio", "mambo", "mouth", "numa", "sunshine", "venga", "voodoo"];
const BANNERS = 39;
const BARKS = [
  "THE MASKED DATER SENDS HIS REGARDS",
  "ONLY AN EPICODUS STUDENT WOULD VISIT A SITE LIKE THIS",
  "HEY, I WANT TO BE IN THE PRESENTATION",
  "WHAT KIND OF SANDWICH WOULD YOU RECOMMEND FOR A WEDDING?\n\nA GROOM-BALL SUB",
  "What’s a singer’s favorite sandwich?\n\nSo-la-mi",
  "I WROTE A SONG ABOUT A SANDWICH... WELL IT'S MORE A 'WRAP' REALLY",
  "A CHEESE SANDWICH WALKS INTO A PUB.\nTHE LANDLORD SAYS 'SORRY, WE DON'T SERVE FOOD'",
  "WHAT DOES AN INJURED PERSON AND THE FILLINGS OF A SANDWICH HAVE IN COMMON?\n\nTHEY'RE BOTH IN PAIN",
  "Is a hot dog a sandwich or a sub?\n\nIt’s just a hot dog. No bun intended.",
  "RIGHT NOW THIS IS JUST FEELING LIKE BANANAKINGZ 2.0"
]

const getRandomIntInclusive = (min, max) => {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1) + min);
};

$(() => {
  $("#song").attr("src", "/midi/" + SONGS[Math.floor(Math.random() * SONGS.length)] + ".mp3")
  $("#banner-1").attr("src", "/img/banners/" + getRandomIntInclusive(1, BANNERS) + '.gif');
  $("#banner-2").attr("src", "/img/banners/" + getRandomIntInclusive(1, BANNERS) + '.gif');
  alert(BARKS[Math.floor(Math.random() * BARKS.length)].toUpperCase());
});
