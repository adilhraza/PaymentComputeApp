using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaymentComputeApp.WebUI.Controllers
{
    public abstract class BaseController : Controller
    {
        public void Alert(string message, NotificationType notificationType)
        {
            var msg = "<script>Swal.fire('" + notificationType.ToString().ToUpper() + "', '"
                + message + "','" + notificationType + "')" + "</script>";
            TempData["notification"] = msg;
        }
    }
}
