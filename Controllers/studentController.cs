using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Crud_Operation.Models;

namespace Crud_Operation.Controllers
{
    public class studentController : Controller
    {
        Databse.db dblayer = new Databse.db();
        // GET: student
        public ActionResult Views()
        {
            string choice = "view";
            DataSet ds = dblayer.Data_Views(choice);
            ViewBag.student = ds.Tables[0];
            return View();
        }

        public ActionResult add_record()
        {
            return View();
        }
        [HttpPost]

        public ActionResult add_record(FormCollection fc)
        {
            student st = new student();
            st.Sname = fc["sname"];
            st.Email = fc["email"];
            st.Phone = fc["phone"];
            st.department = fc["department"];
            st.choice = fc["choice"];
            dblayer.add_record(st);
            TempData["msg"] = "Inserted";

            return View();
        }

      

        
        public ActionResult delete_record1(int id)
        {
           string choice = "delete";
            dblayer.delete_record(id,choice);
            TempData["msg"] = "Deleted";
            return RedirectToAction("Views");

        }


        public ActionResult Update_record1(int id)
        {
            String choice = "update";
            DataSet ds = dblayer.Show_recod_byid(id,choice);
            ViewBag.student = ds.Tables[0];
            return View();
        }




        [HttpPost]
        public ActionResult Update_record1(int id,FormCollection fc)
        {
            student student = new student();
            student.id =id;
            student.Sname = fc["sname"];
            student.Email = fc["email"];
            student.Phone = fc["phone"];
            student.department = fc["department"];
            student.choice = fc["choice"];
            dblayer.update_record(student);
            TempData["msg"] = "Updated";
            return RedirectToAction("Views");

        }








    }
}
