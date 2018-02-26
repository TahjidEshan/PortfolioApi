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
        protected IGenericRepository BaseRepository { get; set; }

        public BaseService(IGenericRepository BaseRepository)
        {
            this.BaseRepository = BaseRepository;
        }


        //Address
        public void Save(Address Address)
        {
            BaseRepository.Insert<Address>(Address);
        }
        public void Delete(Address Address)
        {
            BaseRepository.Delete<Address>(Address);
        }
        public void Update(Address Address)
        {
            BaseRepository.Update<Address>(Address);
        }
        public Address GetAddressById(long Id)
        {
            return BaseRepository.GetByID<Address>(Id);
        }
        public IQueryable<Address> GetAddresses()
        {
            return BaseRepository.GetQuery<Address>();
        }

        //Author
        public void Save(Author Author)
        {
            BaseRepository.Insert<Author>(Author);
        }
        public void Delete(Author Author)
        {
            BaseRepository.Delete<Author>(Author);
        }
        public void Update(Author Author)
        {
            BaseRepository.Update<Author>(Author);
        }
        public Author GetAuthorById(long Id)
        {
            return BaseRepository.GetByID<Author>(Id);
        }
        public IQueryable<Author> GetAuthors()
        {
            return BaseRepository.GetQuery<Author>();
        }
        public IQueryable<Author> GetAuthorsOfAPublication(long PublicationId)
        {
            IQueryable<long> Authors = BaseRepository.
                GetQuery<PublicationAuthors>().Where(x => x.PublicationId == PublicationId).Select(x => x.AuthorId);
            return BaseRepository.GetQuery<Author>().Where(x => Authors.Contains(x.Id));
        }

        //Education
        public void Save(Education Education)
        {
            BaseRepository.Insert<Education>(Education);
        }
        public void Delete(Education Education)
        {
            BaseRepository.Delete<Education>(Education);
        }
        public void Update(Education Education)
        {
            BaseRepository.Update<Education>(Education);
        }
        public Education GetEducationDetailsById(long Id)
        {
            return BaseRepository.GetByID<Education>(Id);
        }
        public IQueryable<Education> GetAllEducationDetails()
        {
            return BaseRepository.GetQuery<Education>();
        }

        //Email
        public void Save(Email Email)
        {
            BaseRepository.Insert<Email>(Email);
        }
        public void Delete(Email Email)
        {
            BaseRepository.Delete<Email>(Email);
        }
        public void Update(Email Email)
        {
            BaseRepository.Update<Email>(Email);
        }
        public Email GetEmailById(long Id)
        {
            return BaseRepository.GetByID<Email>(Id);
        }
        public IQueryable<Email> GetAllEmails()
        {
            return BaseRepository.GetQuery<Email>();
        }

        //Event
        public void Save(Event Event)
        {
            BaseRepository.Insert<Event>(Event);
        }
        public void Delete(Event Event)
        {
            BaseRepository.Delete<Event>(Event);
        }
        public void Update(Event Event)
        {
            BaseRepository.Update<Event>(Event);
        }
        public Event GetEventById(long Id)
        {
            return BaseRepository.GetByID<Event>(Id);
        }
        public IQueryable<Event> GetAllEvents()
        {
            return BaseRepository.GetQuery<Event>();
        }

        //GeneralSkill
        public void Save(GeneralSkill GeneralSkill)
        {
            BaseRepository.Insert<GeneralSkill>(GeneralSkill);
        }
        public void Delete(GeneralSkill GeneralSkill)
        {
            BaseRepository.Delete<GeneralSkill>(GeneralSkill);
        }
        public void Update(GeneralSkill GeneralSkill)
        {
            BaseRepository.Update<GeneralSkill>(GeneralSkill);
        }
        public GeneralSkill GetGeneralSkillById(long Id)
        {
            return BaseRepository.GetByID<GeneralSkill>(Id);
        }
        public IQueryable<GeneralSkill> GetAllGeneralSkills()
        {
            return BaseRepository.GetQuery<GeneralSkill>();
        }

        //Header
        public void Save(Header Header)
        {
            BaseRepository.Insert<Header>(Header);
        } 

        public void Delete(Header Header)
        {
            BaseRepository.Delete<Header>(Header);
        }
        public void Update(Header Header)
        {
            BaseRepository.Update<Header>(Header);
        }
        public Header GetHeaderById(long Id)
        {
            return BaseRepository.GetByID<Header>(Id);
        }
        public IQueryable<Header> GetAllHeaders()
        {
            return BaseRepository.GetQuery<Header>();
        }

        //Image
        public void Save(Image Image)
        {
           BaseRepository.Insert<Image>(Image);
        }
        public void Delete(Image Image)
        {
            BaseRepository.Delete<Image>(Image);
        }
        public void Update(Image Image)
        {
            BaseRepository.Update<Image>(Image);
        }
        public Image GetImageById(long Id)
        {
            return BaseRepository.GetByID<Image>(Id);
        }
        public IQueryable<Image> GetAllImages()
        {
            return BaseRepository.GetQuery<Image>();
        }

        //Motto
        public void Save(Motto Motto)
        {

            BaseRepository.Insert<Motto>(Motto);
        }
        public void Delete(Motto Motto)
        {
            BaseRepository.Delete<Motto>(Motto);
        }
        public void Update(Motto Motto)
        {
            BaseRepository.Update<Motto>(Motto);
        }
        public Motto GetMottoById(long Id)
        {
            return BaseRepository.GetByID<Motto>(Id);
        }
        public IQueryable<Motto> GetAllMottos()
        {
            return BaseRepository.GetQuery<Motto>();
        }

        //Phone
        public void Save(Phone Phone)
        {
            BaseRepository.Insert<Phone>(Phone);
        }
        public void Delete(Phone Phone)
        {
            BaseRepository.Delete<Phone>(Phone);
        }
        public void Update(Phone Phone)
        {
            BaseRepository.Update<Phone>(Phone);
        }
        public Phone GetPhoneById(long Id)
        {
            return BaseRepository.GetByID<Phone>(Id);
        }
        public IQueryable<Phone> GetAllPhones()
        {
            return BaseRepository.GetQuery<Phone>();
        }

        //Publication
        public void Save(Publication Publication)
        {
            BaseRepository.Insert<Publication>(Publication);
        }
        public void Delete(Publication Publication)
        {
            BaseRepository.Delete<Publication>(Publication);
        }
        public void Update(Publication Publication)
        {
            BaseRepository.Update<Publication>(Publication);
        }
        public Publication GetPublicationById(long Id)
        {
            return BaseRepository.GetByID<Publication>(Id);
        }
        public IQueryable<Publication> GetAllPublications()
        {
            return BaseRepository.GetQuery<Publication>();
        }
        public IQueryable<Publication> GetAllPublicationsOfAnAuthor(long AuthorId)
        {
            IQueryable<long> PublicationIds = BaseRepository.GetQuery<PublicationAuthors>().Where(x => x.AuthorId == AuthorId).
                Select(x => x.PublicationId);
            return BaseRepository.GetQuery<Publication>().Where(x => PublicationIds.Contains(x.Id));
        }

        //PublicationAuthors
        public void Save(PublicationAuthors PublicationAuthors)
        {
            BaseRepository.Insert<PublicationAuthors>(PublicationAuthors);
        }
        public void Delete(PublicationAuthors PublicationAuthors)
        {
            BaseRepository.Delete<PublicationAuthors>(PublicationAuthors);
        }
        public void Update(PublicationAuthors PublicationAuthors)
        {
            BaseRepository.Update<PublicationAuthors>(PublicationAuthors);
        }
        public PublicationAuthors GetPublicationAuthorsById(long Id)
        {
            return BaseRepository.GetByID<PublicationAuthors>(Id);
        }
        public IQueryable<PublicationAuthors> GetAllPublicationAuthors()
        {
            return BaseRepository.GetQuery<PublicationAuthors>();
        }

        //SentMail
        public void Save(SentMail SentMail)
        {
            BaseRepository.Insert<SentMail>(SentMail);
        }
        public void Delete(SentMail SentMail)
        {
            BaseRepository.Delete<SentMail>(SentMail);
        }
        public void Update(SentMail SentMail)
        {
            BaseRepository.Update<SentMail>(SentMail);
        }
        public SentMail GetSentMailById(long Id)
        {
            return BaseRepository.GetByID<SentMail>(Id);
        }
        public IQueryable<SentMail> GetAllSentMails()
        {
            return BaseRepository.GetQuery<SentMail>();
        }

        //SocialService
        public void Save(SocialService SocialService)
        {
            BaseRepository.Insert<SocialService>(SocialService);
        }
        public void Delete(SocialService SocialService)
        {
            BaseRepository.Delete<SocialService>(SocialService);
        }
        public void Update(SocialService SocialService)
        {
            BaseRepository.Update<SocialService>(SocialService);
        }
        public SocialService GetSocialServiceById(long Id)
        {
            return BaseRepository.GetByID<SocialService>(Id);
        }
        public IQueryable<SocialService> GetAllSocialServices()
        {
            return BaseRepository.GetQuery<SocialService>();
        }

        //SpecialSkills
        public void Save(SpecialSkills SpecialSkills)
        {
            BaseRepository.Insert<SpecialSkills>(SpecialSkills);
        }
        public void Delete(SpecialSkills SpecialSkills)
        {
            BaseRepository.Delete<SpecialSkills>(SpecialSkills);
        }
        public void Update(SpecialSkills SpecialSkills)
        {
            BaseRepository.Update<SpecialSkills>(SpecialSkills);
        }
        public SpecialSkills GetSpecialSkillsById(long Id)
        {
            return BaseRepository.GetByID<SpecialSkills>(Id);
        }
        public IQueryable<SpecialSkills> GetAllSpecialSkills()
        {
            return BaseRepository.GetQuery<SpecialSkills>();
        }

        //Work
        public void Save(Work Work)
        {
            BaseRepository.Insert<Work>(Work);
        }
        public void Delete(Work Work)
        {
            BaseRepository.Delete<Work>(Work);
        }
        public void Update(Work Work)
        {
            BaseRepository.Update<Work>(Work);
        }
        public Work GetWorkById(long Id)
        {
            return BaseRepository.GetByID<Work>(Id);
        }
        public IQueryable<Work> GetAllWorks()
        {
            return BaseRepository.GetQuery<Work>();
        }
    }
}
