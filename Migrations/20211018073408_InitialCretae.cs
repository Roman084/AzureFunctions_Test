using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FunctionApp.Migrations
{
    public partial class InitialCretae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allowances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Invoice_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    End_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mileage_allowance = table.Column<bool>(type: "bit", nullable: true),
                    Day_allowance = table.Column<bool>(type: "bit", nullable: true),
                    Full_time_allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Part_time_allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Meal_allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Distance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vehicle_type_id = table.Column<int>(type: "int", nullable: false),
                    License_plate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passenger_count = table.Column<int>(type: "int", nullable: false),
                    Additional_vehicle_cost_id = table.Column<int>(type: "int", nullable: false),
                    Forest_trail = table.Column<bool>(type: "bit", nullable: true),
                    Heavy_load = table.Column<bool>(type: "bit", nullable: true),
                    Working_dog = table.Column<bool>(type: "bit", nullable: true),
                    Vehicle_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    invoice_id = table.Column<int>(type: "int", nullable: false),
                    credit_date_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    groupMsgId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tran_end_end_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUpdates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUpdates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filetype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    invoice_id = table.Column<int>(type: "int", nullable: false),
                    debt_invoice_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    interest_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResoniaApp",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tehtavanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyonantajanNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kunta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuvaus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuvausteksti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KuvaustekstiHTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yhteystiedot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyopaikanOsoite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Palkkausteksti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyoAlkaaTeksti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tyoaika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyonKesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakuPaattyy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakemusLahetetaanHTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakemusLahetetaanKevytHTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilmoituspaivamaarateksti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilmoitusnumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LahettajanViite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    statusPaid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusProcessing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gross_salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    net_salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    service_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    expenses_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    reimbursment_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    take_home_pay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tax_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    yel_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    accidental_insurance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    social_contribution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sumWithoutTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    palkka = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deductions_sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceAllowancePassengers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Passenger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowance_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllowancesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceAllowancePassengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceAllowancePassengers_Allowances_AllowancesId",
                        column: x => x.AllowancesId,
                        principalTable: "Allowances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceAllowanceRouteItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Allowance_id = table.Column<int>(type: "int", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowancesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceAllowanceRouteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceAllowanceRouteItems_Allowances_AllowancesId",
                        column: x => x.AllowancesId,
                        principalTable: "Allowances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company_info",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service_payment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Business_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_control = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_contact_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller_num = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_info_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    business_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    person_to_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    person_to_contact_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    web_invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    finvoice_operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Company_info_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualDebtInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Job_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referencenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Billing_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Debt_billing_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Debt_due_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Installment_due_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sum_with_interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoicePaid = table.Column<int>(type: "int", nullable: false),
                    Invoice_rejected = table.Column<int>(type: "int", nullable: false),
                    Debt_invoice_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interest_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Invoice_justification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remindersent = table.Column<int>(type: "int", nullable: false),
                    IsInstall = table.Column<bool>(type: "bit", nullable: false),
                    Noofinstall = table.Column<int>(type: "int", nullable: false),
                    Pdf_display_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Search_invoice_id = table.Column<int>(type: "int", nullable: true),
                    Overdue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Customers_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_info_DocumentId",
                table: "Company_info",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerTypeId",
                table: "Invoice",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceAllowancePassengers_AllowancesId",
                table: "InvoiceAllowancePassengers",
                column: "AllowancesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceAllowanceRouteItems_AllowancesId",
                table: "InvoiceAllowanceRouteItems",
                column: "AllowancesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankInfo");

            migrationBuilder.DropTable(
                name: "CompanyUpdates");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Invoice_items");

            migrationBuilder.DropTable(
                name: "InvoiceAllowancePassengers");

            migrationBuilder.DropTable(
                name: "InvoiceAllowanceRouteItems");

            migrationBuilder.DropTable(
                name: "ResoniaApp");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Allowances");

            migrationBuilder.DropTable(
                name: "Company_info");

            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
