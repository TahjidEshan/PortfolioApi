using Microsoft.AspNetCore.Mvc;
using PortFolio2017.ViewModelBuilder;
using PortFolio2017.Services;

namespace PortFolio2017.Controllers
{
    public class PortfolioController : Controller
    {
        protected IBaseService BaseService { get; set; }

        public PortfolioController(IBaseService BaseService)
        {
            this.BaseService = BaseService;
        }
        [Route("api/get-all-email")]
        [HttpGet]
        public JsonResult GetAllEmails()
        {
            return Json(BaseModelBuilder.GetEmails(BaseService));
        }
    }
}
