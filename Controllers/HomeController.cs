using Microsoft.AspNetCore.Mvc;
using money_minder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace money_minder.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //===================================//
        // Setup Database
        //==================================//
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        //===================================//
        // ROOT 
        //===================================//


        [HttpGet("")]     
        public IActionResult Index()
        {

            @ViewBag.BillsList = _context.Bills.ToList();
            @ViewBag.ChecksList = _context.Paychecks.ToList();
            @ViewBag.BillsTotal = Decimal.Round(_context.Bills.Sum(x => x.Total),2);
            @ViewBag.PaymentsTotal = Decimal.Round(_context.Paychecks.Sum(x => x.Total),2);
            

            return View("Index");
        }

        //===================================//
        // CREATE BILL
        //===================================//
        [HttpGet("create_bill")]     
        public IActionResult CreateBill()
        {
            return View();
        }
        //===================================//
        // PROCESS CREATE BILL 
        //===================================//
        [HttpPost("process_create_bill")]
        public IActionResult ProcessCreateBill(Bill newBill)
        {
            _context.Add(newBill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //===================================//
        // CREATE PAYCHECK
        //===================================//
        [HttpGet("create_paycheck")]     
        public IActionResult CreatePaycheck()
        {
            return View("CreatePaycheck");
        }

        //===================================//
        // PROCESS ADD BILL 
        //===================================//
        [HttpPost("process_create_paycheck")]
        public IActionResult ProcessCreatePaycheck(Paycheck newPaycheck)
        {
            _context.Add(newPaycheck);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}