using PortFolio2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.Services
{
    public interface IBaseService
    {
        //Address
        void Save(Address Address);
        void Delete(Address Address);
        void Update(Address Address);
        Address GetAddressById(Guid Id);
        IQueryable<Address> GetAddresses();

        //Author
        void Save(Author Author);
        void Delete(Author Author);
        void Update(Author Author);
        Author GetAuthorById(Guid Id);
        IQueryable<Author> GetAuthors();
        IQueryable<Author> GetAuthorsOfAPublication(Guid PublicationId);

        //Education
        void Save(Education Education);
        void Delete(Education Education);
        void Update(Education Education);
        Education GetEducationDetailsById(Guid Id);
        IQueryable<Education> GetAllEducationDetails();

        //Email
        void Save(Email Email);
        void Delete(Email Email);
        void Update(Email Email);
        Email GetEmailById(Guid Id);
        IQueryable<Email> GetAllEmails();

        //Event
        void Save(Event Event);
        void Delete(Event Event);
        void Update(Event Event);
        Event GetEventById(Guid Id);
        IQueryable<Event> GetAllEvents();

        //GeneralSkill
        void Save(GeneralSkill GeneralSkill);
        void Delete(GeneralSkill GeneralSkill);
        void Update(GeneralSkill GeneralSkill);
        GeneralSkill GetGeneralSkillById(Guid Id);
        IQueryable<GeneralSkill> GetAllGeneralSkills();

        //Header
        void Save(Header Header);
        void Delete(Header Header);
        void Update(Header Header);
        Header GetHeaderById(Guid Id);
        IQueryable<Header> GetAllHeaders();

        //Image
        void Save(Image Image);
        void Delete(Image Image);
        void Update(Image Image);
        Image GetImageById(Guid Id);
        IQueryable<Image> GetAllImages();

        //Motto
        void Save(Motto Motto);
        void Delete(Motto Motto);
        void Update(Motto Motto);
        Motto GetMottoById(Guid Id);
        IQueryable<Motto> GetAllMottos();

        //Phone
        void Save(Phone Phone);
        void Delete(Phone Phone);
        void Update(Phone Phone);
        Phone GetPhoneById(Guid Id);
        IQueryable<Phone> GetAllPhones();

        //Publication
        void Save(Publication Publication);
        void Delete(Publication Publication);
        void Update(Publication Publication);
        Publication GetPublicationById(Guid Id);
        IQueryable<Publication> GetAllPublications();
        IQueryable<Publication> GetAllPublicationsOfAnAuthor(Guid AuthorId);

        //PublicationAuthor
        void Save(PublicationAuthor PublicationAuthor);
        void Delete(PublicationAuthor PublicationAuthor);
        void Update(PublicationAuthor PublicationAuthor);
        PublicationAuthor GetPublicationAuthorById(Guid Id);
        IQueryable<PublicationAuthor> GetAllPublicationAuthor();

        //SentMail
        void Save(SentMail SentMail);
        void Delete(SentMail SentMail);
        void Update(SentMail SentMail);
        SentMail GetSentMailById(Guid Id);
        IQueryable<SentMail> GetAllSentMails();

        //SocialService
        void Save(SocialService SocialService);
        void Delete(SocialService SocialService);
        void Update(SocialService SocialService);
        SocialService GetSocialServiceById(Guid Id);
        IQueryable<SocialService> GetAllSocialServices();

        //SpecialSkills
        void Save(SpecialSkills SpecialSkills);
        void Delete(SpecialSkills SpecialSkills);
        void Update(SpecialSkills SpecialSkills);
        SpecialSkills GetSpecialSkillsById(Guid Id);
        IQueryable<SpecialSkills> GetAllSpecialSkills();

        //Work
        void Save(Work Work);
        void Delete(Work Work);
        void Update(Work Work);
        Work GetWorkById(Guid Id);
        IQueryable<Work> GetAllWorks();

        //Expertise
        void Save(Expertise Expertise);
        void Delete(Expertise Expertise);
        void Update(Expertise Expertise);
        Expertise GetExpertiseById(Guid Id);
        IQueryable<Expertise> GetAllExpertise();

        //User
        void Save(User User);
        void Delete(User User);
        void Update(User User);
        User GetUserById(Guid Id);
        IQueryable<User> GetAllUsers();



        //Seed Method
        void Seed();
    }
}
