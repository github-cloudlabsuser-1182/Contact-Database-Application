using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();

        // GET: User
        public ActionResult Index(string phoneNumber = null)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return View(userlist);
            }
            else
            {
                var filteredUsers = userlist.Where(u => u.PhoneNumber == phoneNumber).ToList();
                return View(filteredUsers);
            }
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            User user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            userlist.Add(user);
            return RedirectToAction("Index");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            User user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            User existingUser = userlist.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return HttpNotFound();
            }
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.PhoneNumber = user.PhoneNumber;
            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            User user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            User user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            userlist.Remove(user);
            return RedirectToAction("Index");
        }
    }
}
