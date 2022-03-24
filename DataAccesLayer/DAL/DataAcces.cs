using Batu.Entites.Concrete;
using Batu.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.DAL
{
   public class DataAcces
    {
        #region ctor 
        private readonly IAboutRepository m_aboutRepository;
        private readonly IContactRepository m_contactRepository;
        private readonly IExperienceRepo m_experienceRepo;
        private readonly IMainPage m_mainPage;
        private readonly IMessageRepo m_messageRepo;
        private readonly IPortfolioRepo m_portfolioRepo;
        private readonly IServiceRepo m_serviceRepo;
        private readonly ISkillRepo m_skillRepo;
        private readonly ITestimonialRepo m_testimonialRepo;
        private readonly ISocialMediaRepo m_socialMediaRepo;
        public DataAcces(IAboutRepository aboutRepository, IContactRepository contactRepository, IExperienceRepo experienceRepo,
            IMainPage mainPage, IMessageRepo messageRepo, IPortfolioRepo portfolioRepo, IServiceRepo serviceRepo, ITestimonialRepo testimonialRepo, ISocialMediaRepo socialMediaRepo, ISkillRepo skillRepo)
        {
            m_aboutRepository = aboutRepository;
            m_contactRepository = contactRepository;
            m_experienceRepo = experienceRepo;
            m_mainPage = mainPage;
            m_messageRepo = messageRepo;
            m_portfolioRepo = portfolioRepo;
            m_serviceRepo = serviceRepo;
            m_skillRepo = skillRepo;
            m_testimonialRepo = testimonialRepo;
            m_socialMediaRepo = socialMediaRepo;
        }
        #endregion
        #region AboutPage  //deneme
        public void DeleteAboutPage(About t)
        {
            m_aboutRepository.Delete(t);

        }

        public About GetByAboutPageId(int id)
        {
          return  m_aboutRepository.GetById  (id);
        }

        public IEnumerable<About> GetAboutPageList()
        {
            return m_aboutRepository.GetList();
        }

        public void InsertAbout(About t)
        {
            m_aboutRepository.Insert(t);
        }

        public void UpdateAbout(About t)
        {
            m_aboutRepository.Update(t);
        }
        #endregion
        #region Contact
        public void DeleteContactPage(ContactEntity t)
        {
            m_contactRepository. Delete(t);

        }

        public ContactEntity GetByContactId(int id)
        {
            return m_contactRepository.GetById(id);
        }

        public IEnumerable<ContactEntity> GetContactList()
        {
            return m_contactRepository.GetList();
        }

        public void InsertContact(ContactEntity t)
        {
            m_contactRepository.Insert(t);
        }

        public void UpdateContact(ContactEntity t)
        {
            m_contactRepository.Update(t);
        }
        #endregion
        #region Experience
        public void DeleteExperiencePage(ExperienceEntity t)
        {
            m_experienceRepo.Delete(t);

        }

        public ExperienceEntity GetByExperienceId(int id)
        {
            return m_experienceRepo.GetById(id);
        }

        public IEnumerable<ExperienceEntity> GetExperienceList()
        {
            return m_experienceRepo.GetList();
        }

        public void InsertExperience(ExperienceEntity t)
        {
            m_experienceRepo.Insert(t);
        }

        public void UpdateExperience(ExperienceEntity t)
        {
            m_experienceRepo.Update(t);
        }
        #endregion
        #region MainPage //okey
        public void DeleteMainPage(MainPage mainPage)
        {
            m_mainPage.Delete(mainPage);
        }
        public MainPage GetByMainPageID(int id)
        {
            return m_mainPage.GetById(id);
        }
        public IEnumerable<MainPage> GetMainPageList()
        {
            return m_mainPage.GetList();
        }
        public void InsertMainPage(MainPage t)
        {
            m_mainPage.Insert(t);
        }

        public void Update(MainPage t)
        {
            m_mainPage.Update(t);
        }
        #endregion
        #region Message
        public void DeleteMessagePage(MessageEntity mainPage)
        {
            m_messageRepo.Delete(mainPage);
        }
        public MessageEntity GetByMessagePageID(int id)
        {
            return m_messageRepo.GetById(id);
        }
        public IEnumerable<MessageEntity> GetMessagePageList()
        {
            return m_messageRepo.GetList();
        }
        public void InsertMessagePage(MessageEntity t)
        {
            m_messageRepo.Insert(t);
        }

        public void UpdateMessage(MessageEntity t)
        {
            m_messageRepo.Update(t);
        }
        #endregion
        #region Portfolio
        public void DeletePortfolioPage(PortfolioEntity mainPage)
        {
            m_portfolioRepo.Delete(mainPage);
        }
        public PortfolioEntity GetByPortfolioPageID(int id)
        {
            return m_portfolioRepo.GetById(id);
        }
        public IEnumerable<PortfolioEntity> GetPortfolioPageList()
        {
            return m_portfolioRepo.GetList();
        }
        public void InsertPortfolioPage(PortfolioEntity t)
        {
            m_portfolioRepo.Insert(t);
        }

        public void UpdatePortfolio(PortfolioEntity t)
        {
            m_portfolioRepo.Update(t);
        }
        #endregion
        #region Service
        public void DeleteServicePage(ServiceEntity mainPage)
        {
            m_serviceRepo.Delete(mainPage);
        }
        public ServiceEntity GetByServicePageID(int id)
        {
            return m_serviceRepo.GetById(id);
        }
        public IEnumerable<ServiceEntity> GetServicePageList()
        {
            return m_serviceRepo.GetList();
        }
        public void InsertServicePage(ServiceEntity t)
        {
            m_serviceRepo.Insert(t);
        }

        public void UpdateService(ServiceEntity t)
        {
            m_serviceRepo.Update(t);
        }
        #endregion
        #region Skill
        public void DeleteSkillPage(SkillEntity mainPage)
        {
            m_skillRepo.Delete(mainPage);
        }
        public SkillEntity GetBySkillPageID(int id)
        {
            return m_skillRepo.GetById(id);
        }
        public IEnumerable<SkillEntity> GetSkillPageList()
        {
            return m_skillRepo.GetList();
        }
        public void InsertSkillPage(SkillEntity t)
        {
            m_skillRepo.Insert(t);
        }

        public void UpdateSkill(SkillEntity t)
        {
            m_skillRepo.Update(t);
        }
        #endregion
        #region SocialMedia
        public void DeleteSocialMedia(SocialMediaEntity mainPage)
        {
            m_socialMediaRepo.Delete(mainPage);
        }
        public SocialMediaEntity GetBySocialMediaID(int id)
        {
            return m_socialMediaRepo.GetById(id);
        }
        public IEnumerable<SocialMediaEntity> GetSocialMediaList()
        {
            return m_socialMediaRepo.GetList();
        }
        public void InsertSocialMedia(SocialMediaEntity t)
        {
            m_socialMediaRepo.Insert(t);
        }

        public void UpdateSocialMedia(SocialMediaEntity t)
        {
            m_socialMediaRepo.Update(t);
        }
        #endregion
        #region Testimonial
        public void DeleteTestimonial(TestimonialEntity mainPage)
        {
            m_testimonialRepo.Delete(mainPage);
        }
        public TestimonialEntity GetTestimonialID(int id)
        {
            return m_testimonialRepo.GetById(id);
        }
        public IEnumerable<TestimonialEntity> GetSocialTestimonialList()
        {
            return m_testimonialRepo.GetList();
        }
        public void InsertTestimonialMedia(TestimonialEntity t)
        {
            m_testimonialRepo.Insert(t);
        }

        public void UpdatTestimonialMedia(TestimonialEntity t)
        {
            m_testimonialRepo.Update(t);
        }
        #endregion

    }
}
