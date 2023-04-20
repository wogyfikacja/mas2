
namespace mas2
{
    public class Teacher
    {
        private string name;
        private string surname;
        private string subject;
        private int id;
        private static List<Teacher> teachers = new List<Teacher>();
        public List<Group> groups = new List<Group>();

        public Teacher(string name, string surname, string subject, int id)
        {
            this.name = name;
            this.surname = surname;
            this.subject = subject;
            this.id = id;
            teachers.Add(this);
        }
        public override string ToString()
        {
            return $"Teacher: {name} {surname} Subject: {subject} ID: {id}";
        }
        public static void PrintTeachers()
        {
            foreach (var item in teachers)
            {
                Console.WriteLine($"Teacher: {item.name} {item.surname} Subject: {item.subject} ID: {item.id}");
            }
        }
        public void PrintGroups()
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"{item}");
            }
        }
        public void AddGroup(Group group)
        {
            if(groups.Contains(group)){
                throw new Exception("Group found");
            }
            groups.Add(group);
        }
        public void RemoveGroup(Group group)
        {
            if(!groups.Contains(group)){
                throw new Exception("Group not found");
            }
            groups.Remove(group);
        }
    }
}