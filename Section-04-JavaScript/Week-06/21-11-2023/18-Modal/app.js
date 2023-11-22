const btnOpenModal = document.getElementById("btn-open-modal"); // birden fazla kez kullanma ihtimalimiz  olduğu için bir değişkene atıyoruz.
const mainModal = document.querySelector(".main-modal");
const btnCloseModal = document.querySelector(".btn-close-modal");
const btnNoModal = document.querySelector(".btn-no-modal");

btnOpenModal.addEventListener("click", function () {
    mainModal.classList.remove("main-modal-none");
});

//btnCloseModal ı ve btnNoModalı  da yukarıaki gibi yazabilirdik. Ancak fonklar aynı olduğu için bu şekilde yaptık.
btnCloseModal.addEventListener("click", closeModal);
btnNoModal.addEventListener("click", closeModal);
mainModal.addEventListener("click", function(event){
    // console.log(event.target);//target click nerede gerçekleşiyorsa onu veriyor. console dan takip edebiliriz.
    //kutunun dıiına tıklanınca da kapansın istiyoruz.
    //tek bir class tanımlıysa bunu kullanabiliriz.
// if(event.target.className=="main-modal"){
//     closeModal();
// }

if(event.target.classList.contains("main-modal")){
    closeModal();
};
  
});


function closeModal(){
    mainModal.classList.add("main-modal-none");
};