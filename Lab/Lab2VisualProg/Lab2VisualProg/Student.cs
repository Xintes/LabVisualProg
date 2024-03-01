
using System.Net;

namespace Lab2VisualProg
{
   
    public class Student 
    {
        public int BookId { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Number { get; set;}

        public Student(int bookId, string lastName, string firstName, string surname, string birthday, string address, string number)
        {
            BookId = bookId;
            FirstName = firstName;
            LastName = lastName;
            Surname = surname;
            Birthday = birthday;
            Address = address;
            Number = number;
        }
        public override bool Equals(object? obj)
        {  Student human = obj as Student;
            return (BookId == human.BookId &&
                    FirstName == human.FirstName &&
                    LastName == human.LastName &&
                    Surname == human.Surname &&
                    Birthday == human.Birthday &&
                    Address == human.Address &&
                    Number == human.Number);}

    //    public override string ToString()
    //    {
    //        return BookId + "\n" + LastName + " " + FirstName + " " + Surname + "\n" + Birthday +"\n" + Address + "\n" + Number + "\n";           
    //    }
    }

    
}
