using System.Diagnostics.Contracts;

public class Assignment{
    private string _studentName = "";
    private string _studentTopic = "";

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _studentTopic = topic;
    }

    public string GetName(){
        return _studentName;
    }

    public string GetTopic(){
        return _studentTopic;
    }
    
    public string GetSummary(){
        return _studentName + " - " + _studentTopic;
    }
}