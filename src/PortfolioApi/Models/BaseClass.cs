﻿using System;

namespace PortfolioApi.Models
{
    public class BaseClass
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}