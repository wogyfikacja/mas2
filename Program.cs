namespace mas2;
class Program
{
    private static void Main(string[] args)
    {
        var teacher = new Teacher("Caleb", "Rogue", "Mathematics", 30);
        var group = new Group(3);
        var room = new Room(1,30,true);

        Console.WriteLine("to jest z atrybutem: ");
        var roomAndGroup = new RoomAndGroup(room,group,DateTime.Now);
        Console.WriteLine(roomAndGroup);

        Console.WriteLine("to jest kompozycja");
        group.AddStudent(1,"John", "Smith");
        var student = group.getStudent(1);
        Console.WriteLine(student);

        Console.WriteLine("to jest zwykła: ");
        Program.AddGroupAndTeacher(teacher, group);
        teacher.PrintGroups();
        Console.WriteLine("to jest kwalifikowana: ");
        student.AddProject("projectinho",teacher);
        student.PrintProjects();

        Console.WriteLine("-----------------------");
        Program.RemoveGroupAndTeacher(teacher, group);
        student.RemoveProject("projectinho");
        group.RemoveStudentWithID(1);
        teacher.PrintGroups();
        Console.WriteLine("-----------------------");
        group.PrintTeachers();
        Console.WriteLine("-----------------------");        
        student.PrintProjects();

    }
    //są zapisane tutaj dla czytelności programu, trochę unika zastanawiania się do kogo należą te funkcje
    public static void AddGroupAndTeacher(Teacher teacher, Group group)
    {
        teacher.AddGroup(group);
        group.AddTeacher(teacher);
    }   
    public static void RemoveGroupAndTeacher(Teacher teacher, Group group)
    {
        teacher.RemoveGroup(group);
        group.RemoveTeacher(teacher);
    }
    
}
