namespace UniSystem.Data
{
    public class Grade : BaseEntity
    {
        public string Subject { get; set; }
        public double Value { get; set; }
        public int StudentId { get; set; }
    }
}
