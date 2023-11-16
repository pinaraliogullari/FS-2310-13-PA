//Java Script Object Notation-JSON
//Veri taşıma için kullanılan dosya tarif yapısıdır. JSON bir veri formatıdır. 
"use strict";
// let student1 = ["Zeynep Nur", "Ay", 28, "Kadın", 324, 46,];
// let student2 = ["Çağdaş", "Taş", 28, "Erkek"];
// let student3 = ["Furkan", "Gültekin", 20, "Erkek"];

// let students = [student1, student2, student3];
// console.log(students);

// for (let i = 0; i < students.length; i++) {
//     console.log(students[i][0] + " " + students[i][2]);
// }



// let student1 = {
//     firstName: "Pinar",
//     lastName: "Aliogullari",
//     age: 27,
//     gender: "Kadın"

// };
//yukarıdaki student1 değişkeni bir OBJECT tir. firstName, lastName, age ve gender ise bu objenin propertyleridir.

// console.log(student1.firstName);
// console.log(student1.gender  + " " + student1.age);

// let student2 = {
//     firstName: "Emre",
//     lastName: "Kaya",
//     age: 29,
//     gender: "Erkek"

// };

// let student3 = {
//     firstName: "Serkan",
//     lastName: "Aliogullari",
//     age: 23,
//     gender: "Erkek"

// };
// let students = [student1, student2, student3];
// let studentCount = students.length;
// let total = 0;


// for (let i = 0; i < studentCount; i++) {
//     console.log(students[i].firstName + " " + students[i].gender);
//     total += students[i].age;

// }
// let average = total / studentCount;
// console.log(`Yaş ortalaması: ${average.toFixed(2)}`);


/*içerisinde ahmet, mehmet, yeşim değerlerinin olduğu bir dizi tanımlayın. ayrıca yine içerisinde inşaat mühendisliği, yazılım mühendisliği ve mimarlık değerlerinin olduğu bir başka dizi daha tanımlayın. Sonra içinde name ve department bilgilerini yer aldığı 3 adet student objectini şu şekilde oluşturun:

Üç öğrenciye rastgele bölüm atansın ve örnek olarak şu şekilde nesneler oluşsun:
{
    name:"ahmet",
    department:"yazılım mühendisliği"
}
içiçe döngü kullanılacak.
*/

let names = ["Ahmet", "Mehmet", "Yeşim"];
let nameCount = names.length;
let department = ["inşaat müh", "mimarlık", "yazılım müh"];
let departmentCount = department.length;
let randomValue1;
let randomValue2;



for (let i = 0; i < nameCount; i++) {
    randomValue1 = Math.floor(Math.random() * nameCount);

    for (let j = 0; j < departmentCount; j++) {
        randomValue2 = Math.floor(Math.random() * departmentCount);


    }

}
console.log(names[randomValue1] + " " + department[randomValue2]);

