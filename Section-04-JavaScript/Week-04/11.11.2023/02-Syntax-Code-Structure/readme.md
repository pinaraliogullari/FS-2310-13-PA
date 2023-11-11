# Javascript Syntax(Söz Dizimi)
* Javascript'te komut oluşturubilmek için yazdığıöız kod cümlelerine ifade(statement) denir.
* İfadeler birbirinden ; işareti ile ayrılır.
* Ancak Js'te ifadelerin sonuna ; işareti koymak zorunlu değildir.
* Her ne kadar zorunlu değilse de ifadelerin sonuna mutlaka ; ifadesi koymaya dikkat edin.
* [ECMAScript Automatic SemiColumn Insertion detaylı bilgi](https://tc39.es/ecma262/multipage/ecmascript-language-lexical-grammar.html#sec-automatic-semicolon-insertion)
* Tanımlayıcıların isimlendirilmesi ile ilgili hususlar:
    * Tanımlayıcı adları (değişken, fonksiyon vb.) adları _, $ ve harf ile başlayabilir. Yani  _ ve $ hariç özel karakter ya da rakamla başlayamaz.
    Tanımlayıcı adları küçük/BÜYÜK harf duyarlıdır.
    * İSİMLENDİRME YAPARKEN TÜRKÇE KARAKTER KULLANMAYIN.
    * Tanımlayıcı İsimlendirme Teknikleri:
        * Camel Case:
        En çok kullanılan isimlerndirme tekniklerinden biridir. Sözcüklerin ilk harfi büyük geri kalanlar küçük yazılır. İki kullanım şekli var.
            * Upper Camel Case:Pascal Case de denir.Bu yöntemde gerçekten de sözcüklerin ilk harfi büyük geri kalanlar küçüktür.Örn:FirstName, DogumTarihi,GirisSarti,IseBaslamaTarihi
            * Lower Camel Case: Genellikle Camel Case dendiğinde akla bu gelir. İlk sözcük tamamen küçük harflerle yazılır. Geri kalan sözcükler Upper Camel Case kuralı ile yazılır.  Örn: firstName, dogumTarihi, girisSarti,iseBaslamaTarihi
        * Snake Case:
        Sözcükelrin birbirinden _ işareti ile ayrılarak yazıldığı tekniktir. Üç kullanım şekli vardır.
            * Upper Snake Case: FIRST_NAME, DOGUM_TARIHI, GIRIS_SAATI, ISE_BASLAMA_TARIHI
            * Lower Snake Case: first_name, dogum_tarihi.................................
            * Screaming Snake Case: First_Name, Dogum_Tarihi.............................
* Java Script 'te İsimlendirme Teknikleri
    * Değişkenler:
        * Büyük küçük harf duyarlı
        * camelCase tekniği kullanılır.
        * Değişken, içerdiği değeri tanımlayacak şekilde bir isme sahip olmalıdır.
        * Mantıksal(boolean) değişkenlere isim verirken is, hs gibi ifadelerle başlamasına dikkat edilmelidir.
        * Mümkün olduğu kadar ingilizce kavramlarla isimlendirme yapılmalıdır.
    * Fonksiyonlar:
        * Büyük küçük harf duyarlı
        * camelCase tekniği kullanılır.
        * Fonksiyonlara isim verirken get, make, apply gibi emir kipi içeren ifadelerle başlanmalıdır.

