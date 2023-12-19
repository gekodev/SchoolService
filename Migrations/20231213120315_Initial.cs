using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SchoolService.Migrations;

  /// <inheritdoc />
  public partial class Initial : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "academic_session",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  title = table.Column<string>(type: "text", nullable: true),
                  type = table.Column<int>(type: "integer", nullable: false),
                  start_date = table.Column<string>(type: "text", nullable: true),
                  end_date = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_academic_session", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "clazz",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  org_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  title = table.Column<string>(type: "text", nullable: true),
                  session_sourced_ids = table.Column<string>(type: "text", nullable: true),
                  course_sourced_id = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_clazz", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "course",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  org_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  title = table.Column<string>(type: "text", nullable: true),
                  code = table.Column<string>(type: "text", nullable: true),
                  family_name = table.Column<string>(type: "text", nullable: true),
                  school_year_sourced_id = table.Column<string>(type: "text", nullable: true),
                  subject = table.Column<int>(type: "integer", nullable: false),
                  grade = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_course", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "demographic",
              columns: table => new
              {
                  user_sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  sex = table.Column<string>(type: "text", nullable: true),
                  birth_date = table.Column<string>(type: "text", nullable: true),
                  birth_city = table.Column<string>(type: "text", nullable: true),
                  birth_state = table.Column<string>(type: "text", nullable: true),
                  birth_country = table.Column<string>(type: "text", nullable: true),
                  ethnicity_codes = table.Column<string>(type: "text", nullable: true),
                  race_codes = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_demographic", x => x.user_sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "enrollment",
              columns: table => new
              {
                  class_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  user_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  role = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_enrollment", x => new { x.class_sourced_id, x.user_sourced_id });
              });

          migrationBuilder.CreateTable(
              name: "org",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  name = table.Column<string>(type: "text", nullable: true),
                  type = table.Column<string>(type: "text", nullable: true),
                  parent_sourced_id = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_org", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "relationship",
              columns: table => new
              {
                  user_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  relationship_user_sourced_id = table.Column<string>(type: "text", nullable: false),
                  relationship_role = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_relationship", x => new { x.user_sourced_id, x.relationship_user_sourced_id });
              });

          migrationBuilder.CreateTable(
              name: "rol",
              columns: table => new
              {
                  user_sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  org_sourced_id = table.Column<int>(type: "integer", nullable: false),
                  role = table.Column<string>(type: "text", nullable: true),
                  session_sourced_id = table.Column<string>(type: "text", nullable: true),
                  grade = table.Column<int>(type: "integer", nullable: false),
                  is_primary = table.Column<bool>(type: "boolean", nullable: false),
                  role_start_date = table.Column<string>(type: "text", nullable: true),
                  role_end_date = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_rol", x => x.user_sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "room",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  code = table.Column<string>(type: "text", nullable: true),
                  name = table.Column<string>(type: "text", nullable: false),
                  size = table.Column<decimal>(type: "numeric", nullable: false),
                  capacity = table.Column<int>(type: "integer", nullable: false),
                  number = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_room", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "school",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  name = table.Column<string>(type: "text", nullable: true),
                  school_number = table.Column<int>(type: "integer", nullable: false),
                  school_nces_id = table.Column<int>(type: "integer", nullable: false),
                  state_id = table.Column<string>(type: "text", nullable: true),
                  grade_low = table.Column<int>(type: "integer", nullable: false),
                  grade_high = table.Column<int>(type: "integer", nullable: false),
                  principal_sis_id = table.Column<int>(type: "integer", nullable: false),
                  principal_name = table.Column<string>(type: "text", nullable: true),
                  principal_secondary_email = table.Column<string>(type: "text", nullable: true),
                  address = table.Column<string>(type: "text", nullable: true),
                  city = table.Column<string>(type: "text", nullable: true),
                  state = table.Column<string>(type: "text", nullable: true),
                  country = table.Column<string>(type: "text", nullable: true),
                  zip = table.Column<string>(type: "text", nullable: true),
                  phone = table.Column<string>(type: "text", nullable: true),
                  zone = table.Column<int>(type: "integer", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_school", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "section",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  school_sis_id = table.Column<int>(type: "integer", nullable: false),
                  section_name = table.Column<string>(type: "text", nullable: true),
                  section_number = table.Column<int>(type: "integer", nullable: false),
                  term_sis_id = table.Column<int>(type: "integer", nullable: false),
                  term_name = table.Column<string>(type: "text", nullable: true),
                  term_start_date = table.Column<string>(type: "text", nullable: true),
                  term_endate = table.Column<string>(type: "text", nullable: true),
                  course_sis_id = table.Column<int>(type: "integer", nullable: false),
                  course_name = table.Column<string>(type: "text", nullable: true),
                  course_number = table.Column<int>(type: "integer", nullable: false),
                  course_description = table.Column<string>(type: "text", nullable: true),
                  course_subject = table.Column<string>(type: "text", nullable: true),
                  periods = table.Column<int>(type: "integer", nullable: false),
                  status = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_section", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "student",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  school_sis_id = table.Column<int>(type: "integer", nullable: false),
                  first_name = table.Column<string>(type: "text", nullable: true),
                  last_name = table.Column<string>(type: "text", nullable: true),
                  user_name = table.Column<string>(type: "text", nullable: true),
                  password = table.Column<string>(type: "text", nullable: true),
                  state_id = table.Column<string>(type: "text", nullable: true),
                  secondary_email = table.Column<string>(type: "text", nullable: true),
                  student_number = table.Column<int>(type: "integer", nullable: false),
                  middle_name = table.Column<string>(type: "text", nullable: true),
                  grade = table.Column<string>(type: "text", nullable: true),
                  status = table.Column<string>(type: "text", nullable: true),
                  birthdate = table.Column<string>(type: "text", nullable: true),
                  graduation_year = table.Column<int>(type: "integer", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_student", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "student_enrollment",
              columns: table => new
              {
                  section_sis_id = table.Column<int>(type: "integer", nullable: false),
                  sis_id = table.Column<int>(type: "integer", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_student_enrollment", x => new { x.section_sis_id, x.sis_id });
              });

          migrationBuilder.CreateTable(
              name: "subject",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  code = table.Column<string>(type: "text", nullable: true),
                  name = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_subject", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "teacher",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  school_sis_id = table.Column<int>(type: "integer", nullable: false),
                  first_name = table.Column<string>(type: "text", nullable: true),
                  last_name = table.Column<string>(type: "text", nullable: true),
                  user_name = table.Column<string>(type: "text", nullable: true),
                  password = table.Column<string>(type: "text", nullable: true),
                  state_id = table.Column<string>(type: "text", nullable: true),
                  teacher_number = table.Column<int>(type: "integer", nullable: false),
                  status = table.Column<string>(type: "text", nullable: true),
                  middle_name = table.Column<string>(type: "text", nullable: true),
                  secondary_email = table.Column<string>(type: "text", nullable: true),
                  title = table.Column<string>(type: "text", nullable: true),
                  qualification = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_teacher", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "teacher_roster",
              columns: table => new
              {
                  section_sis_id = table.Column<int>(type: "integer", nullable: false),
                  sis_id = table.Column<int>(type: "integer", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_teacher_roster", x => new { x.section_sis_id, x.sis_id });
              });

          migrationBuilder.CreateTable(
              name: "time_block",
              columns: table => new
              {
                  sis_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  name = table.Column<string>(type: "text", nullable: true),
                  comment = table.Column<string>(type: "text", nullable: true),
                  start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  end_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  minutes = table.Column<int>(type: "integer", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_time_block", x => x.sis_id);
              });

          migrationBuilder.CreateTable(
              name: "user",
              columns: table => new
              {
                  sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  user_name = table.Column<string>(type: "text", nullable: true),
                  given_name = table.Column<string>(type: "text", nullable: true),
                  family_name = table.Column<string>(type: "text", nullable: true),
                  password = table.Column<string>(type: "text", nullable: true),
                  active_directory_match_id = table.Column<string>(type: "text", nullable: true),
                  email = table.Column<string>(type: "text", nullable: true),
                  phone = table.Column<string>(type: "text", nullable: true),
                  sms = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_user", x => x.sourced_id);
              });

          migrationBuilder.CreateTable(
              name: "user_flag",
              columns: table => new
              {
                  user_sourced_id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  flag = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_user_flag", x => x.user_sourced_id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "academic_session");

          migrationBuilder.DropTable(
              name: "clazz");

          migrationBuilder.DropTable(
              name: "course");

          migrationBuilder.DropTable(
              name: "demographic");

          migrationBuilder.DropTable(
              name: "enrollment");

          migrationBuilder.DropTable(
              name: "org");

          migrationBuilder.DropTable(
              name: "relationship");

          migrationBuilder.DropTable(
              name: "rol");

          migrationBuilder.DropTable(
              name: "room");

          migrationBuilder.DropTable(
              name: "school");

          migrationBuilder.DropTable(
              name: "section");

          migrationBuilder.DropTable(
              name: "student");

          migrationBuilder.DropTable(
              name: "student_enrollment");

          migrationBuilder.DropTable(
              name: "subject");

          migrationBuilder.DropTable(
              name: "teacher");

          migrationBuilder.DropTable(
              name: "teacher_roster");

          migrationBuilder.DropTable(
              name: "time_block");

          migrationBuilder.DropTable(
              name: "user");

          migrationBuilder.DropTable(
              name: "user_flag");
      }
  }
