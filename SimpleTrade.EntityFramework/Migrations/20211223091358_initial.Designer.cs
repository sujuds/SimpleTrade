// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleTrade.EntityFramework;

namespace SimpleTrade.EntityFramework.Migrations
{
    [DbContext(typeof(SimpleTradeDbContext))]
    [Migration("20211223091358_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SimpleTrade.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountHolderId");

                    b.Property<double>("Balance");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SimpleTrade.Domain.Models.AssetTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<DateTime>("DateProcessed");

                    b.Property<bool>("IsPurchase");

                    b.Property<int>("Share");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AssetTransactions");
                });

            modelBuilder.Entity("SimpleTrade.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatedJoined");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleTrade.Domain.Models.Account", b =>
                {
                    b.HasOne("SimpleTrade.Domain.Models.User", "AccountHolder")
                        .WithMany()
                        .HasForeignKey("AccountHolderId");
                });

            modelBuilder.Entity("SimpleTrade.Domain.Models.AssetTransaction", b =>
                {
                    b.HasOne("SimpleTrade.Domain.Models.Account", "Account")
                        .WithMany("AssetTransactions")
                        .HasForeignKey("AccountId");

                    b.OwnsOne("SimpleTrade.Domain.Models.Stock", "Stock", b1 =>
                        {
                            b1.Property<int>("AssetTransactionId");

                            b1.Property<double>("PricePerShare");

                            b1.Property<string>("Symbol");

                            b1.HasKey("AssetTransactionId");

                            b1.ToTable("AssetTransactions");

                            b1.HasOne("SimpleTrade.Domain.Models.AssetTransaction")
                                .WithOne("Stock")
                                .HasForeignKey("SimpleTrade.Domain.Models.Stock", "AssetTransactionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
