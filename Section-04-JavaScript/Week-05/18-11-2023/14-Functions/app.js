"use strict"
//PARAMETRESİZ FONKSİYON

// function sayHello(){
//     console.log("Merhaba");
// }

// sayHello();

/********************************************************************************** */
//PARAMETRELİ FONKSİYON

// function sayHello2(message) {
//     console.log(message);

// }

// sayHello2("Merhaba, nasılsın?")
/********************************************************************************** */

// function today() {

//    let result= new Date();
//    return result;

// }

// let bugun=today();
// console.log(bugun);

// function calculateAge(yearOfBirth) {
// // let today= new Date();
// // let year=today.getFullYear();
// // let result= year- yearOfBirth;
// // return result;
// return new Date().getFullYear()- yearOfBirth;

// }

// console.log(calculateAge(1975));

/*
Kadınlar için emeklilik yaşı 60 erkekler için 65 tir. Buna göre doğum yılı, cinsiyeti ve adı verilen bir kişinin emekli olmasına kaç yıl kaldığını şu örnekteki gibi bildiren function ı hazırlayınız.
Sayın 'Fettah Can',emekli olmanıza 7 yıl kalmıştır.
*/


// function calculateAge(yearOfBirth) {
//     let today = new Date();
//     let year = today.getFullYear();
//     let result = year - yearOfBirth;
//     return result;


// }
// function calculatePension(yearofBirth, gender, fullName) {
//     let age = calculateAge(yearofBirth);
//     let diff = gender === "Kadin" ? 60 - age : 65 - age;
//     // let result ='Sayın "' + fullName +'" emekli olmanıza ' + diff +  ' yıl kalmıştır.'
//     // let result = 'Sayın \' ' + fullName + '\' emekli olmanıza ' + diff + ' yıl kalmıştır.'

//     //template literal yöntemi
//     let result=`Sayın '${fullName}' emekli olmanıza  ${diff} yıl kalmıştır.`
//     return result;
// }

// console.log(calculatePension(1995, "Kadin", "Sezen Aksu"));

/****************************************************************************** */
//kendisine verilen bir dörtgenin kenar uunluklarını alıp ilgili dörtgenin alanını ve çevresini hesaplayıp geri döndğren bir function hazırlayalım.

// function calculate(short, long) 
// {
//     let area=short*long;
//     let env=(short+long)*2;
//     //return ile tek bir değer döndürülebilir. yani return env, area; diyemeyiz. bu yüzden dizi içine aldık ya da obje olarak da gönderebiliriz.
//     // let result=[area, env];
//     let result={area, env}
//     return result;


// }

// console.log(calculate(4,6));


//SORU:Çağrıldığında bize Yazı ya da Tura şeklinde sonuç veren fonksiyonu hazırlayın.

// function yazıTuraAt() {
//     let random = Math.random();
//     let result = random >= 0.5 ? "Yazı" : "Tura";
//     return result;


// }

// console.log(yazıTuraAt());

//SORU: Kendisine gönderilen sayının tam bölenlerini bulup döndüren fonksiyonu hazırlayınız.

// function tamBolenler(sayi) {
//     let tambolenlerDisizi = [];
//     for (let i = 1; i <= sayi; i++) {
//         if (sayi % i == 0) {
//             tambolenlerDisizi.push(i);
//         }
//     }
//     return tambolenlerDisizi;
// }

// console.log(tamBolenler(8));

//ÖDEV: 1-50 arasındaki asal sayıları bulup  döndüren fonksiyonu yazınız.

function findPrime() {
    let primeArray = [];

    for (let i = 1; i < 50; i++) {
        if (isPrime(i)) {
            primeArray.push(i);
        }
    }

    return primeArray;
}

function isPrime(number) {
    if (number < 2) return false;

    for (let i = 2; i < number; i++) {
        if (number % i === 0) return false;
    }

    return true;
}

let primeArray = findPrime();
console.log(`1 ile 50 arasındaki asal sayılar :${primeArray}`);


