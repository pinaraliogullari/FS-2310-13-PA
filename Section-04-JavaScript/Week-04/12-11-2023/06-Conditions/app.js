// let a=10;

// if (a>10) {
//     console.log("Sayı büyük");
// }


// let a = 10;

// if (a > 10) {
//     console.log("Sayı büyük");
// } else {
//     console.log("Sayı büyük değil");
// }

// let a = 15;

// if (a > 10) {
//     console.log("Sayı büyük");
// } else if(a<10) {
//     console.log("Sayıküçük");
// }else {
//     console.log("Sayılar eşit");
// };

// let a = 15;

// if (a > 10) {
//     console.log("Büyük");
// };
// if (a < 10) {
//     console.log("Küçük");

// };
// if (a == 10) {
//     console.log("Eşit");
// };

// let age=12;
/* 0-16:Çocuk
17-35:genç
36-50:yaşlı
51-70:ölmüş ağlayanı yok
71'den büyükse:no comment
*/
// if (age<= 16) {
//     console.log("Çocuk");
// }else if(age<=35){
//     console.log("Genç");
// }else if(age<=50){
//     console.log("Yaşlı");
// }else if(age<=70){
//     console.log("Ölmüş ağlayanı yok");
// }else{
//     console.log("No comment");
// };

// if (age <= 16) {
//     console.log("Çocuk");
// } ;
// if (age <= 35) {
//     console.log("Genç");
// } ;
//  if (age <= 50) {
//     console.log("Yaşlı");
// };
//  if (age <= 70) {
//     console.log("Ölmüş ağlayanı yok");
// }
//  if(age>70) {
//     console.log("No comment");
// };

//TERNARY IF OPERATOR(ÜÇLÜ OPERATOR)
// let message;
// let age = 30;
// // if (age>=18) {
// //    message="girebilirsiniz.";
// // } else {
// //     message="giremezsiniz.";
// // };
// message = age >= 18 ? "girebilirsiniz" :"giremezsiniz.";
// console.log("Yaşınız " + age + " " + "olduğu için " + message);


/* 0-16:Çocuk
17-35:genç
36-50:yaşlı
51-70:ölmüş ağlayanı yok
71'den büyükse:no comment
*/
//TERNARY IF ÇÖZÜMÜ

// let age = 20;
// let result;
// result =
//     age <= 16 ? "Çocuk" :
//         age <= 35 ? "Genç" :
//             age <= 50 ? "Yaşlı" :
//                 age <= 70 ? "Ölmüş ağlayanı yok" : "No comment";
// console.log(result);

//ALERT(kullanıcıya mesaj vermek için)
// alert("Merhaba");
// let message = "Merhaba";
// alert(message);

//PROMPT(kullanıcıdan bilgi almak için)
// let age;
// age = prompt("Kaç yaşındasınız?");
// console.log(age + " yaşındasınız");
// console.log(typeof age);

//CONFIRM
// result = confirm("Emin misiniz?");

/*SORU-1)
let a=40;
let b=60;
let result;
if(a-b< 30){
result="Küçük"
}else{
    result="Büyük"
}
Bu kodu ternary if ile yazın

*/
// let a = 40;
// let b = 60;
// let result;
// result = a - b < 30 ? "Küçük" : "Büyük";
// console.log(result);

/*
Kullanıcıya "JavaScriptin official ismi nedir?" şeklinde bir soru sorup gelen cevap ECMAScript ise Tebrikler bildiniz değilse YANLIŞ CEVAP yeniden deneyiniz şeklinde bir cevabı alert ile
if else ile
ternary if ile yaznınız
*/

// let trueAnswer = "ECMAScript";
// let userAnswer = prompt("JavaScriptin official ismi nedir?");
// let result;

// if (trueAnswer == userAnswer) {
//     result = "Tebrikler,bildiniz!";
// } else {
//     result = "Yanlış cevap yeniden deneyiniz!"
// }
// alert(result);

// //TERNARY
// result = userAnswer == trueAnswer ? "Tebrikler,bildiniz!" : "Yanlış cevap yeniden deneyiniz!";
// alert(result);
