using SWIFTtask_7_;


//უბრალოდ შემოწმებისთვის შემოტანილი მონაცემები
{
    var teacher1 = new teacher { name = "mikle", surname = "Doe", gender = "Male", subject = "Mathematics" };
    var teacher3 = new teacher { name = "John", surname = "DAMN", gender = "Male", subject = "biology" };
    var teacher2 = new teacher { name = "lisa", surname = "wow", gender = "Female", subject = "math" };

    var student1 = new Student { first_name = "giorgi", last_name = "Smith", gender = "male", _class = 10 };
    var student2 = new Student { first_name = "micle", last_name = "jorge", gender = "Male", _class = 5 };

    addItemsInDB(student1, teacher2);
    addItemsInDB(student1, teacher1);
    addItemsInDB(student1, teacher3);

    var a=GetAllTeachersByStudent("giorgi");
    foreach(var teacher in a){
        Console.WriteLine(teacher.name);
    }
}

//გადაცემულ სტუდენტის ობიექტს და მასწავლებლის ობიექტს წერს ბაზაში
//იმ შემთხვევაში თუ რომელიმე არის უკვე ბაზაში ახალ ობიეწტს ჩასვავს და 
//კავშირს გააკეთებს...
void addItemsInDB(Student stdname, teacher tch)
{
    using (var db = new TeacherStudent())
    {
        var existTeach = ckeckIfExistsTeach(tch);
        if (existTeach == 0)
        {
            db.teachers.Add(tch);
            db.SaveChanges();
        }

        var existStud = ckeckIfExistsStud(stdname);
        if (existStud == 0)
        {
            db.Student.Add(stdname);
            db.SaveChanges();
        }

        // საზიარო ცხრილში მონაცემების დამატება...
        var addingstud = ckeckIfExistsStud(stdname);
        var instanceStud = db.Student.Find(addingstud);

        var addingTeach = ckeckIfExistsTeach(tch);
        var instanceTeach = db.teachers.Find(addingTeach);

        instanceTeach.pupils.Add(instanceStud);
        db.SaveChanges();
    }
}


//ბაზაში ამოწმებს არის თუ არა გადაცემული მასწავლებელი
int ckeckIfExistsTeach(teacher teacherName)
{
    using (var db = new TeacherStudent())
    {
        var obj = db.teachers.Where(tch => tch.name == teacherName.name && tch.surname == teacherName.surname && tch.gender == teacherName.gender && tch.subject == teacherName.subject);
        if (obj.Count() > 0)
        {
            foreach (var teacher in obj)
            {
                return teacher.teacher_id; // ერთი იქნება მარტო და პირველს დაბეჭდის
            }
        }
        return 0;  //თუ ვერ ნახა ბაზაში 0 დააბრუნებს

    }
}

// ბაზაში ამოწმებს არის თუ არა გადაცემული სტუდენტი
int ckeckIfExistsStud(Student studname)
{
    using (var db = new TeacherStudent())
    {
        var obj = db.Student.Where(tch => tch.first_name == studname.first_name && tch.last_name == studname.last_name && tch.gender == studname.gender && tch._class == studname._class).ToArray();
        if (obj.Count() > 0)
        {
            foreach (var student in obj)
            {
                return student.pupil_id; // ერთი იქნება მარტო და პირველს დაბეჭდის
            }
        }
        return 0;  //თუ ვერ ნახა ბაზაში 0 დააბრუნებს

    }
}

//აბრუნებს გადაცემული სტუდენტის ყველა მასწავლებელს
teacher[] GetAllTeachersByStudent(string studentName)
{
    using (var db = new TeacherStudent())
    {

        var STD = db.teachers.Where(t => t.pupils.Any(m => m.first_name == studentName));
        return STD.ToArray();
    }

}


