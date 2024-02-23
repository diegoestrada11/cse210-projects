public class MathAssigments : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssigments(string textbookSection, string problems, string _studentName, string _studentTopic) : base (_studentName,_studentTopic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";

    }


}