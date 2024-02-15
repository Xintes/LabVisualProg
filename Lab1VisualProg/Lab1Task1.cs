namespace Lab1VisualProg
{
    public static class Lab1Task1
    {   
        public static bool IsPalyndrome(string str)
        {
            string rts = "";
            for (int i = str.Length-1; i>=0; i--)
            {
                rts += str[i];
            }

            return str == rts;
        }
    } 
}
