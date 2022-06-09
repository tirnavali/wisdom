using RazorPagesReferenceReport.Models;
namespace RazorPagesReferenceReport.Services;
public static class ReferenceReportService{
    static List<ReferenceReport> ReferenceReports {get;}
    static int nextId = 4;
    static ReferenceReportService() {
        ReferenceReports = new List<ReferenceReport>
        {
            new ReferenceReport { Id = 1, Reporter= "Sercan Tırnavalı", ReportStatus=Status.Draft, BookUsage= 183, IsControlled= true},
            new ReferenceReport { Id = 2, Reporter= "Ziya Kutluoğlu", ReportStatus=Status.Completed, BookUsage= 483, IsControlled = false},
            new ReferenceReport { Id = 3, Reporter= "Nafiz Ertürk", ReportStatus=Status.Completed, BookUsage= 387, IsControlled = true}
        };
    }

    public static List<ReferenceReport> GetAll() => ReferenceReports;
    public static ReferenceReport? Get(int id) => ReferenceReports.FirstOrDefault(p => p.Id == id);
    public static void Add(ReferenceReport referenceReport)
    {
        referenceReport.Id = nextId++;
        ReferenceReports.Add(referenceReport);
    }
    public static void Delete(int id)
    {
        var referenceReport = Get(id);
        if (referenceReport is null)
            return;
        ReferenceReports.Remove(referenceReport);
    }
    public static void Update(ReferenceReport referenceReport)
    {
        var index = ReferenceReports.FindIndex(r => r.Id == referenceReport.Id);
        if (index == -1)
        return;
        ReferenceReports[index] = referenceReport;
    }

}