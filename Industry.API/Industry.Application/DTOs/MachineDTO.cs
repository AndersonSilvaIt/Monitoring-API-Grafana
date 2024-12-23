namespace Industry.Application.DTOs
{
    public class MachineDTO
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public string Manufacter { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
    }
}