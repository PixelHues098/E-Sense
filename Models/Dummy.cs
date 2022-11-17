namespace MyApplication
{
    public static class Dummy
    {
        /// <summary>
        /// Returns a capital letter from the alphabet
        /// </summary>
        public static char RndEnChar()
        {
            Random rnd = new Random();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet[rnd.Next(alphabet.Length - 1)];
        }
    }
}