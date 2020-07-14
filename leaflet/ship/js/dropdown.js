/**
 *
 * @authors RealTime
 * @date    2018-9-15
 * @version 1.0
 */

// 下拉
function makeCustomSelect(el_customSelect) {

  
  if(!el_customSelect) return;
  
  var el_selector = el_customSelect,
      el_input = el_customSelect.querySelector(".simInput_customSelector"),
      el_btnQuery = el_customSelect.querySelector(".imgBtn_customSelector_query"),
      el_drapdown = el_customSelect.querySelector(".drapdown_customSelector"),
      el_listItem = el_customSelect.getElementsByClassName("listItem_customSelector"),
      el_listItemLabel = el_customSelect.getElementsByClassName("listItem_label"),
      el_listItemAddBtn = el_customSelect.getElementsByClassName("listItem_imgBtn_add"),
      el_input = el_customSelect.querySelector(".simInput_customSelector");
  var isClose = true;
  el_input.addEventListener("click", e => {
    if (isClose==true){
      el_drapdown.classList.add("expand");
    } else {
      el_drapdown.classList.remove("expand");
    }
    isClose = !isClose;
  });
  for(var i = 0; i < el_listItem.length;i += 1) {
    el_listItem[i].addEventListener("click", e => {
      var _label = e.target.querySelector(".listItem_label").innerText;
      el_input.innerHTML = "<i class='selected'>" + _label + "</i>";
      el_drapdown.classList.remove("expand");
      for(var j = 0; j < el_listItem.length; j += 1) {
        el_listItem[j].classList.remove("selected");
      }
      e.target.classList.add("selected");
    });
  }

 
}


 // 特殊的需求 箭頭也要可以控制下拉
 var arrow = document.getElementById("imgBtn_admin2");
 var dropdown = document.getElementById("dropdown_admin2");
 
 var imgBtn_admin2IsClose = true;
 if (arrow != null){
   arrow.addEventListener("click", e => {
     if (imgBtn_admin2IsClose==true){
       dropdown.classList.add("expand");
     } else {
       dropdown.classList.remove("expand");
     }
     imgBtn_admin2IsClose = !imgBtn_admin2IsClose;
   });
 }

 var arrow3 = document.getElementById("imgBtn_admin3");
 var dropdown3 = document.getElementById("dropdown_admin3");
 
 var imgBtn_admin3IsClose = true;
 if (arrow3 != null){
   arrow3.addEventListener("click", e => {
     if (imgBtn_admin3IsClose==true){
       dropdown3.classList.add("expand");
     } else {
       dropdown3.classList.remove("expand");
     }
     imgBtn_admin3IsClose = !imgBtn_admin3IsClose;
   });
 }

 var arrow4 = document.getElementById("imgBtn_admin4");
 var dropdown4 = document.getElementById("dropdown_admin4");
 
 var imgBtn_admin4IsClose = true;
 if (arrow4 != null){
   arrow4.addEventListener("click", e => {
     if (imgBtn_admin4IsClose==true){
       dropdown4.classList.add("expand");
     } else {
       dropdown4.classList.remove("expand");
     }
     imgBtn_admin4IsClose = !imgBtn_admin4IsClose;
   });
 }


 
var list_customSelector = document.getElementsByClassName("box_customSelector");
for(var i = 0; i < list_customSelector.length; i +=1) {
  makeCustomSelect(list_customSelector[i]);
}

var list_customSelector = document.getElementsByClassName("box_customSelector2");
for(var i = 0; i < list_customSelector.length; i +=1) {
  makeCustomSelect(list_customSelector[i]);
  console.log(i)
}
