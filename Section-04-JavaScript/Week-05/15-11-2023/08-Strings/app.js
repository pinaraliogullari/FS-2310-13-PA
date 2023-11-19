let courseName = "Fullstack Web Developer Eğitimi";
let result;

result = courseName.toLowerCase();
result = courseName.toLocaleLowerCase();
result = courseName.toUpperCase();
result = courseName.toLocaleUpperCase();

result = courseName.length; // property
result = courseName[0];
result = courseName[14];

result = courseName.slice(14, 23);//başlangıç ve bitiş indeksi

result = courseName.replace("Eğitimi", "Kursu");

result = courseName.trim();//sadece baştaki ve sonraki boşlukları siler
result = courseName.trimStart();
result = courseName.trimEnd();

result = courseName.indexOf("F", 0); //küçük f yazsak bulamaz.0. indexten başla. 3 yazsak aramaya  3. indexten başlar. bulamazsak -1 döner.

result=courseName.split(" ");
result=courseName.startsWith("s");
result=courseName.endsWith("i");

console.log(result);




//indexOf ile ilgili minnak bir örnek;

// let message;
// let findedText;

// message = prompt("Lütfen metni giriniz:");
// findedText = prompt("Lütfen arayacağınız metni ya da karakteri giriniz");

// result = message.indexOf(findedText);
// if (result == -1) {
//    alert(`${message} icinde ${findedText} bulunamamıştır`);

// } else {
//     alert(`"${message}" icinde "${findedText}" ${result+1} .sırada bulunmaktadır.`);
// }

