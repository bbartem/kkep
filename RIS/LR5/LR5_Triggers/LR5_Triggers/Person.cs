namespace LR5_Triggers
{
    public class Person
    {
        private string nameValue;
        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }
        private double ageValue;
        public double Age
        {
            get { return ageValue; }
            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }
    }
}
