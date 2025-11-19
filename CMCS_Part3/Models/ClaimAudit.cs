namespace CMCS_Part3.Models
{
    public class ClaimAudit
    {
    

    public int Id { get; set; }
    public int ClaimId { get; set; }
    public string ActionBy { get; set; } = string.Empty;
    public string ActionType { get; set; } = string.Empty;
    public DateTime ActionDate { get; set; } = DateTime.Now;
}
}

