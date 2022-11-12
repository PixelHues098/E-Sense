using MyApplication;

namespace MyApplication.Models
{
    public class Issues
    {
        public string Name { get; init; } = Dummy.RndIpsumSentenceGen(12);
        public string Definition { get; init; } = Dummy.RndIpsumSentenceGen(40);
        public string Selector { get; set; } = Dummy.RndNum(1, 7).ToString();
        public string Id { get; set; } = "ESS-" + Dummy.RndNum(1, 999).ToString();
        public string Icon { get; set; } = Dummy.RndIssueIconGen();
        public MudBlazor.Color IconColor { get; set; }
        public int Priority { get; set; } = Dummy.RndNum(0, 4);
        public char Asignee { get; set; } = Dummy.RndEnChar();

        public string IssueIconColor { get; set; } = Dummy.RandomMudColorGenStr(true, 3);

        public string EpicTitle { get; set; } = Dummy.EpicTitleGenerator();
        public string RndColor { get; set; } = Dummy.RandomMudColorGenStr(false, 3) + " white-text";
        public string RndColor2 { get; set; } = Dummy.RandomMudColorGenStr(false, 3);
    }
}
