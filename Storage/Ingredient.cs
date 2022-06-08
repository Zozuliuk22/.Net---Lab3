namespace Storage
{
    public class Ingredient
    {
        public string Name { get; set; }

        public Categories Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
