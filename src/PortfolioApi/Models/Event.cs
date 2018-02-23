using System;
using System.Collections.Generic;
using PortfolioApi.Enums;

namespace PortfolioApi.Models
{
    public class Event : BaseClass
    {
        public LifeEvent LifeEvent { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool CurrentWorkPlace { get; set; }
        public IList<string> PublicationAuthors { get; set; }
    }
}
