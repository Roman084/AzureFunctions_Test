﻿// <auto-generated />
using System;
using FunctionApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunctionApp.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20211011124029_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FunctionApp.Data.Entities.Allowances", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Additional_vehicle_cost_id")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Day_allowance")
                        .HasColumnType("bit");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("End_time")
                        .HasColumnType("time");

                    b.Property<bool?>("Forest_trail")
                        .HasColumnType("bit");

                    b.Property<decimal>("Full_time_allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("Heavy_load")
                        .HasColumnType("bit");

                    b.Property<string>("Invoice_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("License_plate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Meal_allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("Mileage_allowance")
                        .HasColumnType("bit");

                    b.Property<decimal>("Part_time_allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Passenger_count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Start_time")
                        .HasColumnType("time");

                    b.Property<string>("Vehicle_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vehicle_type_id")
                        .HasColumnType("int");

                    b.Property<bool?>("Working_dog")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Allowances");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.BankInfoInvoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("credit_date_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("groupMsgId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("invoice_id")
                        .HasColumnType("int");

                    b.Property<decimal>("invoice_sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("paymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tran_end_end_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankInfoInvoice");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Business_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DocumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment_control")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seller_num")
                        .HasColumnType("int");

                    b.Property<decimal>("Service_payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("User_contact_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.CompanyUpdates", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NewsUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyUpdates");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Business_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Customer_id")
                        .HasColumnType("int");

                    b.Property<string>("Customer_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Delivery_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Delivery_method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Finvoice_operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person_to_contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person_to_contact_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Web_invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filetype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActualDebtInvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Billing_date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Customer_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Debt_billing_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Debt_due_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Debt_invoice_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Installment_due_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Interest_percent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InvoicePaid")
                        .HasColumnType("int");

                    b.Property<string>("Invoice_justification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Invoice_rejected")
                        .HasColumnType("int");

                    b.Property<bool>("IsInstall")
                        .HasColumnType("bit");

                    b.Property<string>("Job_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Noofinstall")
                        .HasColumnType("int");

                    b.Property<DateTime>("Overdue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pdf_display_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Remindersent")
                        .HasColumnType("int");

                    b.Property<Guid?>("SalaryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Search_invoice_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum_with_interest")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTypeId");

                    b.HasIndex("SalaryId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.InvoiceAllowancePassengers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Allowance_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AllowancesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Passenger")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllowancesId");

                    b.ToTable("InvoiceAllowancePassengers");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.InvoiceAllowanceRouteItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Allowance_id")
                        .HasColumnType("int");

                    b.Property<Guid?>("AllowancesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Route")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllowancesId");

                    b.ToTable("InvoiceAllowanceRouteItems");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.InvoiceItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Debt_invoice_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Interest_percent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Invoice_item_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.ResoniaApp", b =>
                {
                    b.Property<string>("HakemusLahetetaanHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakemusLahetetaanKevytHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakuPaattyy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilmoitusnumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilmoituspaivamaarateksti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kunta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kuvaus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kuvausteksti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KuvaustekstiHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LahettajanViite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Palkkausteksti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tehtavanimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TyoAlkaaTeksti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tyoaika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TyonKesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TyonantajanNimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TyopaikanOsoite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yhteystiedot")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ResoniaApp");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Salary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Accidental_insurance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Deductions_sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Expenses_cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Gross_salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Net_salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Palkka")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reimbursment_cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Service_cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Social_contribution")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusPaid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusProcessing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SumWithoutTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Take_home_pay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax_cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Yel_cost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Company", b =>
                {
                    b.HasOne("FunctionApp.Data.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Customer", b =>
                {
                    b.HasOne("FunctionApp.Data.Entities.Company", null)
                        .WithMany("Customer")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Invoice", b =>
                {
                    b.HasOne("FunctionApp.Data.Entities.Customer", "CustomerType")
                        .WithMany("Invoice")
                        .HasForeignKey("CustomerTypeId");

                    b.HasOne("FunctionApp.Data.Entities.Salary", null)
                        .WithMany("Invoices")
                        .HasForeignKey("SalaryId");

                    b.Navigation("CustomerType");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.InvoiceAllowancePassengers", b =>
                {
                    b.HasOne("FunctionApp.Data.Entities.Allowances", null)
                        .WithMany("AllowancePassenger")
                        .HasForeignKey("AllowancesId");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.InvoiceAllowanceRouteItems", b =>
                {
                    b.HasOne("FunctionApp.Data.Entities.Allowances", null)
                        .WithMany("AllowanceInputRow")
                        .HasForeignKey("AllowancesId");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Allowances", b =>
                {
                    b.Navigation("AllowanceInputRow");

                    b.Navigation("AllowancePassenger");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Company", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Customer", b =>
                {
                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("FunctionApp.Data.Entities.Salary", b =>
                {
                    b.Navigation("Invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
