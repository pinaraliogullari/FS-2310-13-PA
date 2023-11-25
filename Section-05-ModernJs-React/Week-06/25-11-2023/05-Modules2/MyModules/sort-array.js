//0 -maxNumber arasında rastgele sayı üretir.

const randomNumber = (maxNumber) => Math.ceil(Math.random() * (maxNumber) );

export const arrayASC = array => {
    // return array.sort(compareNumericASC);
    return array.sort((a,b)=>a-b);
}

export const arrayDESC=array=>{
    // let result = arrayASC(array);
    // return result.reverse();
    return array.sort((a,b) => b-a);
}

const compareNumericASC = (a, b) => {
    if (a > b) return 1;
    if (a == b) return 0;
    return -1;
}



export const getArray = count => {
    const resultArray = [];
    for (let i = 0; i < count; i++) {
        resultArray.push(randomNumber(100));
    }

    return resultArray;
}


