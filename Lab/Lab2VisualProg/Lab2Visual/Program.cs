using Lab2VisualProg;

Student Egor = new Student(145151, "Кутузов", "Егор",  "Сергеевич", "24.10.03","Рязань, ул. Пушкино, д.2", "+79999999999");
Student Serg = new Student(2241, "Марцынов", "Серж",  "Дагович", "24.12.23", "Коломна, ул. Колотушкино, д.153", "+79999869999");
Student Iz = new Student(41255, "Радинов", "Из",  "Кляра", "12.5.01", "Новиград, ул. Дейкстры, д.8", "+7996732999");
Student Georg = new Student(6262, "Ом", "Георг", "Симов", "21.01.11", "Калининград, ул. Тоник, д.241", "+79999994624");
////////ZAD1
Console.WriteLine("Информация о студенте:\n"+Egor.ToString());
Console.WriteLine(Egor.Equals(Egor));
Console.WriteLine(Egor.Equals(Iz)+ "\n\n");

///////ZAD2
Group group = new Group("140");
Console.WriteLine(group.GetInfo());
group.AddStudent(Egor);
group.AddStudent(Serg);
Console.WriteLine(group.GetInfo());
group.AddStudent(Iz);
Console.WriteLine(group.GetInfo());
group.AddStudent(Georg);
Console.WriteLine(group.GetInfo());
group.RemoveStudent(Egor);
Console.WriteLine(group.GetInfo());
Console.WriteLine(group[2241]);
