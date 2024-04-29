using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class CreateCourseModel : PageModel
{
    [BindProperty]
    public required Course Course { get; set; }
    public IActionResult OnPost()
    {
        CollegeDbContext db = new();
        db.Courses.AddRange(Course);
        db.SaveChanges();
        
        return RedirectToPage("Courses");
    }
}