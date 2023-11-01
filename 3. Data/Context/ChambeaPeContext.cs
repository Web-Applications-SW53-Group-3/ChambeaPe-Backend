using System;
using System.Collections.Generic;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Context;

public partial class ChambeaPeContext : DbContext
{
    public ChambeaPeContext()
    {
    }

    public ChambeaPeContext(DbContextOptions<ChambeaPeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advertisement> Advertisements { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Claim> Claims { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Employer> Employers { get; set; }

    public virtual DbSet<Evidence> Evidences { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Premium> Premia { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Suscription> Suscriptions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=chambeapedb.mysql.database.azure.com;database=ChambeaPe;user=ChambeaPeUser;password=ConoCraft%69", ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Advertisement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("advertisements");

            entity.HasIndex(e => e.WorkerId, "Advertisements_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasColumnName("category");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.EndDay)
                .HasColumnType("datetime")
                .HasColumnName("end_day");
            entity.Property(e => e.IsActive)
            .HasColumnName("is_active")
            .HasDefaultValue(true);
            entity.Property(e => e.PictureUrl)
                .HasMaxLength(250)
                .HasColumnName("picture_url");
            entity.Property(e => e.StartDay)
                .HasColumnType("datetime")
                .HasColumnName("start_day");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Advertisements)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Advertisements_Worker");
        });

        modelBuilder.Entity<Certificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("certificates");

            entity.HasIndex(e => e.WorkerId, "Certificates_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.CertificateName)
                .HasMaxLength(60)
                .HasColumnName("certificate_name");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.ImgUrl)
                .HasMaxLength(250)
                .HasColumnName("imgUrl");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(60)
                .HasColumnName("institution_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issue_date");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.TeacherName)
                .HasMaxLength(40)
                .HasColumnName("teacher_name");
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Certificates)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Certificates_Worker");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chat");

            entity.HasIndex(e => e.EmployerId, "Chat_Employer");

            entity.HasIndex(e => e.MessageId, "Chat_Message");

            entity.HasIndex(e => e.WorkerId, "Chat_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.CreationTime)
                .HasColumnType("datetime")
                .HasColumnName("creation_time");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.EmployerId).HasColumnName("Employer_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.MessageId).HasColumnName("Message_id");
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Employer).WithMany(p => p.Chats)
                .HasForeignKey(d => d.EmployerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Chat_Employer");

            entity.HasOne(d => d.Message).WithMany(p => p.Chats)
                .HasForeignKey(d => d.MessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Chat_Message");

            entity.HasOne(d => d.Worker).WithMany(p => p.Chats)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Chat_Worker");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("claims");

            entity.HasIndex(e => e.ChatId, "Claims_Chat");

            entity.HasIndex(e => e.MessageId, "Claims_Message");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.ChatId).HasColumnName("Chat_id");
            entity.Property(e => e.CreationTime)
                .HasColumnType("datetime")
                .HasColumnName("creation_time");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.MessageId).HasColumnName("Message_id");

            entity.HasOne(d => d.Chat).WithMany(p => p.Claims)
                .HasForeignKey(d => d.ChatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Claims_Chat");

            entity.HasOne(d => d.Message).WithMany(p => p.Claims)
                .HasForeignKey(d => d.MessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Claims_Message");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contract");

            entity.HasIndex(e => e.WorkerId, "Contract_Worker");

            entity.HasIndex(e => e.PostsId, "Contract_posts");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.EndDay)
                .HasColumnType("datetime")
                .HasColumnName("end_day");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.PostsId).HasColumnName("Posts_id");
            entity.Property(e => e.Salary)
                .HasPrecision(6, 2)
                .HasColumnName("salary");
            entity.Property(e => e.StartDay)
                .HasColumnType("datetime")
                .HasColumnName("start_day");
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Posts).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.PostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Contract_posts");

            entity.HasOne(d => d.Worker).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Contract_Worker");
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employer");

            entity.HasIndex(e => e.UserId, "Employer_User");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Employers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Employer_User");
        });

        modelBuilder.Entity<Evidence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("evidences");

            entity.HasIndex(e => e.ClaimsId, "Evidences_Claims");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.ClaimsId).HasColumnName("Claims_id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);

            entity.HasOne(d => d.Claims).WithMany(p => p.Evidences)
                .HasForeignKey(d => d.ClaimsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Evidences_Claims");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("message");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.SendById).HasColumnName("send_by_id");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notifications");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("portfolio");

            entity.HasIndex(e => e.WorkerId, "Portfolio_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Portfolios)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Portfolio_Worker");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("posts");

            entity.HasIndex(e => e.EmployerId, "posts_Employer");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EmployerId).HasColumnName("Employer_id");
            entity.Property(e => e.ImgUrl)
                .HasMaxLength(255)
                .HasColumnName("imgUrl");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.Subtitle)
                .HasMaxLength(30)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .HasColumnName("title");

            entity.HasOne(d => d.Employer).WithMany(p => p.Posts)
                .HasForeignKey(d => d.EmployerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("posts_Employer");
        });

        modelBuilder.Entity<Premium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("premium");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.Price)
                .HasPrecision(6, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reviews");

            entity.HasIndex(e => e.EmployerId, "Reviews_Employer");

            entity.HasIndex(e => e.WorkerId, "Reviews_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.EmployerId).HasColumnName("Employer_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.SentById).HasColumnName("sent_by_id");
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Employer).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.EmployerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reviews_Employer");

            entity.HasOne(d => d.Worker).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reviews_Worker");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("service");

            entity.HasIndex(e => e.ContractId, "Service_Contract");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.ContractId).HasColumnName("Contract_id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.State)
                .HasColumnType("text")
                .HasColumnName("state");

            entity.HasOne(d => d.Contract).WithMany(p => p.Services)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Service_Contract");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skills");

            entity.HasIndex(e => e.WorkerId, "Table_62_Worker");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Content)
                .HasMaxLength(25)
                .HasColumnName("content");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.WorkerId).HasColumnName("Worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Skills)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Table_62_Worker");
        });

        modelBuilder.Entity<Suscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("suscription");

            entity.HasIndex(e => e.PremiumId, "Suscription_Premium");

            entity.HasIndex(e => e.UserId, "Suscription_User");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.EndDay)
                .HasColumnType("datetime")
                .HasColumnName("end_day");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.PremiumId).HasColumnName("Premium_id");
            entity.Property(e => e.StartDay)
                .HasColumnType("datetime")
                .HasColumnName("start_day");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.Premium).WithMany(p => p.Suscriptions)
                .HasForeignKey(d => d.PremiumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Suscription_Premium");

            entity.HasOne(d => d.User).WithMany(p => p.Suscriptions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Suscription_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Description)
                .HasColumnName("description");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.UserRole)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("user_role");
            entity.Property(e => e.HasPremium).HasColumnName("has_premium");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number").HasMaxLength(30);
            entity.Property(e => e.ProfilePic)
                .HasMaxLength(250)
                .HasColumnName("profile_pic");
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user_notifications");

            entity.HasIndex(e => e.NotificationsId, "User_Notifications_Notifications");

            entity.HasIndex(e => e.UserId, "User_Notifications_User");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.NotificationsId).HasColumnName("Notifications_id");
            entity.Property(e => e.Read).HasColumnName("read");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.Notifications).WithMany(p => p.UserNotifications)
                .HasForeignKey(d => d.NotificationsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("User_Notifications_Notifications");

            entity.HasOne(d => d.User).WithMany(p => p.UserNotifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("User_Notifications_User");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("worker");

            entity.HasIndex(e => e.UserId, "Worker_User");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_created")
                .HasDefaultValue(DateTime.Now);
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_updated");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            entity.Property(e => e.Occupation)
                .HasColumnType("text")
                .HasColumnName("occupation");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Workers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Worker_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
