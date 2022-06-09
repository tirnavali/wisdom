using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesReferenceReport.Models;
using RazorPagesReferenceReport.Services;

namespace RazorPagesReferenceReport.Pages
{
    public class ReferenceReportModel : PageModel
    {
        public List<ReferenceReport> referenceReports = new();
        public void OnGet()
        {
            referenceReports = ReferenceReportService.GetAll();
        }
        [BindProperty]
        public ReferenceReport NewReferenceReport {get; set;} = new();

        public string IsControlledText(ReferenceReport referenceReport)
        {
            if (referenceReport.IsControlled)
            return "Controll Completed";
            return "Not Controlled";
        }
        public IActionResult OnPost() {
            if(!ModelState.IsValid){
                return Page();
            }
            ReferenceReportService.Add(NewReferenceReport);
            return RedirectToAction("Get"); 
        }
        public IActionResult OnPostDelete(int id)
        {
            ReferenceReportService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
