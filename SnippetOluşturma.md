# Windows
## Snippet eklemek
İlk önce tools menüsünden __code snipper manager__ seçilir

![](snippetOluşturma/01.jpg)

Karşımıza çıkan pencerede __Import__ seçeneği seçilir ve [__UnitTestSnippet.snippet__](snippetOluşturma/UnitTestSnippet.snippet) dosyası seçilir

![](snippetOluşturma/02.jpg)

Bu pencerede __Finish__ seçeneği seçilir ve işlem tamamlanmış olur

![](snippetOluşturma/03.jpg)

## Snippetin eklenip eklenmediğini kontrol etmek
Snippetin eklenip eklenmediğini kontrol etmek için gerekirse tekrardan _code snipper manager_ açılır ve __Language__ __CSharp__ olarak seçilir. Eklenen snippet örnekteki gibi görünüyorsa sorun yoktur.

![](snippetOluşturma/04.jpg)

## Snippetin çalıştırılması
Şimdi kullanmak için herhangi bir _.cs_ dosyası açıp __utest__ yazıp iki kez _tab_ tuşuna basın. Sonuç aşağıdaki gibi olacaktır.

![](snippetOluşturma/05.jpg)

![](snippetOluşturma/06.jpg)

Not: Eğer __utest__ dışında bir snippet kısayolu atamak isterseniz, [__UnitTestSnippet.snippet__](snippetOluşturma/UnitTestSnippet.snippet) dosyası içerisindeki ilgili yeri (satır 17) değiştirmeniz gerekmektedir.

![](snippetOluşturma/07.jpg)

# Linux / VsCode

## Snippet Eklemek

İlk olarak __Ctrl+Shift+P__ kombinasyonu ile __Komut Paleti__ açılır

![](snippetOluşturma/l01.jpg)

Buraya __Configure User Snippet__ yazılır ve __csharp__ seçilir
![](snippetOluşturma/l02.jpg)
![](snippetOluşturma/l03.jpg)

Açılan dosyaya aşağıdaki kod parçası resimdeki gibi eklenir ve kaydedilir

```json
"Print to cosole": {
    "prefix": "utest",
    "body": [
        "[Test]",
        "public void Temp(){",
        "	// Arrange",
        "",
        "	// Act",
        "",
        "	// Assert",
        "}",
    ],
    "description": "[UTEST] csharp UnitTest template."
}
```
![](snippetOluşturma/l04.jpg)

## Snippetin çalıştırılması
Şimdi kullanmak için herhangi bir _.cs_ dosyası açıp __utest__ yazıp bir kez _tab_ tuşuna basın. Sonuç aşağıdaki gibi olacaktır.

![](snippetOluşturma/l05.jpg)

![](snippetOluşturma/l06.jpg)