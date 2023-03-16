using Microsoft.AspNetCore.Mvc;

namespace MvcViewComponentApp.ViewComponents
{
    public class UserList : ViewComponent
    {
        List<string> users = new(){"Bob", "Joe", "Sam", "Tim", "Jim", "Leo", "Tom"};

        public IViewComponentResult Invoke()
        {
            //return View("UserListView", users);

            int numbers = users.Count();
            
            if(Request.Query.ContainsKey("number"))
            {
                Int32.TryParse(Request.Query["number"], out numbers);
            }

            ViewBag.Users = users.Take(numbers);
            ViewData["Header"] = $"Users count: {numbers}";

            return View("UserListView");
        }
    }
}
