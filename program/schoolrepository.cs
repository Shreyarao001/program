public class schoolrepository
{
    private schooldata dataStorage;

    public schoolrepository()
    {
        dataStorage = schooldata.Instance;
    }

    public void AddStudent(student student)
    {
        dataStorage.Students.Add(student);
    }

    public void AddTeacher(teacher teacher)
    {
        dataStorage.Teachers.Add(teacher);
    }

    public void AddSubject(subject subject)
    {
        dataStorage.Subjects.Add(subject);
    }
}