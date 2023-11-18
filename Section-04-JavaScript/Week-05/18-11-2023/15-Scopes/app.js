//bir function scope u içinde let ile tanımlanan değişken sadece o functionda geçerlidir.
// function print(){
//     let name = "Zeynep Nur Ay";

//     console.log(name)
// }

// if (true) {
//     let price=45;
//     console.log(price)
// }

// print();

// console.log(price); //price tanımlı değil dedi.




//ES5 öncesinde js de değşşken tanımlamak için var ve const keywordleri vardı.
//ES5 ile birlikte bunlara let eklendi. Doğru olan let ile ilerlemektir.

//bir function scope u içinde var ile tanımlanan değişken function dışında da kullanılabilir. Ama bu avantajlı bir durum değildir.
//let kullanılmalıdır.



function print() {
    var name = "Zeynep Nur Ay";
    console.log(name);
}

if (true) {
    var price = 56;
}
print();

console.log(name);
console.log(price);