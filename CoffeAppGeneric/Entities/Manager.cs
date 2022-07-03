namespace CoffeeAppGeneric.Entities
{
    public class Manager : Employee
    {
        public override string ToString()
        {
            return base.ToString() + " (Manager)";
        }
    }
}