using MyApplication;

namespace MyApplication.Models
{
    public class Issue
    {
        // TODO: Narrow down properties to only 
        public string Title { get; init; } = Dummy.FillerContent(12);
        public string Definition { get; init; } = Dummy.FillerContent(40);
        public string SprintIteration { get; set; } = Dummy.RndNum(1, 7).ToString();
        public string Id { get; set; } = "ESS-" + Dummy.RndNum(1, 999).ToString();
        public string Icon { get; set; } = Dummy.RndIssueIcon();
        public MudBlazor.Color IconColor { get; set; }
        public int Priority { get; set; } = Dummy.RndNum(0, 4);
        public char Asignee { get; set; } = Dummy.RndCapitalChar();
        public string IssueIconColor { get; set; } = Dummy.RndPastelColor(true, 3);
        public string EpicTitle { get; set; } = Dummy.GenerateEpicTitle();
        public string EpicColor { get; set; } = Dummy.RndPastelColor(false, 3) + " white-text";
        public string AsigneeColor { get; set; } = Dummy.RndPastelColor(false, 3);
    }

    public class Epic : Issue
    {
        public string StartDate { get; init; }
        public string EndDate { get; init; }
        public string Color { get; init; }
    }
}
