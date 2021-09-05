namespace Web.API.Extension.Methods
{
    public static class NameClientToUpperCase
    {
        public static string ClientNameUpperCase(this string nameClient)
        {
            return nameClient.ToUpper();
        }
    }
}
