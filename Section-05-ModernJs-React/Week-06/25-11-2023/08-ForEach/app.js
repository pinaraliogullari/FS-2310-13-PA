let numbers = [54, 32, 5, 79, 90];
let oddNumbers = [];
let evenNumbers = [];


//hem değerin  kendisini hem indexini görebiliriz. sadece değeri görüntüleyebiliriz ancak i yi tek görüntüleyemeyiz..
numbers.forEach((nextNumber,i) => {
    if (nextNumber % 2 == 0) {
        evenNumbers.push(nextNumber);
    } else {
        oddNumbers.push(nextNumber);
    }

});

console.log(numbers);
console.log(evenNumbers);
console.log(oddNumbers);



