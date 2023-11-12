//Döngü:Aynı kod parçasının tekrar tekrar çalıştırılmasını sağlayan yapıya döngü denir.

//WHILE:Yazılan koşul doğru olduüu sürece kodlar çalışacak
// let a = 1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

//1 ile 10 arasındaki çift sayıları konsola yazdırın.
// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }

//     i++;

// }

//1 ile 50 arasındaki 4 ün katı olan sayıların adetini bulup konsola yazdırın.
let i = 1;
let sayac = 0;
while (i <= 50) {
    if (i % 4 == 0) {
        sayac++;

    }
    i++;
}
console.log(sayac);

