using Microsoft.EntityFrameworkCore;
using MyCarrier.Domain.Entities.Addresses;
using MyCarrier.Domain.Entities.Attachments;
using MyCarrier.Domain.Entities.Chats;
using MyCarrier.Domain.Entities.Companies;
using MyCarrier.Domain.Entities.Contacts;
using MyCarrier.Domain.Entities.Contracts;
using MyCarrier.Domain.Entities.Countries;
using MyCarrier.Domain.Entities.Educations;
using MyCarrier.Domain.Entities.Experiences;
using MyCarrier.Domain.Entities.Freelancers;
using MyCarrier.Domain.Entities.Hobbies;
using MyCarrier.Domain.Entities.Jobs;
using MyCarrier.Domain.Entities.Languages;
using MyCarrier.Domain.Entities.Likes;
using MyCarrier.Domain.Entities.Messages;
using MyCarrier.Domain.Entities.Regions;
using MyCarrier.Domain.Entities.Resumes;
using MyCarrier.Domain.Entities.Skills;
using MyCarrier.Domain.Entities.Talents;
using MyCarrier.Domain.Entities.Users;

namespace MyCarrier.Data.Contexts;

public class MyCarrierDbContext : DbContext
{
    public MyCarrierDbContext(DbContextOptionsBuilder<MyCarrierDbContext> options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Freelancer> Freelancers { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<UserLanguage> UserLanguages { get; set; }
    public DbSet<Hobby> Hobbies { get; set;}
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<UserContact> UserContacts { get; set; }
    public DbSet<UserHobby> UserHobbies { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<JobSkill> JobSkills { get; set; }
    public DbSet<CompanyInformation> CompanyInformations { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<ContractSkill> ContractSkills { get; set; }
    public DbSet<Talent> Talents { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Chat> Chats { get; set; }  
    public DbSet<PerformerDetails> PerformerDetails { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Message> Messages { get; set; }
}