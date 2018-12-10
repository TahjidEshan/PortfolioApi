using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortFolio2017.DAL;
using PortFolio2017.Models;

namespace PortFolio2017.Services {
    public class BaseService : IBaseService {
        protected IGenericRepository BaseRepository { get; set; }

        public BaseService (IGenericRepository BaseRepository) {
            this.BaseRepository = BaseRepository;
        }

        //Address
        public void Save (Address Address) => BaseRepository.Insert<Address> (Address);
        public void Delete (Address Address) => BaseRepository.Delete<Address> (Address);
        public void Update (Address Address) => BaseRepository.Update<Address> (Address);
        public Address GetAddressById (Guid Id) => BaseRepository.GetByID<Address> (Id);

        public IQueryable<Address> GetAddresses (bool trackChanges = true) =>
            BaseRepository.GetQuery<Address> (trackChanges);

        //Author
        public void Save (Author Author) => BaseRepository.Insert<Author> (Author);
        public void Delete (Author Author) => BaseRepository.Delete<Author> (Author);
        public void Update (Author Author) => BaseRepository.Update<Author> (Author);
        public Author GetAuthorById (Guid Id) => BaseRepository.GetByID<Author> (Id);
        public IQueryable<Author> GetAuthors (bool trackChanges = true, Guid? PublicationId = null) {
            IList<Guid> Authors = PublicationId != null?
            BaseRepository.GetQuery<PublicationAuthor> (false).Where (x => x.PublicationId == PublicationId.Value).Select (x => x.AuthorId).ToList ():
                new List<Guid> ();
            return BaseRepository.GetQuery<Author> (trackChanges).Where (x => Authors.Count == 0 ? true : Authors.Contains (x.Id));
        }
        //Education
        public void Save (Education Education) => BaseRepository.Insert<Education> (Education);
        public void Delete (Education Education) => BaseRepository.Delete<Education> (Education);
        public void Update (Education Education) => BaseRepository.Update<Education> (Education);
        public Education GetEducationDetailsById (Guid Id) => BaseRepository.GetByID<Education> (Id);
        public IQueryable<Education> GetAllEducationDetails (bool trackChanges = true) =>
            BaseRepository.GetQuery<Education> (trackChanges);

        //Email
        public void Save (Email Email) => BaseRepository.Insert<Email> (Email);
        public void Delete (Email Email) => BaseRepository.Delete<Email> (Email);
        public void Update (Email Email) => BaseRepository.Update<Email> (Email);
        public Email GetEmailById (Guid Id) => BaseRepository.GetByID<Email> (Id);
        public IQueryable<Email> GetAllEmails (bool trackChanges = true) => BaseRepository.GetQuery<Email> (trackChanges);

        //Event
        public void Save (Event Event) => BaseRepository.Insert<Event> (Event);
        public void Delete (Event Event) => BaseRepository.Delete<Event> (Event);
        public void Update (Event Event) => BaseRepository.Update<Event> (Event);
        public Event GetEventById (Guid Id) => BaseRepository.GetByID<Event> (Id);
        public IQueryable<Event> GetAllEvents (bool trackChanges = true) => BaseRepository.GetQuery<Event> (trackChanges);

        //GeneralSkill
        public void Save (GeneralSkill GeneralSkill) => BaseRepository.Insert<GeneralSkill> (GeneralSkill);
        public void Delete (GeneralSkill GeneralSkill) => BaseRepository.Delete<GeneralSkill> (GeneralSkill);
        public void Update (GeneralSkill GeneralSkill) => BaseRepository.Update<GeneralSkill> (GeneralSkill);
        public GeneralSkill GetGeneralSkillById (Guid Id) => BaseRepository.GetByID<GeneralSkill> (Id);
        public IQueryable<GeneralSkill> GetAllGeneralSkills (bool trackChanges = true) =>
            BaseRepository.GetQuery<GeneralSkill> (trackChanges);

        //Header
        public void Save (Header Header) => BaseRepository.Insert<Header> (Header);

        public void Delete (Header Header) => BaseRepository.Delete<Header> (Header);
        public void Update (Header Header) => BaseRepository.Update<Header> (Header);
        public Header GetHeaderById (Guid Id) => BaseRepository.GetByID<Header> (Id);
        public IQueryable<Header> GetAllHeaders (bool trackChanges = true) => BaseRepository.GetQuery<Header> (trackChanges);

        //Image
        public void Save (Image Image) => BaseRepository.Insert<Image> (Image);
        public void Delete (Image Image) => BaseRepository.Delete<Image> (Image);
        public void Update (Image Image) => BaseRepository.Update<Image> (Image);
        public Image GetImageById (Guid Id) => BaseRepository.GetByID<Image> (Id);
        public IQueryable<Image> GetAllImages (bool trackChanges = true) => BaseRepository.GetQuery<Image> (trackChanges);

        //Motto
        public void Save (Motto Motto) => BaseRepository.Insert<Motto> (Motto);
        public void Delete (Motto Motto) => BaseRepository.Delete<Motto> (Motto);
        public void Update (Motto Motto) => BaseRepository.Update<Motto> (Motto);
        public Motto GetMottoById (Guid Id) => BaseRepository.GetByID<Motto> (Id);
        public IQueryable<Motto> GetAllMottos (bool trackChanges = true) => BaseRepository.GetQuery<Motto> (trackChanges);

        //Phone
        public void Save (Phone Phone) => BaseRepository.Insert<Phone> (Phone);
        public void Delete (Phone Phone) => BaseRepository.Delete<Phone> (Phone);
        public void Update (Phone Phone) => BaseRepository.Update<Phone> (Phone);
        public Phone GetPhoneById (Guid Id) => BaseRepository.GetByID<Phone> (Id);
        public IQueryable<Phone> GetAllPhones (bool trackChanges = true) => BaseRepository.GetQuery<Phone> (trackChanges);

        //Publication
        public void Save (Publication Publication) => BaseRepository.Insert<Publication> (Publication);
        public void Delete (Publication Publication) => BaseRepository.Delete<Publication> (Publication);
        public void Update (Publication Publication) => BaseRepository.Update<Publication> (Publication);
        public Publication GetPublicationById (Guid Id) => BaseRepository.GetByID<Publication> (Id);
        public IQueryable<Publication> GetAllPublications (bool trackChanges = true, Guid? AuthorId = null) {
            IList<Guid> PublicationIds = AuthorId != null?
            BaseRepository.GetQuery<PublicationAuthor> (false).Where (x => x.AuthorId == AuthorId.Value).
            Select (x => x.PublicationId).ToList () : new List<Guid> ();
            return BaseRepository.GetQuery<Publication> (trackChanges).Where (x => PublicationIds.Count > 0 ?
                PublicationIds.Contains (x.Id) : true);
        }

        //PublicationAuthor
        public void Save (PublicationAuthor PublicationAuthor) => BaseRepository.Insert<PublicationAuthor> (PublicationAuthor);
        public void Delete (PublicationAuthor PublicationAuthor) => BaseRepository.Delete<PublicationAuthor> (PublicationAuthor);
        public void Update (PublicationAuthor PublicationAuthor) => BaseRepository.Update<PublicationAuthor> (PublicationAuthor);
        public PublicationAuthor GetPublicationAuthorById (Guid Id) => BaseRepository.GetByID<PublicationAuthor> (Id);
        public IQueryable<PublicationAuthor> GetAllPublicationAuthor (bool trackChanges = true) =>
            BaseRepository.GetQuery<PublicationAuthor> (trackChanges);

        //SentMail
        public void Save (SentMail SentMail) => BaseRepository.Insert<SentMail> (SentMail);
        public void Delete (SentMail SentMail) => BaseRepository.Delete<SentMail> (SentMail);
        public void Update (SentMail SentMail) => BaseRepository.Update<SentMail> (SentMail);
        public SentMail GetSentMailById (Guid Id) => BaseRepository.GetByID<SentMail> (Id);
        public IQueryable<SentMail> GetAllSentMails (bool trackChanges = true) => BaseRepository.GetQuery<SentMail> (trackChanges);

        //SocialService
        public void Save (SocialService SocialService) => BaseRepository.Insert<SocialService> (SocialService);
        public void Delete (SocialService SocialService) => BaseRepository.Delete<SocialService> (SocialService);
        public void Update (SocialService SocialService) => BaseRepository.Update<SocialService> (SocialService);
        public SocialService GetSocialServiceById (Guid Id) => BaseRepository.GetByID<SocialService> (Id);
        public IQueryable<SocialService> GetAllSocialServices (bool trackChanges = true) =>
            BaseRepository.GetQuery<SocialService> (trackChanges);

        //SpecialSkills
        public void Save (SpecialSkills SpecialSkills) => BaseRepository.Insert<SpecialSkills> (SpecialSkills);
        public void Delete (SpecialSkills SpecialSkills) => BaseRepository.Delete<SpecialSkills> (SpecialSkills);
        public void Update (SpecialSkills SpecialSkills) => BaseRepository.Update<SpecialSkills> (SpecialSkills);
        public SpecialSkills GetSpecialSkillsById (Guid Id) => BaseRepository.GetByID<SpecialSkills> (Id);
        public IQueryable<SpecialSkills> GetAllSpecialSkills (bool trackChanges = true) => BaseRepository.GetQuery<SpecialSkills> (trackChanges);

        //Work
        public void Save (Work Work) => BaseRepository.Insert<Work> (Work);
        public void Delete (Work Work) => BaseRepository.Delete<Work> (Work);
        public void Update (Work Work) => BaseRepository.Update<Work> (Work);
        public Work GetWorkById (Guid Id) => BaseRepository.GetByID<Work> (Id);
        public IQueryable<Work> GetAllWorks (bool trackChanges = true) => BaseRepository.GetQuery<Work> (trackChanges);

        //Expertise
        public void Save (Expertise Expertise) => BaseRepository.Insert<Expertise> (Expertise);
        public void Delete (Expertise Expertise) => BaseRepository.Delete<Expertise> (Expertise);
        public void Update (Expertise Expertise) => BaseRepository.Update<Expertise> (Expertise);
        public Expertise GetExpertiseById (Guid Id) => BaseRepository.GetByID<Expertise> (Id);
        public IQueryable<Expertise> GetAllExpertise (bool trackChanges = true) => BaseRepository.GetQuery<Expertise> (trackChanges);

        //User
        public void Save (User User) => BaseRepository.InsertUser<User> (User);
        public void Delete (User User) => BaseRepository.DeleteUser<User> (User);
        public void Update (User User) => BaseRepository.UpdateUser<User> (User);
        public User GetUserById (Guid Id) => BaseRepository.GetUserByID<User> (Id);
        public IQueryable<User> GetAllUsers (bool trackChanges = true) => BaseRepository.GetAllUsers<User> (trackChanges);

        //Seed
        public void Seed () {
            User Eshan = new User { UserName = "Eshan" };
            Save (Eshan);

            IList<SocialService> SideBarSocialIcons = new List<SocialService> ();
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-twitter2",
                    Url = "https://twitter.com/Ashfaque_Eshan",
                    Name = "Twitter"
            });
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-facebook2",
                    Url = "https://www.facebook.com/Ashfaque.Eshan",
                    Name = "Facebook"
            });
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-linkedin2",
                    Url = "https://www.linkedin.com/in/tahjid",
                    Name = "LinkedIn"
            });
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-google-plus",
                    Url = "https://plus.google.com/u/0/+TahjidAshfaqueEshan",
                    Name = "Google+"
            });
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-github2",
                    Url = "https://github.com/TahjidEshan",
                    Name = "Github"
            });
            SideBarSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Sidebar,
                    Icon = "icon-instagram2",
                    Url = "https://www.instagram.com/tahjidashfaque.eshan/",
                    Name = "Instagram"
            });
            foreach (SocialService item in SideBarSocialIcons) Save (item);

            IList<Header> Headers = new List<Header> ();
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Tahjid Ashfaque"
            });
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Designer"
            });
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Developer"
            });
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Consultant"
            });
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Artist"
            });
            Headers.Add (new Header {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Engineer"
            });
            foreach (Header item in Headers) Save (item);
            Image DownArrow = new Image {
                Location = "images/others/down-arrow-black.png",
                Title = "Down Arrow",
                CreatedByUserId = Eshan.UserId,
                UpdatedByUserId = Eshan.UserId,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };
            Save (DownArrow);

            IList<GeneralSkill> GeneralSkills = new List<GeneralSkill> ();
            GeneralSkills.Add (new GeneralSkill {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Full Stack Web Development",
                    Percentage = 85,
            });
            GeneralSkills.Add (new GeneralSkill {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Responsive UX/UI Design",
                    Percentage = 85,
            });
            GeneralSkills.Add (new GeneralSkill {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Database Management",
                    Percentage = 80,
            });
            GeneralSkills.Add (new GeneralSkill {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Image Processing",
                    Percentage = 70,
            });
            GeneralSkills.Add (new GeneralSkill {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Text = "Machine Learning",
                    Percentage = 70,
            });
            foreach (GeneralSkill Item in GeneralSkills) Save (Item);
            IList<Event> LifeEvents = new List<Event> ();
            IList<Work> Works = new List<Work> ();
            Works.Add (new Work {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Jr. Software Engineer",
                    Url = "http://www.asthait.com/",
                    UrlText = "Astha IT Research & Consultancy Ltd.",
                    CurrentlyEmployed = true,
                    FromDate = new DateTime (2017, 9, 6)
            });
            Works.Add (new Work {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Software Engineer",
                    Url = "http://www.crowdware.co/",
                    UrlText = "Crowdware",
                    ToDate = new DateTime (2017, 8, 31),
                    FromDate = new DateTime (2017, 6, 6)
            });
            Works.Add (new Work {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Software Engineer",
                    Url = "https://www.iquantile.com/",
                    UrlText = "iQuantile",
                    ToDate = new DateTime (2017, 6, 5),
                    FromDate = new DateTime (2017, 5, 2)
            });
            Works.Add (new Work {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Student Tutor",
                    Url = "http://www.bracu.ac.bd/",
                    UrlText = "BRAC University",
                    ToDate = new DateTime (2016, 12, 16),
                    FromDate = new DateTime (2015, 1, 16)
            });
            foreach (Work Item in Works) {
                Save (Item);
                LifeEvents.Add (new Event {
                    CreatedByUserId = Eshan.UserId,
                        UpdatedByUserId = Eshan.UserId,
                        CreatedOn = DateTime.UtcNow,
                        UpdatedOn = DateTime.UtcNow,
                        WorkId = Item.Id
                });
            }
            IList<Education> EducationHistory = new List<Education> ();
            EducationHistory.Add (new Education {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Bachelor of Science in Computer Science and Engineering(CSE)",
                    Url = "http://www.bracu.ac.bd/",
                    FromDate = new DateTime (2013, 1, 1),
                    ToDate = new DateTime (2016, 12, 31),
                    UrlText = "Brac University-" + new DateTime (2013, 1, 1) + "-" + new DateTime (2016, 12, 31),
                    Description = "Graduated with High Distinction\n" +
                    "Recipient of Merit-Based Scholarship all throughout Undergraduate\n" +
                    "Placed on VC's List on Three semesters\n" +
                    "Placed on Dean's List on Five Semesters\n" +
                    "Selected as a Student Tutor for Five Semesters (Spring 2015-Summer 2016)"
            });
            EducationHistory.Add (new Education {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Higher Secondary Certificate(HSC)",
                    Url = "http://www.notredamecollege-dhaka.com/",
                    FromDate = new DateTime (2010, 8, 1),
                    ToDate = new DateTime (2012, 8, 31),
                    UrlText = "Notre Dame College-" + 2010 + "-" + 2012,
            });
            EducationHistory.Add (new Education {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Secondary School Certificate(SSC)",
                    Url = "http://www.scpsc.edu.bd/",
                    ToDate = new DateTime (2010, 7, 31),
                    UrlText = "Brac University-" + " -" + 2010,
            });
            foreach (Education item in EducationHistory) {
                Save (item);
                LifeEvents.Add (new Event {
                    CreatedByUserId = Eshan.UserId,
                        UpdatedByUserId = Eshan.UserId,
                        CreatedOn = DateTime.UtcNow,
                        UpdatedOn = DateTime.UtcNow,
                        EducationId = item.Id
                });
            }
            Publication Publication = new Publication {
                CreatedByUserId = Eshan.UserId,
                UpdatedByUserId = Eshan.UserId,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                Name = "Abnormal event detection in crowded scenarios",
                Url = "http://ieeexplore.ieee.org/document/8275217/",
                UrlText = "View in IEEE XPlore",
                Description = "This paper proposes an autonomous video surveillance system which analyzes footages of extremely crowded scenes and detects abnormal events in the context of that particular scene. The model analyzes the local spatial-temporal motion pattern and detects abnormal motion variations and sudden changes and it can be divided into two major parts, selecting a set of Points of Interest (POI) from given frames and tracking them across multiple frames and dividing the input video frame in a number of cubes and track the motion patterns in each of the cubes for spatial-temporal statistical deviations. To evaluate the performance of proposed model we utilize several datasets and compare the acquired results of the proposed model with various state-of-the art models. Experimental results demonstrate that the proposed model outperforms the other models by exhibiting an average of 96.12% accuracy using Convolutional Neural Network.",
            };
            Save (Publication);
            LifeEvents.Add (new Event {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    PublicationId = Publication.Id
            });
            IList<Author> Authors = new List<Author> ();
            Authors.Add (new Author {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    UserId = Eshan.UserId,
                    Name = "Tahjid Ashfaque Mostafa"
            });
            Authors.Add (new Author {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Name = "Jia Uddin"
            });
            Authors.Add (new Author {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Name = "Md. Haider Ali"
            });
            foreach (Author Item in Authors) {
                Save (Item);
                Save (new PublicationAuthor {
                    PublicationId = Publication.Id,
                        AuthorId = Item.Id,
                        CreatedByUserId = Eshan.UserId,
                        UpdatedByUserId = Eshan.UserId,
                        CreatedOn = DateTime.UtcNow,
                        UpdatedOn = DateTime.UtcNow
                });
            }
            foreach (Event Item in LifeEvents) Save (Item);

            IList<Expertise> Expertise = new List<Expertise> ();
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Full Stack Web Development",
                    Details = "Full Stack Web Development"
            });
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Responsive UX/UI Development",
                    Details = "Responsive UX/UI Development"
            });
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Computer Vision/Image Processing",
                    Details = "Computer Vision/Image Processing"
            });
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Machine Learning",
                    Details = "Machine Learning"
            });
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Software Development",
                    Details = "Software Development"
            });
            Expertise.Add (new Expertise {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Title = "Database Management",
                    Details = "Database Management"
            });
            foreach (Expertise Item in Expertise) Save (Item);
            IList<SpecialSkills> SpecialSkillsList = new List<SpecialSkills> ();
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "C#",
                    Percentage = 90
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "JAVA SE",
                    Percentage = 90
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "PYTHON",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "PHP",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "JavaScript",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "HTML5",
                    Percentage = 90
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "CSS3",
                    Percentage = 80
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "RUBY",
                    Percentage = 65
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.Chart,
                    Title = "C/C++",
                    Percentage = 75
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "CodeIgniter",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Laravel",
                    Percentage = 70
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "jQuery",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "AngularJs",
                    Percentage = 80
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Java Swing",
                    Percentage = 80
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "LINQ",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Arduino Programming",
                    Percentage = 60
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Vue JS",
                    Percentage = 70
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "RSpec",
                    Percentage = 65
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Jasmine",
                    Percentage = 65
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "BootStrap",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "OpenCV",
                    Percentage = 80
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Theano",
                    Percentage = 70
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "TensorFlow",
                    Percentage = 65
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Keras",
                    Percentage = 70
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "ScikitLearn",
                    Percentage = 70
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Linux OS",
                    Percentage = 90
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "ASP.NET MVC",
                    Percentage = 90
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Entity Framework",
                    Percentage = 85
            });
            SpecialSkillsList.Add (new SpecialSkills {
                DisplayType = Enums.DisplayType.ProgressBar,
                    Title = "Scrum",
                    Percentage = 70
            });
            foreach (SpecialSkills Item in SpecialSkillsList) {
                Item.CreatedByUserId = Eshan.UserId;
                Item.UpdatedByUserId = Eshan.UserId;
                Item.CreatedOn = DateTime.UtcNow;
                Item.UpdatedOn = DateTime.UtcNow;
                Save (Item);
            }
            Save (new Address {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    Country = "Bangladesh",
                    City = "Dhaka",
                    HouseNumber = "111/2/3",
                    RoadNumber = "Niketon Bazar, Tejgao Industrial Area",
            });
            Save (new Phone {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    PhoneNumber = "01985169856"
            });
            Save (new Phone {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    PhoneNumber = "01684190636"
            });

            IList<SocialService> FooterSocialIcons = new List<SocialService> ();
            FooterSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Footer,
                    Icon = "fa fa-twitter",
                    Url = "https://twitter.com/Ashfaque_Eshan",
                    Name = "Twitter"
            });
            FooterSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Footer,
                    Icon = "fa fa-facebook",
                    Url = "https://www.facebook.com/Ashfaque.Eshan",
                    Name = "Facebook"
            });
            FooterSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Footer,
                    Icon = "fa fa-linkedin",
                    Url = "https://www.linkedin.com/in/tahjid",
                    Name = "LinkedIn"
            });
            FooterSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Footer,
                    Icon = "fa fa-google-plus",
                    Url = "https://plus.google.com/u/0/+TahjidAshfaqueEshan",
                    Name = "Google+"
            });
            FooterSocialIcons.Add (new SocialService {
                CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                    SocialLinkType = Enums.SocialLinkType.Footer,
                    Icon = "fa fa-github",
                    Url = "https://github.com/TahjidEshan",
                    Name = "Github"
            });
            foreach (SocialService item in FooterSocialIcons) Save (item);
            Save (new Email {
                EmailAddress = "atahjid@gmail.com",
                    CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
            });
            Save (new Email {
                EmailAddress = "atahjid@live.com",
                    CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
            });
            Save (new Email {
                EmailAddress = "atahjid@yahoo.com",
                    CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
            });
            Save (new Email {
                EmailAddress = "ta.mostafa@asthait.com",
                    CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
            });
            Save (new Email {
                EmailAddress = "tahjidashfaque@zoho.com",
                    CreatedByUserId = Eshan.UserId,
                    UpdatedByUserId = Eshan.UserId,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
            });
        }
    }
}