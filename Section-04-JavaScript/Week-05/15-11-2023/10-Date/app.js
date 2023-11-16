let result;
let now;
now = new Date();
result = now;
result = now.getDate(); // günü verir.
result = now.getDay(); //haftanın kaçıncı günü olduğunu verir.

// let newDate= new Date(2023,5,12); // ay bilgisi 0 dan başlar. bu sonuç haziranı verir.
// result=newDate.getDay();

// result = now.getFullYear();
// result = now.getHours();
// result = now.getTime();

// result = now.getMinutes();
// result = now.getSeconds();


// result = new Date(1900, 0, 1);
// result=result.getTime();// 1 0cak 1900 yılının sayısal karşılığı


// let year = result.getFullYear() + 3;
// let month = result.getMonth();
// let day = result.getDate();
// result = new Date(year, month, day);
// console.log(result);

//kaç gün yaşadığımızı bulan kod;
// let birthday = new Date(1996, 7, 18);
// // let milisecond = now - birthday;
// let second = milisecond / 1000;
// let minute = second / 60;
// let hour = minute / 60;
// let dayCount = hour / 24;
// console.log(dayCount);

// console.error(dayCount);//hatalı durumlar farklı görünsün istiyorsak  böyle yazdırabiliriz.
// console.warn(dayCount);//hatalı durumlar farklı görünsün istiyorsak  böyle yazdırabiliriz.

//Araştırma ödevi:getTime ()ı  0 olan tarih nedir?

let date = new Date(1970, 0, 1, 0, 0, 0, 0);
console.log(date);
console.log(date.getTime())









//-2208995816000
//-2208995816000
