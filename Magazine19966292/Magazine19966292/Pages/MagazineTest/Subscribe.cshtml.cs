using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Magazine19966292.Pages.MagazineTest
{
    public class SubscribeModel : PageModel
    {
        // GET: https://localhost:5001/MagazineTest/Subscribe?MagazineID=3&NumIssues=4
        public void OnGet(int MagazineID = 0, int NumIssues = 0)
        {
            // Some processing
            double TotalPrice = 0;
            int flag = 0;
            string[] MagazineName = new string[4] { "Scientific American", "New Scientist", "Reader’s Digest", "National Geographic" };
            double[] price = new double[4] {6.5, 6.0, 5.0, 7.0};

            if(MagazineID > 4 || MagazineID < 1)
            {
                flag = 1;
                ViewData["Flag"] = flag;
                return;
            }else if(NumIssues < 1)
            {
                flag = 2;
                ViewData["Flag"] = flag;
                return;
            }
            else
            {
                TotalPrice = price[MagazineID - 1] * NumIssues;
                // Passing data to the content file
                ViewData["TotalPrice"] = TotalPrice;
                ViewData["MagazineID"] = MagazineID;
                ViewData["NumIssues"] = NumIssues;
                ViewData["MagazineName"] = MagazineName[MagazineID - 1];
                ViewData["Flag"] = flag;
            }
            
        }
    }
}
