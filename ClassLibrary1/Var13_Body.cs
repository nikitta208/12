namespace ClassLibrary1
{
    public class typeOfOccupation
    {
        private string Class = "";

        public typeOfOccupation(string Class)
        {
            Occupation = Class;
        }

        public string Occupation
        {
            get { return Class; }
            set => Class = value;
        }
    }
}
