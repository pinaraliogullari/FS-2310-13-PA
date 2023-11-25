const calculateCircleArea = (r, pi = 3) => {
    return "Circle Area: " + r * r * pi;
}

console.log(calculateCircleArea(5, 3.14));
console.log(calculateCircleArea(5));
console.log(calculateCircleArea(5, 3.145683));

//rest parameters: ne kadar değer gönderirsek gönderelim alır. yukarıdaki yöntem doğru olandır.
const calculateCircleArea2 = (...parameters) => {
    let array = [...parameters];
    let r = array[0];
    let pi = array[1] == undefined ? 3 : array[1];
    return "Circle Area: " + r * r * pi;

}

console.log(calculateCircleArea2(5, 3.14));

//Soru: içerisine gönderilen sayıları toplayıp, sonucu ekrana yazan arrow functionı hazırayalım.

const getTotal= (...numbers)=>{
    let arr= [...numbers];
    let total=0;
    for(let i=0; i<arr.length; i++){
        total+= arr[i];
    }
    return total;

};

// console.log(getTotal(5,6));
// console.log(getTotal(10,20,30,40));
const basketItemsPrices =[135, 500, 900,250]; 
console.log(getTotal(...basketItemsPrices));// direkt olarak bir dizi göndereceksek rest işlemine tabi tutup gönderiyoruz.
