using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class webcmsContext : DbContext
    {
        public webcmsContext()
        {
        }

        public webcmsContext(DbContextOptions<webcmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cms730Building> Cms730Building { get; set; }
        public virtual DbSet<Cms730District> Cms730District { get; set; }
        public virtual DbSet<Cms730Estate> Cms730Estate { get; set; }
        public virtual DbSet<CmsActivityAlbum> CmsActivityAlbum { get; set; }
        public virtual DbSet<CmsAdvertisement> CmsAdvertisement { get; set; }
        public virtual DbSet<CmsAgent> CmsAgent { get; set; }
        public virtual DbSet<CmsAgentAward> CmsAgentAward { get; set; }
        public virtual DbSet<CmsAnnouncement> CmsAnnouncement { get; set; }
        public virtual DbSet<CmsApiLog> CmsApiLog { get; set; }
        public virtual DbSet<CmsApiMls2Log> CmsApiMls2Log { get; set; }
        public virtual DbSet<CmsArticle> CmsArticle { get; set; }
        public virtual DbSet<CmsAttachment> CmsAttachment { get; set; }
        public virtual DbSet<CmsAward> CmsAward { get; set; }
        public virtual DbSet<CmsBanner> CmsBanner { get; set; }
        public virtual DbSet<CmsBranch> CmsBranch { get; set; }
        public virtual DbSet<CmsBuildingSqft> CmsBuildingSqft { get; set; }
        public virtual DbSet<CmsC21Handbook> CmsC21Handbook { get; set; }
        public virtual DbSet<CmsCampaign> CmsCampaign { get; set; }
        public virtual DbSet<CmsCirArticle> CmsCirArticle { get; set; }
        public virtual DbSet<CmsCirProperty> CmsCirProperty { get; set; }
        public virtual DbSet<CmsCirTransaction> CmsCirTransaction { get; set; }
        public virtual DbSet<CmsCnCity> CmsCnCity { get; set; }
        public virtual DbSet<CmsCnCountry> CmsCnCountry { get; set; }
        public virtual DbSet<CmsCnFirsthand> CmsCnFirsthand { get; set; }
        public virtual DbSet<CmsCnNews> CmsCnNews { get; set; }
        public virtual DbSet<CmsCnRegion> CmsCnRegion { get; set; }
        public virtual DbSet<CmsCompany> CmsCompany { get; set; }
        public virtual DbSet<CmsDiscount> CmsDiscount { get; set; }
        public virtual DbSet<CmsDistrict> CmsDistrict { get; set; }
        public virtual DbSet<CmsDistrict28hse> CmsDistrict28hse { get; set; }
        public virtual DbSet<CmsDistrictGohome> CmsDistrictGohome { get; set; }
        public virtual DbSet<CmsEmailTemplate> CmsEmailTemplate { get; set; }
        public virtual DbSet<CmsEntityTags> CmsEntityTags { get; set; }
        public virtual DbSet<CmsEntityTagsRelation> CmsEntityTagsRelation { get; set; }
        public virtual DbSet<CmsErpSearchLog> CmsErpSearchLog { get; set; }
        public virtual DbSet<CmsErpTransaction> CmsErpTransaction { get; set; }
        public virtual DbSet<CmsErpmLogDetail> CmsErpmLogDetail { get; set; }
        public virtual DbSet<CmsEstate> CmsEstate { get; set; }
        public virtual DbSet<CmsEstateOld> CmsEstateOld { get; set; }
        public virtual DbSet<CmsEstateTopic> CmsEstateTopic { get; set; }
        public virtual DbSet<CmsFiles> CmsFiles { get; set; }
        public virtual DbSet<CmsFirsthand> CmsFirsthand { get; set; }
        public virtual DbSet<CmsFloorplan> CmsFloorplan { get; set; }
        public virtual DbSet<CmsGoodwinSubscriber> CmsGoodwinSubscriber { get; set; }
        public virtual DbSet<CmsGwContent> CmsGwContent { get; set; }
        public virtual DbSet<CmsGwHomeLuxury> CmsGwHomeLuxury { get; set; }
        public virtual DbSet<CmsGwLink> CmsGwLink { get; set; }
        public virtual DbSet<CmsGwPropertyFavourite> CmsGwPropertyFavourite { get; set; }
        public virtual DbSet<CmsGwads> CmsGwads { get; set; }
        public virtual DbSet<CmsGwarticleAward> CmsGwarticleAward { get; set; }
        public virtual DbSet<CmsGwblog> CmsGwblog { get; set; }
        public virtual DbSet<CmsGwblogCategory> CmsGwblogCategory { get; set; }
        public virtual DbSet<CmsGwblogVideo> CmsGwblogVideo { get; set; }
        public virtual DbSet<CmsGwcustomerLikes> CmsGwcustomerLikes { get; set; }
        public virtual DbSet<CmsGwloyaltyShops> CmsGwloyaltyShops { get; set; }
        public virtual DbSet<CmsGwnews> CmsGwnews { get; set; }
        public virtual DbSet<CmsGwpresents> CmsGwpresents { get; set; }
        public virtual DbSet<CmsGwtips> CmsGwtips { get; set; }
        public virtual DbSet<CmsHomeNews> CmsHomeNews { get; set; }
        public virtual DbSet<CmsHomeTrannews> CmsHomeTrannews { get; set; }
        public virtual DbSet<CmsIntlAgent> CmsIntlAgent { get; set; }
        public virtual DbSet<CmsIntlBlog> CmsIntlBlog { get; set; }
        public virtual DbSet<CmsIntlBrochureUser> CmsIntlBrochureUser { get; set; }
        public virtual DbSet<CmsIntlClientRecognition> CmsIntlClientRecognition { get; set; }
        public virtual DbSet<CmsIntlContact> CmsIntlContact { get; set; }
        public virtual DbSet<CmsIntlContent> CmsIntlContent { get; set; }
        public virtual DbSet<CmsIntlDeveloperRecognition> CmsIntlDeveloperRecognition { get; set; }
        public virtual DbSet<CmsIntlEvent> CmsIntlEvent { get; set; }
        public virtual DbSet<CmsIntlHomeBanner> CmsIntlHomeBanner { get; set; }
        public virtual DbSet<CmsIntlMediaReport> CmsIntlMediaReport { get; set; }
        public virtual DbSet<CmsIntlOne2one> CmsIntlOne2one { get; set; }
        public virtual DbSet<CmsIntlSubscriber> CmsIntlSubscriber { get; set; }
        public virtual DbSet<CmsLineCallback> CmsLineCallback { get; set; }
        public virtual DbSet<CmsLineReply> CmsLineReply { get; set; }
        public virtual DbSet<CmsLineUserBind> CmsLineUserBind { get; set; }
        public virtual DbSet<CmsLogAction> CmsLogAction { get; set; }
        public virtual DbSet<CmsLogFace> CmsLogFace { get; set; }
        public virtual DbSet<CmsLogGwplusUserLogin> CmsLogGwplusUserLogin { get; set; }
        public virtual DbSet<CmsLogLogin> CmsLogLogin { get; set; }
        public virtual DbSet<CmsLogPropertyShareview> CmsLogPropertyShareview { get; set; }
        public virtual DbSet<CmsLoyalty> CmsLoyalty { get; set; }
        public virtual DbSet<CmsLoyaltyCoupon> CmsLoyaltyCoupon { get; set; }
        public virtual DbSet<CmsLoyaltyOwner> CmsLoyaltyOwner { get; set; }
        public virtual DbSet<CmsLoyaltyPoints> CmsLoyaltyPoints { get; set; }
        public virtual DbSet<CmsNotificationGcm> CmsNotificationGcm { get; set; }
        public virtual DbSet<CmsNotificationMatch> CmsNotificationMatch { get; set; }
        public virtual DbSet<CmsPageSocialThumb> CmsPageSocialThumb { get; set; }
        public virtual DbSet<CmsProperty> CmsProperty { get; set; }
        public virtual DbSet<CmsPropertyAdClicked> CmsPropertyAdClicked { get; set; }
        public virtual DbSet<CmsPropertyVideo> CmsPropertyVideo { get; set; }
        public virtual DbSet<CmsPublish28hse> CmsPublish28hse { get; set; }
        public virtual DbSet<CmsPublishC21Photo> CmsPublishC21Photo { get; set; }
        public virtual DbSet<CmsPublishC21PhotoBk> CmsPublishC21PhotoBk { get; set; }
        public virtual DbSet<CmsPublishHouse730> CmsPublishHouse730 { get; set; }
        public virtual DbSet<CmsPublishSqft> CmsPublishSqft { get; set; }
        public virtual DbSet<CmsPublishSqftCategory> CmsPublishSqftCategory { get; set; }
        public virtual DbSet<CmsPublishSqftOld> CmsPublishSqftOld { get; set; }
        public virtual DbSet<CmsPublishSqftResult> CmsPublishSqftResult { get; set; }
        public virtual DbSet<CmsSessions> CmsSessions { get; set; }
        public virtual DbSet<CmsStaffHandbook> CmsStaffHandbook { get; set; }
        public virtual DbSet<CmsStaffRules> CmsStaffRules { get; set; }
        public virtual DbSet<CmsSyncAccessKey> CmsSyncAccessKey { get; set; }
        public virtual DbSet<CmsSyncAccessLog> CmsSyncAccessLog { get; set; }
        public virtual DbSet<CmsSyncProcessLog> CmsSyncProcessLog { get; set; }
        public virtual DbSet<CmsSyncPropertyLog> CmsSyncPropertyLog { get; set; }
        public virtual DbSet<CmsTag> CmsTag { get; set; }
        public virtual DbSet<CmsTopic> CmsTopic { get; set; }
        public virtual DbSet<CmsTopicProperties> CmsTopicProperties { get; set; }
        public virtual DbSet<CmsTopicPropertyClicks> CmsTopicPropertyClicks { get; set; }
        public virtual DbSet<CmsTrannews> CmsTrannews { get; set; }
        public virtual DbSet<CmsTransaction> CmsTransaction { get; set; }
        public virtual DbSet<CmsTree> CmsTree { get; set; }
        public virtual DbSet<CmsUrl> CmsUrl { get; set; }
        public virtual DbSet<CmsUsers> CmsUsers { get; set; }
        public virtual DbSet<CmsVideoUrl> CmsVideoUrl { get; set; }
        public virtual DbSet<CmsVnews> CmsVnews { get; set; }
        public virtual DbSet<CmsWebConversion> CmsWebConversion { get; set; }
        public virtual DbSet<CmsWebFilterHash> CmsWebFilterHash { get; set; }
        public virtual DbSet<CmsWechatLog> CmsWechatLog { get; set; }
        public virtual DbSet<CmsWhatsappNumber> CmsWhatsappNumber { get; set; }
        public virtual DbSet<CmsYahooKeyword> CmsYahooKeyword { get; set; }
        public virtual DbSet<CpCampaign> CpCampaign { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.10.97;port=3306;user=chris;password=9TxFwZQsXn3XNHEh;persistsecurityinfo=True;treattinyasboolean=true;convertzerodatetime=True;database=webcms;characterset=utf8mb4", x => x.ServerVersion("5.5.52-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cms730Building>(entity =>
            {
                entity.ToTable("cms_730_building");

                entity.HasIndex(e => e.DistrictCode)
                    .HasName("district_code");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Cms730District>(entity =>
            {
                entity.ToTable("cms_730_district");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.MatchingCode)
                    .HasName("matching_code");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.MatchingCode)
                    .HasColumnName("matching_code")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<Cms730Estate>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("cms_730_estate");

                entity.HasIndex(e => e.DistrictCode)
                    .HasName("district_code");

                entity.HasIndex(e => e.EstateId)
                    .HasName("estate_id");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PhaseNumber)
                    .HasName("phase_number");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EstateId)
                    .HasColumnName("estate_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PhaseNumber)
                    .HasColumnName("phase_number")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsActivityAlbum>(entity =>
            {
                entity.ToTable("cms_activity_album");

                entity.HasIndex(e => e.RefSourceId)
                    .HasName("source_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .IsRequired()
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.YoutubeId)
                    .HasColumnName("youtube_id")
                    .HasColumnType("varchar(18)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsAdvertisement>(entity =>
            {
                entity.ToTable("cms_advertisement");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.UtmCampaign)
                    .HasName("utm_campaign")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UtmContent)
                    .HasName("utm_content")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UtmMedium)
                    .HasName("utm_medium")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UtmSource)
                    .HasName("utm_source")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UtmCampaign)
                    .HasColumnName("utm_campaign")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UtmContent)
                    .HasColumnName("utm_content")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UtmMedium)
                    .HasColumnName("utm_medium")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UtmSource)
                    .HasColumnName("utm_source")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsAgent>(entity =>
            {
                entity.ToTable("cms_agent");

                entity.HasIndex(e => e.BranchId)
                    .HasName("branch_id");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("company_id");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Gender)
                    .HasName("gender");

                entity.HasIndex(e => e.Languages)
                    .HasName("languages")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.LicenseNo)
                    .HasName("license_no");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en");

                entity.HasIndex(e => e.NameSc)
                    .HasName("name_sc");

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc");

                entity.HasIndex(e => e.PropertyTotal)
                    .HasName("property_total");

                entity.HasIndex(e => e.RefSource)
                    .HasName("ref_source");

                entity.HasIndex(e => e.SalesleadTags)
                    .HasName("saleslead_tags")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 255 });

                entity.HasIndex(e => e.ScoreTimes)
                    .HasName("score_times");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Tel)
                    .HasName("tel");

                entity.HasIndex(e => e.ViewCount)
                    .HasName("view_count");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.Awards)
                    .HasColumnName("awards")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branch_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasColumnType("int(5) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("enum('male','female')")
                    .HasDefaultValueSql("'male'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabelEn)
                    .HasColumnName("label_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabelSc)
                    .HasColumnName("label_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabelTc)
                    .HasColumnName("label_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Languages)
                    .HasColumnName("languages")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LicenseNo)
                    .IsRequired()
                    .HasColumnName("license_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyTotal)
                    .HasColumnName("property_total")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("enum('agent','manager','dmanager','director')")
                    .HasDefaultValueSql("'agent'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SalesleadTags)
                    .HasColumnName("saleslead_tags")
                    .HasColumnType("varchar(800)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("decimal(3,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ScoreTimes)
                    .HasColumnName("score_times")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelCn)
                    .HasColumnName("tel_cn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpDirector)
                    .HasColumnName("up_director")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UpDmanager)
                    .HasColumnName("up_dmanager")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UpManager)
                    .HasColumnName("up_manager")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.ViewCount)
                    .HasColumnName("view_count")
                    .HasColumnType("bigint(12) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CmsAgentAward>(entity =>
            {
                entity.ToTable("cms_agent_award");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.Count)
                    .HasName("count");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => e.Year)
                    .HasName("year");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.AwardArticleId)
                    .HasColumnName("award_article_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("smallint(2) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('company','personal','elite','centurion','heart')")
                    .HasDefaultValueSql("'company'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsAnnouncement>(entity =>
            {
                entity.ToTable("cms_announcement");

                entity.HasIndex(e => e.Branches)
                    .HasName("branches");

                entity.HasIndex(e => e.Role)
                    .HasName("role");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Branches)
                    .HasColumnName("branches")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PublisherEmail)
                    .IsRequired()
                    .HasColumnName("publisher_email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("enum('all','manager')")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('manual','notice','message','report')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsApiLog>(entity =>
            {
                entity.ToTable("cms_api_log");

                entity.HasIndex(e => e.Action)
                    .HasName("action");

                entity.HasIndex(e => e.Entity)
                    .HasName("entity");

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.Party)
                    .HasName("party");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Entity)
                    .HasColumnName("entity")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Parameters)
                    .IsRequired()
                    .HasColumnName("parameters")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasComment("1-success , 2-failed");
            });

            modelBuilder.Entity<CmsApiMls2Log>(entity =>
            {
                entity.ToTable("cms_api_mls2_log");

                entity.HasIndex(e => e.Action)
                    .HasName("action");

                entity.HasIndex(e => e.Result)
                    .HasName("result");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("enum('update','delete')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'2'")
                    .HasComment("1 -- fail , 2 -- success");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsArticle>(entity =>
            {
                entity.ToTable("cms_article");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToHomefantasy)
                    .HasColumnName("to_homefantasy")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsAttachment>(entity =>
            {
                entity.ToTable("cms_attachment");

                entity.HasIndex(e => e.Entity)
                    .HasName("entity");

                entity.HasIndex(e => e.EntityId)
                    .HasName("entity_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasColumnName("entity")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsAward>(entity =>
            {
                entity.ToTable("cms_award");

                entity.HasIndex(e => e.First)
                    .HasName("first");

                entity.HasIndex(e => e.RefSource)
                    .HasName("ref_source");

                entity.HasIndex(e => e.RefSourceId)
                    .HasName("ref_source_id");

                entity.HasIndex(e => e.Second)
                    .HasName("second");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Third)
                    .HasName("third");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.First)
                    .HasColumnName("first")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FirstAvatar)
                    .HasColumnName("first_avatar")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FirstBranch)
                    .HasColumnName("first_branch")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstLicenseNo)
                    .HasColumnName("first_license_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstPosition)
                    .HasColumnName("first_position")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Second)
                    .HasColumnName("second")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SecondAvatar)
                    .HasColumnName("second_avatar")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SecondBranch)
                    .HasColumnName("second_branch")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecondLicenseNo)
                    .HasColumnName("second_license_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecondName)
                    .HasColumnName("second_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecondPosition)
                    .HasColumnName("second_position")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Third)
                    .HasColumnName("third")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ThirdAvatar)
                    .HasColumnName("third_avatar")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ThirdBranch)
                    .HasColumnName("third_branch")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThirdLicenseNo)
                    .HasColumnName("third_license_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThirdName)
                    .HasColumnName("third_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThirdPosition)
                    .HasColumnName("third_position")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("enum('month','season','annual')")
                    .HasDefaultValueSql("'month'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsBanner>(entity =>
            {
                entity.ToTable("cms_banner");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Target)
                    .HasName("target");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasColumnType("enum('_self','_blank')")
                    .HasDefaultValueSql("'_self'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleTc)
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsBranch>(entity =>
            {
                entity.ToTable("cms_branch");

                entity.HasIndex(e => e.C21Code)
                    .HasName("c21_code");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("company_id");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Manager)
                    .HasName("manager");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => e.WhatsappNumber)
                    .HasName("whatsapp_number");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressSc)
                    .IsRequired()
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C21Code)
                    .HasColumnName("c21_code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("fax")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('R','C')")
                    .HasDefaultValueSql("'R'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.WhatsappNumber)
                    .HasColumnName("whatsapp_number")
                    .HasColumnType("int(4) unsigned");

                entity.HasOne(d => d.WhatsappNumberNavigation)
                    .WithMany(p => p.CmsBranch)
                    .HasForeignKey(d => d.WhatsappNumber)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("whatsapp_number");
            });

            modelBuilder.Entity<CmsBuildingSqft>(entity =>
            {
                entity.ToTable("cms_building_sqft");

                entity.HasIndex(e => e.Block)
                    .HasName("block");

                entity.HasIndex(e => e.BuildingName)
                    .HasName("building_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.DistrictCode)
                    .HasName("district_code");

                entity.HasIndex(e => e.DistrictTc)
                    .HasName("district");

                entity.HasIndex(e => e.Estate)
                    .HasName("estate")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Phase)
                    .HasName("phase");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressSc)
                    .IsRequired()
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Block)
                    .HasColumnName("block")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingName)
                    .HasColumnName("building_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DistrictCode)
                    .HasColumnName("district_code")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictEn)
                    .HasColumnName("district_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictSc)
                    .HasColumnName("district_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictTc)
                    .IsRequired()
                    .HasColumnName("district_tc")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Estate)
                    .HasColumnName("estate")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsC21Handbook>(entity =>
            {
                entity.ToTable("cms_c21_handbook");

                entity.HasIndex(e => e.Chapter)
                    .HasName("chapter");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Chapter)
                    .HasColumnName("chapter")
                    .HasColumnType("enum('GUIDELINE','WELFARE','COMMISSION','FOUR_GUARANTEE','DAILY_WORK','SAIKUNG_WORK')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCampaign>(entity =>
            {
                entity.ToTable("cms_campaign");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.ShareAgent)
                    .HasName("agent_share");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.InfoContent)
                    .HasColumnName("info_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InfoUrl)
                    .HasColumnName("info_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShareAgent)
                    .HasColumnName("share_agent")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ShareContent)
                    .HasColumnName("share_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShareUrl)
                    .IsRequired()
                    .HasColumnName("share_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('campaign','firsthand','goodwinplus')")
                    .HasDefaultValueSql("'campaign'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCirArticle>(entity =>
            {
                entity.ToTable("cms_cir_article");

                entity.HasIndex(e => e.Category)
                    .HasName("category");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("enum('marketing','transaction')")
                    .HasDefaultValueSql("'marketing'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCirProperty>(entity =>
            {
                entity.ToTable("cms_cir_property");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.AgentId2)
                    .HasName("agent_id2");

                entity.HasIndex(e => e.BuildingId)
                    .HasName("building_id");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("company_id");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.DescriptionTc)
                    .HasName("description_tc");

                entity.HasIndex(e => e.DistrictEn)
                    .HasName("district_en");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("district");

                entity.HasIndex(e => e.DistrictSc)
                    .HasName("district_sc");

                entity.HasIndex(e => e.DistrictTc)
                    .HasName("district_tc");

                entity.HasIndex(e => e.EstateEn)
                    .HasName("estate_en");

                entity.HasIndex(e => e.EstateId)
                    .HasName("estate_id");

                entity.HasIndex(e => e.EstateSc)
                    .HasName("estate_sc");

                entity.HasIndex(e => e.EstateTc)
                    .HasName("estate_tc");

                entity.HasIndex(e => e.ExpiryDate)
                    .HasName("expiry_date");

                entity.HasIndex(e => e.FacilityTags)
                    .HasName("facility_tags");

                entity.HasIndex(e => e.FeatureTags)
                    .HasName("feature_tags");

                entity.HasIndex(e => e.GrossArea)
                    .HasName("gross_area");

                entity.HasIndex(e => e.HitTags)
                    .HasName("hit_tags");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en");

                entity.HasIndex(e => e.NameSc)
                    .HasName("name_sc");

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc");

                entity.HasIndex(e => e.PriceRent)
                    .HasName("price_rent");

                entity.HasIndex(e => e.PriceSale)
                    .HasName("price_sale");

                entity.HasIndex(e => e.PropertyUsage)
                    .HasName("property_usage");

                entity.HasIndex(e => e.Recommended)
                    .HasName("recommended");

                entity.HasIndex(e => e.RefDb)
                    .HasName("ref_db");

                entity.HasIndex(e => e.RefNo)
                    .HasName("ref_no");

                entity.HasIndex(e => e.SaleableArea)
                    .HasName("saleable_area");

                entity.HasIndex(e => e.SoleAgency)
                    .HasName("sole_agency");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.HasIndex(e => e.ViewCount)
                    .HasName("view_count");

                entity.HasIndex(e => e.ViewTags)
                    .HasName("view_tags");

                entity.HasIndex(e => e.WithTenancy)
                    .HasName("with_tenancy");

                entity.HasIndex(e => e.Year)
                    .HasName("year");

                entity.HasIndex(e => e.Zone)
                    .HasName("zone");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressSc)
                    .IsRequired()
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AgentId2)
                    .HasColumnName("agent_id2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AveragePriceGross)
                    .HasColumnName("average_price_gross")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.AveragePriceSaleable)
                    .HasColumnName("average_price_saleable")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.AverageRentGross)
                    .HasColumnName("average_rent_gross")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.AverageRentSaleable)
                    .HasColumnName("average_rent_saleable")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.Block)
                    .HasColumnName("block")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingEn)
                    .HasColumnName("building_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("building_id")
                    .HasColumnType("bigint(12) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BuildingSc)
                    .HasColumnName("building_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuildingTc)
                    .HasColumnName("building_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DataRaw)
                    .HasColumnName("data_raw")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("description_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DescriptionSc)
                    .HasColumnName("description_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DescriptionTc)
                    .HasColumnName("description_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictEn)
                    .HasColumnName("district_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("district_id")
                    .HasColumnType("mediumint(4) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DistrictSc)
                    .HasColumnName("district_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictTc)
                    .HasColumnName("district_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstateEn)
                    .HasColumnName("estate_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstateId)
                    .HasColumnName("estate_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EstateSc)
                    .HasColumnName("estate_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstateTc)
                    .HasColumnName("estate_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiry_date")
                    .HasColumnType("date");

                entity.Property(e => e.FacilityTags)
                    .IsRequired()
                    .HasColumnName("facility_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeatureTags)
                    .HasColumnName("feature_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FloorLevel)
                    .HasColumnName("floor_level")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GrossArea)
                    .HasColumnName("gross_area")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HitTags)
                    .HasColumnName("hit_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PriceRent)
                    .HasColumnName("price_rent")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.PriceSale)
                    .HasColumnName("price_sale")
                    .HasColumnType("decimal(6,2) unsigned")
                    .HasComment("百萬");

                entity.Property(e => e.PropertyUsage)
                    .HasColumnName("property_usage")
                    .HasColumnType("enum('R','C','O','I','P','M','A','U','V','H','T','W','D','B')")
                    .HasDefaultValueSql("'R'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Recommended)
                    .HasColumnName("recommended")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.RefDb)
                    .IsRequired()
                    .HasColumnName("ref_db")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RefNo)
                    .HasColumnName("ref_no")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SaleableArea)
                    .HasColumnName("saleable_area")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SoleAgency)
                    .HasColumnName("sole_agency")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled','suspend')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.ViewCount)
                    .HasColumnName("view_count")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.ViewCountCookie)
                    .HasColumnName("view_count_cookie")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.ViewTags)
                    .IsRequired()
                    .HasColumnName("view_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WithTenancy)
                    .HasColumnName("with_tenancy")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("mediumint(4) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Yield)
                    .HasColumnName("yield")
                    .HasColumnType("decimal(2,2)");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone")
                    .HasColumnType("enum('HK','KL','NT','OI')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsCirTransaction>(entity =>
            {
                entity.ToTable("cms_cir_transaction");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.DocumentDate)
                    .HasName("document_date");

                entity.HasIndex(e => e.MemoNo)
                    .HasName("memo_no");

                entity.HasIndex(e => e.Mls2By)
                    .HasName("mls2_by");

                entity.HasIndex(e => e.RegDate)
                    .HasName("date");

                entity.HasIndex(e => e.SaleableArea)
                    .HasName("saleable_area");

                entity.HasIndex(e => e.Usage)
                    .HasName("estate_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.BuildingEn)
                    .HasColumnName("building_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingSc)
                    .HasColumnName("building_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingTc)
                    .IsRequired()
                    .HasColumnName("building_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("document_date")
                    .HasColumnType("date");

                entity.Property(e => e.DocumentNature)
                    .HasColumnName("document_nature")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Facing)
                    .HasColumnName("facing")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GrossArea)
                    .HasColumnName("gross_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GrossPrice)
                    .HasColumnName("gross_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Layout)
                    .HasColumnName("layout")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MemoNo)
                    .IsRequired()
                    .HasColumnName("memo_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mls2By)
                    .HasColumnName("mls2_by")
                    .HasColumnType("enum('tran','prop')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("date");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SaleableArea)
                    .HasColumnName("saleable_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SaleablePrice)
                    .HasColumnName("saleable_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StreetEn)
                    .HasColumnName("street_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StreetSc)
                    .HasColumnName("street_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StreetTc)
                    .HasColumnName("street_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Usage)
                    .HasColumnName("usage")
                    .HasColumnType("enum('I','C','O','P')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.YearBuilt)
                    .HasColumnName("year_built")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.YearExpire)
                    .HasColumnName("year_expire")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsCnCity>(entity =>
            {
                entity.ToTable("cms_cn_city");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.MetaDescEn)
                    .HasColumnName("meta_desc_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescSc)
                    .HasColumnName("meta_desc_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescTc)
                    .HasColumnName("meta_desc_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleEn)
                    .HasColumnName("meta_title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleSc)
                    .HasColumnName("meta_title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleTc)
                    .HasColumnName("meta_title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescEn)
                    .HasColumnName("page_desc_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreEn)
                    .HasColumnName("page_desc_more_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreSc)
                    .HasColumnName("page_desc_more_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreTc)
                    .HasColumnName("page_desc_more_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescSc)
                    .HasColumnName("page_desc_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescTc)
                    .HasColumnName("page_desc_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'999'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCnCountry>(entity =>
            {
                entity.ToTable("cms_cn_country");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CurrencyEn)
                    .HasColumnName("currency_en")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencySc)
                    .HasColumnName("currency_sc")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyTc)
                    .HasColumnName("currency_tc")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DollarSign)
                    .HasColumnName("dollar_sign")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'$'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HomeGridImage)
                    .HasColumnName("home_grid_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MetaDescEn)
                    .HasColumnName("meta_desc_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescSc)
                    .HasColumnName("meta_desc_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescTc)
                    .HasColumnName("meta_desc_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleEn)
                    .HasColumnName("meta_title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleSc)
                    .HasColumnName("meta_title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitleTc)
                    .HasColumnName("meta_title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescEn)
                    .HasColumnName("page_desc_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreEn)
                    .HasColumnName("page_desc_more_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreSc)
                    .HasColumnName("page_desc_more_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescMoreTc)
                    .HasColumnName("page_desc_more_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescSc)
                    .HasColumnName("page_desc_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageDescTc)
                    .HasColumnName("page_desc_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'999'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCnFirsthand>(entity =>
            {
                entity.ToTable("cms_cn_firsthand");

                entity.HasIndex(e => e.City)
                    .HasName("city");

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.FeatureTags)
                    .HasName("feature_tags")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PriceAverage)
                    .HasName("price_average")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Region)
                    .HasName("region");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Top)
                    .HasName("top");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.HasIndex(e => e.UsageType)
                    .HasName("usage_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressSc)
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AreaEn)
                    .HasColumnName("area_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AreaSc)
                    .HasColumnName("area_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AreaTc)
                    .HasColumnName("area_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Attachments)
                    .HasColumnName("attachments")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Bathroom)
                    .HasColumnName("bathroom")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Bedroom)
                    .HasColumnName("bedroom")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingsTotal)
                    .HasColumnName("buildings_total")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CarparksTotal)
                    .HasColumnName("carparks_total")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DateDeliveryEn)
                    .HasColumnName("date_delivery_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DateDeliverySc)
                    .HasColumnName("date_delivery_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DateDeliveryTc)
                    .HasColumnName("date_delivery_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DateStartEn)
                    .HasColumnName("date_start_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DateStartSc)
                    .HasColumnName("date_start_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DateStartTc)
                    .HasColumnName("date_start_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DecorationEn)
                    .HasColumnName("decoration_en")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DecorationSc)
                    .HasColumnName("decoration_sc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DecorationTc)
                    .HasColumnName("decoration_tc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("description_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionSc)
                    .HasColumnName("description_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionTc)
                    .HasColumnName("description_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DeveloperEn)
                    .HasColumnName("developer_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DeveloperSc)
                    .HasColumnName("developer_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DeveloperTc)
                    .HasColumnName("developer_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilitiesEn)
                    .HasColumnName("facilities_en")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilitiesSc)
                    .HasColumnName("facilities_sc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilitiesTc)
                    .HasColumnName("facilities_tc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FeatureTags)
                    .HasColumnName("feature_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Floorplans)
                    .HasColumnName("floorplans")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FloorsTotal)
                    .HasColumnName("floors_total")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroundRentEn)
                    .HasColumnName("ground_rent_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroundRentSc)
                    .HasColumnName("ground_rent_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroundRentTc)
                    .HasColumnName("ground_rent_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManagementEn)
                    .HasColumnName("management_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManagementFee)
                    .HasColumnName("management_fee")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManagementSc)
                    .HasColumnName("management_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManagementTc)
                    .HasColumnName("management_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(10,6)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(10,6)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PriceAverage)
                    .HasColumnName("price_average")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PriceTotal)
                    .HasColumnName("price_total")
                    .HasColumnType("decimal(10,1) unsigned")
                    .HasDefaultValueSql("'0.0'");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(6)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SellingPointEn)
                    .HasColumnName("selling_point_en")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SellingPointSc)
                    .HasColumnName("selling_point_sc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SellingPointTc)
                    .HasColumnName("selling_point_tc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TenureEn)
                    .HasColumnName("tenure_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TenureSc)
                    .HasColumnName("tenure_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TenureTc)
                    .HasColumnName("tenure_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TermsEn)
                    .HasColumnName("terms_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TermsSc)
                    .HasColumnName("terms_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TermsTc)
                    .HasColumnName("terms_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Top)
                    .HasColumnName("top")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TransportEn)
                    .HasColumnName("transport_en")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TransportSc)
                    .HasColumnName("transport_sc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TransportTc)
                    .HasColumnName("transport_tc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('first','second','reassignment')")
                    .HasDefaultValueSql("'first'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UsageType)
                    .HasColumnName("usage_type")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.VideoUrls)
                    .HasColumnName("video_urls")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsCnNews>(entity =>
            {
                entity.ToTable("cms_cn_news");

                entity.HasIndex(e => e.City)
                    .HasName("city");

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentEn)
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentSc)
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromEn)
                    .HasColumnName("from_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromSc)
                    .HasColumnName("from_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromTc)
                    .HasColumnName("from_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCnRegion>(entity =>
            {
                entity.ToTable("cms_cn_region");

                entity.HasIndex(e => e.City)
                    .HasName("code");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'999'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsCompany>(entity =>
            {
                entity.ToTable("cms_company");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Districts)
                    .HasColumnName("districts")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsDiscount>(entity =>
            {
                entity.ToTable("cms_discount");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.RefSourceId)
                    .HasName("ref_source_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DetailImage)
                    .HasColumnName("detail_image")
                    .HasColumnType("int(8)");

                entity.Property(e => e.ExtraBtnTitle)
                    .HasColumnName("extra_btn_title")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtraBtnUrl)
                    .HasColumnName("extra_btn_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.MerchantEmail)
                    .HasColumnName("merchant_email")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MerchantTel)
                    .HasColumnName("merchant_tel")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MerchantUrl)
                    .HasColumnName("merchant_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RemarkBtnTitle)
                    .HasColumnName("remark_btn_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsDistrict>(entity =>
            {
                entity.ToTable("cms_district");

                entity.HasIndex(e => e.Area)
                    .HasName("area");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area")
                    .HasColumnType("enum('HK','KL','NT','OI')")
                    .HasDefaultValueSql("'NT'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefGohomeId)
                    .HasColumnName("ref_gohome_id")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefGohomePath)
                    .HasColumnName("ref_gohome_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsDistrict28hse>(entity =>
            {
                entity.ToTable("cms_district_28hse");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("mediumint(4) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefId)
                    .HasColumnName("ref_id")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefPath)
                    .HasColumnName("ref_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsDistrictGohome>(entity =>
            {
                entity.ToTable("cms_district_gohome");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefId)
                    .HasColumnName("ref_id")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RefPath)
                    .HasColumnName("ref_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsEmailTemplate>(entity =>
            {
                entity.ToTable("cms_email_template");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Mailtype)
                    .HasName("mailtype");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mailtype)
                    .IsRequired()
                    .HasColumnName("mailtype")
                    .HasColumnType("enum('html','plaintext')")
                    .HasDefaultValueSql("'html'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SenderEmail)
                    .HasColumnName("sender_email")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SenderName)
                    .HasColumnName("sender_name")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SenderPass)
                    .HasColumnName("sender_pass")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CmsEntityTags>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PRIMARY");

                entity.ToTable("cms_entity_tags");

                entity.HasIndex(e => e.Tag)
                    .HasName("tag")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsEntityTagsRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cms_entity_tags_relation");

                entity.HasIndex(e => e.Entity)
                    .HasName("entity");

                entity.HasIndex(e => e.EntityId)
                    .HasName("entity_id");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.TagId)
                    .HasName("tag_id");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasColumnName("entity")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .HasColumnType("bigint(10) unsigned");
            });

            modelBuilder.Entity<CmsErpSearchLog>(entity =>
            {
                entity.ToTable("cms_erp_search_log");

                entity.HasIndex(e => e.Datetime)
                    .HasName("datetime");

                entity.HasIndex(e => e.FiltersMd5)
                    .HasName("filters_md5")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.Result)
                    .HasName("result");

                entity.HasIndex(e => e.ResultNo)
                    .HasName("result_no")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Filters)
                    .IsRequired()
                    .HasColumnName("filters")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FiltersMd5)
                    .IsRequired()
                    .HasColumnName("filters_md5")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ResultNo)
                    .HasColumnName("result_no")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsErpTransaction>(entity =>
            {
                entity.ToTable("cms_erp_transaction");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.DocumentDate)
                    .HasName("document_date");

                entity.HasIndex(e => e.MemoNo)
                    .HasName("memo_no");

                entity.HasIndex(e => e.Mls2By)
                    .HasName("mls2_by");

                entity.HasIndex(e => e.RegDate)
                    .HasName("date");

                entity.HasIndex(e => e.SaleableArea)
                    .HasName("saleable_area");

                entity.HasIndex(e => e.Usage)
                    .HasName("estate_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.BuildingEn)
                    .HasColumnName("building_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingSc)
                    .HasColumnName("building_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingTc)
                    .IsRequired()
                    .HasColumnName("building_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("document_date")
                    .HasColumnType("date");

                entity.Property(e => e.DocumentNature)
                    .HasColumnName("document_nature")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Facing)
                    .HasColumnName("facing")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GrossArea)
                    .HasColumnName("gross_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GrossPrice)
                    .HasColumnName("gross_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Layout)
                    .HasColumnName("layout")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MemoNo)
                    .IsRequired()
                    .HasColumnName("memo_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mls2By)
                    .HasColumnName("mls2_by")
                    .HasColumnType("enum('tran','prop')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("date");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SaleableArea)
                    .HasColumnName("saleable_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SaleablePrice)
                    .HasColumnName("saleable_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StreetEn)
                    .HasColumnName("street_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StreetSc)
                    .HasColumnName("street_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StreetTc)
                    .HasColumnName("street_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Usage)
                    .IsRequired()
                    .HasColumnName("usage")
                    .HasColumnType("enum('R','C','O','P')")
                    .HasDefaultValueSql("'R'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.YearBuilt)
                    .HasColumnName("year_built")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.YearExpire)
                    .HasColumnName("year_expire")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsErpmLogDetail>(entity =>
            {
                entity.ToTable("cms_erpm_log_detail");

                entity.HasIndex(e => e.Datetime)
                    .HasName("created");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnName("user_agent")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsEstate>(entity =>
            {
                entity.ToTable("cms_estate");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.District28hse)
                    .HasName("district_28hse");

                entity.HasIndex(e => e.DistrictGeneral)
                    .HasName("district_general");

                entity.HasIndex(e => e.DistrictGohome)
                    .HasName("district_gohome");

                entity.HasIndex(e => e.Featured)
                    .HasName("featured");

                entity.HasIndex(e => e.IdGohome)
                    .HasName("id_gohome")
                    .IsUnique();

                entity.HasIndex(e => e.MatchingHouse730)
                    .HasName("matching_house730");

                entity.HasIndex(e => e.MatchingHouse730Estate)
                    .HasName("matching_house730_estate");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameSc)
                    .HasName("name_sc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PropertyTotal)
                    .HasName("property_total");

                entity.HasIndex(e => e.Source)
                    .HasName("source");

                entity.HasIndex(e => e.SqftBuildingId)
                    .HasName("sqft_building_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressSc)
                    .IsRequired()
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BlockTotal)
                    .HasColumnName("block_total")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Developer)
                    .HasColumnName("developer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.District28hse)
                    .HasColumnName("district_28hse")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.DistrictGeneral)
                    .IsRequired()
                    .HasColumnName("district_general")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DistrictGohome)
                    .HasColumnName("district_gohome")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Facility)
                    .HasColumnName("facility")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Featured)
                    .HasColumnName("featured")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.FloorPlans)
                    .IsRequired()
                    .HasColumnName("floor_plans")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdGohome)
                    .HasColumnName("id_gohome")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.MatchingHouse730)
                    .HasColumnName("matching_house730")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.MatchingHouse730Estate)
                    .HasColumnName("matching_house730_estate")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescEn)
                    .HasColumnName("meta_desc_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MetaDescSc)
                    .HasColumnName("meta_desc_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MetaDescTc)
                    .HasColumnName("meta_desc_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OccupationDate)
                    .HasColumnName("occupation_date")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photos)
                    .IsRequired()
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyTotal)
                    .HasColumnName("property_total")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RefSourcePath)
                    .IsRequired()
                    .HasColumnName("ref_source_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolNet)
                    .HasColumnName("school_net")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'gohome'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SqftBuildingId)
                    .HasColumnName("sqft_building_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitTotal)
                    .HasColumnName("unit_total")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsEstateOld>(entity =>
            {
                entity.ToTable("cms_estate_old");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.District28hse)
                    .HasName("district_28hse");

                entity.HasIndex(e => e.DistrictGeneral)
                    .HasName("district_general");

                entity.HasIndex(e => e.DistrictGohome)
                    .HasName("district_gohome");

                entity.HasIndex(e => e.Featured)
                    .HasName("featured");

                entity.HasIndex(e => e.IdGohome)
                    .HasName("id_gohome")
                    .IsUnique();

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en");

                entity.HasIndex(e => e.NameSc)
                    .HasName("name_sc");

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc");

                entity.HasIndex(e => e.Source)
                    .HasName("source");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressSc)
                    .IsRequired()
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTc)
                    .IsRequired()
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlockTotal)
                    .HasColumnName("block_total")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Developer)
                    .HasColumnName("developer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District28hse)
                    .HasColumnName("district_28hse")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.DistrictGeneral)
                    .IsRequired()
                    .HasColumnName("district_general")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictGohome)
                    .HasColumnName("district_gohome")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Facility)
                    .HasColumnName("facility")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Featured)
                    .HasColumnName("featured")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.FloorPlans)
                    .IsRequired()
                    .HasColumnName("floor_plans")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdGohome)
                    .HasColumnName("id_gohome")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OccupationDate)
                    .HasColumnName("occupation_date")
                    .HasColumnType("date");

                entity.Property(e => e.Photos)
                    .IsRequired()
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RefSourcePath)
                    .IsRequired()
                    .HasColumnName("ref_source_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolNet)
                    .HasColumnName("school_net")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'gohome'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitTotal)
                    .HasColumnName("unit_total")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsEstateTopic>(entity =>
            {
                entity.ToTable("cms_estate_topic");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(6) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estates)
                    .HasColumnName("estates")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsFiles>(entity =>
            {
                entity.ToTable("cms_files");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Filename)
                    .HasName("filename");

                entity.HasIndex(e => e.Folder)
                    .HasName("folder");

                entity.HasIndex(e => e.RefPath)
                    .HasName("ref_path");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => new { e.Folder, e.Filename })
                    .HasName("folder_filename");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filesize)
                    .HasColumnName("filesize")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'/'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Md5)
                    .IsRequired()
                    .HasColumnName("md5")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mime)
                    .IsRequired()
                    .HasColumnName("mime")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefId)
                    .HasColumnName("ref_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RefPath)
                    .HasColumnName("ref_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','removed')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThumbFid)
                    .HasColumnName("thumb_fid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("mediumint(5) unsigned");
            });

            modelBuilder.Entity<CmsFirsthand>(entity =>
            {
                entity.ToTable("cms_firsthand");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.PublishDate)
                    .HasName("publish_date");

                entity.HasIndex(e => e.RefSource)
                    .HasName("source");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Attachment)
                    .HasColumnName("attachment")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Developer)
                    .HasColumnName("developer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ImageHomefan)
                    .HasColumnName("image_homefan")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publish_date")
                    .HasColumnType("date");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YoutubeId)
                    .HasColumnName("youtube_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsFloorplan>(entity =>
            {
                entity.ToTable("cms_floorplan");

                entity.HasIndex(e => e.Block)
                    .HasName("blocks")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.BlockValues)
                    .HasName("block_values")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.EstateId)
                    .HasName("estate_id");

                entity.HasIndex(e => e.FloorValues)
                    .HasName("floor_values")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PhaseValues)
                    .HasName("phase_value")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.UnitValues)
                    .HasName("unit_values")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Block)
                    .HasColumnName("block")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BlockValues)
                    .HasColumnName("block_values")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.EstateId)
                    .HasColumnName("estate_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FloorValues)
                    .HasColumnName("floor_values")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PhaseValues)
                    .HasColumnName("phase_values")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UnitValues)
                    .HasColumnName("unit_values")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGoodwinSubscriber>(entity =>
            {
                entity.ToTable("cms_goodwin_subscriber");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Unsubscribed)
                    .HasName("unsubscribed");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','unsubscribed')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unsubscribed).HasColumnName("unsubscribed");
            });

            modelBuilder.Entity<CmsGwContent>(entity =>
            {
                entity.ToTable("cms_gw_content");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentEn)
                    .IsRequired()
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentSc)
                    .IsRequired()
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwHomeLuxury>(entity =>
            {
                entity.ToTable("cms_gw_home_luxury");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.Fid)
                    .HasName("fid");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("fid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwLink>(entity =>
            {
                entity.ToTable("cms_gw_link");

                entity.HasIndex(e => e.Area)
                    .HasName("area");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Title)
                    .HasName("title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("enum('HK','KL','NT','OI')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwPropertyFavourite>(entity =>
            {
                entity.ToTable("cms_gw_property_favourite");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.MemberId)
                    .HasName("member_id");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsGwads>(entity =>
            {
                entity.ToTable("cms_gwads");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwarticleAward>(entity =>
            {
                entity.ToTable("cms_gwarticle_award");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwblog>(entity =>
            {
                entity.ToTable("cms_gwblog");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwblogCategory>(entity =>
            {
                entity.ToTable("cms_gwblog_category");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwblogVideo>(entity =>
            {
                entity.ToTable("cms_gwblog_video");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("mediumint(4) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ThumbFid)
                    .HasColumnName("thumb_fid")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsGwcustomerLikes>(entity =>
            {
                entity.ToTable("cms_gwcustomer_likes");

                entity.HasIndex(e => e.Agents)
                    .HasName("agents");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Customer)
                    .HasName("customer");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Agents)
                    .IsRequired()
                    .HasColumnName("agents")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentsName)
                    .IsRequired()
                    .HasColumnName("agents_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasColumnName("customer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwloyaltyShops>(entity =>
            {
                entity.ToTable("cms_gwloyalty_shops");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Banner)
                    .HasColumnName("banner")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwnews>(entity =>
            {
                entity.ToTable("cms_gwnews");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwpresents>(entity =>
            {
                entity.ToTable("cms_gwpresents");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsGwtips>(entity =>
            {
                entity.ToTable("cms_gwtips");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsHomeNews>(entity =>
            {
                entity.ToTable("cms_home_news");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsHomeTrannews>(entity =>
            {
                entity.ToTable("cms_home_trannews");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlAgent>(entity =>
            {
                entity.ToTable("cms_intl_agent");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Slug)
                    .HasName("slug")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Title)
                    .HasName("title");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("description_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionSc)
                    .HasColumnName("description_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionTc)
                    .HasColumnName("description_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .IsRequired()
                    .HasColumnName("name_sc")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Projects)
                    .HasColumnName("projects")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Signature)
                    .HasColumnName("signature")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Slug)
                    .HasColumnName("slug")
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UrlLinkedin)
                    .HasColumnName("url_linkedin")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorksEn)
                    .HasColumnName("works_en")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorksSc)
                    .HasColumnName("works_sc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorksTc)
                    .HasColumnName("works_tc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsIntlBlog>(entity =>
            {
                entity.ToTable("cms_intl_blog");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.City)
                    .HasName("city");

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentEn)
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentSc)
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlBrochureUser>(entity =>
            {
                entity.ToTable("cms_intl_brochure_user");

                entity.HasIndex(e => e.InterestCountry)
                    .HasName("interest_country");

                entity.HasIndex(e => e.Subscribe)
                    .HasName("notification_email_sent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AgentString)
                    .HasColumnName("agent_string")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InterestCountry)
                    .HasColumnName("interest_country")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Subscribe)
                    .HasColumnName("subscribe")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("enum('mr','ms','mrs','miss')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UtmData)
                    .HasColumnName("utm_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsIntlClientRecognition>(entity =>
            {
                entity.ToTable("cms_intl_client_recognition");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasColumnName("client_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlContact>(entity =>
            {
                entity.ToTable("cms_intl_contact");

                entity.HasIndex(e => e.FromSite)
                    .HasName("from_site");

                entity.HasIndex(e => e.NotificationEmailSent)
                    .HasName("notification_email_sent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AgentString)
                    .HasColumnName("agent_string")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FromSite)
                    .HasColumnName("from_site")
                    .HasColumnType("enum('default','uk')")
                    .HasDefaultValueSql("'default'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KnownFrom)
                    .HasColumnName("known_from")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NotificationEmailSent)
                    .HasColumnName("notification_email_sent")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UtmData)
                    .HasColumnName("utm_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsIntlContent>(entity =>
            {
                entity.ToTable("cms_intl_content");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentEn)
                    .IsRequired()
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentSc)
                    .IsRequired()
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlDeveloperRecognition>(entity =>
            {
                entity.ToTable("cms_intl_developer_recognition");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Developer)
                    .HasColumnName("developer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlEvent>(entity =>
            {
                entity.ToTable("cms_intl_event");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.HasIndex(e => e.DateEnd)
                    .HasName("date_end");

                entity.HasIndex(e => e.DateStart)
                    .HasName("date_start");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("date");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlHomeBanner>(entity =>
            {
                entity.ToTable("cms_intl_home_banner");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("property_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.ImageDesktop)
                    .HasColumnName("image_desktop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ImageMobile)
                    .HasColumnName("image_mobile")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(5)");

                entity.Property(e => e.PropertyId)
                    .HasColumnName("property_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlMediaReport>(entity =>
            {
                entity.ToTable("cms_intl_media_report");

                entity.HasIndex(e => e.City)
                    .HasName("city");

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.FromEn)
                    .HasName("from_en");

                entity.HasIndex(e => e.FromSc)
                    .HasName("from_sc");

                entity.HasIndex(e => e.FromTc)
                    .HasName("from_tc");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentEn)
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentSc)
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromEn)
                    .HasColumnName("from_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromSc)
                    .HasColumnName("from_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromTc)
                    .HasColumnName("from_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsIntlOne2one>(entity =>
            {
                entity.ToTable("cms_intl_one2one");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.FirsthandId)
                    .HasName("property_id");

                entity.HasIndex(e => e.FirsthandName)
                    .HasName("property_title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Tel)
                    .HasName("tel");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FirsthandId)
                    .HasColumnName("firsthand_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.FirsthandName)
                    .IsRequired()
                    .HasColumnName("firsthand_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UtmData)
                    .HasColumnName("utm_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsIntlSubscriber>(entity =>
            {
                entity.ToTable("cms_intl_subscriber");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UtmData)
                    .HasColumnName("utm_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsLineCallback>(entity =>
            {
                entity.ToTable("cms_line_callback");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasColumnName("mid")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsLineReply>(entity =>
            {
                entity.ToTable("cms_line_reply");

                entity.HasIndex(e => e.LogId)
                    .HasName("log_id");

                entity.HasIndex(e => e.ReplyTo)
                    .HasName("reply_to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.ReplyTo)
                    .IsRequired()
                    .HasColumnName("reply_to")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsLineUserBind>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PRIMARY");

                entity.ToTable("cms_line_user_bind");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidCode)
                    .IsRequired()
                    .HasColumnName("valid_code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidDate).HasColumnName("valid_date");

                entity.Property(e => e.Valided)
                    .HasColumnName("valided")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<CmsLogAction>(entity =>
            {
                entity.ToTable("cms_log_action");

                entity.HasIndex(e => e.Action)
                    .HasName("action");

                entity.HasIndex(e => e.DataId)
                    .HasName("data_id");

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.Model)
                    .HasName("model");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DataId)
                    .HasColumnName("data_id")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataNew)
                    .IsRequired()
                    .HasColumnName("data_new")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataOld)
                    .IsRequired()
                    .HasColumnName("data_old")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsLogFace>(entity =>
            {
                entity.ToTable("cms_log_face");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Result)
                    .HasName("result");

                entity.HasIndex(e => e.UserAgent)
                    .HasName("user_agent")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PictureData)
                    .IsRequired()
                    .HasColumnName("picture_data")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ResultLog)
                    .IsRequired()
                    .HasColumnName("result_log")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnName("user_agent")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsLogGwplusUserLogin>(entity =>
            {
                entity.ToTable("cms_log_gwplus_user_login");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => e.Mid)
                    .HasName("mid");

                entity.HasIndex(e => e.Result)
                    .HasName("result");

                entity.HasIndex(e => e.UserAgent)
                    .HasName("user_agent")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasColumnName("mid")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnName("user_agent")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsLogLogin>(entity =>
            {
                entity.ToTable("cms_log_login");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CmsLogPropertyShareview>(entity =>
            {
                entity.ToTable("cms_log_property_shareview");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasColumnName("agent")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnName("lang")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsLoyalty>(entity =>
            {
                entity.ToTable("cms_loyalty");

                entity.HasIndex(e => e.Agent)
                    .HasName("agent");

                entity.HasIndex(e => e.CustomerMonth)
                    .HasName("customer_month");

                entity.HasIndex(e => e.DateUpdate)
                    .HasName("date_update");

                entity.HasIndex(e => e.Email2)
                    .HasName("email2");

                entity.HasIndex(e => e.Email2Validated)
                    .HasName("email2_validated");

                entity.HasIndex(e => e.EmailInvalid)
                    .HasName("email_invalid");

                entity.HasIndex(e => e.EmailValidated)
                    .HasName("email_validated");

                entity.HasIndex(e => e.GoodwinplusSent)
                    .HasName("goodwinplus_sent");

                entity.HasIndex(e => e.GoodwinplusUpdated)
                    .HasName("goodwinplus_updated");

                entity.HasIndex(e => e.IsCustomer)
                    .HasName("is_customer");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.TheclubId)
                    .HasName("theclub_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.AcceptAd)
                    .HasColumnName("accept_ad")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Campain)
                    .HasColumnName("campain")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CustomerMonth)
                    .HasColumnName("customer_month")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomerYear)
                    .HasColumnName("customer_year")
                    .HasColumnType("year(4)");

                entity.Property(e => e.DateReg).HasColumnName("date_reg");

                entity.Property(e => e.DateUpdate).HasColumnName("date_update");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Education)
                    .HasColumnName("education")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Email2Validated)
                    .HasColumnName("email2_validated")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailInvalid)
                    .HasColumnName("email_invalid")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.EmailValidated)
                    .HasColumnName("email_validated")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailVcode)
                    .HasColumnName("email_vcode")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExpectInfo)
                    .HasColumnName("expect_info")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FamilyIncome)
                    .HasColumnName("family_income")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodwinplusSent)
                    .HasColumnName("goodwinplus_sent")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GoodwinplusUpdated)
                    .HasColumnName("goodwinplus_updated")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Hkid)
                    .HasColumnName("hkid")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Income)
                    .HasColumnName("income")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCustomer)
                    .HasColumnName("is_customer")
                    .HasColumnType("enum('yes','no')")
                    .HasDefaultValueSql("'no'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsOpened)
                    .HasColumnName("is_opened")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsReadPolicy)
                    .HasColumnName("is_read_policy")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LivingArea)
                    .HasColumnName("living_area")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.No)
                    .HasColumnName("no")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(63)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Present)
                    .HasColumnName("present")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QtySent)
                    .HasColumnName("qty_sent")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Referer)
                    .HasColumnName("referer")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Src)
                    .HasColumnName("src")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TheclubId)
                    .HasColumnName("theclub_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsLoyaltyCoupon>(entity =>
            {
                entity.ToTable("cms_loyalty_coupon");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.ButtonText)
                    .HasColumnName("button_text")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ButtonUrl)
                    .IsRequired()
                    .HasColumnName("button_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CouponImage)
                    .HasColumnName("coupon_image")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Terms)
                    .IsRequired()
                    .HasColumnName("terms")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsLoyaltyOwner>(entity =>
            {
                entity.ToTable("cms_loyalty_owner");

                entity.HasIndex(e => e.Agent)
                    .HasName("agent");

                entity.HasIndex(e => e.AutoRegister)
                    .HasName("auto_register");

                entity.HasIndex(e => e.EmailValidated)
                    .HasName("email_validated");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AutoRegister)
                    .HasColumnName("auto_register")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Campaign)
                    .HasColumnName("campaign")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailValidated)
                    .HasColumnName("email_validated")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.EmailVcode)
                    .HasColumnName("email_vcode")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsReadPolicy)
                    .HasColumnName("is_read_policy")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(63)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Referer)
                    .HasColumnName("referer")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsLoyaltyPoints>(entity =>
            {
                entity.ToTable("cms_loyalty_points");

                entity.HasIndex(e => e.Action)
                    .HasName("action");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Points)
                    .HasName("points");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Url)
                    .HasName("url")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("mediumint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsNotificationGcm>(entity =>
            {
                entity.ToTable("cms_notification_gcm");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegistrationId)
                    .IsRequired()
                    .HasColumnName("registration_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeGot).HasColumnName("time_got");

                entity.Property(e => e.TimeRead).HasColumnName("time_read");

                entity.Property(e => e.TimeSent).HasColumnName("time_sent");
            });

            modelBuilder.Entity<CmsNotificationMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cms_notification_match");

                entity.HasIndex(e => new { e.Email, e.RegistrationId })
                    .HasName("email");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasColumnName("device")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegistrationId)
                    .IsRequired()
                    .HasColumnName("registration_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsPageSocialThumb>(entity =>
            {
                entity.ToTable("cms_page_social_thumb");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.Image)
                    .HasName("image");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(5000)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsProperty>(entity =>
            {
                entity.ToTable("cms_property");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.AgentId2)
                    .HasName("agent_id2");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("company_id");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.DescriptionTc)
                    .HasName("description_tc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.EstateId)
                    .HasName("estate_id");

                entity.HasIndex(e => e.FacilityTags)
                    .HasName("facility_tags");

                entity.HasIndex(e => e.FeatureTags)
                    .HasName("feature_tags");

                entity.HasIndex(e => e.GrossArea)
                    .HasName("gross_area");

                entity.HasIndex(e => e.InputDate)
                    .HasName("input_date");

                entity.HasIndex(e => e.LogicErrors)
                    .HasName("logic_errors")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Mls2AgmtRent)
                    .HasName("mls2_agmt_rent")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Mls2AgmtVend)
                    .HasName("mls2_agmt_vend")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Mls2DateExpiry)
                    .HasName("mls2_date_expiry");

                entity.HasIndex(e => e.Mls2DateExpiryRent)
                    .HasName("mls2_date_expiry_rent");

                entity.HasIndex(e => e.Mls2Eaa)
                    .HasName("mls_eaa")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Mls2EaaExpiry)
                    .HasName("mls_eaa_expired");

                entity.HasIndex(e => e.Mls2InstanceId)
                    .HasName("mls2_instance_id");

                entity.HasIndex(e => e.Mls2Status)
                    .HasName("mls2_status");

                entity.HasIndex(e => e.NameEn)
                    .HasName("name_en")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameSc)
                    .HasName("name_sc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.NameTc)
                    .HasName("name_tc")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.OverrideRules)
                    .HasName("override_rules");

                entity.HasIndex(e => e.PriceRent)
                    .HasName("price_rent");

                entity.HasIndex(e => e.PriceSale)
                    .HasName("price_sale");

                entity.HasIndex(e => e.PropertyType)
                    .HasName("property_type");

                entity.HasIndex(e => e.PropertyUsage)
                    .HasName("property_usage");

                entity.HasIndex(e => e.RefSource)
                    .HasName("ref_source");

                entity.HasIndex(e => e.SaleableArea)
                    .HasName("saleable_area");

                entity.HasIndex(e => e.SkDistrict)
                    .HasName("sk_district");

                entity.HasIndex(e => e.SkipPublish)
                    .HasName("skip_publish");

                entity.HasIndex(e => e.SoleAgency)
                    .HasName("sole_agency");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.HasIndex(e => e.Url360)
                    .HasName("url_360");

                entity.HasIndex(e => e.UrlVr)
                    .HasName("url_vr");

                entity.HasIndex(e => e.ViewCount)
                    .HasName("view_count");

                entity.HasIndex(e => e.ViewTags)
                    .HasName("view_tags");

                entity.HasIndex(e => e.VrAgent)
                    .HasName("vr_agent");

                entity.HasIndex(e => e.WithTenancy)
                    .HasName("with_tenancy");

                entity.HasIndex(e => e._28happyTags)
                    .HasName("28share_tags")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => new { e.BuildingOriginalTc, e.BuildingOriginalSc, e.BuildingOriginalEn })
                    .HasName("building_original")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191, 191, 191 });

                entity.HasIndex(e => new { e.BuildingSc, e.BuildingTc, e.BuildingEn })
                    .HasName("building")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191, 191, 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddressEn)
                    .HasColumnName("address_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressSc)
                    .HasColumnName("address_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddressTc)
                    .HasColumnName("address_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AgentId2)
                    .HasColumnName("agent_id2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Bathrooms)
                    .HasColumnName("bathrooms")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Bedrooms)
                    .HasColumnName("bedrooms")
                    .HasColumnType("int(2) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Block)
                    .HasColumnName("block")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingEn)
                    .HasColumnName("building_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingOriginalEn)
                    .HasColumnName("building_original_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingOriginalSc)
                    .HasColumnName("building_original_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingOriginalTc)
                    .HasColumnName("building_original_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingSc)
                    .HasColumnName("building_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BuildingTc)
                    .HasColumnName("building_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CombinedFid)
                    .HasColumnName("combined_fid")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("contact_person")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactTel)
                    .HasColumnName("contact_tel")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("description_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionSc)
                    .HasColumnName("description_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DescriptionTc)
                    .HasColumnName("description_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ensuites)
                    .HasColumnName("ensuites")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("套房數");

                entity.Property(e => e.EstateId)
                    .HasColumnName("estate_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FacilityTags)
                    .HasColumnName("facility_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeatureTags)
                    .HasColumnName("feature_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FlatType)
                    .HasColumnName("flat_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FloorLevel)
                    .HasColumnName("floor_level")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GrossArea)
                    .HasColumnName("gross_area")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HitTags)
                    .HasColumnName("hit_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputDate).HasColumnName("input_date");

                entity.Property(e => e.LogicErrors)
                    .HasColumnName("logic_errors")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MapLat)
                    .HasColumnName("map_lat")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapLon)
                    .HasColumnName("map_lon")
                    .HasColumnType("decimal(20,15)");

                entity.Property(e => e.MapZoom)
                    .HasColumnName("map_zoom")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.MewmeVr)
                    .HasColumnName("mewme_vr")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mls2AgmtRent)
                    .HasColumnName("mls2_agmt_rent")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mls2AgmtVend)
                    .HasColumnName("mls2_agmt_vend")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mls2BuildingId)
                    .HasColumnName("mls2_building_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mls2DateExpiry)
                    .HasColumnName("mls2_date_expiry")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Mls2DateExpiryRent)
                    .HasColumnName("mls2_date_expiry_rent")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Mls2Eaa)
                    .HasColumnName("mls2_eaa")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Mls2EaaExpiry)
                    .HasColumnName("mls2_eaa_expiry")
                    .HasColumnType("date");

                entity.Property(e => e.Mls2InstanceId)
                    .HasColumnName("mls2_instance_id")
                    .HasColumnType("enum('goodwin','homefantasy','fortunesix')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mls2Status)
                    .HasColumnName("mls2_status")
                    .HasColumnType("enum('L','S','I','B','D','F','O','T','U')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mls2StatusTime).HasColumnName("mls2_status_time");

                entity.Property(e => e.MlsAgtcode)
                    .HasColumnName("mls_agtcode")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MlsRefno)
                    .HasColumnName("mls_refno")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameTc)
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OverrideRules)
                    .HasColumnName("override_rules")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("override rules such as eaa ...");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photos360)
                    .HasColumnName("photos_360")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photos360Agent)
                    .HasColumnName("photos_360_agent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceHos)
                    .HasColumnName("price_hos")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PriceRent)
                    .HasColumnName("price_rent")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.PriceSale)
                    .HasColumnName("price_sale")
                    .HasColumnType("decimal(6,3) unsigned")
                    .HasComment("百萬");

                entity.Property(e => e.PropertyType)
                    .HasColumnName("property_type")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasComment("物業種類");

                entity.Property(e => e.PropertyUsage)
                    .HasColumnName("property_usage")
                    .HasColumnType("enum('R','C','O','I','P','M','A','U','V','H','T','W','D','B')")
                    .HasDefaultValueSql("'R'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'goodwin'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.RefSourcePhotos)
                    .HasColumnName("ref_source_photos")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SaleableArea)
                    .HasColumnName("saleable_area")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SkDistrict)
                    .HasColumnName("sk_district")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SkTags)
                    .HasColumnName("sk_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SkipPublish)
                    .HasColumnName("skip_publish")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SoleAgency)
                    .HasColumnName("sole_agency")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled','suspend')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url360)
                    .HasColumnName("url_360")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url360Agent)
                    .HasColumnName("url_360_agent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UrlVideo)
                    .HasColumnName("url_video")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlVideoAgent)
                    .HasColumnName("url_video_agent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UrlVideoThumb)
                    .HasColumnName("url_video_thumb")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.UrlVr)
                    .HasColumnName("url_vr")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VideoVr)
                    .HasColumnName("video_vr")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ViewCount)
                    .HasColumnName("view_count")
                    .HasColumnType("bigint(12) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ViewCountCookie)
                    .HasColumnName("view_count_cookie")
                    .HasColumnType("bigint(12) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ViewTags)
                    .HasColumnName("view_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VrAgent)
                    .HasColumnName("vr_agent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.VrThumb)
                    .HasColumnName("vr_thumb")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.WithTenancy)
                    .HasColumnName("with_tenancy")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e._28happyTags)
                    .HasColumnName("28happy_tags")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsPropertyAdClicked>(entity =>
            {
                entity.ToTable("cms_property_ad_clicked");

                entity.HasIndex(e => e.Campaign)
                    .HasName("campaign");

                entity.HasIndex(e => e.CampaignReferer)
                    .HasName("campaign_referer");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Campaign)
                    .IsRequired()
                    .HasColumnName("campaign")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CampaignReferer)
                    .HasColumnName("campaign_referer")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefererUrl)
                    .HasColumnName("referer_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsPropertyVideo>(entity =>
            {
                entity.ToTable("cms_property_video");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.ThumbFid)
                    .HasName("thumb_fid");

                entity.HasIndex(e => e.Title)
                    .HasName("title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ThumbFid)
                    .HasColumnName("thumb_fid")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsPublish28hse>(entity =>
            {
                entity.HasKey(e => e.StockNo)
                    .HasName("PRIMARY");

                entity.ToTable("cms_publish_28hse");

                entity.HasIndex(e => e.GoldTop)
                    .HasName("gold_top");

                entity.HasIndex(e => e.Rerank)
                    .HasName("rerank");

                entity.HasIndex(e => e.Top)
                    .HasName("top");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentEmail)
                    .IsRequired()
                    .HasColumnName("agent_email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoldTop).HasColumnName("gold_top");

                entity.Property(e => e.Normal)
                    .HasColumnName("normal")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.NormalDatetime).HasColumnName("normal_datetime");

                entity.Property(e => e.Rerank)
                    .HasColumnName("rerank")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.SetDatetime).HasColumnName("set_datetime");

                entity.Property(e => e.Top).HasColumnName("top");

                entity.Property(e => e.TopDatetime).HasColumnName("top_datetime");
            });

            modelBuilder.Entity<CmsPublishC21Photo>(entity =>
            {
                entity.HasKey(e => e.Filename)
                    .HasName("PRIMARY");

                entity.ToTable("cms_publish_c21_photo");

                entity.HasIndex(e => e.Destination)
                    .HasName("destination");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasColumnName("destination")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uploaded).HasColumnName("uploaded");
            });

            modelBuilder.Entity<CmsPublishC21PhotoBk>(entity =>
            {
                entity.HasKey(e => e.Filename)
                    .HasName("PRIMARY");

                entity.ToTable("cms_publish_c21_photo_bk");

                entity.HasIndex(e => e.Destination)
                    .HasName("destination");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasColumnName("destination")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uploaded).HasColumnName("uploaded");
            });

            modelBuilder.Entity<CmsPublishHouse730>(entity =>
            {
                entity.ToTable("cms_publish_house730");

                entity.HasIndex(e => e.BatchId)
                    .HasName("batch_id");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsPublishSqft>(entity =>
            {
                entity.HasKey(e => e.StockNo)
                    .HasName("PRIMARY");

                entity.ToTable("cms_publish_sqft");

                entity.HasIndex(e => e.Datetime)
                    .HasName("datetime");

                entity.HasIndex(e => e.Grade)
                    .HasName("grade");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasColumnName("grade")
                    .HasColumnType("enum('normal','golden')")
                    .HasDefaultValueSql("'normal'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsPublishSqftCategory>(entity =>
            {
                entity.ToTable("cms_publish_sqft_category");

                entity.HasIndex(e => e.ParentCatId)
                    .HasName("parent_cat_id");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasColumnName("addr")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AddrEng)
                    .IsRequired()
                    .HasColumnName("addr_eng")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NameEng)
                    .IsRequired()
                    .HasColumnName("name_eng")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ParentCatId)
                    .HasColumnName("parent_cat_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('area','district','building')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.ParentCat)
                    .WithMany(p => p.InverseParentCat)
                    .HasForeignKey(d => d.ParentCatId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sqft_category_parent");
            });

            modelBuilder.Entity<CmsPublishSqftOld>(entity =>
            {
                entity.ToTable("cms_publish_sqft_old");

                entity.HasIndex(e => e.BatchId)
                    .HasName("batch_id");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsPublishSqftResult>(entity =>
            {
                entity.ToTable("cms_publish_sqft_result");

                entity.HasIndex(e => e.AdId)
                    .HasName("ad_id");

                entity.HasIndex(e => e.ExpiredAt)
                    .HasName("expired_at");

                entity.HasIndex(e => e.Grade)
                    .HasName("publish_grade");

                entity.HasIndex(e => e.PublishStatus)
                    .HasName("publish_status");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => new { e.StockNo, e.Type })
                    .HasName("stock_no_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.AdId)
                    .HasColumnName("ad_id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AdStatus)
                    .HasColumnName("ad_status")
                    .HasColumnType("enum('normal','sold','freeze','hidden','rented')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AdUrl)
                    .HasColumnName("ad_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiredAt).HasColumnName("expired_at");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("enum('normal','golden')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PublishError)
                    .HasColumnName("publish_error")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PublishStatus)
                    .IsRequired()
                    .HasColumnName("publish_status")
                    .HasColumnType("enum('uploaded','published')")
                    .HasDefaultValueSql("'uploaded'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PublishedAt).HasColumnName("published_at");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('sale','rental')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CmsSessions>(entity =>
            {
                entity.ToTable("cms_sessions");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("cms_sessions_timestamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("blob");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CmsStaffHandbook>(entity =>
            {
                entity.ToTable("cms_staff_handbook");

                entity.HasIndex(e => e.Chapter)
                    .HasName("chapter");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Chapter)
                    .HasColumnName("chapter")
                    .HasColumnType("enum('GUIDELINE','WELFARE','COMMISSION','FOUR_GUARANTEE','DAILY_WORK','SAIKUNG_WORK','REFER_CHINA')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsStaffRules>(entity =>
            {
                entity.ToTable("cms_staff_rules");

                entity.HasIndex(e => e.Chapter)
                    .HasName("chapter");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Chapter)
                    .HasColumnName("chapter")
                    .HasColumnType("enum('RULES')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsSyncAccessKey>(entity =>
            {
                entity.ToTable("cms_sync_access_key");

                entity.HasIndex(e => e.AccessKey)
                    .HasName("key");

                entity.HasIndex(e => e.Party)
                    .HasName("party");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.AccessKey)
                    .IsRequired()
                    .HasColumnName("access_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsSyncAccessLog>(entity =>
            {
                entity.ToTable("cms_sync_access_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'2'")
                    .HasComment("1-success,2-failed");
            });

            modelBuilder.Entity<CmsSyncProcessLog>(entity =>
            {
                entity.ToTable("cms_sync_process_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasColumnName("entity")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntityData)
                    .IsRequired()
                    .HasColumnName("entity_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsSyncPropertyLog>(entity =>
            {
                entity.HasKey(e => e.StockNo)
                    .HasName("PRIMARY");

                entity.ToTable("cms_sync_property_log");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataHash)
                    .IsRequired()
                    .HasColumnName("data_hash")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataHashOld)
                    .IsRequired()
                    .HasColumnName("data_hash_old")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataOld)
                    .IsRequired()
                    .HasColumnName("data_old")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhotoHash)
                    .IsRequired()
                    .HasColumnName("photo_hash")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhotoHashOld)
                    .IsRequired()
                    .HasColumnName("photo_hash_old")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhotoOld)
                    .IsRequired()
                    .HasColumnName("photo_old")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsTag>(entity =>
            {
                entity.ToTable("cms_tag");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(6) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .IsRequired()
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SourceRid)
                    .HasColumnName("source_rid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsTopic>(entity =>
            {
                entity.ToTable("cms_topic");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Creator)
                    .HasName("creator");

                entity.HasIndex(e => e.LiveUpdate)
                    .HasName("live_update");

                entity.HasIndex(e => e.Privacy)
                    .HasName("privacy");

                entity.HasIndex(e => e.ShareBranches)
                    .HasName("share_branches")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.ShareModify)
                    .HasName("share_modify");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Banner)
                    .HasColumnName("banner")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filter)
                    .IsRequired()
                    .HasColumnName("filter")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FilterExclude)
                    .IsRequired()
                    .HasColumnName("filter_exclude")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiveUpdate)
                    .HasColumnName("live_update")
                    .HasColumnType("enum('yes','no')")
                    .HasDefaultValueSql("'no'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderBy)
                    .IsRequired()
                    .HasColumnName("order_by")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Privacy)
                    .HasColumnName("privacy")
                    .HasColumnType("enum('private','public')")
                    .HasDefaultValueSql("'private'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShareBranches)
                    .IsRequired()
                    .HasColumnName("share_branches")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShareModify)
                    .HasColumnName("share_modify")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsTopicProperties>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cms_topic_properties");

                entity.HasIndex(e => e.Clicks)
                    .HasName("clicks");

                entity.HasIndex(e => e.Hidden)
                    .HasName("hidden");

                entity.HasIndex(e => e.Id)
                    .HasName("id");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Score)
                    .HasName("score");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.TopicId)
                    .HasName("topic_id");

                entity.Property(e => e.Clicks)
                    .HasColumnName("clicks")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoverFid)
                    .HasColumnName("cover_fid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TopicId)
                    .HasColumnName("topic_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsTopicPropertyClicks>(entity =>
            {
                entity.ToTable("cms_topic_property_clicks");

                entity.HasIndex(e => e.ClientIp)
                    .HasName("client_ip");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.IsMobile)
                    .HasName("is_mobile");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Template)
                    .HasName("template");

                entity.HasIndex(e => e.TopicId)
                    .HasName("topic_code");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.ClientAgent)
                    .HasColumnName("client_agent")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientPlatform)
                    .HasColumnName("client_platform")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientReferrer)
                    .HasColumnName("client_referrer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompaignReferrer)
                    .HasColumnName("compaign_referrer")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.IsMobile)
                    .HasColumnName("is_mobile")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TopicId)
                    .HasColumnName("topic_id")
                    .HasColumnType("int(8) unsigned");
            });

            modelBuilder.Entity<CmsTrannews>(entity =>
            {
                entity.ToTable("cms_trannews");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsTransaction>(entity =>
            {
                entity.ToTable("cms_transaction");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.EstateType)
                    .HasName("estate_type");

                entity.HasIndex(e => e.FloorNum)
                    .HasName("floor_num");

                entity.HasIndex(e => e.Mls2By)
                    .HasName("mls2_by");

                entity.HasIndex(e => e.PremiumPaid)
                    .HasName("premium_paid");

                entity.HasIndex(e => e.SaleableArea)
                    .HasName("saleable_area");

                entity.HasIndex(e => e.SkDistrict)
                    .HasName("sk_district");

                entity.HasIndex(e => e.SkVillage)
                    .HasName("sk_village");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12) unsigned");

                entity.Property(e => e.BuildingEn)
                    .HasColumnName("building_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuildingSc)
                    .HasColumnName("building_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuildingTc)
                    .IsRequired()
                    .HasColumnName("building_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictGroup)
                    .HasColumnName("district_group")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstateType)
                    .HasColumnName("estate_type")
                    .HasColumnType("enum('private','village','scheme','other')")
                    .HasDefaultValueSql("'private'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Floor)
                    .HasColumnName("floor")
                    .HasColumnType("enum('high','middle','low')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FloorNum)
                    .HasColumnName("floor_num")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.GrossArea)
                    .HasColumnName("gross_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GrossPrice)
                    .HasColumnName("gross_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mls2By)
                    .HasColumnName("mls2_by")
                    .HasColumnType("enum('tran','prop')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PremiumPaid)
                    .HasColumnName("premium_paid")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("已補地價");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.RefSource)
                    .HasColumnName("ref_source")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefSourceId)
                    .HasColumnName("ref_source_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SaleableArea)
                    .HasColumnName("saleable_area")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SaleablePrice)
                    .HasColumnName("saleable_price")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SkDistrict)
                    .HasColumnName("sk_district")
                    .HasColumnType("mediumint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SkVillage)
                    .HasColumnName("sk_village")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("enum('rent','sale')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.YearBuilt)
                    .HasColumnName("year_built")
                    .HasColumnType("mediumint(4) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CmsTree>(entity =>
            {
                entity.ToTable("cms_tree");

                entity.HasIndex(e => e.Parent)
                    .HasName("parent");

                entity.HasIndex(e => e.SourceRid)
                    .HasName("source_rid");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameSc)
                    .HasColumnName("name_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameTc)
                    .HasColumnName("name_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SourceRid)
                    .HasColumnName("source_rid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<CmsUrl>(entity =>
            {
                entity.ToTable("cms_url");

                entity.HasIndex(e => e.AgentEmail)
                    .HasName("agent_id");

                entity.HasIndex(e => e.BranchId)
                    .HasName("branch_id");

                entity.HasIndex(e => e.Campaign)
                    .HasName("campaign")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.CampaignId)
                    .HasName("campaign_id");

                entity.HasIndex(e => e.OtherSource)
                    .HasName("other_source");

                entity.HasIndex(e => e.ShortKey)
                    .HasName("short_key")
                    .IsUnique();

                entity.HasIndex(e => e.Source)
                    .HasName("source");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.StockNo)
                    .HasName("stock_no");

                entity.HasIndex(e => e.Title)
                    .HasName("title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => e.UserEmail)
                    .HasName("user_email");

                entity.HasIndex(e => e.UtmMedium)
                    .HasName("utm_mediumn")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(12) unsigned");

                entity.Property(e => e.AgentEmail)
                    .HasColumnName("agent_email")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branch_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Campaign)
                    .IsRequired()
                    .HasColumnName("campaign")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OtherSource)
                    .HasColumnName("other_source")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PostUrl)
                    .HasColumnName("post_url")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShortKey)
                    .IsRequired()
                    .HasColumnName("short_key")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('url','tel','whatsapp')")
                    .HasDefaultValueSql("'url'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UtmMedium)
                    .HasColumnName("utm_medium")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsUsers>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("cms_users");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("company_id");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Username)
                    .HasName("username");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(5) unsigned");

                entity.Property(e => e.Branches)
                    .IsRequired()
                    .HasColumnName("branches")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gmail)
                    .HasColumnName("gmail")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("enum('admin','company_admin','director','dmanager','manager','agent','clerk','webcms_admin','admin_dept','china_dept','overseas_dept','agent_no_license','test')")
                    .HasDefaultValueSql("'agent'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsVideoUrl>(entity =>
            {
                entity.ToTable("cms_video_url");

                entity.HasIndex(e => e.Created)
                    .HasName("created");

                entity.HasIndex(e => e.Entity)
                    .HasName("entity");

                entity.HasIndex(e => e.EntityId)
                    .HasName("entity_id");

                entity.HasIndex(e => e.Priority)
                    .HasName("priority");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Updated)
                    .HasName("updated");

                entity.HasIndex(e => new { e.Entity, e.EntityId, e.Status })
                    .HasName("entity_entity_id_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasColumnName("entity")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ThumbFid)
                    .HasColumnName("thumb_fid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsVnews>(entity =>
            {
                entity.ToTable("cms_vnews");

                entity.HasIndex(e => e.Category)
                    .HasName("category");

                entity.HasIndex(e => e.Date)
                    .HasName("date");

                entity.HasIndex(e => e.District)
                    .HasName("district");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("enum('market')")
                    .HasDefaultValueSql("'market'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentEn)
                    .IsRequired()
                    .HasColumnName("content_en")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentSc)
                    .IsRequired()
                    .HasColumnName("content_sc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentTc)
                    .IsRequired()
                    .HasColumnName("content_tc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(5) unsigned");

                entity.Property(e => e.FbDesc)
                    .HasColumnName("fb_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FbImage)
                    .HasColumnName("fb_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FbTitle)
                    .HasColumnName("fb_title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubtitleEn)
                    .HasColumnName("subtitle_en")
                    .HasColumnType("varchar(600)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubtitleSc)
                    .HasColumnName("subtitle_sc")
                    .HasColumnType("varchar(600)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubtitleTc)
                    .HasColumnName("subtitle_tc")
                    .HasColumnType("varchar(600)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ThumbFid)
                    .HasColumnName("thumb_fid")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleSc)
                    .HasColumnName("title_sc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TitleTc)
                    .IsRequired()
                    .HasColumnName("title_tc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasColumnName("video_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsWebConversion>(entity =>
            {
                entity.ToTable("cms_web_conversion");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.AgentName)
                    .HasName("agent_name");

                entity.HasIndex(e => e.BranchId)
                    .HasName("branch_id");

                entity.HasIndex(e => e.Campaign)
                    .HasName("campaign");

                entity.HasIndex(e => e.CampaignReferer)
                    .HasName("campaign_referer");

                entity.HasIndex(e => e.Tel)
                    .HasName("tel");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => e.UrlCode)
                    .HasName("url_code")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UrlId)
                    .HasName("url_id");

                entity.HasIndex(e => e.UtmCampaign)
                    .HasName("utm_campaign");

                entity.HasIndex(e => e.UtmMedium)
                    .HasName("utm_medium");

                entity.HasIndex(e => e.UtmSource)
                    .HasName("utm_source");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branch_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Campaign)
                    .HasColumnName("campaign")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CampaignReferer)
                    .HasColumnName("campaign_referer")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Redirect)
                    .HasColumnName("redirect")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Referer)
                    .HasColumnName("referer")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StockNo)
                    .HasColumnName("stock_no")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('tel','whatsapp','email_enquiry','url')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlCode)
                    .HasColumnName("url_code")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UrlId)
                    .HasColumnName("url_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UtmCampaign)
                    .HasColumnName("utm_campaign")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UtmMedium)
                    .HasColumnName("utm_medium")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UtmSource)
                    .HasColumnName("utm_source")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsWebFilterHash>(entity =>
            {
                entity.ToTable("cms_web_filter_hash");

                entity.HasIndex(e => e.Hit)
                    .HasName("hit");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Hit)
                    .HasColumnName("hit")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('gw_property_filter','gw_calculator')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsWechatLog>(entity =>
            {
                entity.ToTable("cms_wechat_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmsWhatsappNumber>(entity =>
            {
                entity.ToTable("cms_whatsapp_number");

                entity.HasIndex(e => e.Number)
                    .HasName("number")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(4) unsigned");

                entity.Property(e => e.ApiEndpoint)
                    .IsRequired()
                    .HasColumnName("api_endpoint")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ApiToken)
                    .IsRequired()
                    .HasColumnName("api_token")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<CmsYahooKeyword>(entity =>
            {
                entity.ToTable("cms_yahoo_keyword");

                entity.HasIndex(e => e.DisplayZh)
                    .HasName("display_zh")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(6) unsigned");

                entity.Property(e => e.DisplayCn)
                    .HasColumnName("display_cn")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisplayEn)
                    .HasColumnName("display_en")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisplayZh)
                    .HasColumnName("display_zh")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileImg)
                    .HasColumnName("file_img")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QtySelected)
                    .HasColumnName("qty_selected")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QtyShown)
                    .HasColumnName("qty_shown")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CpCampaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cp_campaign");

                entity.Property(e => e.AgentShare)
                    .HasColumnName("agent_share")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.InfoContent)
                    .HasColumnName("info_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InfoUrl)
                    .HasColumnName("info_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegisterUrl)
                    .IsRequired()
                    .HasColumnName("register_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShareContent)
                    .HasColumnName("share_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("'active'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
