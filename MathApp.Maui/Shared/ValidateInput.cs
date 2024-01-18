namespace MathApp.Maui.Shared
{
    static class ValidateInput
    {
        static string input = String.Empty;

        public static int ValidatePositiveInteger(string? input) 
        {
            int result = 0;

            try
            {
                int.TryParse(input, out result);
            }
            catch (Exception)
            {
                
            }
            return result;
        }
    }
}
