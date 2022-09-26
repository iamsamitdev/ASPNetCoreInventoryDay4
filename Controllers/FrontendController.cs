using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Controllers
{
    public class FrontendController : Controller
    {

        // ทดสอบเขียนฟังก์ชันการเชื่อมต่อ database
        public void TestConnectDB()
        {
            // สร้าง object context
            InventoryDBContext dBContext = new InventoryDBContext();
            if (dBContext.Database.CanConnect())
            {
                // ถ้า Connect success
                Console.WriteLine("Connect  db Success");
            }
            else
            {
                Console.WriteLine("Connect db fail!!");
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Webdev()
        {
            return View();
        }

        public ActionResult Mobiledev()
        {
            return View();
        }

        public ActionResult Graphic()
        {
            return View();
        }

        // เรียกแสดงแบบฟอร์มลงทะเบียน
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(tb_Member member)
        {
            string message;

            // ตรวจสอบการ Validate ฟอร์ม
            if (ModelState.IsValid)
            {
                // บันทึกข้อมูลลงตาราง
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    db.tb_Members.Add(member);
                    db.SaveChanges();
                    ModelState.Clear();
                    message = "<div class=\"alert alert-success text-center\">ลงทะเบียนเรียบร้อยแล้ว</div>";
                    // Redirect ไปหน้า Login
                    return RedirectToAction("Login", "Frontend");
                }

            }
            else
            {
                // แสดงข้อความแจ้งเตือน
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }

            ViewBag.Message = message;
            return View();
        }

        [HttpGet]
        public ActionResult Registeruser()
        {
            return View();
        }


        [HttpGet]
        public ActionResult SignupMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignupMember(tb_Member member)
        {
            string message;

            // ตรวจสอบการ Validate ฟอร์ม
            if (ModelState.IsValid)
            {
                // บันทึกข้อมูลลงตาราง
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    db.tb_Members.Add(member);
                    db.SaveChanges();
                    ModelState.Clear();
                    message = "<div class=\"alert alert-success text-center\">ลงทะเบียนเรียบร้อยแล้ว</div>";
                    // Redirect ไปหน้า Login
                    return RedirectToAction("Login", "Frontend");
                }

            }
            else
            {
                // แสดงข้อความแจ้งเตือน
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }

            ViewBag.Message = message;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registeruser(User user)
        {
            // ตรวจสอบว่า Validate ผ่านหรือยัง
            if (ModelState.IsValid)
            {
                // บันทึกลงฐานข้อมูล
                //using(ASPInventorySonyContext db = new ASPInventorySonyContext())
                //{
                //    db.Users.Add(user);
                //    db.SaveChanges();
                //    // Clear form
                //    ModelState.Clear();
                //}
            }
            else
            {
                // แสดง message แจ้งเตือน
            }
            return View();
        }

        // เรียกแสดงแบบฟอร์มลงเข้าสู่ระบบ
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(tb_Member member)
        {
            string message;
            if (member.Member_Email != null && member.Member_Password != null)
            {
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    var query = db.tb_Members.Where(tbm => tbm.Member_Email == member.Member_Email).FirstOrDefault();
                    if(query != null)
                    {
                        if(string.Compare(member.Member_Password, query.Member_Password) == 0)
                        {
                            // Login Success
                            message = "<div class=\"alert alert-success text-center\">เข้าสู่ระบบสำเร็จ</div>";

                            // เก็บข้อมูลการ Login ลง Session
                            HttpContext.Session.SetString("Email", query.Member_Email);
                            HttpContext.Session.SetString("FirstName", query.Member_Firstname);
                            HttpContext.Session.SetString("LastName", query.Member_Lastname);

                            // ทำการ Redirect ไปหน้า Dashboard
                            return RedirectToAction("Dashboard", "Backend");

                        }
                        else
                        {
                            message = "<div class=\"alert alert-danger text-center\">ป้อนรหัสผ่านไม่ถูกต้อง</div>";
                        }
                    }
                    else
                    {
                        message = "<div class=\"alert alert-danger text-center\">ไม่พบอีเมล์นี้</div>";
                    }
                }
            }
            else
            {
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }
            ViewBag.Message = message;
            return View();
        }

    }
}
