using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures4.Controllers
{
    public class StackController : Controller
    {
        public Stack<string> myStack = new Stack<string>();
        // GET: Stack

        public ActionResult Index()
        {
            return View();
        }
        //comment
        public ActionResult AddOne()  
        {                              
            int i = myStack.Count + 1; // +1?  //figure out how many items are in the queue

            myStack.Push("New Entry " + i);

            return View("Index");
        }

        public ActionResult AddHugeList()
        {
            myStack.Clear();  //first clear the stack

            for (int i = 0; i < 2000; i++)
            {
                myStack.Push("New Entry " + (i + 1));
            }

            return View("Index");
        }

        public ActionResult Display()      // ViewBag.dStack = "Test";
        {
            foreach(string item in myStack)
            {
                ViewBag.dStack += "test ";
                //use something besides pop?  does that make a new line?
            }
                    
            //handle any errors and inform the user!

            return View("Index");
        }

        public ActionResult Clear()
        {
            myStack.Clear();

            return View("Index");
        }

    }
}