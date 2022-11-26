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

        /// <summary>
        /// Generate a random fillter sentences based on lorem impsum words
        /// </summary>
        /// <param name="wordCount">Number of words to generate</param>
        /// <returns>A string of randomly organized lorem impsum words with a capital first letter</returns>
        public static string GenerateLoremSentence(int wordCount)
        {
            Random rnd = new Random();

            string ipsumSentence = "";
            string[] words = new string[] { "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
         "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
         "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
         "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet",
         "lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
         "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
         "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
         "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet",
         "lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
         "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
         "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
         "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "duis",
         "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate", "velit", "esse", "molestie",
         "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at", "vero", "eros", "et",
         "accumsan", "et", "iusto", "odio", "dignissim", "qui", "blandit", "praesent", "luptatum", "zzril", "delenit",
         "augue", "duis", "dolore", "te", "feugait", "nulla", "facilisi", "lorem", "ipsum", "dolor", "sit", "amet",
         "consectetuer", "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod", "tincidunt", "ut", "laoreet",
         "dolore", "magna", "aliquam", "erat", "volutpat", "ut", "wisi", "enim", "ad", "minim", "veniam", "quis",
         "nostrud", "exerci", "tation", "ullamcorper", "suscipit", "lobortis", "nisl", "ut", "aliquip", "ex", "ea",
         "commodo", "consequat", "duis", "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate",
         "velit", "esse", "molestie", "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at",
         "vero", "eros", "et", "accumsan", "et", "iusto", "odio", "dignissim", "qui", "blandit", "praesent", "luptatum",
         "zzril", "delenit", "augue", "duis", "dolore", "te", "feugait", "nulla", "facilisi", "nam", "liber", "tempor",
         "cum", "soluta", "nobis", "eleifend", "option", "congue", "nihil", "imperdiet", "doming", "id", "quod", "mazim",
         "placerat", "facer", "possim", "assum", "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer", "adipiscing",
         "elit", "sed", "diam", "nonummy", "nibh", "euismod", "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam",
         "erat", "volutpat", "ut", "wisi", "enim", "ad", "minim", "veniam", "quis", "nostrud", "exerci", "tation",
         "ullamcorper", "suscipit", "lobortis", "nisl", "ut", "aliquip", "ex", "ea", "commodo", "consequat", "duis",
         "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate", "velit", "esse", "molestie",
         "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at", "vero", "eos", "et", "accusam",
         "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita", "kasd", "gubergren", "no", "sea",
         "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
         "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut",
         "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "at", "vero", "eos", "et",
         "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita", "kasd", "gubergren", "no",
         "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
         "amet", "consetetur", "sadipscing", "elitr", "at", "accusam", "aliquyam", "diam", "diam", "dolore", "dolores",
         "duo", "eirmod", "eos", "erat", "et", "nonumy", "sed", "tempor", "et", "et", "invidunt", "justo", "labore",
         "stet", "clita", "ea", "et", "gubergren", "kasd", "magna", "no", "rebum", "sanctus", "sea", "sed", "takimata",
         "ut", "vero", "voluptua", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
         "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut",
         "labore", "et", "dolore", "magna", "aliquyam", "erat", "consetetur", "sadipscing", "elitr", "sed", "diam",
         "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed",
         "diam", "voluptua", "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea",
         "rebum", "stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum" };

            for (int i = 0; i < wordCount; i++)
            {
                ipsumSentence = ipsumSentence + (i == 0 ? "" : " ") + words[rnd.Next(words.Length)];
            }

            return ipsumSentence[0].ToString().ToUpper() + ipsumSentence.Substring(1);
        }

        /// <summary>
        /// Generate a random title to represent a possible an issue with an epic type
        /// </summary>
        public static string GenerateEpicTitle()
        {
            Random rnd = new Random();
            switch (rnd.Next(9))
            {
                case 0:
                    return "Releases";
                case 1:
                    return "Login";
                case 2:
                    return "Backlog";
                case 3:
                    return "Signup";
                case 4:
                    return "Diagrams";
                case 5:
                    return "Others";
                case 6:
                    return "Settings";
                case 7:
                    return "History";
                case 8:
                    return "Permissions";
                case 9:
                    return "User";
                default:
                    return "Security";
            }
        }

        /// <summary>
        /// Picks a random color from a set of preselected colors
        /// </summary>
        /// <param name="isText">Set to true if you want to set the color to the text and not to background ,false otherwise.</param>
        /// <param name="intensity">How light a color should be from 1-5 (5 being the lightest). int outside 1-5 range won't change the intensity.</param>
        /// <returns>A string to change the color of a component. To be assigned to a class property</returns>
        public static string GeneratePastelColor(bool isText, int intensity)
        {
            Random rnd = new Random();
            string color = "";

            switch (rnd.Next(9))
            {
                case 1:
                    color = "red";
                    break;
                case 2:
                    color = "blue";
                    break;
                case 3:
                    color = "purple";
                    break;
                case 4:
                    color = "indigo";
                    break;
                case 5:
                    color = "cyan";
                    break;
                case 6:
                    color = "teal";
                    break;
                case 7:
                    color = "blue-grey";
                    break;
                default:
                    color = "green";
                    break;
            }

            return isText ? (color + "-text text-lighten-" + intensity.ToString()) : (color + " lighten-" + intensity.ToString());
        }

        /// <summary>
        /// Generates a random number from the range provided in the arguments
        /// </summary>
        /// <param name="min">Minimum possible value to be returned</param>
        /// <param name="max">Max possible value to be returned</param>
        /// <returns>Returns an int that contains a random number from the range provided from the arguments</returns>
        public static int RndNum(int min, int max)
        {
            Random rnd = new Random();

            return rnd.Next(min, max);
        }

        /// <summary>
        /// Generates a random icon to be used for types of issues
        /// </summary>
        /// <returns>Return the string for the issue type icons from mudblazor</returns>
        public static string RndIssueIconGen()
        {
            Random rnd = new Random();
            switch (rnd.Next(4))
            {
                case 0:
                    return MudBlazor.Icons.Outlined.BugReport;
                case 1:
                    return MudBlazor.Icons.Outlined.BubbleChart;
                case 2:
                    return MudBlazor.Icons.Outlined.Settings;
                default:
                    return MudBlazor.Icons.Outlined.Bookmarks;
            }
        }

        /// <summary>
        /// Returns a random color from the mud blazor default theme
        /// </summary>
        /// <returns>Returns an int from the mudblazor color enum to represent color</returns>
        public static MudBlazor.Color RandomMudColorGen()
        {
            Random rnd = new Random();
            switch (rnd.Next(9))
            {
                case 1:
                    return MudBlazor.Color.Primary;
                case 2:
                    return MudBlazor.Color.Secondary;
                case 3:
                    return MudBlazor.Color.Tertiary;
                case 4:
                    return MudBlazor.Color.Info;
                case 5:
                    return MudBlazor.Color.Success;
                case 6:
                    return MudBlazor.Color.Warning;
                case 7:
                    return MudBlazor.Color.Error;
                default:
                    return MudBlazor.Color.Dark;
            }
        }
    }
}