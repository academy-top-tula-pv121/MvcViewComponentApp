using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcViewComponentApp.Services;

namespace MvcViewComponentApp.ViewComponents
{
    //public class TimeNowViewComponent
    //{
    //    public string Invoke()
    //    {
    //        return $"Time now: {DateTime.Now.ToShortTimeString()}";
    //    }
    //}

    public class TimeNow : ViewComponent
    {
        ITimeService timeService;
        public TimeNow(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public ContentViewComponentResult Invoke()
        {
            //return Content($"Time now: {timeService.GetTime()}");
            return new ContentViewComponentResult($"Time now: {timeService.GetTime()}");
        }
    }

    //[ViewComponent]
    //public class TimeNow
    //{
    //    public string Invoke(int zone = 3, bool isShort = true)
    //    {
    //        DateTime time = DateTime.UtcNow.AddHours(zone);
    //        return $"Time now: {(isShort ? time.ToShortTimeString() : time.ToLongTimeString())}";
    //    }
    //}
}
