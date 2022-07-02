using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "card_operators",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card_operators", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    category_type = table.Column<string>(type: "text", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true),
                    birthday = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cost_center_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cost_center_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cost_centers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cost_centers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "expense_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expense_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "files",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    size = table.Column<long>(type: "bigint", nullable: false),
                    key = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true),
                    mimetype = table.Column<string>(type: "text", nullable: true),
                    resource = table.Column<string>(type: "text", nullable: true),
                    resource_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_files", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payment_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    prefix = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contact_informations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_contact_name = table.Column<string>(type: "text", nullable: true),
                    work_email = table.Column<string>(type: "text", nullable: true),
                    personal_email = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    mobile = table.Column<string>(type: "text", nullable: true),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_informations", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_informations_contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contact_pfs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_pfs", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_pfs_contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contact_pjs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj = table.Column<string>(type: "text", nullable: true),
                    company_name = table.Column<string>(type: "text", nullable: true),
                    state_registration = table.Column<string>(type: "text", nullable: true),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_pjs", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_pjs_contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    balance = table.Column<float>(type: "real", nullable: false),
                    initial_balance = table.Column<float>(type: "real", nullable: false),
                    _default = table.Column<bool>(type: "boolean", nullable: false),
                    cost_center_type_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_accounts_cost_center_types_cost_center_type_id",
                        column: x => x.cost_center_type_id,
                        principalTable: "cost_center_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transaction_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    expense_group_id = table.Column<int>(type: "integer", nullable: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_transaction_categories_expense_groups_expense_group_id",
                        column: x => x.expense_group_id,
                        principalTable: "expense_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    state_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.id);
                    table.ForeignKey(
                        name: "FK_cities_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create = table.Column<bool>(type: "boolean", nullable: false),
                    read = table.Column<bool>(type: "boolean", nullable: false),
                    update = table.Column<bool>(type: "boolean", nullable: false),
                    delete = table.Column<bool>(type: "boolean", nullable: false),
                    resource = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.id);
                    table.ForeignKey(
                        name: "FK_permissions_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "system_logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    action = table.Column<string>(type: "text", nullable: true),
                    _object = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_logs", x => x.id);
                    table.ForeignKey(
                        name: "FK_system_logs_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_settings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_owner = table.Column<bool>(type: "boolean", nullable: false),
                    has_mei_access = table.Column<bool>(type: "boolean", nullable: false),
                    has_transactions = table.Column<bool>(type: "boolean", nullable: false),
                    show_question_update_date_after_pay = table.Column<bool>(type: "boolean", nullable: false),
                    update_paydate_after_payment = table.Column<bool>(type: "boolean", nullable: false),
                    view_all_cost_centers = table.Column<bool>(type: "boolean", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_settings", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_settings_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "text", nullable: true),
                    document_number = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    value = table.Column<float>(type: "real", nullable: false),
                    paid = table.Column<bool>(type: "boolean", nullable: false),
                    payment_plan = table.Column<string>(type: "text", nullable: true),
                    split = table.Column<bool>(type: "boolean", nullable: false),
                    has_nf = table.Column<bool>(type: "boolean", nullable: false),
                    has_boleto = table.Column<bool>(type: "boolean", nullable: false),
                    has_attachment = table.Column<bool>(type: "boolean", nullable: false),
                    frequency_main_id = table.Column<int>(type: "integer", nullable: false),
                    frequency_number = table.Column<int>(type: "integer", nullable: false),
                    frequency_total = table.Column<int>(type: "integer", nullable: false),
                    frequency_type = table.Column<string>(type: "text", nullable: true),
                    transaction_category_id = table.Column<int>(type: "integer", nullable: false),
                    cost_center_id = table.Column<int>(type: "integer", nullable: false),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    payment_type_id = table.Column<int>(type: "integer", nullable: false),
                    pay_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    due_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_transactions_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_cost_centers_cost_center_id",
                        column: x => x.cost_center_id,
                        principalTable: "cost_centers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_payment_types_payment_type_id",
                        column: x => x.payment_type_id,
                        principalTable: "payment_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_transaction_categories_transaction_category_id",
                        column: x => x.transaction_category_id,
                        principalTable: "transaction_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contact_addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cep = table.Column<string>(type: "text", nullable: true),
                    street = table.Column<string>(type: "text", nullable: true),
                    neighborhood = table.Column<string>(type: "text", nullable: true),
                    number = table.Column<string>(type: "text", nullable: true),
                    complement = table.Column<string>(type: "text", nullable: true),
                    city_id = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_addresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_addresses_cities_city_id",
                        column: x => x.city_id,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_contact_addresses_contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "attachments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    transaction_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachments", x => x.id);
                    table.ForeignKey(
                        name: "FK_attachments_transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "installments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "text", nullable: true),
                    value = table.Column<float>(type: "real", nullable: false),
                    paid = table.Column<bool>(type: "boolean", nullable: false),
                    due_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    transaction_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_installments", x => x.id);
                    table.ForeignKey(
                        name: "FK_installments_transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "splits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    paid = table.Column<bool>(type: "boolean", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    value = table.Column<float>(type: "real", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    transaction_id = table.Column<int>(type: "integer", nullable: false),
                    transaction_category_id = table.Column<int>(type: "integer", nullable: false),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_splits", x => x.id);
                    table.ForeignKey(
                        name: "FK_splits_contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_splits_transaction_categories_transaction_category_id",
                        column: x => x.transaction_category_id,
                        principalTable: "transaction_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_splits_transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    transaction_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                    table.ForeignKey(
                        name: "FK_tags_transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_cost_center_type_id",
                table: "accounts",
                column: "cost_center_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_attachments_transaction_id",
                table: "attachments",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_cities_state_id",
                table: "cities",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_addresses_city_id",
                table: "contact_addresses",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_addresses_ContactId",
                table: "contact_addresses",
                column: "ContactId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_informations_contact_id",
                table: "contact_informations",
                column: "contact_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_pfs_contact_id",
                table: "contact_pfs",
                column: "contact_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_pjs_contact_id",
                table: "contact_pjs",
                column: "contact_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_installments_transaction_id",
                table: "installments",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_permissions_user_id",
                table: "permissions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_splits_contact_id",
                table: "splits",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_splits_transaction_category_id",
                table: "splits",
                column: "transaction_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_splits_transaction_id",
                table: "splits",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_system_logs_user_id",
                table: "system_logs",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_tags_transaction_id",
                table: "tags",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_categories_expense_group_id",
                table: "transaction_categories",
                column: "expense_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_account_id",
                table: "transactions",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_contact_id",
                table: "transactions",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_cost_center_id",
                table: "transactions",
                column: "cost_center_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_payment_type_id",
                table: "transactions",
                column: "payment_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_transaction_category_id",
                table: "transactions",
                column: "transaction_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_settings_user_id",
                table: "user_settings",
                column: "user_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attachments");

            migrationBuilder.DropTable(
                name: "card_operators");

            migrationBuilder.DropTable(
                name: "contact_addresses");

            migrationBuilder.DropTable(
                name: "contact_informations");

            migrationBuilder.DropTable(
                name: "contact_pfs");

            migrationBuilder.DropTable(
                name: "contact_pjs");

            migrationBuilder.DropTable(
                name: "files");

            migrationBuilder.DropTable(
                name: "installments");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "splits");

            migrationBuilder.DropTable(
                name: "system_logs");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "user_settings");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "cost_centers");

            migrationBuilder.DropTable(
                name: "payment_types");

            migrationBuilder.DropTable(
                name: "transaction_categories");

            migrationBuilder.DropTable(
                name: "cost_center_types");

            migrationBuilder.DropTable(
                name: "expense_groups");
        }
    }
}
