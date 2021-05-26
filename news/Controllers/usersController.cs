using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using news.Models;

namespace news.Controllers
{
    public class usersController : Controller
    {
        private identityModel db = new identityModel();

        // GET: users
        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        // GET: users/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: users/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: users/Register
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "username,Fname,Lname,Email,password,phoneNumber,photo,ImageFile")] user user, FormCollection frm)
        {

            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(user.ImageFile.FileName);
                string Extension = Path.GetExtension(user.ImageFile.FileName);
                fileName = fileName + Extension;
                user.photo = "~/Images_face_users/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Images_face_users/"), fileName);
                user.ImageFile.SaveAs(fileName);
                string userRoleRadio = frm["userRole"].ToString();
                user.userRole = userRoleRadio;
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "username,Fname,Lname,Email,password,phoneNumber,photo,ImageFile")] user user, FormCollection frm)
        {
            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(user.ImageFile.FileName);
                string Extension = Path.GetExtension(user.ImageFile.FileName);
                fileName = fileName + Extension;
                user.photo = "~/Images_face_users/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Images_face_users/"), fileName);
                user.ImageFile.SaveAs(fileName);

                string userRoleRadio = frm["userRole"].ToString();
                user.userRole = userRoleRadio;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            user user = db.users.Find(id);
            db.users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }

}
