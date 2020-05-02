using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProperDeedRealty.Data.Contracts;

namespace ProperDeedRealty.Data.Models
{
    public partial class TheCoreBankingRetailContext : DbContext
    {

        public virtual DbSet<TblFinanceChartOfAccount> TblFinanceChartOfAccount { get; set; }
        public virtual DbSet<TblFinanceCounterpartyTransaction> TblFinanceCounterpartyTransaction { get; set; }
        public virtual DbSet<TblFinanceTransaction> TblFinanceTransaction { get; set; }
        public virtual DbSet<APIStubModel> APIStubModel { get; set; }
        public virtual DbSet<GLBalance> GLBalance { get; set; }
        public virtual DbSet<TblApprovalstatus> TblApprovalstatus { get; set; }
        public virtual DbSet<TblBankdraftsetup> TblBankdraftsetup { get; set; }
        public virtual DbSet<TblBankingoperationtype> TblBankingoperationtype { get; set; }
        public virtual DbSet<TblBankingCadeposit> TblBankingCadeposit { get; set; }
        public virtual DbSet<TblBankingsinglefundtransfer> TblBankingsinglefundtransfer { get; set; }
        public virtual DbSet<TblChequebookdetail> TblChequebookdetail { get; set; }
        public virtual DbSet<TblChequebooktype> TblChequebooktype { get; set; }
        public virtual DbSet<TblChequecharges> TblChequecharges { get; set; }
        public virtual DbSet<TblChequeleafstatus> TblChequeleafstatus { get; set; }
        public virtual DbSet<TblChequeleavesdetail> TblChequeleavesdetail { get; set; }
        public virtual DbSet<TblClearingoptions> TblClearingoptions { get; set; }
        public virtual DbSet<TblCotsetup> TblCotsetup { get; set; }
        public virtual DbSet<TblGrantreversalprivilege> TblGrantreversalprivilege { get; set; }
        public virtual DbSet<TblInwardbankcheque> TblInwardbankcheque { get; set; }
        public virtual DbSet<TblOperationtype> TblOperationtype { get; set; }
        public virtual DbSet<TblOutwardbankcheque> TblOutwardbankcheque { get; set; }
        public virtual DbSet<TblRetailoperationtype> TblRetailoperationtype { get; set; }
        public virtual DbSet<TblStaffInformation> TblStaffInformation { get; set; }
        public virtual DbSet<TblStampcharge> TblStampcharge { get; set; }
        public virtual DbSet<TblSystemnarration> TblSystemnarration { get; set; }
        public virtual DbSet<TblTellercloselimitsetup> TblTellercloselimitsetup { get; set; }
        public virtual DbSet<TblTellerlimit> TblTellerlimit { get; set; }
        public virtual DbSet<TblTellerlogin> TblTellerlogin { get; set; }
        public virtual DbSet<TblTellersetup> TblTellersetup { get; set; }
        public virtual DbSet<TblTilldefinition> TblTilldefinition { get; set; }
        public virtual DbSet<TblTillimit> TblTillimit { get; set; }
        public virtual DbSet<TblTilllimitsetup> TblTilllimitsetup { get; set; }
        public virtual DbSet<TblTillmapping> TblTillmapping { get; set; }
        public virtual DbSet<TblTilltfunction> TblTilltfunction { get; set; }
        public virtual DbSet<TblTilltype> TblTilltype { get; set; }
        public virtual DbSet<TblTransfercharge> TblTransfercharge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                // optionsBuilder.UseSqlServer(@"Server=BANKINGPLATFORM\FINTRAKSQL;Database=TheCoreBanking;User Id=sa;Password=sqluser10$;");
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\FINTRAKSQL;Database=TheCoreBanking;User Id=sa;Password=sqluser10$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblFinanceChartOfAccount>(entity =>
            {
                entity.ToTable("tbl_FinanceChartOfAccount", "Finance");

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.BrId)
                    .HasColumnName("brID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .IsRequired()
                    .HasColumnName("coyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FscaptionCode)
                    .HasColumnName("FSCaptionCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId)
                    .HasColumnName("OldAccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId1)
                    .HasColumnName("OldAccountID1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId2)
                    .HasColumnName("OldAccountID2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StCode).HasColumnName("stCode");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceCounterpartyTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("tbl_FinanceCounterpartyTransaction", "Finance");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CVolume).HasColumnName("cVolume");

                entity.Property(e => e.Coy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("money");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DVolume).HasColumnName("dVolume");

                entity.Property(e => e.DebitAmount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.FormNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountId)
                    .HasColumnName("GLAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Legtype)
                    .HasColumnName("legtype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Show).HasColumnName("show");

                entity.Property(e => e.SystemDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GLBalance>(entity =>
            {
                entity.HasKey(e => e.Id);

                //entity.ToTable("tbl_BankingAllBanks", "Credit");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.GLBalances)
                    .HasMaxLength(100)
                    .IsUnicode(false);


            });

            modelBuilder.Entity<TblApprovalstatus>(entity =>
            {
                entity.ToTable("TBL_APPROVALSTATUS", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankdraftsetup>(entity =>
            {
                entity.HasKey(e => e.Bankdraftid);

                entity.ToTable("TBL_BANKDRAFTSETUP", "Retail");

                entity.Property(e => e.Bankdraftid).HasColumnName("BANKDRAFTID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destinationbranchid).HasColumnName("DESTINATIONBRANCHID");

                entity.Property(e => e.Interestgl).HasColumnName("INTERESTGL");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Israte).HasColumnName("ISRATE");

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Principalgl).HasColumnName("PRINCIPALGL");

                entity.Property(e => e.Sourcebranchid).HasColumnName("SOURCEBRANCHID");
            });

            modelBuilder.Entity<TblBankingoperationtype>(entity =>
            {
                entity.ToTable("TBL_BANKINGOPERATIONTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingCadeposit>(entity =>
            {
                entity.ToTable("TBL_Banking_CADeposit", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.AmtDeposited).HasColumnType("money");

                entity.Property(e => e.AmtDeposited1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DepositorAddr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationCa).HasColumnName("DestinationCA");

                entity.Property(e => e.FundSource)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IddateExpiry)
                    .HasColumnName("IDDateExpiry")
                    .HasColumnType("date");

                entity.Property(e => e.IddateIssued)
                    .HasColumnName("IDDateIssued")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Idtype)
                    .HasColumnName("IDType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MeansOfPayment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PrincipalBalGl)
                    .HasColumnName("PrincipalBalGL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlipNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCa).HasColumnName("SourceCA");

                entity.Property(e => e.TillAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingsinglefundtransfer>(entity =>
            {
                entity.ToTable("TBL_BANKINGSINGLEFUNDTRANSFER", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppSource).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.NarrationCr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NarrationDr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostingTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblChequebookdetail>(entity =>
            {
                entity.ToTable("TBL_CHEQUEBOOKDETAIL", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.Chequebooktypeid).HasColumnName("CHEQUEBOOKTYPEID");

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Endrange).HasColumnName("ENDRANGE");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Ischarged).HasColumnName("ISCHARGED");

                entity.Property(e => e.Iscountercheque).HasColumnName("ISCOUNTERCHEQUE");

                entity.Property(e => e.Leavesno).HasColumnName("LEAVESNO");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .IsUnicode(false);

                entity.Property(e => e.Startrange).HasColumnName("STARTRANGE");

                entity.HasOne(d => d.Chequebooktype)
                    .WithMany(p => p.TblChequebookdetail)
                    .HasForeignKey(d => d.Chequebooktypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUEBOOKDETAIL_TBL_CHEQUEBOOKTYPE");
            });

            modelBuilder.Entity<TblChequebooktype>(entity =>
            {
                entity.ToTable("TBL_CHEQUEBOOKTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Charge)
                    .HasColumnName("CHARGE")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Chequetype)
                    .IsRequired()
                    .HasColumnName("CHEQUETYPE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Creditledger)
                    .HasColumnName("CREDITLEDGER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Leavesno).HasColumnName("LEAVESNO");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequecharges>(entity =>
            {
                entity.ToTable("TBL_CHEQUECHARGES", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountledgerid).HasColumnName("ACCOUNTLEDGERID");

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdiscountcharge).HasColumnName("ISDISCOUNTCHARGE");

                entity.Property(e => e.Isreturncharge).HasColumnName("ISRETURNCHARGE");

                entity.Property(e => e.Maxamount).HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Percentage)
                    .HasColumnName("PERCENTAGE")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<TblChequeleafstatus>(entity =>
            {
                entity.ToTable("TBL_CHEQUELEAFSTATUS", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequeleavesdetail>(entity =>
            {
                entity.ToTable("TBL_CHEQUELEAVESDETAIL", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Chequebookid).HasColumnName("CHEQUEBOOKID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Leafno).HasColumnName("LEAFNO");

                entity.Property(e => e.Leafstatus).HasColumnName("LEAFSTATUS");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Chequebook)
                    .WithMany(p => p.TblChequeleavesdetail)
                    .HasForeignKey(d => d.Chequebookid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUELEAVESDETAIL_TBL_CHEQUEBOOKDETAIL");

                entity.HasOne(d => d.LeafstatusNavigation)
                    .WithMany(p => p.TblChequeleavesdetail)
                    .HasForeignKey(d => d.Leafstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUELEAVESDETAIL_TBL_CHEQUELEAFSTATUS");
            });

            modelBuilder.Entity<TblClearingoptions>(entity =>
            {
                entity.ToTable("TBL_CLEARINGOPTIONS", "Retail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCotsetup>(entity =>
            {
                entity.ToTable("TBL_COTSETUP", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLedgerId).HasColumnName("CreditLedgerID");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Maintenance')");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceTransaction>(entity =>
            {
                entity.ToTable("tbl_FinanceTransaction", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef).IsUnicode(false);

                entity.Property(e => e.CreditAmt).HasColumnType("money");

                entity.Property(e => e.DebitAmt).HasColumnType("money");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DestinationBranch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid)
                    .HasColumnName("ITEMID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LcurrencyCode)
                    .HasColumnName("LCurrencyCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Legtype)
                    .HasColumnName("LEGTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonBrAccountId)
                    .HasColumnName("NonBrAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.Property(e => e.SCoyCode)
                    .HasColumnName("sCoyCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBranch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGrantreversalprivilege>(entity =>
            {
                entity.HasKey(e => e.Reversalsetupid);

                entity.ToTable("TBL_GRANTREVERSALPRIVILEGE", "Retail");

                entity.Property(e => e.Reversalsetupid).HasColumnName("REVERSALSETUPID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Canreversealltransaction).HasColumnName("CANREVERSEALLTRANSACTION");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Staffinformationid)
                    .IsRequired()
                    .HasColumnName("STAFFINFORMATIONID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInwardbankcheque>(entity =>
            {
                entity.ToTable("TBL_INWARDBANKCHEQUE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Amountdifference)
                    .HasColumnName("AMOUNTDIFFERENCE")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchid)
                    .HasColumnName("BRANCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Casaaccountname)
                    .IsRequired()
                    .HasColumnName("CASAACCOUNTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Casaaccountno)
                    .IsRequired()
                    .HasColumnName("CASAACCOUNTNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Chargeamount)
                    .HasColumnName("CHARGEAMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Chargecot).HasColumnName("CHARGECOT");

                entity.Property(e => e.Chargeglid).HasColumnName("CHARGEGLID");

                entity.Property(e => e.Chargepercent)
                    .HasColumnName("CHARGEPERCENT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Chequeno)
                    .IsRequired()
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Companyid)
                    .HasColumnName("COMPANYID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cotamount)
                    .HasColumnName("COTAMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdiscountcharge).HasColumnName("ISDISCOUNTCHARGE");

                entity.Property(e => e.Isreturncharge).HasColumnName("ISRETURNCHARGE");

                entity.Property(e => e.Isreturned).HasColumnName("ISRETURNED");

                entity.Property(e => e.Isreversed).HasColumnName("ISREVERSED");

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Otherreturncheque).HasColumnName("OTHERRETURNCHEQUE");

                entity.Property(e => e.Principalglid).HasColumnName("PRINCIPALGLID");

                entity.Property(e => e.Reusecheque).HasColumnName("REUSECHEQUE");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("TRANSACTIONDATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOperationtype>(entity =>
            {
                entity.ToTable("TBL_OPERATIONTYPE", "Retail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Datedeleted)
                    .HasColumnName("DATEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Operationcode).HasColumnName("OPERATIONCODE");

                entity.Property(e => e.Operationname)
                    .HasColumnName("OPERATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutwardbankcheque>(entity =>
            {
                entity.ToTable("TBL_OUTWARDBANKCHEQUE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Approvalremark)
                    .HasColumnName("APPROVALREMARK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bankledgerid)
                    .IsRequired()
                    .HasColumnName("BANKLEDGERID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chargestampamount).HasColumnName("CHARGESTAMPAMOUNT");

                entity.Property(e => e.Chargestampduty).HasColumnName("CHARGESTAMPDUTY");

                entity.Property(e => e.Chequedate)
                    .HasColumnName("CHEQUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Chequeno)
                    .IsRequired()
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cleardate)
                    .HasColumnName("CLEARDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Clearedby)
                    .HasColumnName("CLEAREDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clearingoption)
                    .HasColumnName("CLEARINGOPTION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clearingremark)
                    .HasColumnName("CLEARINGREMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecleared)
                    .HasColumnName("DATECLEARED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Operationremark)
                    .HasColumnName("OPERATIONREMARK")
                    .IsUnicode(false);

                entity.Property(e => e.Referenceno)
                    .IsRequired()
                    .HasColumnName("REFERENCENO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApprovalstatusNavigation)
                    .WithMany(p => p.TblOutwardbankcheque)
                    .HasForeignKey(d => d.Approvalstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_OUTWARDBANKCHEQUE_TBL_APPROVALSTATUS");

                entity.HasOne(d => d.ClearingoptionNavigation)
                    .WithMany(p => p.TblOutwardbankcheque)
                    .HasForeignKey(d => d.Clearingoption)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_OUTWARDBANKCHEQUE_TBL_CLEARINGOPTIONS");
            });

            modelBuilder.Entity<TblRetailoperationtype>(entity =>
            {
                entity.HasKey(e => e.Retailoperationid);

                entity.ToTable("TBL_RETAILOPERATIONTYPE", "Retail");

                entity.Property(e => e.Retailoperationid).HasColumnName("RETAILOPERATIONID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retailoperationname)
                    .IsRequired()
                    .HasColumnName("RETAILOPERATIONNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStaffInformation>(entity =>
            {
                entity.ToTable("tbl_StaffInformation", "GeneralSetup");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData).HasColumnType("image");

                entity.Property(e => e.ImageTitle).HasColumnName("imageTitle");
            });

            modelBuilder.Entity<TblStampcharge>(entity =>
            {
                entity.ToTable("TBL_STAMPCHARGE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TblSystemnarration>(entity =>
            {
                entity.ToTable("TBL_SYSTEMNARRATION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("TEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTellercloselimitsetup>(entity =>
            {
                entity.HasKey(e => e.Tellercloselimitid);

                entity.ToTable("TBL_TELLERCLOSELIMITSETUP", "Retail");

                entity.Property(e => e.Tellercloselimitid).HasColumnName("TELLERCLOSELIMITID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retailoperationid).HasColumnName("RETAILOPERATIONID");

                entity.HasOne(d => d.Retailoperation)
                    .WithMany(p => p.TblTellercloselimitsetup)
                    .HasForeignKey(d => d.Retailoperationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERCLOSELIMITSETUP_TBL_RETAILOPERATIONTYPE");
            });

            modelBuilder.Entity<TblTellerlimit>(entity =>
            {
                entity.ToTable("TBL_TELLERLIMIT", "Retail");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

                entity.Property(e => e.Maxamount).HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Minamount).HasColumnName("MINAMOUNT");

                entity.Property(e => e.Operationname)
                    .HasColumnName("OPERATIONNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationtypeid).HasColumnName("OPERATIONTYPEID");

                entity.HasOne(d => d.Operationtype)
                    .WithMany(p => p.TblTellerlimit)
                    .HasForeignKey(d => d.Operationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERLIMIT_TBL_OPERATIONTYPE");
            });

            modelBuilder.Entity<TblTellerlogin>(entity =>
            {
                entity.ToTable("TBL_TELLERLOGIN", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountbalance)
                    .HasColumnName("ACCOUNTBALANCE")
                    .HasColumnType("money");

                entity.Property(e => e.Accountid)
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Assignuser)
                    .HasColumnName("ASSIGNUSER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branchid)
                    .HasColumnName("BRANCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Closingbalance)
                    .HasColumnName("CLOSINGBALANCE")
                    .HasColumnType("money");

                entity.Property(e => e.Companyid)
                    .HasColumnName("COMPANYID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Ledgername)
                    .IsRequired()
                    .HasColumnName("LEDGERNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellerlimitid).HasColumnName("TELLERLIMITID");

                entity.Property(e => e.Tellerlogindate)
                    .HasColumnName("TELLERLOGINDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tellerlogintime)
                    .HasColumnName("TELLERLOGINTIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellerno)
                    .HasColumnName("TELLERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellersetupid).HasColumnName("TELLERSETUPID");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<TblTellersetup>(entity =>
            //{
            //    entity.ToTable("TBL_TELLERSETUP", "Retail");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

            //    entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

            //    entity.Property(e => e.Createdby)
            //        .HasColumnName("CREATEDBY")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Datecreated)
            //        .HasColumnName("DATECREATED")
            //        .HasColumnType("date");

            //    entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

            //    entity.Property(e => e.Staffinformationid)
            //        .HasColumnName("STAFFINFORMATIONID")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Tellertillaccount)
            //        .HasColumnName("TELLERTILLACCOUNT")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Tillaccountnumber)
            //        .IsRequired()
            //        .HasColumnName("TILLACCOUNTNUMBER")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Tilllimitamount).HasColumnName("TILLLIMITAMOUNT");

            //    entity.Property(e => e.Tilllimitid).HasColumnName("TILLLIMITID");

            //    entity.Property(e => e.Tillmappingid).HasColumnName("TILLMAPPINGID");

            //    entity.Property(e => e.Tillname)
            //        .IsRequired()
            //        .HasColumnName("TILLNAME")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Tilluser)
            //        .IsRequired()
            //        .HasColumnName("TILLUSER")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.Tilllimit)
            //        .WithMany(p => p.TblTellersetup)
            //        .HasForeignKey(d => d.Tilllimitid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLIMIT");

            //    entity.HasOne(d => d.Tillmapping)
            //        .WithMany(p => p.TblTellersetup)
            //        .HasForeignKey(d => d.Tillmappingid)
            //        .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLMAPPING");
            //});

            modelBuilder.Entity<TblTellersetup>(entity =>
            {
                entity.ToTable("TBL_TELLERSETUP", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

                entity.Property(e => e.Staffinformationid).HasColumnName("STAFFINFORMATIONID");

                entity.Property(e => e.Tellertillaccount)
                    .HasColumnName("TELLERTILLACCOUNT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillaccountnumber)
                    .IsRequired()
                    .HasColumnName("TILLACCOUNTNUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilllimitamount).HasColumnName("TILLLIMITAMOUNT");

                entity.Property(e => e.Tilllimitid).HasColumnName("TILLLIMITID");

                entity.Property(e => e.Tillmappingid).HasColumnName("TILLMAPPINGID");

                entity.Property(e => e.Tillname)
                    .IsRequired()
                    .HasColumnName("TILLNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilluser)
                    .IsRequired()
                    .HasColumnName("TILLUSER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tilllimit)
                    .WithMany(p => p.TblTellersetup)
                    .HasForeignKey(d => d.Tilllimitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLIMIT");

                entity.HasOne(d => d.Tillmapping)
                    .WithMany(p => p.TblTellersetup)
                    .HasForeignKey(d => d.Tillmappingid)
                    .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLMAPPING");
            });

            modelBuilder.Entity<TblTilldefinition>(entity =>
            {
                entity.ToTable("TBL_TILLDEFINITION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Tellername)
                    .IsRequired()
                    .HasColumnName("TELLERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTillimit>(entity =>
            {
                entity.ToTable("TBL_TILLIMIT", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Ledgeraccount)
                    .IsRequired()
                    .HasColumnName("LEDGERACCOUNT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillfunction)
                    .IsRequired()
                    .HasColumnName("TILLFUNCTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillfunctionid).HasColumnName("TILLFUNCTIONID");

                entity.Property(e => e.Tillmappingid).HasColumnName("TILLMAPPINGID");

                entity.Property(e => e.Tillname)
                    .IsRequired()
                    .HasColumnName("TILLNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TillfunctionNavigation)
                    .WithMany(p => p.TblTillimit)
                    .HasForeignKey(d => d.Tillfunctionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLIMIT_TBL_TILLTFUNCTION");

                entity.HasOne(d => d.Tillmapping)
                    .WithMany(p => p.TblTillimit)
                    .HasForeignKey(d => d.Tillmappingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLIMIT_TBL_TILLMAPPING");
            });

            modelBuilder.Entity<TblTilllimitsetup>(entity =>
            {
                entity.HasKey(e => e.Tillid);

                entity.ToTable("TBL_TILLLIMITSETUP", "Retail");

                entity.Property(e => e.Tillid).HasColumnName("TILLID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Limitamount)
                    .HasColumnName("LIMITAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telleraccountid)
                    .IsRequired()
                    .HasColumnName("TELLERACCOUNTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tilluserid).HasColumnName("TILLUSERID");
            });

            modelBuilder.Entity<TblTillmapping>(entity =>
            {
                entity.ToTable("TBL_TILLMAPPING", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountid)
                    .IsRequired()
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Tilldefinationid).HasColumnName("TILLDEFINATIONID");

                entity.Property(e => e.Tilldefinationname)
                    .IsRequired()
                    .HasColumnName("TILLDEFINATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilltypeid).HasColumnName("TILLTYPEID");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tilldefination)
                    .WithMany(p => p.TblTillmapping)
                    .HasForeignKey(d => d.Tilldefinationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLMAPPING_TBL_TILLDEFINITION");

                entity.HasOne(d => d.Tilltype)
                    .WithMany(p => p.TblTillmapping)
                    .HasForeignKey(d => d.Tilltypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLMAPPING_TBL_TILLTYPE");
            });

            modelBuilder.Entity<TblTilltfunction>(entity =>
            {
                entity.ToTable("TBL_TILLTFUNCTION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Functioncode).HasColumnName("FUNCTIONCODE");

                entity.Property(e => e.Tillfunction)
                    .IsRequired()
                    .HasColumnName("TILLFUNCTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<TblTilltype>(entity =>
            {
                entity.ToTable("TBL_TILLTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransfercharge>(entity =>
            {
                entity.HasKey(e => e.Transferchargeid);

                entity.ToTable("TBL_TRANSFERCHARGE", "Retail");

                entity.Property(e => e.Transferchargeid).HasColumnName("TRANSFERCHARGEID");

                entity.Property(e => e.Amounttocharge)
                    .HasColumnName("AMOUNTTOCHARGE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maxamount)
                    .HasColumnName("MAXAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minamount)
                    .HasColumnName("MINAMOUNT")
                    .HasDefaultValueSql("((0))");
            });
        }


    }
}
