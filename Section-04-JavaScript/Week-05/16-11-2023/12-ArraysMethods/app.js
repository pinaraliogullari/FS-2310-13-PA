"use strict"; //JavaScript use strict anahtar kelimesi kullanım amacı kodun katı kurallı olarak çalıştırılacağını belirtir. Katı kurallı kullanımda değişken oluşturulmadan kullanmaya izin verilmez.
let students=["ayşen", "umay","ceyda","begüm","köfte","heda"];
let result;


// result=students.length;
// result=students; //diziler başka bir değişkenin içine katarılabilir.
// result=students.toString(); //birleştirilebilir ve stringe dönüştürülebilirler.
// result=students.join("-");// elemanların arasına istediğimiz karakteri koymamızı sağlar. hiçbir şey koymayadabiliriz.
// result = students.join(";");
// result = result.split(";");


// //concat: 2 diziyi tek dizi haline getirir.
// let products1= ["Ürün1", "Ürün2", "Ürün3"];
// let products2 = ["Ürün4", "Ürün5", "Ürün6"];
// result=products1.concat(products2);

//push:sona eleman ekler.
// students.push("Pinar");


// //pop:son elemanı siler.
// students.pop();


// //shift: ilk elemanı siler.
// students.shift();


// // unshift: başa eleman ekler.
// students.unshift("Emre");


//students dizisindeki ceyda değerini taşıyan elemanın içeriğini ece olarak değiştirin.
// let indexCeyda=students.indexOf("ceyda");
// students[indexCeyda]="Ece";
// console.log(result);


//değer silme
//  students.splice(students.indexOf("ceyda"),1);
students.splice(2, 1);

 result = students;
 console.log(result);



