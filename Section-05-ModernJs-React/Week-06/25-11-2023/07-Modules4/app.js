/*rastgele üretilecek 1-100 arasındaki 10 adet sayıyı kullanarak bir dizi oluşturun.
Oluşturulan dizi içerisindeki tek sayıları tespit edip döndüren bir function.
Oluşturulan dizi içerisindeki çift sayıları tespit edip döndüren bir function.
içeren bir module dosyası hazırlayıo, app.js içinde kullanın.
*/

// import { randomNumbers, getOddNumbers, getEvenNumbers } from "./core.js";

// const numbers=randomNumbers();
// console.log("Dizinin originali: "+numbers);
// console.log("Tek sayilar: "+getOddNumbers(numbers));
// console.log("Cift Sayilar: "+getEvenNumbers(numbers));


//tek fonkda yazdık.

import { getResult } from "./core.js";
//  let result=getResult();
console.log(getResult());
console.log("Orjinal hali " + result.all);
console.log("Tek Sayilar " + result.odds);
console.log("Çift hali " + result.evens);

