using NUnit.Framework;
using TestAppExample;
using TestAppExample.Models;
using static TestAppExample.ApplicationEvaluator;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {
        [Test]
        public void Application_WithUnderAge_AutoRejected()
        {
            // Arrange ------------------------------------------------------------------

            // Test edilecek classın referansını almak
            var evaluator = new ApplicationEvaluator();

            // Evaluator methodu form olarak bir adet JobApplication istiyor
            var form = new JobApplication()
            {
                // Age=15 olacak şekilde bir Applicant oluşturuluyor
                Applicant = new Applicant()
                {
                    Age = 15
                },
            };



            // Act ------------------------------------------------------------------

            // ApplicationEvaluator class içerisindeki "Evaluator" methodu kullanımı
            // Evaluate methodu form istediği için Arrange kısmında form hazırlandı
            var result = evaluator.Evalauate(form);



            // Assert ------------------------------------------------------------------

            // Test olarak hazırlanan "result", beklentimiz olan "AutoReject"
            //      olup olmadığı kontrol edilir
            Assert.AreEqual(ApplicationResult.AutoReject, result);
        }

        [Test]
        public void Application_ExperienceWith18_AutoAccepted()
        {
            // Arrange
            var evaluator = new ApplicationEvaluator();

            // Tüm şartları fazlasıyla tutturan biri yaratıldı
            var form = new JobApplication() {
                Applicant = new Applicant { Age = 35 },
                YearsOfExperience = 18,
                TechStackList = new System.Collections.Generic.List<string> { "C#", "RabbirMQ", "Microservices", "Visual Studio" },
            };


            // Act
            var result = evaluator.Evalauate(form);

            // Assert

            // Sonuç olarak AutoAccept olması bekleniyor
            Assert.AreEqual(result, ApplicationResult.AutoAccept);

        }
    }
}