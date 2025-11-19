namespace CMCS_Part3.Models
{
    public class Claim
    {
    
    public int Id { get; set; }
    public string LecturerId { get; set; } = string.Empty;
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }
    public double Total => HoursWorked * HourlyRate;
    public string Status { get; set; } = "Pending";
    public DateTime DateSubmitted { get; set; } = DateTime.Now;
}
}
