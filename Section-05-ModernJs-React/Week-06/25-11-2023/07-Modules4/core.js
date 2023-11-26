

export const getResult = () => {
let number;
    const allNumbers = [];
    const oddNumbers=[];
    const evenNumbers=[];
    for (let i = 0; i < 10; i++) {
        number = Math.ceil(Math.random() * 100);
        allNumbers.push(number);
        if(number %2 ==0){
            evenNumbers.push(number);
        }else{
            oddNumbers.push(number);
        };
    };

let result={
    all: allNumbers,
    odds: oddNumbers,
    even:evenNumbers
}
  return result; 
}








//aşağıda 3 fonksiyonda ayrı ayrı yaptık. doğru olan aslında bu

// export const randomNumbers= ()=>{
    
// const result=[];
//     for(let i=0; i<10; i++){
//         result.push(Math.ceil(Math.random() * 100));
//     }
//    return result;
// }


// export const getOddNumbers=(numbers)=>{
//  const result=[];
// for (const i in numbers) {
//    if(numbers[i]%2!=0) result.push(numbers[i]);
// }

// return result;
// }

// export const getEvenNumbers= (numbers)=>{
//     const result=[];
//     //for in den farklı olarak indexe değil direkt elemana bak deriz. 1. indexe bak yerine git 10 a bak gibi
//     for (const nextNumber of numbers) {
//         if(nextNumber%2==0){
//             result.push(nextNumber);
//         }
//     }
//     return result;
   
// }

