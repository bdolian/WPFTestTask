namespace WPFTestApp.Models
{
    public class PersonName
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public PersonName(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
