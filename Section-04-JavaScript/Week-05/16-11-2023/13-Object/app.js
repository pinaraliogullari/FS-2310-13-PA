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

// let names = ["Ahmet", "Mehmet", "Yeşim"];

// let departments = ["inşaat müh", "mimarlık", "yazılım müh"];
//hocanın çözümü;

// let result = [];
// let random=3;

// for (let i = 0; i < names.length; i++) {
//     while (random>2) {
//         random = parseInt(Math.random() * 10);
//     }

//     result.push({name:names[i], department:departments[random]});
// random=3;

// }
// console.log(result);

//diğer çözüm;


 let names = ["Ahmet", "Mehmet", "Yeşim"];

 let departments = ["inşaat müh", "mimarlık", "yazılım müh"];
//0 ile 5 arası sayı üretir. 5 hariç.
//  let random=Math.random()*5; 
//  console.log(random);
//  console.log(Math.floor(random));

 //verilen min ve max değer arasında rastgele bir sayı üretir. min ve max dahildir.

//  let random=Math.floor(Math.random()*7+3);

//  function randomInt(min,max){

//     return Math.floor(Math.random()*(max-min)+min);

//  }

//  console.log(randomInt(0,3));

let students=[];
let arr=[];

while(arr.length<3){
    let n=Math.floor(Math.random()*departments.length);
     if(arr.indexOf(n)==-1) arr.push(n);
}

 for(let i=0; i<names.length; i++)
 {
     let student={name:names[i], department: departments[arr[i]]};
    students.push(student);

}
 console.log(students);