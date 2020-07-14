/**
 *
 * @authors RealTime
 * @date    2018-9-15
 * @version 1.0
 */

$( document ).ready(function(){
    //menu
    $( ".mobile_menu" ).click(function() {
        $( ".users" ).slideToggle( 200 );
        $(this).find('.menu').toggleClass('open');
    });
    //向下展開 風格１
      var _showTab = 0;
      $( ".editform").hide();
      $( ".maintain").click(function() {
      $(this).parents("td").parents("tr").next(".editform").slideToggle();
    });
    
    //向下展開 風格２
    var _showTab = 0;
      $( ".editformIndex").hide();
      $( ".airAdd").click(function() {
      $(this).parents("td").parents("tr").next(".editformIndex").slideToggle();
    });

     //向下展開 風格２ 
     var _showTab = 0;
     $( ".editformIndex1").hide();
     $( ".airAdd1").click(function() {
     $(this).parents("td").parents("tr").next("tr").next(".editformIndex1").slideToggle();
   });
    // 時間
    $( "#datepicker" ).datepicker({
      changeMonth: true,
      changeYear: true,
      dateFormat: "yy-mm-dd",
      yearRange: '1900:2080'
    });
    $( "#datepicker1" ).datepicker({
      changeMonth: true,
      changeYear: true,
      dateFormat: "yy-mm-dd",
      yearRange: '1900:2080'
    });

 
});



    




// 標籤分頁
function myFunction(tab, evt) {
  //先把所有元件全部關閉
  var DatederedBoxes = document.getElementsByClassName('tab1');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

  
  var DatederedBoxes = document.getElementsByClassName('tab3');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

   var DatederedBoxes = document.getElementsByClassName('tab4');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

  // 打開要打開的classß
  var DatederedBoxes = document.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = document.getElementsByClassName("tabBox");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor");
  }
  

  var originTab1 = document.getElementById('tabbox1');
  if (originTab1 != null){
    originTab1.style = null;
  }
  
  evt.currentTarget.classList.add("tabColor");
  
  var originTab2 = document.getElementById('tabbox2');
  if (originTab2 != null){
    originTab2.style = null;
  }
}

function popupMyFunction(tab, evt) {
  //先把所有元件全部關閉
  var DatederedBoxes = document.getElementsByClassName('tab1');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }


  // 打開要打開的classß
  var DatederedBoxes = document.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = document.getElementsByClassName("tabBox");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor2");
  }
  
  
  //移除預設的
  var originTab2 = document.getElementById('tabbox2');
  if (originTab2 != null){
    originTab2.style = null;
  }

  //focus 
  evt.currentTarget.classList.add("tabColor2");
}

function popupMyFunction2(tab, evt) {
  //先把所有元件全部關閉
  var DatederedBoxes = document.getElementsByClassName('tab1_2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab2_2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab3_2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

  // 打開要打開的classß
  var DatederedBoxes = document.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = document.getElementsByClassName("tabBox_2");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor2");
  }
  
  
  //移除預設的
  var originTab2 = document.getElementById('tabbox2_2');
  if (originTab2 != null){
    originTab2.style = null;
  }

  //focus 
  evt.currentTarget.classList.add("tabColor2");
}


function popup14MyFunction(tab, evt) {

  var root = document.getElementById('popup14');

  //先把所有元件全部關閉
  var DatederedBoxes = root.getElementsByClassName('tab114');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = root.getElementsByClassName('tab214');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }


  // 打開要打開的classß
  var DatederedBoxes = root.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = root.getElementsByClassName("tabBox");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor2");
     x[i].style = null;
  }

  //focus 
  evt.currentTarget.classList.add("tabColor2");
}

function popup15MyFunction(tab, evt) {

  var root = document.getElementById('popup15');

  //先把所有元件全部關閉
  var DatederedBoxes = root.getElementsByClassName('tab114');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = root.getElementsByClassName('tab214');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = root.getElementsByClassName('tab314');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }


  // 打開要打開的classß
  var DatederedBoxes = root.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = root.getElementsByClassName("tabBox");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor2");
     x[i].style = null;
  }

  //focus 
  evt.currentTarget.classList.add("tabColor2");
}

// focus在第二頁
function selectTab2(tab) {
  //先把所有元件全部關閉
  var DatederedBoxes = document.getElementsByClassName('tab1');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab2');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

  
  var DatederedBoxes = document.getElementsByClassName('tab3');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }
  var DatederedBoxes = document.getElementsByClassName('tab4');
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "none";
  }

  // 打開要打開的classß
  var DatederedBoxes = document.getElementsByClassName(tab);
  for (var i = 0; i < DatederedBoxes.length; i++) {
      DatederedBoxes[i].style.display = "block";
  }

  var x = document.getElementsByClassName("tabBox");
  for (i = 0; i < x.length; i++) {
     x[i].classList.remove("tabColor");
  }
  
  // 取消預設的style
  var originTab1 = document.getElementById('tabbox1');
  if (originTab1 != null){
    originTab1.style = null;
  }
  
  // 包分頁二加上底線
  var tab2 = document.getElementById('tabbox2');
  if (tab2 != null){
    tab2.classList.add("tabColor");
  }
}

//跳窗
// Get the modal
var modal = document.getElementById('popup1');
var modal = document.getElementById('popup2');
var modal = document.getElementById('popup3');
var modal = document.getElementById('popup4');
var modal = document.getElementById('popup5');
var modal = document.getElementById('popup6');
var modal = document.getElementById('popup7');
var modal = document.getElementById('popup8');
var modal = document.getElementById('popup9');
var modal = document.getElementById('popup10');
var modal = document.getElementById('popup11');
var modal = document.getElementById('popup12');
var modal = document.getElementById('popup13');
// When the user clicks anywhere outside of the modal, close it

window.onclick = function(event) {
    console.log(1);
    if (event.target == modal) {console.log(2);
        //modal.style.display = "none";
    }
    $( ".modal_title_close" ).click(function() {
        $(".modal" ).hide();
    });
    $( ".BtnCOlor" ).click(function() {
        $(".modal" ).hide();
    });
      
}



$(document).ready(function() {
  var counter = 0;
  var c = 0;
  var i = setInterval(function(){
      $(".loadingBox .loadingtime h1").html(c + "%");
    counter++;
    c++;
    if(counter == 101) {
        clearInterval(i);
    }
  }, 50);
});