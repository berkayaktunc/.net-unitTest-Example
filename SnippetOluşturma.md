# Windows

## Snippet eklemek

- İlk önce tools menüsünden **code snipper manager** seçilir

![](snippetOluşturma/01.jpg)


- Karşımıza çıkan pencerede **Import** seçeneği seçilir ve [**UnitTestSnippet.snippet**](snippetOluşturma/UnitTestSnippet.snippet) dosyası seçilir

![](snippetOluşturma/02.jpg)


- Bu pencerede **Finish** seçeneği seçilir ve işlem tamamlanmış olur

![](snippetOluşturma/03.jpg)


## Snippetin eklenip eklenmediğini kontrol etmek

- Snippetin eklenip eklenmediğini kontrol etmek için gerekirse tekrardan *code snipper manager* açılır ve **Language** ise **CSharp** olarak seçilir. Eklenen snippet örnekteki gibi görünüyorsa sorun yoktur.

![](snippetOluşturma/04.jpg)


## Snippetin çalıştırılması

- Şimdi kullanmak için herhangi bir *.cs* dosyası açıp **utest** yazıp iki kez *tab* tuşuna basın. Sonuç aşağıdaki gibi olacaktır.

![](snippetOluşturma/05.jpg)
![](snippetOluşturma/06.jpg)


Not: Eğer **utest** dışında bir snippet kısayolu atamak isterseniz, [**UnitTestSnippet.snippet**](snippetOluşturma/UnitTestSnippet.snippet) dosyası içerisindeki ilgili yeri (satır 17) değiştirmeniz gerekmektedir.

![](snippetOluşturma/07.jpg)


# Linux / VsCode

## Snippet Eklemek

- İlk olarak **Ctrl+Shift+P** kombinasyonu ile **Komut Paleti** açılır

![](snippetOluşturma/l01.jpg)


- Buraya **Configure User Snippet** yazılır ve **csharp** seçilir

![](snippetOluşturma/l02.jpg)
![](snippetOluşturma/l03.jpg)


- Açılan dosyaya aşağıdaki kod parçası resimdeki gibi eklenir ve kaydedilir

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

- Şimdi kullanmak için herhangi bir *.cs* dosyası açıp **utest** yazıp bir kez *tab* tuşuna basın. Sonuç aşağıdaki gibi olacaktır.

![](snippetOluşturma/l05.jpg)
![](snippetOluşturma/l06.jpg)