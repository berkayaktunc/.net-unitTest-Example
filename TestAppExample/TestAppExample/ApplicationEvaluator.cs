using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestAppExample.Models;
using TestAppExample.Services;

namespace TestAppExample
{
    public class ApplicationEvaluator
    {
        private const int minAge = 18;
        private List<string> techList = new() { "C#", "RabbirMQ", "Microservices", "Visual Studio" };

        private readonly IIdentityValidator _identityValidator;

        // class dışarıdan interface alarak çalışıyor varsayıyoruz.
        //  Services klasörü içerisinde onu temsilen
        //  IIdentityValidator interfacesi oluşturduk ve IdentityValidator
        //  içerisinde imlementasyonunu yaptık
        public ApplicationEvaluator(IIdentityValidator identityValidator)
        {
            // projeye bu sayede ekledik
            this._identityValidator = identityValidator; 
        }

        public ApplicationResult Evalauate(JobApplication form)
        {

            // 18 yaşından küçükler direk reject edilecek
            if(form.Applicant.Age < minAge) {
                return ApplicationResult.AutoReject;
            }

            var similarityRate = GetTechSimilarityRate(form.TechStackList);
            var valid = _identityValidator.IsValid(form.Applicant.IdentityNumber);

            if (!valid)
                return ApplicationResult.TransferredToHR;
            // benzerlik 25%den az ise direk reject et
            if (similarityRate < 25)
                return ApplicationResult.AutoReject;
            
            // benzerlik 75%den fazla ise direk kabul et
            if (similarityRate < 75)
                return ApplicationResult.AutoAccept;

            if (form.YearsOfExperience > 10)
                return ApplicationResult.AutoAccept;

            return ApplicationResult.TransferredToCTO;
        }

        private int GetTechSimilarityRate(List<string> inList)
        {
            // girilan liste is elimizdeki listede eş bulunan değerleri bulur
            // upper/lower case probleminden kurtulmak için "StringComperer.OrdinalIgnoreCare" kullanıldı
            var temp = inList.Where(i => techList.Contains(i, StringComparer.OrdinalIgnoreCase)).Count();

            // sonuç olarak bir yüzde dönüldü
            return (int) ((double)temp/ inList.Count)*100;
        }

        public enum ApplicationResult
        {
            AutoReject,
            TransferredToHR,
            TransferredToLead,
            TransferredToCTO,
            AutoAccept
        }
    }
}