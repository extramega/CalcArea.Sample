namespace WinFormsArea
{
    internal static class Global
    {
        public static string DecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == "." ? "." : ",";

    }
}
