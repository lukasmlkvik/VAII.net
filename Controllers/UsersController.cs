using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VAII.Data;
using VAII.Models;

namespace VAII.Controllers
{
    public class UsersController : Controller
    {
        private VAIIDB db;

        public UsersController(VAIIDB db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Acounts.ToListAsync());
        }


        //[HttpDelete]
        public IActionResult Delete(string id)
        {
            AcountModel a = db.Acounts.Where(x => x.Username == id).Single();
            db.Acounts.Remove(a);
            db.SaveChanges();
            return View();
        }

        
        public IActionResult Edit(string id,string m, string p)
        {
            AcountModel a = db.Acounts.Where(x => x.Username == id).Single();
            a.FirstName = m;
            a.LastName = p;
            //db.Acounts.Update(a);
            db.SaveChanges();
            return View();
        }
    }
}