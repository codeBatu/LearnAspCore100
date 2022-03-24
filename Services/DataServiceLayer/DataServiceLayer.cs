using Batu.Entites.Concrete;
using DataAccesLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Services.DataServiceLayer
{
    
   public class DataServiceLayer
    {
        private readonly DataAcces m_dataAcces;
        public DataServiceLayer(DataAcces dataAcces)
        {
            m_dataAcces = dataAcces;
        }
        #region AboutPage  //deneme
        public void DeleteAboutPage(About t)
        {
            m_dataAcces.DeleteAboutPage(t);

        }

        public About GetByAboutPageId(int id)
        {
            return m_dataAcces.GetByAboutPageId(id);
        }

        public IEnumerable<About> GetAboutPageList()
        {
            return m_dataAcces.GetAboutPageList();
        }

        public void InsertAbout(About t)
        {
            m_dataAcces.InsertAbout(t);
        }

        public void UpdateAbout(About t)
        {
            m_dataAcces.UpdateAbout(t);
        }
        #endregion
        #region Contact
        public void DeleteContactPage(ContactEntity t)
        {
            m_dataAcces.DeleteContactPage(t);

        }

        public ContactEntity GetByContactId(int id)
        {
            return m_dataAcces.GetByContactId(id);
        }

        public IEnumerable<ContactEntity> GetContactList()
        {
            return m_dataAcces.GetContactList();
        }

        public void InsertContact(ContactEntity t)
        {
            m_dataAcces.InsertContact(t);
        }

        public void UpdateContact(ContactEntity t)
        {
            m_dataAcces.UpdateContact(t);
        }
        #endregion
        #region Experience
        public void DeleteExperiencePage(ExperienceEntity t)
        {
            m_dataAcces.DeleteExperiencePage(t);

        }

        public ExperienceEntity GetByExperienceId(int id)
        {
            return m_dataAcces.GetByExperienceId(id);
        }

        public IEnumerable<ExperienceEntity> GetExperienceList()
        {
            return m_dataAcces.GetExperienceList();
        }

        public void InsertExperience(ExperienceEntity t)
        {
            m_dataAcces.InsertExperience(t);
        }

        public void UpdateExperience(ExperienceEntity t)
        {
            m_dataAcces.UpdateExperience(t);
        }
        #endregion
        #region MainPage //okey
        public void DeleteMainPage(MainPage mainPage)
        {
            m_dataAcces.DeleteMainPage(mainPage);
        }
        public MainPage GetByMainPageID(int id)
        {
            return m_dataAcces.GetByMainPageID(id);
        }
        public IEnumerable<MainPage> GetMainPageList()
        {
            return m_dataAcces.GetMainPageList();
        }
        public void InsertMainPage(MainPage t)
        {
            m_dataAcces.InsertMainPage(t);
        }

        public void UpdateMainPage(MainPage t)
        {
            m_dataAcces.Update(t);
        }
        #endregion
        #region Message
        public void DeleteMessagePage(MessageEntity mainPage)
        {
            m_dataAcces.DeleteMessagePage(mainPage);
        }
        public MessageEntity GetByMessagePageID(int id)
        {
            return m_dataAcces.GetByMessagePageID(id);
        }
        public IEnumerable<MessageEntity> GetMessagePageList()
        {
            return m_dataAcces.GetMessagePageList();
        }
        public void InsertMessagePage(MessageEntity t)
        {
            m_dataAcces.InsertMessagePage(t);
        }

        public void UpdateMessage(MessageEntity t)
        {
            m_dataAcces.UpdateMessage(t);
        }
        #endregion
        #region Portfolio
        public void DeletePortfolioPage(PortfolioEntity mainPage)
        {
            m_dataAcces.DeletePortfolioPage(mainPage);
        }
        public PortfolioEntity GetByPortfolioPageID(int id)
        {
            return m_dataAcces.GetByPortfolioPageID(id);
        }
        public IEnumerable<PortfolioEntity> GetPortfolioPageList()
        {
            return m_dataAcces.GetPortfolioPageList();
        }
        public void InsertPortfolioPage(PortfolioEntity t)
        {
            m_dataAcces.InsertPortfolioPage(t);
        }

        public void UpdatePortfolio(PortfolioEntity t)
        {
            m_dataAcces.UpdatePortfolio(t);
        }
        #endregion
        #region Service
        public void DeleteServicePage(ServiceEntity mainPage)
        {
            m_dataAcces.DeleteServicePage(mainPage);
        }
        public ServiceEntity GetByServicePageID(int id)
        {
            return m_dataAcces.GetByServicePageID(id);
        }
        public IEnumerable<ServiceEntity> GetServicePageList()
        {
            return m_dataAcces.GetServicePageList();
        }
        public void InsertServicePage(ServiceEntity t)
        {
            m_dataAcces.InsertServicePage(t);
        }

        public void UpdateService(ServiceEntity t)
        {
            m_dataAcces.UpdateService(t);
        }
        #endregion
        #region Skill
        public void DeleteSkillPage(SkillEntity mainPage)
        {
            m_dataAcces.DeleteSkillPage(mainPage);
        }
        public SkillEntity GetBySkillPageID(int id)
        {
            return m_dataAcces.GetBySkillPageID(id);
        }
        public IEnumerable<SkillEntity> GetSkillPageList()
        {
            return m_dataAcces.GetSkillPageList();
        }
        public void InsertSkillPage(SkillEntity t)
        {
            m_dataAcces.InsertSkillPage(t);
        }

        public void UpdateSkill(SkillEntity t)
        {
            m_dataAcces.UpdateSkill(t);
        }
        #endregion
        #region SocialMedia
        public void DeleteSocialMedia(SocialMediaEntity mainPage)
        {
            m_dataAcces.DeleteSocialMedia(mainPage);
        }
        public SocialMediaEntity GetBySocialMediaID(int id)
        {
            return m_dataAcces.GetBySocialMediaID(id);
        }
        public IEnumerable<SocialMediaEntity> GetSocialMediaList()
        {
            return m_dataAcces.GetSocialMediaList();
        }
        public void InsertSocialMedia(SocialMediaEntity t)
        {
            m_dataAcces.InsertSocialMedia(t);
        }

        public void UpdateSocialMedia(SocialMediaEntity t)
        {
            m_dataAcces.UpdateSocialMedia(t);
        }
        #endregion
        #region Testimonial
        public void DeleteTestimonial(TestimonialEntity mainPage)
        {
            m_dataAcces.DeleteTestimonial(mainPage);
        }
        public TestimonialEntity GetTestimonialID(int id)
        {
            return m_dataAcces.GetTestimonialID(id);
        }
        public IEnumerable<TestimonialEntity> GetTestimonialList()
        {
            return m_dataAcces.GetSocialTestimonialList();
        }
        public void InsertTestimonial(TestimonialEntity t)
        {
            m_dataAcces.InsertTestimonialMedia(t);
        }

        public void UpdatTestimonial(TestimonialEntity t)
        {
            m_dataAcces.UpdatTestimonialMedia(t);
        }
        #endregion
    }
}
