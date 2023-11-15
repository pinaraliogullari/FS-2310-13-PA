let result;

result = parseInt(10.8);
result = parseInt("10.4asdf");
result = parseFloat("101.56aa");

let num = 10.37853;
result = parseFloat(num.toFixed(4)); //ondalıklı kısımda kaç basamak görelim.
result = num.toFixed(4); // ve yuvarlar
result = num.toPrecision(4); //toplam bas. sayısı 4. olacak şekilde ayarlanır ve yuvarlar.

result = Math.round(2.4);// en yakın inte yuvarlar.
result = Math.round(2.5);
result = Math.ceil(2.1);//yukarı yuvarlar.
result = Math.floor(2.9);//aşağı yuvarlar.
result = Math.round(2.499);

result = Math.pow(5, 2); //5 in 2. kuvvetini alır.
result = Math.sqrt(25);//25 in karekökünü alır.
result = Math.abs(-10);//mutlak değer
result = Math.min(12, 48, 89, 5);//en küçük değeri verir.
result = Math.max(12, 48, 89, 5);//en büyük değeri verir.
result = Math.random();
result = parseInt(Math.random() * 10);// 10 tane random sayı üretiyor.






console.log(result, typeof result);