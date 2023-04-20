namespace mas2{
public class Group{
    private static List<Group> groups = new List<Group>();
    private List<Student> studentsGroup = new List<Student>();
    private static List<Student> studentsList = new List<Student>();
    public List<Teacher> teachersIDs = new List<Teacher>();
    public List<RoomAndGroup> roomAndGroups = new List<RoomAndGroup>();
    public int id{get; set;}
    public Group(int id){
        this.id = id;
        groups.Add(this);
    }
    public void AddRoomAndGroup(RoomAndGroup roomAndGroup){
        roomAndGroups.Add(roomAndGroup);
    }
    public void RemoveRoomAndGroup(RoomAndGroup roomAndGroup){
        roomAndGroups.Remove(roomAndGroup);
    }
    public void AddStudent(int id, string name, string surname){
        Student student = new Student(id,name,surname);
        if(!studentsGroup.Contains(student)){
            if(studentsList.Contains(student)){
                throw new Exception("Student already in the list");
            }
            studentsGroup.Add(student);
            studentsList.Add(student);
        }
    }
    public Student getStudent(int id){
        foreach(Student student in studentsGroup){
            if(student.id == id){
                return student;
            }
        }
        throw new Exception("Student not found");
    }
    public void RemoveStudentWithID(int id){
        foreach(Student student in studentsGroup){
            if(student.id  == id){
                studentsGroup.Remove(student);
                return;
            }
        }
        throw new Exception("Student not found");
    }
    public void AddTeacher(Teacher teacher){
        if(!teachersIDs.Contains(teacher)){
            teachersIDs.Add(teacher);
        }
    }
    public void RemoveTeacher(Teacher teacher){
        if(teachersIDs.Contains(teacher)){
            teachersIDs.Remove(teacher);
        }
    }
    public void PrintTeachers(){
        foreach(Teacher teacher in teachersIDs){
            Console.WriteLine(teacher);
        }
    }
    
    //tostring that shows all students in the group
    public override string ToString(){
        string result = id + " ";
        foreach(Student student in studentsGroup){
            result += student.ToString() + "\n";
        }
        return result;
    }
    //klasa wewnętrzna do kompozycji
    public class Student{
        //do asocjacji kwalifikowanej
        internal Dictionary<String,Teacher> projectAndTeacher = new Dictionary<string, Teacher>();
        internal int id{get; set;}
        internal string? name;
        internal string? surname;
        public override string ToString(){
            return $"{id} {name} {surname}";
        }
        public void AddProject(string projectName, Teacher teacher){
            if(!projectAndTeacher.ContainsKey(projectName)){
                projectAndTeacher.Add(projectName,teacher);
            }
        }
        public void RemoveProject(string projectName){
            if(projectAndTeacher.ContainsKey(projectName)){
                projectAndTeacher.Remove(projectName);
            }
        }
        public void PrintProjects(){
            foreach(KeyValuePair<string,Teacher> project in projectAndTeacher){
                Console.WriteLine($"{project.Key} : {project.Value}");
            }
        }
        internal Student(int id, string? name, string? surname){
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
}
