using System.Text.RegularExpressions;
using static Lab2VisualProg.Group;

namespace Lab2VisualProg
{
    public class Group
    {
        public string groupNumber;
        public List<Student> students;
        public Group(string groupNumber)
        {
            this.groupNumber = groupNumber;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            students.Sort((s1, s2) => string.Compare(s1.LastName, s2.LastName)); // Сортировка по алфавиту

        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public virtual Student this[int bookId]
        {
            get { return students.FirstOrDefault(s => s.BookId == bookId); }
            //возвращает первый элемент коллекции, удовлетворяющий заданному условию
        }

        public string GetInfo()
        {


            string info = $"Номер группы: {groupNumber}\nСтуденты:\n----------------\n";
            foreach (var student in students)
            {
                info += $"{student.LastName} {student.FirstName} {student.Surname}\nСтуденческий: {student.BookId}\n" +
                    $"Дата рождения: {student.Birthday}\nАдрес: {student.Address}\nНомер: {student.Number}\n\n";
            }
            info += "---------------------\n\n";

            return info;
        }



      

      

    }

   

}