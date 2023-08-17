# Windows

- Dependencies üzerine sağ tıklayıp __Manage Nuget Packeges__ seçeneğini seçin

![](installMoq/01.jpg)

- Açılan menüde __Browse__ kısmında __Moq__ araması yapıp en üstteki paketi indirin

![](installMoq/02.jpg)

- İndirme esnasında herhangi bir uyarı çıkması durumunda __kabul edin__.

![](installMoq/03.jpg)


# Linux/Cli

Moq kütüphanesini Linux içerisine indirebilmek için

- Projenin __.csproj__ dosyasının bulunduğu yerde terminal aç. Bu örnek için açılması gereken klasör:

```
TestAppExample/TestAppExample/TestAppExample.csproj
```

- Burada terminal aç ve aşağıdaki komutu yaz

```console
dotnet add package Moq
```