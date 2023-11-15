//Döngü:Aynı kod parçasının tekrar tekrar çalıştırılmasını sağlayan yapıya döngü denir.

//WHILE:Yazılan koşul doğru olduüu sürece kodlar çalışacak
// let a = 1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

//1 ile 10 arasındaki çift sayıları konsola yazdırın.
// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }

//     i++;

// }

//1 ile 50 arasındaki 4 ün katı olan sayıların adetini bulup konsola yazdırın.
// let i = 1;
// let counter = 0;
// while (i <= 50) {
//     if (i % 4 == 0) {
//         counter++;

//     }
//     i++;
// }
// console.log("1 ile 50 arasındaki 4 ün katları olan sayı adeti :" + counter);

//girilecek 3 adet sayıyı toplayıp console yazdırın.
// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("Lütfen sayıyı giriniz: "));
//     //total = total + num;
//     total += num;
//     i++;
// }
// console.log(total); 




//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp console a yazan kodu yazınız. Not:kullanıcı 0 girerse uygulama sona ersin.
// let i = 1;
// let num;
// let total = 0;
// while (true) {
//     num = Number(prompt("Lütfen sayı giriniz: "));
//     if (num == 0) {
//         break;
//     }
//     total += num;

// }
// console.log("toplam: " + total);

//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp console a yazan kodu yazınız. Not:kullanıcı exit girerse uygulama sona ersin.
// let i = 1;
// let num;
// let total = 0;
// while (true) {
//     num = prompt("lütfen " + i + ". sayiyi giriniz:(Çıkmak için exit) ");

//     if (num.toLocaleLowerCase() == "exit") {
//         break;

//     }
//     i++;
//     total += Number(num);

// }
// i--;
// console.log("girdiğiniz" + i + " adet sayının toplamı:" + total);

//FOR DÖNGÜSÜ

// let count=Number(prompt("lütfen bir sayı gir"));
// for (let i = 0; i <= count; i++) {
//     console.log(i);
// }

//1 ile 10 arasındaki çift sayıları console a yazdırın.
// for(let i=1; i<=10; i++)
// {
//     if (i%2==0) {
//         console.log(i);

//     }
// }

//1 ile 10 arasındaki tek sayıları console a yazdırın.
// for(let i=1; i<=10; i++)
// {
//     if (i % 2 == 0) {//eğer durum böyleyse bu adımı atlar aşağıdan devam eder.
//         continue;

//     }
//     console.log(i);

// }

//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsole yazan kodu yazınız . for kullanın. while ile çözmek mantıklıdır.

// for(let i=0; i==0; ){
//     console.log("merhaba");
// }

// let total = 0;
// let num;
// for (let i = 0; i == 0;) {
//     num = prompt("lütfen bir sayı giriniz: ");
//     if (num.toLocaleUpperCase() == "exit") {
//         break;
//     }
//     total += Number(num);

// }
// console.log(total);

//1 ile 20 arasındaki sayıları konsola şu şekilde yazdıran kodu hazırlayınız.
//1-tek sayı
//çift sayı
//tek sayı
//çift sayı

for (let i = 0; i <= 20; i++) {
    if (i % 2 == 0) {
        console.log(`${i} cift sayi`);
    }
    else {
        console.log(`${i} tek sayi`);
    }
}
