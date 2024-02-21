namespace WPFTestApp.Models
{
    public class PersonNameModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public PersonNameModel(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
