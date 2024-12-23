namespace Industry.Domain.Entities
{
    public class Machine : BaseEntity
    {
        public int Year { get; private set; }
        public string Manufacter { get; private set; }
        public string Model { get; private set; }
        public decimal Value { get; private set; }

        public Machine(int year, string manufacter, string model, decimal value)
        {
            Year = year;
            Manufacter = manufacter;
            Model = model;
            Value = value;
        }
    }
}