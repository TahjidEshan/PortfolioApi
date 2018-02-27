using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.ViewModels
{
    public class BaseViewModel
    {
    }
    public class AddressViewModel
    {
        public string HouseNumber { get; set; }
        public string RoadNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
    public class EmailViewModel
    {
        public IList<string> Emails { get; set; }
    }
    public class PhoneViewModel
    {
        public IList<string> Phones { get; set; }
    }
    public class AddressListViewModel
    {
        public IList<AddressViewModel> Addresses { get; set; }
    }
    public class SocialViewModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
    public class HeadersViewModel
    {
        public IList<string> Headers { get; set; }
    }
    public class SocialIconsViewModel
    {
        public IList<SocialViewModel> Icons { get; set; }
    }
    public class MottosViewModel
    {
        public IList<string> Mottos { get; set; }
    }
    public class GeneralSkillViewModel
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
    }
    public class GeneralSkillsList
    {
        public IList<GeneralSkillViewModel> Skills { get; set; }
    }
    public class WorkViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool CurrentlyEmployed { get; set; }
    }
    public class WorkHistoryViewModel
    {
        public IList<WorkViewModel> Works { get; set; }
    }
    public class EducationViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool CurrentlyEnrolled { get; set; }
    }
    public class EducationHistoryViewModel
    {
        public IList<EducationViewModel> Educations { get; set; }
    }
    public class PublicationViewModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public IList<string> Authors { get; set; }
    }
    public class PublicationListViewModel
    {
        public IList<PublicationViewModel> Publications { get; set; }
    }
    public class ExpertiseViewModel
    {
        public string Title { get; set; }
        public string Details { get; set; }
    }
    public class ExpertiseListViewModel
    {
        public IList<ExpertiseViewModel> Expertise { get; set; }
    }
    public class SpecialSkillsViewModel
    {
        public string Title { get; set; }
        public int Percentage { get; set; }
    }
    public class SpecialSkillsList
    {
        public IList<SpecialSkillsViewModel> Skills { get; set; }
    }
}
