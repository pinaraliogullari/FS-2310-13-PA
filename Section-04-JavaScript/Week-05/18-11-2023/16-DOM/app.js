/*
DOM-Document Object Model
*/

/**************************1) Single Element(id si olan element)**********************************************************/

// let result;
//getElementById :id seçer
// result = document.getElementById("task-list");
// result = document.getElementById("title");
// result.style.backgroundColor="red";
// result.style.color="white";
// result.style.padding="10px";
// // result.innerText="Full Stack Programlama"; //sadece text olarak yazmamızı sağlar.

// result.innerHTML="<span style='color:yellow'>Full Stack</span> Proramlama"; //veriyi ve html kodunu yazmamızı sağlar.



//querySelector: her türü seçebilir. türün başına ayırt edicisini girmeliyiz. . # gibi.
//dökümanın en üstünden başlayarak ilk karşılaştığı elemanı bulup getirir.
// result=document.querySelector("#title");
// result=document.querySelector(".card-title"); //aynı isimle farklı classlar varsa ilkini seçer.
// result=document.querySelector("li");


// console.log(result);
/*****************************************2)MULTI ELEMENTS************************************************************** */

//getElementsByClassName

// let result;
// result= document.getElementsByClassName("card-title");
// result=document.querySelector("li"); //birazdan tümünü seçeçcek querySelectorAll u öğreneceğiz.
// result=document.getElementsByClassName("task");

//getElementByTagname
// result= document.getElementsByTagName("li"); //var olan tüm lileri döndürür.

//querySelectorAll
// result=document.querySelectorAll(".task");
// result=document.querySelectorAll("#task-list-2 .task");
// console.log(result);


//araştırma Ödevi: HTMLCollection ile NodeList arasındaki fark ve benzerlikleri araştırın.


/*****************************************3)TRAVERSING ELEMENTS************************************************************** */

let result;
// let taskList=document.getElementById("task-list");
// result=taskList.children; //bir elemntin içindeki tüm elementleri seçer.
// console.log(taskList);


// let body=document.querySelector("body");
// console.log(body);
// result=body.children;
// result=body.children[0]; //0. childrenı getir.
// result=body.firstElementChild; //aynı şekilde ilk elemanı getirir.
// result=body.lastElementChild;// son elementi verir.


// result=document.getElementById("title");
// result=result.parentElement.parentElement; //bir üst elementi(kapsayıcı elementi) bulma

result = document.getElementById("task-list");
result = result.firstElementChild;
result = result.nextElementSibling; //aynı seviyedeki bir sonraki elemanı seçer. bir sonraki elemean için de tekrar nextElement.siblings demeliyiz.
result = result.previousElementSibling;//bir önceki elemente gider.

console.log(result);

