function selamVer() {
    console.log("Merhaba,  burası klasik bir function");
}


const selamVer2 = () => {
    console.log("Merhaba, burası bir arrow function");
}


const selamVer3 = (ad) => {
    console.log("Merhaba " + ad)
}

//sayi3 e varsayılan değer girdik. yani eğer sayi3 e değer girilmezse 0 olarak kabul edilecek. varsayılan değerler son sırada verilmelidir.
const topla = (sayi1, sayi2, sayi3 = 0) => {
    return sayi1 + sayi2 + sayi3;
}


//bir functionun tek bir parametresi varsa parantez kullanmayabiliriz.
const selamVer4 = ad => {
    return console.log("Merhaba" + ad);
}


//tek bir satır varsa scopa kullanmayabiliriz.
const topla2 = (sayi, sayi2) => sayi1 + sayi2;





selamVer();
selamVer2();
selamVer3("Pino");
console.log(topla(1, 2));
selamVer4("Emre");
console.log(topla2(5, 20));