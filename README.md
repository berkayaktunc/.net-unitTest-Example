# .Net Core Unit Test Örneği

Bu repository örnek bir unit test nasıl yazılır onu belirtmek için oluşturulmuştur.

Uygulamanın içeriği:
* Uygulama bir şirkete başvuran kişileri seri şekilde değerlendirme üzerine inşa edilmiştir.
* [Aplicant.cs](TestAppExample\TestAppExample\Models\Applicant.cs) başvuran kişinin bilgilerini [JobApplicant.cs](TestAppExample\TestAppExample\Models\JobApplication.cs) ise şirkete başvurmak için kişinin doldurduğu form gibi düşünülebilir.
* [ApplicationEvaluator.cs](TestAppExample\TestAppExample\ApplicationEvaluator.cs) ise şirketin iş alım stratejisinin bulunduğu dosyadır.
* [TestOluşturma.md](TestOluşturma.md) ise herhangi bir proje için nasıl unit test oluşturulur adımları mevcuttur.
* Eğer test edilecek class bir için bir interface gerekiyor ise [Moq framework](InstallMoq.md) kullanılır.

Note: Unit test için __Visual Code__'nize kullanışlı bir snippet eklemek için [snippet oluşturma rehberi](SnippetOluşturma.md)ne göz atınız.

__Önemli Not:__ Proje ismi nokta ile başladığından dolayı clonlanması halinde bazen klasörde görünmeyebilir ancak terminal kodu (" `cd .net-unitTest-Example` ") ile proje dosyasına geçebilirsiniz. Projeyi klasör içerisinde görmek isterseniz __Gizli Dosyalar__ görüntülenmesini __açmanız__ gerekmektedir. 