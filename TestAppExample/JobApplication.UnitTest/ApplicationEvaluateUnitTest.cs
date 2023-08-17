using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using TestAppExample;
using TestAppExample.Models;
using static TestAppExample.ApplicationEvaluator;
using Moq;
using TestAppExample.Services;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {
        [Test]
        public void Application_WithUnderAge_AutoRejected()
        {
            // Arrange ------------------------------------------------------------------

            // Test edilecek classın referansını almak
            var evaluator = new ApplicationEvaluator(null);

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
            // Arrange  ------------------------------------------------------------------
            var evaluator = new ApplicationEvaluator(null);

            // Tüm şartları fazlasıyla tutturan biri yaratıldı
            var form = new JobApplication() {
                Applicant = new Applicant { Age = 35 },
                YearsOfExperience = 18,
                TechStackList = new System.Collections.Generic.List<string> { "C#", "RabbirMQ", "Microservices", "Visual Studio" },
            };


            // Act ------------------------------------------------------------------
            var result = evaluator.Evalauate(form);


            // Assert ------------------------------------------------------------------

            // Sonuç olarak AutoAccept olması bekleniyor
            Assert.AreEqual(result, ApplicationResult.AutoAccept);
        }


        // Unit test için Moq kütüphanesindan yararlanma örneği 1
        [Test]
        public void Application_WithValid_AutoAccept()
        {
            // Arrange ------------------------------------------------------------------

            // Moq bir interface oluşturma
            var moqValidator = new Mock<IIdentityValidator>();

            /* Eğer isvalid içerisine boş string atılırsa
            /  sonuç olarak true döner.
            /   Buradaki sorun, IsValid("123") girilirse false döner
            */
            moqValidator.Setup(i=> i.IsValid("")).Returns(true);


            // Moq bir interface method içerisine "xx.Object" şeklinde gönderilir
            var evaluator = new ApplicationEvaluator(moqValidator.Object);

            // Tüm şartları fazlasıyla tutturan biri yaratıldı
            var form = new JobApplication() {
                Applicant = new Applicant { Age = 35, IdentityNumber = "123" },
                YearsOfExperience = 18,
                TechStackList = new System.Collections.Generic.List<string> { "C#", "RabbirMQ", "Microservices", "Visual Studio" },
            };



            // Act ------------------------------------------------------------------
            var result = evaluator.Evalauate(form);


            // Assert ------------------------------------------------------------------

            // Sonuç olarak TransferedToHR olması bekleniyor
            Assert.AreEqual(result, ApplicationResult.TransferredToHR);
        }


        // Unit test için Moq kütüphanesindan yararlanma örneği 2
        [Test]
        public void Application_WithNonValid_AutoAccept()
        {
            // Arrange ------------------------------------------------------------------

            // Moq bir interface oluşturma
            var moqValidator = new Mock<IIdentityValidator>();

            /* Yukarıda bahsettiğim sorunu çözmek için It classı kullanılır
            /  It classı ile IsValid() içine verilecek input türevleri tanımlanabilir
            */

            /* Aşağıdaki satır: IsValid() içerisine string olarak ne atılırsa atılsın
            /  bana sonuç olarak return dön demek
            */
            moqValidator.Setup(i=> i.IsValid(It.IsAny<string>())).Returns(true);        

            // Moq bir interface method içerisine "xx.Object" şeklinde gönderilir
            var evaluator = new ApplicationEvaluator(moqValidator.Object);

            // Tüm şartları fazlasıyla tutturan biri yaratıldı
            var form = new JobApplication() {
                Applicant = new Applicant { Age = 35, IdentityNumber = "123" },
                YearsOfExperience = 18,
                TechStackList = new System.Collections.Generic.List<string> { "C#", "RabbirMQ", "Microservices", "Visual Studio" },
            };



            // Act ------------------------------------------------------------------
            var result = evaluator.Evalauate(form);


            // Assert ------------------------------------------------------------------

            // Sonuç olarak AutoReject olması bekleniyor
            Assert.AreEqual(result, ApplicationResult.AutoReject);
        }
    }
}