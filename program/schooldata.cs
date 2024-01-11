using System.Collections.Generic;

public class schooldata
{
    private static schooldata instance;
    public List<student> Students { get; private set; }
    public List<teacher> Teachers { get; private set; }
    public List<subject> Subjects { get; private set; }

    private schooldata()
    {
        Students = new List<student>();
        Teachers = new List<teacher>();
        Subjects = new List<subject>();
    }

    public static schooldata Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new schooldata();
            }
            return instance;
        }
    }
}