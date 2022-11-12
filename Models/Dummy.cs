namespace MyApplication
{
    public static class Dummy
    {
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

        public static char RndEnChar()
        {
            Random rnd = new Random();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet[rnd.Next(alphabet.Length - 1)];
        }

        public static int RndNum(int min, int max)
        {
            Random rnd = new Random();

            return rnd.Next(min, max);
        }

        public static List<MudBlazor.Color> RandomMudColorGenList(int size)
        {
            Random rnd = new Random();
            List<MudBlazor.Color> ColorGenList = new List<MudBlazor.Color>();

            for (int i = 0; i < size; i++)
            {
                switch (rnd.Next(9))
                {
                    case 1:
                        ColorGenList.Add(MudBlazor.Color.Primary);
                        break;
                    case 2:
                        ColorGenList.Add(MudBlazor.Color.Secondary);
                        break;
                    case 3:
                        ColorGenList.Add(MudBlazor.Color.Tertiary);
                        break;
                    case 4:
                        ColorGenList.Add(MudBlazor.Color.Info);
                        break;
                    case 5:
                        ColorGenList.Add(MudBlazor.Color.Success);
                        break;
                    case 6:
                        ColorGenList.Add(MudBlazor.Color.Warning);
                        break;
                    case 7:
                        ColorGenList.Add(MudBlazor.Color.Error);
                        break;
                    default:
                        ColorGenList.Add(MudBlazor.Color.Dark);
                        break;
                }
            }

            return ColorGenList;
        }

        public static string[] RandomMudColorGenStrList(int size)
        {
            Random rnd = new Random();
            string[] ColorGenList = new string[size];

            for (int i = 0; i < size; i++)
            {
                switch (rnd.Next(9))
                {
                    case 1:
                        ColorGenList[i] = "red lighten-3";
                        break;
                    case 2:
                        ColorGenList[i] = "blue lighten-3";
                        break;
                    case 3:
                        ColorGenList[i] = "purple lighten-3";
                        break;
                    case 4:
                        ColorGenList[i] = "indigo lighten-3";
                        break;
                    case 5:
                        ColorGenList[i] = "cyan lighten-3";
                        break;
                    case 6:
                        ColorGenList[i] = "teal lighten-3";
                        break;
                    case 7:
                        ColorGenList[i] = "lime lighten-3";
                        break;
                    default:
                        ColorGenList[i] = "green lighten-3";
                        break;
                }
            }

            return ColorGenList;
        }

        public static string RandomMudColorGenStr(bool isText, int intensity)
        {
            Random rnd = new Random();

            switch (rnd.Next(9))
            {
                case 1:
                    return isText ? "red-text text-lighten-" + intensity.ToString() : "red lighten-" + intensity.ToString();
                case 2:
                    return isText ? "blue-text text-lighten-" + intensity.ToString() : "blue lighten-" + intensity.ToString();
                case 3:
                    return isText ? "purple-text text-lighten-" + intensity.ToString() : "purple lighten-" + intensity.ToString();
                case 4:
                    return isText ? "indigo-text text-lighten-" + intensity.ToString() : "indigo lighten-" + intensity.ToString();
                case 5:
                    return isText ? "cyan-text text-lighten-" + intensity.ToString() : "cyan lighten-" + intensity.ToString();
                case 6:
                    return isText ? "teal-text text-lighten-" + intensity.ToString() : "teal lighten-" + intensity.ToString();
                case 7:
                    return isText ? "blue-grey-text text-lighten-" + intensity.ToString() : "blue-grey lighten-" + intensity.ToString();
                default:
                    return isText ? "green-text text-lighten-" + intensity.ToString() : "green lighten-" + intensity.ToString();
            }
        }

        public static string[] EpicTitleListGenerator(int size)
        {
            Random rnd = new Random();
            string[] ColorGenList = new string[size];

            for (int i = 0; i < size; i++)
            {
                switch (rnd.Next(11))
                {
                    case 0:
                        ColorGenList[i] = "Releases";
                        break;
                    case 1:
                        ColorGenList[i] = "Login";
                        break;
                    case 2:
                        ColorGenList[i] = "Backlog";
                        break;
                    case 3:
                        ColorGenList[i] = "Signup";
                        break;
                    case 4:
                        ColorGenList[i] = "Diagrams";
                        break;
                    case 5:
                        ColorGenList[i] = "Others";
                        break;
                    case 6:
                        ColorGenList[i] = "Settings";
                        break;
                    case 7:
                        ColorGenList[i] = "History";
                        break;
                    case 8:
                        ColorGenList[i] = "Permissions";
                        break;
                    case 9:
                        ColorGenList[i] = "User";
                        break;
                    default:
                        ColorGenList[i] = "Security";
                        break;
                }
            }

            return ColorGenList;
        }

        public static string EpicTitleGenerator()
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

        public static string RndIpsumSentenceGen(int wordCount)
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
    }
}
