namespace UML2
{
    public class Pizza
    {
        // Variabler jeg selv danner
        string Name;
        int Price;
        int Number;

        // Constructor
        public Pizza(string Name, int Price, int Number)
        {
            this.Name = Name;
            this.Price = Price;
            this.Number = Number;
        }
        //properties
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
        public int GetPrice()
        {
            return Price;
        }
        public void SetNumber(int Number)
        {
            this.Number = Number;
        }
        public int GetNumber()
        {
            return Number;
        }
        // override tostring metode
        public override string ToString()
        {
            return $" Name : {Name}  Price : {Price}  ID Number : {Number}";
        }


    }
}
