/* Scrollevent abfragen */
window.onscroll = function() {myHeader()};

/* Variablen definieren */
var header = document.getElementById("navbar");
var sticky = header.offsetTop;

/* Funktion für das fixieren der Navigationsleiste */
function myHeader() {
  if (window.pageYOffset > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}