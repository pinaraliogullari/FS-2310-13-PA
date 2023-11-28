//MAP

let numbers = [4, 914, 20, 19];
let newNumbers = numbers.map(nextNumber => {
    if (nextNumber >= 10) return nextNumber;
});

console.log(numbers);
console.log(newNumbers);

//FILTER

// let newNumbersFilters= numbers.filter(nextNumber=>{
// if(nextNumber>=10) return true;
// });

//KISA YAZIMI
let newNumbersFilters = numbers.filter(nextNumber => nextNumber >= 15);

console.log(newNumbersFilters);

