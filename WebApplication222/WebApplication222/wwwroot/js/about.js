
function showSidebar(){
    const sidebar = document.querySelector('.sidebar')
    const menu = document.querySelector('.menu-button')
    sidebar.style.display = 'flex'
    menu.style.display= 'none'
  }
  function hideSidebar(){
    const sidebar = document.querySelector('.sidebar')
    const menu = document.querySelector('.menu-button')
    sidebar.style.display = 'none'
    menu.style.display= 'block'
  }









var MainImg = document.getElementById("MainImg");
var smallImg = document.getElementsByClassName("small-img");

smallImg[0].onclick = function(){
    MainImg.src = smallImg[0].src;
}
smallImg[1].onclick = function(){
    MainImg.src = smallImg[1].src;
}
smallImg[2].onclick = function(){
    MainImg.src = smallImg[2].src;
}
smallImg[3].onclick = function(){
    MainImg.src = smallImg[3].src;
}





