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
        [Route("api/emails")]
        [HttpGet]
        public JsonResult GetAllEmails()
        {
            return Json(BaseModelBuilder.GetEmails(BaseService));
        }
        [Route("api/addresses")]
        [HttpGet]
        public JsonResult GetAllAddresses()
        {
            return Json(BaseModelBuilder.GetAddresses(BaseService));
        }
        [Route("api/headers")]
        [HttpGet]
        public JsonResult GetHeaders()
        {
            return Json(BaseModelBuilder.GetHeaders(BaseService));
        }
        [Route("api/sidebar-social-links")]
        [HttpGet]
        public JsonResult GetSocialLinksForSideBar()
        {
            return Json(BaseModelBuilder.GetSocialLinksForSidebar(BaseService));
        }
        [Route("api/mottos")]
        [HttpGet]
        public JsonResult GetMottos()
        {
            return Json(BaseModelBuilder.GetMottos(BaseService));
        }
        [Route("api/general-skills")]
        [HttpGet]
        public JsonResult GetGeneralSkills()
        {
            return Json(BaseModelBuilder.GetGeneralSkills(BaseService));
        }
        [Route("api/work-history")]
        [HttpGet]
        public JsonResult GetWorkHistory()
        {
            return Json(BaseModelBuilder.GetWorkHistory(BaseService));
        }
        [Route("api/education-history")]
        [HttpGet]
        public JsonResult GetEducationHistory()
        {
            return Json(BaseModelBuilder.GetEducationHistory(BaseService));
        }
        [Route("api/publications")]
        [HttpGet]
        public JsonResult GetAllPublications()
        {
            return Json(BaseModelBuilder.GetAllPublications(BaseService));
        }
        [Route("api/expertise")]
        [HttpGet]
        public JsonResult GetExpertise()
        {
            return Json(BaseModelBuilder.GetAllExpertise(BaseService));
        }
        [Route("api/special-skills-chart")]
        [HttpGet]
        public JsonResult GetSpecialSkillsWithChart()
        {
            return Json(BaseModelBuilder.GetSpecialSkillsWithChart(BaseService));
        }
        [Route("api/special-skills-bar")]
        [HttpGet]
        public JsonResult GetSpecialSkillsWithBar()
        {
            return Json(BaseModelBuilder.GetSpecialSkillsWithBar(BaseService));
        }
        [Route("api/footer-social-links")]
        [HttpGet]
        public JsonResult GetSocialLinksForFooter()
        {
            return Json(BaseModelBuilder.GetSocialLinksForFooter(BaseService));
        }
        [Route("api/phones")]
        [HttpGet]
        public JsonResult GetAllPhones()
        {
            return Json(BaseModelBuilder.GetPhones(BaseService));
        }
    }
}
