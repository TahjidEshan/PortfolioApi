using PortFolio2017.DAL;
using PortFolio2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.Services
{
    public class BaseService : IBaseService
    {
        protected IGenericRepository<Address> AddressRepository { get; set; }
        protected IGenericRepository<Author> AuthorRepository { get; set; }
        protected IGenericRepository<Education> EducationRepository { get; set; }
        protected IGenericRepository<Email> EmailRepository { get; set; }
        protected IGenericRepository<Event> EventRepository { get; set; }
        protected IGenericRepository<GeneralSkill> GeneralSkillRepository { get; set; }
        protected IGenericRepository<Header> HeaderRepository { get; set; }
        protected IGenericRepository<Image> ImageRepository { get; set; }
        protected IGenericRepository<Motto> MottoRepository { get; set; }
        protected IGenericRepository<Phone> PhoneRepository { get; set; }
        protected IGenericRepository<Publication> PublicationRepository { get; set; }
        protected IGenericRepository<PublicationAuthors> PublicationAuthorsRepository { get; set; }
        protected IGenericRepository<SentMail> SentMailRepository { get; set; }
        protected IGenericRepository<SocialService> SocialServiceRepository { get; set; }
        protected IGenericRepository<SpecialSkills> SpecialSkillsRepository { get; set; }
        protected IGenericRepository<Work> WorkRepository { get; set; }

        public BaseService(IGenericRepository<Address> AddressRepository, IGenericRepository<Author> AuthorRepository,
            IGenericRepository<Education> EducationRepository, IGenericRepository<Email> EmailRepository,
            IGenericRepository<Event> EventRepository, IGenericRepository<GeneralSkill> GeneralSkillRepository,
            IGenericRepository<Header> HeaderRepository, IGenericRepository<Image> ImageRepository,
            IGenericRepository<Motto> MottoRepository, IGenericRepository<Phone> PhoneRepository,
            IGenericRepository<Publication> PublicationRepository, IGenericRepository<PublicationAuthors> PublicationAuthorsRepository,
            IGenericRepository<SentMail> SentMailRepository, IGenericRepository<SocialService> SocialServiceRepository,
            IGenericRepository<SpecialSkills> SpecialSkillsRepository, IGenericRepository<Work> WorkRepository
            )
        {
            this.AddressRepository = AddressRepository;
            this.AuthorRepository = AuthorRepository;
            this.EducationRepository = EducationRepository;
            this.EmailRepository = EmailRepository;
            this.EventRepository = EventRepository;
            this.GeneralSkillRepository = GeneralSkillRepository;
            this.HeaderRepository = HeaderRepository;
            this.ImageRepository = ImageRepository;
            this.MottoRepository = MottoRepository;
            this.PhoneRepository = PhoneRepository;
            this.PublicationRepository = PublicationRepository;
            this.PublicationAuthorsRepository = PublicationAuthorsRepository;
            this.SentMailRepository = SentMailRepository;
            this.SocialServiceRepository = SocialServiceRepository;
            this.SpecialSkillsRepository = SpecialSkillsRepository;
            this.WorkRepository = WorkRepository;
        }


        //Address
        public void Save(Address Address)
        {
            AddressRepository.Insert(Address);
        }
        public void Delete(Address Address)
        {
            AddressRepository.Delete(Address);
        }
        public void Update(Address Address)
        {
            AddressRepository.Update(Address);
        }
        public Address GetAddressById(long Id)
        {
            return AddressRepository.GetByID(Id);
        }
        public IQueryable<Address> GetAddresses()
        {
            return AddressRepository.GetQuery();
        }

        //Author
        public void Save(Author Author)
        {
            AuthorRepository.Insert(Author);
        }
        public void Delete(Author Author)
        {
            AuthorRepository.Delete(Author);
        }
        public void Update(Author Author)
        {
            AuthorRepository.Update(Author);
        }
        public Author GetAuthorById(long Id)
        {
            return AuthorRepository.GetByID(Id);
        }
        public IQueryable<Author> GetAuthors()
        {
            return AuthorRepository.GetQuery();
        }
        public IQueryable<Author> GetAuthorsOfAPublication(long PublicationId)
        {
            IQueryable<long> Authors = PublicationAuthorsRepository.
                GetQuery().Where(x => x.PublicationId == PublicationId).Select(x => x.AuthorId);
            return AuthorRepository.GetQuery().Where(x => Authors.Contains(x.Id));
        }

        //Education
        public void Save(Education Education)
        {
            EducationRepository.Insert(Education);
        }
        public void Delete(Education Education)
        {
            EducationRepository.Delete(Education);
        }
        public void Update(Education Education)
        {
            EducationRepository.Update(Education);
        }
        public Education GetEducationDetailsById(long Id)
        {
            return EducationRepository.GetByID(Id);
        }
        public IQueryable<Education> GetAllEducationDetails()
        {
            return EducationRepository.GetQuery();
        }

        //Email
        public void Save(Email Email)
        {
            EmailRepository.Insert(Email);
        }
        public void Delete(Email Email)
        {
            EmailRepository.Delete(Email);
        }
        public void Update(Email Email)
        {
            EmailRepository.Update(Email);
        }
        public Email GetEmailById(long Id)
        {
            return EmailRepository.GetByID(Id);
        }
        public IQueryable<Email> GetAllEmails()
        {
            return EmailRepository.GetQuery();
        }

        //Event
        public void Save(Event Event)
        {
            EventRepository.Insert(Event);
        }
        public void Delete(Event Event)
        {
            EventRepository.Delete(Event);
        }
        public void Update(Event Event)
        {
            EventRepository.Update(Event);
        }
        public Event GetEventById(long Id)
        {
            return EventRepository.GetByID(Id);
        }
        public IQueryable<Event> GetAllEvents()
        {
            return EventRepository.GetQuery();
        }

        //GeneralSkill
        public void Save(GeneralSkill GeneralSkill)
        {
            GeneralSkillRepository.Insert(GeneralSkill);
        }
        public void Delete(GeneralSkill GeneralSkill)
        {
            GeneralSkillRepository.Delete(GeneralSkill);
        }
        public void Update(GeneralSkill GeneralSkill)
        {
            GeneralSkillRepository.Update(GeneralSkill);
        }
        public GeneralSkill GetGeneralSkillById(long Id)
        {
            return GeneralSkillRepository.GetByID(Id);
        }
        public IQueryable<GeneralSkill> GetAllGeneralSkills()
        {
            return GeneralSkillRepository.GetQuery();
        }

        //Header
        public void Save(Header Header)
        {
            HeaderRepository.Insert(Header);
        } 

        public void Delete(Header Header)
        {
            HeaderRepository.Delete(Header);
        }
        public void Update(Header Header)
        {
            HeaderRepository.Update(Header);
        }
        public Header GetHeaderById(long Id)
        {
            return HeaderRepository.GetByID(Id);
        }
        public IQueryable<Header> GetAllHeaders()
        {
            return HeaderRepository.GetQuery();
        }

        //Image
        public void Save(Image Image)
        {
            ImageRepository.Insert(Image);
        }
        public void Delete(Image Image)
        {
            ImageRepository.Delete(Image);
        }
        public void Update(Image Image)
        {
            ImageRepository.Update(Image);
        }
        public Image GetImageById(long Id)
        {
            return ImageRepository.GetByID(Id);
        }
        public IQueryable<Image> GetAllImages()
        {
            return ImageRepository.GetQuery();
        }

        //Motto
        public void Save(Motto Motto)
        {
            MottoRepository.Insert(Motto);
        }
        public void Delete(Motto Motto)
        {
            MottoRepository.Delete(Motto);
        }
        public void Update(Motto Motto)
        {
            MottoRepository.Update(Motto);
        }
        public Motto GetMottoById(long Id)
        {
            return MottoRepository.GetByID(Id);
        }
        public IQueryable<Motto> GetAllMottos()
        {
            return MottoRepository.GetQuery();
        }

        //Phone
        public void Save(Phone Phone)
        {
            PhoneRepository.Insert(Phone);
        }
        public void Delete(Phone Phone)
        {
            PhoneRepository.Delete(Phone);
        }
        public void Update(Phone Phone)
        {
            PhoneRepository.Update(Phone);
        }
        public Phone GetPhoneById(long Id)
        {
            return PhoneRepository.GetByID(Id);
        }
        public IQueryable<Phone> GetAllPhones()
        {
            return PhoneRepository.GetQuery();
        }

        //Publication
        public void Save(Publication Publication)
        {
            PublicationRepository.Insert(Publication);
        }
        public void Delete(Publication Publication)
        {
            PublicationRepository.Delete(Publication);
        }
        public void Update(Publication Publication)
        {
            PublicationRepository.Update(Publication);
        }
        public Publication GetPublicationById(long Id)
        {
            return PublicationRepository.GetByID(Id);
        }
        public IQueryable<Publication> GetAllPublications()
        {
            return PublicationRepository.GetQuery();
        }
        public IQueryable<Publication> GetAllPublicationsOfAnAuthor(long AuthorId)
        {
            IQueryable<long> PublicationIds = PublicationAuthorsRepository.GetQuery().Where(x => x.AuthorId == AuthorId).
                Select(x => x.PublicationId);
            return PublicationRepository.GetQuery().Where(x => PublicationIds.Contains(x.Id));
        }

        //PublicationAuthors
        public void Save(PublicationAuthors PublicationAuthors)
        {
            PublicationAuthorsRepository.Insert(PublicationAuthors);
        }
        public void Delete(PublicationAuthors PublicationAuthors)
        {
            PublicationAuthorsRepository.Delete(PublicationAuthors);
        }
        public void Update(PublicationAuthors PublicationAuthors)
        {
            PublicationAuthorsRepository.Update(PublicationAuthors);
        }
        public PublicationAuthors GetPublicationAuthorsById(long Id)
        {
            return PublicationAuthorsRepository.GetByID(Id);
        }
        public IQueryable<PublicationAuthors> GetAllPublicationAuthors()
        {
            return PublicationAuthorsRepository.GetQuery();
        }

        //SentMail
        public void Save(SentMail SentMail)
        {
            SentMailRepository.Insert(SentMail);
        }
        public void Delete(SentMail SentMail)
        {
            SentMailRepository.Delete(SentMail);
        }
        public void Update(SentMail SentMail)
        {
            SentMailRepository.Update(SentMail);
        }
        public SentMail GetSentMailById(long Id)
        {
            return SentMailRepository.GetByID(Id);
        }
        public IQueryable<SentMail> GetAllSentMails()
        {
            return SentMailRepository.GetQuery();
        }

        //SocialService
        public void Save(SocialService SocialService)
        {
            SocialServiceRepository.Insert(SocialService);
        }
        public void Delete(SocialService SocialService)
        {
            SocialServiceRepository.Delete(SocialService);
        }
        public void Update(SocialService SocialService)
        {
            SocialServiceRepository.Update(SocialService);
        }
        public SocialService GetSocialServiceById(long Id)
        {
            return SocialServiceRepository.GetByID(Id);
        }
        public IQueryable<SocialService> GetAllSocialServices()
        {
            return SocialServiceRepository.GetQuery();
        }

        //SpecialSkills
        public void Save(SpecialSkills SpecialSkills)
        {
            SpecialSkillsRepository.Insert(SpecialSkills);
        }
        public void Delete(SpecialSkills SpecialSkills)
        {
            SpecialSkillsRepository.Delete(SpecialSkills);
        }
        public void Update(SpecialSkills SpecialSkills)
        {
            SpecialSkillsRepository.Update(SpecialSkills);
        }
        public SpecialSkills GetSpecialSkillsById(long Id)
        {
            return SpecialSkillsRepository.GetByID(Id);
        }
        public IQueryable<SpecialSkills> GetAllSpecialSkills()
        {
            return SpecialSkillsRepository.GetQuery();
        }

        //Work
        public void Save(Work Work)
        {
            WorkRepository.Insert(Work);
        }
        public void Delete(Work Work)
        {
            WorkRepository.Delete(Work);
        }
        public void Update(Work Work)
        {
            WorkRepository.Update(Work);
        }
        public Work GetWorkById(long Id)
        {
            return WorkRepository.GetByID(Id);
        }
        public IQueryable<Work> GetAllWorks()
        {
            return WorkRepository.GetQuery();
        }
    }
}
