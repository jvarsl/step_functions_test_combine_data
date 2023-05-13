namespace Models
{
    public enum Sex
    {
        Male, Female
    }

    public class Person
    {
        public string Name { get; set; }

        public Sex? Sex { get; set; }

        public int Age { get; set; }
    }
}