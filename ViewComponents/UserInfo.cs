using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcViewComponentApp.Models;

namespace MvcViewComponentApp.ViewComponents
{
    public class UserInfo : ViewComponent
    {
        public HtmlContentViewComponentResult Invoke(User user)
        {
            string result = $"<div><h3>User:</h3>";
            result = $"{result}<p>Name: {user.Name}</p>";
            result = $"{result}<p>Age: {user.Age}</p></div>";
            return new HtmlContentViewComponentResult(new HtmlString(result));
        }
    }
}
