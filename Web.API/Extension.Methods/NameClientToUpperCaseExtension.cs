namespace Web.API.Extension.Methods
{
    public static class NameClientToUpperCaseExtension
    {
        public static string ClientNameUpperCase(this string nameClient)
        {
            return nameClient.ToUpper();
        }
    }
}
