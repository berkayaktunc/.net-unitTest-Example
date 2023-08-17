namespace TestAppExample.Services
{
    public class IdentityValidator : IIdentityValidator
    {
        public bool IsValid(string identityNumber)
        {
            return true;
        }
    }
}