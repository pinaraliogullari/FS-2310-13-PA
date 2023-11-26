"use strict";

// function Student(){
//     firstName="";
//     lastName="";
//     age=0;
// }

// let student1 = new Student();
// student1.firstName="Çağdaş";
// student1.lastName="Taş";
// student1.age=23;

// console.log(student1);



function Product (productName, productPrice){
    this.productName=productName;
    this.productPrice=productPrice;
}
 

let p1= new Product("IPhone13", 42500);
console.log(p1);

let p2= new Product("Samsun S22", 37000);
console.log(p2);