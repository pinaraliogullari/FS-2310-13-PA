
//map işlem yapmak istediğimiz dizinin üzerinde dolaşır. koşula uygun olanlar ile yeni bir dizi oluşturur.
// let numbers = [4, 914, 20, 19];
// let evenNumbers = numbers.map(nextNumber => {
//     if (nextNumber % 2 == 0) return nextNumber;
// });
// console.log(numbers);
// console.log(evenNumbers);


let prices=[40, 50, 100, 200, 250];
let newPrices= prices.map(nextPrices=>{
    return nextPrices*1.2;
});

console.log(prices);
console.log(newPrices);
