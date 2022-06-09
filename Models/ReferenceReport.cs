using System.ComponentModel.DataAnnotations;

namespace RazorPagesReferenceReport.Models;
public class ReferenceReport {
    public int Id { get; set; }
    [Required]
    public string? Reporter { get; set; }
    public Status ReportStatus {get; set;}
    [Range(1,30000)]
    public int BookUsage { get; set; }
    public bool IsControlled {get; set;}

}

public enum Status { Completed, Draft }