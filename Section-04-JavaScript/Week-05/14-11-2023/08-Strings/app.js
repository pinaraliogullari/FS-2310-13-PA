let courseName = "        Fullstack Web Developer Eğitimi         ";
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

result = courseName.indexOf("F"); //küçük f yazsak bulamaz.

console.log(result);