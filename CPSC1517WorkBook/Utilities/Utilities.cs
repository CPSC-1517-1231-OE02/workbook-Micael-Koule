namespace Utils
{
    public class Utilities
    {
        public static bool IsZeroOrNegative(int value)
        {
            bool result;
            if (value<=0 ) 
            {
                result = true;

            }
            else
            {
                result = false;
            }
            return result;
        }


        public static bool IsNullEmptyOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsInTheFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}