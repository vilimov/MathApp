namespace MathApp.Maui.Shared
{
    static class ValidateInput
    {
        public static int IsPositiveInteger(string input)
        {
            int result = 0;
            return result;
        }

        public static bool IsPositiveInt(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
