//kendisine verilecek sayının faktörüyelini hesaplayan ve geri döndüren bir function hazırlıyoruz.

 const  calculateFactorial = number => {
    if (number == 0 || number == 1) return 1;

    for (let i = number-1; i >= 1; i--) {
        number =number*i;
    }
    return number;
}



 const display= ()=>{
    console.log("Merhaba");
}


export {display};
export default calculateFactorial; //default olaraj tanımladığımızda import ederken süsllü parantez kullanılmaz. (bkz:app.js)
