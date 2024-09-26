using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ManageSystem.Models;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace ManageSystem.DAL
{
    public class LoginRepository
    {
        private readonly string _connectionString;

        public LoginRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        }
        public void RegisterUser(string username, string passwordHash)
        {
            // Create a new MySqlConnection using the connection string
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                // Open the connection to the database
                conn.Open();

                // SQL query to insert a new user into the SystemAdmin table
                string query = "INSERT INTO SystemAdmin(Username, PasswordHash) VALUES (@username, @passwordhash)";

                // Create a command to execute the SQL query
                using (var cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordhash", passwordHash);

                    // Execute the command, performing the insert operation
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ValidateUser(string username, string password)
        {
            // SQL query to select a user based on username and password hash
            string selectData = "SELECT * FROM SystemAdmin WHERE username = @username AND passwordhash = @passwordhash";

            // Create a new MySqlConnection using the connection string
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                // Open the connection to the database
                conn.Open();

                // Create a command to execute the SQL query
                using (MySqlCommand cmd = new MySqlCommand(selectData, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordhash", password);

                    // Execute the query and read the results
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Return true if a matching record is found
                        return reader.Read();
                    }
                }
            }
        }

        public void TestConnection(bool showMessage = false)
        {
            // Create a new MySqlConnection using the connection string
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    // Open the connection to the database
                    connection.Open();

                    // If showMessage is true, display a success message
                    if (showMessage)
                    {
                        MessageBox.Show("Connection Successful");
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if the connection fails
                    MessageBox.Show($"Connection Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool CheckDuplicateUser(string email)
        {
            using (var conn = new MySqlConnection(_connectionString)) // Establish a database connection
            {
                var command = new MySqlCommand(@"
            SELECT COUNT(*) FROM Administration a
            JOIN Users u ON a.UserId = u.Id
            WHERE u.Email = @Email
            UNION ALL
            SELECT COUNT(*) FROM Students s
            JOIN Users u ON s.UserId = u.Id
            WHERE u.Email = @Email
            UNION ALL
            SELECT COUNT(*) FROM TeachingStaff t
            JOIN Users u ON t.UserId = u.Id
            WHERE u.Email = @Email", conn);

                command.Parameters.AddWithValue("@Email", email); // Add parameter to prevent SQL injection
                conn.Open(); // Open the connection

                int totalCount = 0;
                using (var reader = command.ExecuteReader()) // Execute the query
                {
                    while (reader.Read())
                    {
                        totalCount += reader.GetInt32(0); // Sum the counts from all tables
                    }
                }
                return totalCount > 0; // Return true if any duplicates are found
            }
        }

        public void AddTeachingStaff(TeachingStaff teachingStaff)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                // Insert into Users table first to get UserId
                try
                {
                    // SQL query to insert a new user into the Users table
                    string query = @"
            INSERT INTO Users (Name, Telephone, Email, RoleType) 
            VALUES (@Name, @Telephone, @Email, 'TeachingStaff');";

                    int userId; // Variable to hold the new UserId

                    // Execute the insert command for the Users table
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Name", teachingStaff.Name);
                        cmd.Parameters.AddWithValue("@Telephone", teachingStaff.Telephone);
                        cmd.Parameters.AddWithValue("@Email", teachingStaff.Email);

                        cmd.ExecuteNonQuery(); // Execute the insert command

                        // SQL query to get the last inserted UserId
                        string getQuery = "SELECT LAST_INSERT_ID();";
                        using (var idCmd = new MySqlCommand(getQuery, conn))
                        {
                            // Execute the command and convert the result to an integer
                            userId = Convert.ToInt32(idCmd.ExecuteScalar());
                        }
                    }

                    // SQL query to insert the teaching staff details into the TeachingStaff table
                    string staffQuery = @"
            INSERT INTO TeachingStaff (UserId, Salary, Subject1, Subject2) 
            VALUES (@UserId, @Salary, @Subject1, @Subject2);";

                    // Execute the insert command for the TeachingStaff table
                    using (var staffCmd = new MySqlCommand(staffQuery, conn))
                    {
                        // Add parameters to the command
                        staffCmd.Parameters.AddWithValue("@UserId", userId);
                        staffCmd.Parameters.AddWithValue("@Salary", teachingStaff.Salary);
                        staffCmd.Parameters.AddWithValue("@Subject1", teachingStaff.Subject1);
                        staffCmd.Parameters.AddWithValue("@Subject2", teachingStaff.Subject2);

                        staffCmd.ExecuteNonQuery(); // Execute the insert command
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if an exception occurs
                    MessageBox.Show($"Error adding Teaching Staff: {ex.Message}");
                }
            } // The connection is automatically closed and disposed of here
        }

        public List<TeachingStaff> GetTeachingStaffList()
        {
            // Initialize a list to hold the teaching staff objects
            var teachingStaffList = new List<TeachingStaff>();

            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                // SQL query to select relevant details from TeachingStaff and Users tables
                string query = @"
        SELECT U.Name, U.Telephone, U.Email, T.UserId, T.Salary, T.Subject1, T.Subject2
        FROM TeachingStaff T
        JOIN Users U ON T.UserId = U.Id";

                // Create a command object to execute the query
                var cmd = new MySqlCommand(query, conn);
                conn.Open(); // Open the database connection

                try
                {
                    // Execute the query and use a DataReader to read the results
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Iterate through each record in the result set
                        while (reader.Read())
                        {
                            // Create a new TeachingStaff object and populate its properties
                            var teachingStaff = new TeachingStaff(
                                reader["Name"].ToString(),
                                reader["Telephone"].ToString(),
                                reader["Email"].ToString(),
                                Convert.ToDecimal(reader["Salary"]),
                                reader["Subject1"].ToString(),
                                reader["Subject2"].ToString()
                            )
                            {
                                // Set the ID property to the UserId from the database
                                ID = Convert.ToInt32(reader["UserId"])
                            };

                            // Add the newly created TeachingStaff object to the list
                            teachingStaffList.Add(teachingStaff);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log any errors that occur during the retrieval process
                    Console.WriteLine($"Error retrieving teaching staff: {ex.Message}");
                }

                // Return the populated list of teaching staff
                return teachingStaffList;
            } // The connection is automatically closed and disposed of here
        }
        public void AddAdministration(Administration administration)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                // Insert into Users table first to get UserId
                try
                {
                    // SQL query to insert a new user into the Users table
                    string query = @"
            INSERT INTO Users (Name, Telephone, Email, RoleType) 
            VALUES (@Name, @Telephone, @Email, 'Administration');";

                    int userId; // Variable to hold the newly generated UserId

                    // Execute the query to insert the user
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Name", administration.Name);
                        cmd.Parameters.AddWithValue("@Telephone", administration.Telephone);
                        cmd.Parameters.AddWithValue("@Email", administration.Email);

                        cmd.ExecuteNonQuery(); // Execute the insertion command

                        // Get the last inserted UserId
                        string getQuery = "SELECT LAST_INSERT_ID();"; // SQL to retrieve the last inserted ID
                        using (var idCmd = new MySqlCommand(getQuery, conn))
                        {
                            userId = Convert.ToInt32(idCmd.ExecuteScalar()); // Execute and convert result to an integer
                        }
                    }

                    // Insert into Administration table
                    string adminQuery = @"
            INSERT INTO Administration (UserId, Salary, EmploymentType, WorkingHours) 
            VALUES (@UserId, @Salary, @EmploymentType, @WorkingHours);";

                    // Execute the query to insert the administration details
                    using (var adminCmd = new MySqlCommand(adminQuery, conn))
                    {
                        // Add parameters for the administration details
                        adminCmd.Parameters.AddWithValue("@UserId", userId);
                        adminCmd.Parameters.AddWithValue("@Salary", administration.Salary);
                        adminCmd.Parameters.AddWithValue("@EmploymentType", administration.Employment.ToString());
                        adminCmd.Parameters.AddWithValue("@WorkingHours", administration.Workhour);

                        adminCmd.ExecuteNonQuery(); // Execute the insertion command for administration
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show($"Error adding Administration: {ex.Message}");
                }
            }
        }

        public List<Administration> GetAdministrations()
        {
            // Initialize a list to hold Administration objects
            var administrationList = new List<Administration>();

            // Establish a connection to the database
            using (var conn = new MySqlConnection(_connectionString))
            {
                // SQL query to retrieve administration details along with user information
                string query = @"
        SELECT u.Id AS UserId, u.Name, u.Telephone, u.Email, a.Salary, a.EmploymentType, a.WorkingHours 
        FROM Administration a
        JOIN Users u ON a.UserId = u.Id";

                var cmd = new MySqlCommand(query, conn);
                conn.Open(); // Open the database connection

                try
                {
                    // Execute the query and read the results
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Parse the EmploymentType enum from the database
                            if (Enum.TryParse(reader["EmploymentType"].ToString(), out Administration.EmploymentType employmentType))
                            {
                                // Create a new Administration object with the retrieved data
                                var administration = new Administration(
                                    reader["Name"].ToString(),
                                    reader["Telephone"].ToString(),
                                    reader["Email"].ToString(),
                                    Convert.ToDecimal(reader["Salary"]),
                                    Convert.ToInt32(reader["WorkingHours"]),
                                    employmentType
                                )
                                {
                                    ID = Convert.ToInt32(reader["UserId"]) // Assign the UserId to the Administration object
                                };

                                // Add the new administration object to the list
                                administrationList.Add(administration);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during data retrieval
                    MessageBox.Show($"Error retrieving administration: {ex.Message}");
                }

                // Return the list of administrations
                return administrationList;
            }
        }
        public void AddStudent(Student student)
        {
            using (var conn = new MySqlConnection(_connectionString)) // Establish a connection to the database
            {
                conn.Open(); // Open the connection

                int userId;

                // Insert the user into the Users table
                try
                {
                    string userQuery = @"
INSERT INTO Users (Name, Telephone, Email, RoleType)
VALUES (@Name, @Telephone, @Email, 'Students');";

                    using (var userCmd = new MySqlCommand(userQuery, conn)) // Create command for user insertion
                    {
                        userCmd.Parameters.AddWithValue("@Name", student.Name); // Set parameters
                        userCmd.Parameters.AddWithValue("@Telephone", student.Telephone);
                        userCmd.Parameters.AddWithValue("@Email", student.Email);

                        userCmd.ExecuteNonQuery(); // Execute the user insertion

                        // Get the last inserted UserId
                        using (var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn)) // Retrieve the last inserted ID
                        {
                            userId = Convert.ToInt32(idCmd.ExecuteScalar()); // Store the user ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}"); // Show error message
                    return; // Exit if user insertion fails
                }

                // Insert into the Students table
                try
                {
                    string studentQuery = @"
INSERT INTO Students (UserId, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2)
VALUES (@UserId, @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2);";

                    using (var studentCmd = new MySqlCommand(studentQuery, conn)) // Create command for student insertion
                    {
                        studentCmd.Parameters.AddWithValue("@UserId", userId); // Set parameters
                        studentCmd.Parameters.AddWithValue("@CurrentSubject1", student.Subject1);
                        studentCmd.Parameters.AddWithValue("@CurrentSubject2", student.Subject2);
                        studentCmd.Parameters.AddWithValue("@PreviousSubject1", student.Presubject1);
                        studentCmd.Parameters.AddWithValue("@PreviousSubject2", student.Presubject2);

                        studentCmd.ExecuteNonQuery(); // Execute the student insertion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding student: {ex.Message}"); // Show error message
                }
            }
        }

        public List<Student> GetStudents()
        {
            var studentList = new List<Student>(); // Initialize a list to hold students
            using (var conn = new MySqlConnection(_connectionString)) // Establish a connection to the database
            {
                string query = @"
SELECT u.Id AS UserId, u.Name, u.Telephone, u.Email, 
       s.CurrentSubject1, s.CurrentSubject2, 
       s.PreviousSubject1, s.PreviousSubject2
FROM Students s
JOIN Users u ON s.UserId = u.Id"; // SQL query to join Students and Users tables

                var cmd = new MySqlCommand(query, conn);
                conn.Open(); // Open the connection

                try
                {
                    using (var reader = cmd.ExecuteReader()) // Execute the query and read results
                    {
                        while (reader.Read()) // Loop through each record
                        {
                            var student = new Student(
                                reader["Name"].ToString(),
                                reader["Telephone"].ToString(),
                                reader["Email"].ToString(),
                                reader["CurrentSubject1"].ToString(),
                                reader["CurrentSubject2"].ToString(),
                                reader["PreviousSubject1"].ToString(),
                                reader["PreviousSubject2"].ToString()
                            )
                            {
                                ID = Convert.ToInt32(reader["UserId"]) // Set the student ID
                            };

                            studentList.Add(student); // Add the student to the list
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving student: {ex.Message}"); // Handle any errors
                }

                return studentList; // Return the list of students
            }
        }
        public void UpdateTeachingStaff(TeachingStaff teachingStaff)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                // Update the Users table
                try
                {
                    // SQL query to update user information
                    string userQuery = "UPDATE Users SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE ID = @ID";
                    using (var userCmd = new MySqlCommand(userQuery, conn))
                    {
                        // Add parameters to the SQL command
                        userCmd.Parameters.AddWithValue("@ID", teachingStaff.ID);
                        userCmd.Parameters.AddWithValue("@Name", teachingStaff.Name);
                        userCmd.Parameters.AddWithValue("@Telephone", teachingStaff.Telephone);
                        userCmd.Parameters.AddWithValue("@Email", teachingStaff.Email);

                        // Execute the command to update the user
                        userCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if the update fails
                    MessageBox.Show($"Error Updating User: {ex.Message}");
                    return; // Exit the method to avoid proceeding if there's an error
                }

                // Update the TeachingStaff table
                try
                {
                    // SQL query to update teaching staff details
                    string staffQuery = "UPDATE TeachingStaff SET Salary = @Salary, Subject1 = @Subject1, Subject2 = @Subject2 WHERE UserId = @UserId";
                    using (var staffCmd = new MySqlCommand(staffQuery, conn))
                    {
                        // Add parameters to the SQL command
                        staffCmd.Parameters.AddWithValue("@UserId", teachingStaff.ID);
                        staffCmd.Parameters.AddWithValue("@Salary", teachingStaff.Salary);
                        staffCmd.Parameters.AddWithValue("@Subject1", teachingStaff.Subject1);
                        staffCmd.Parameters.AddWithValue("@Subject2", teachingStaff.Subject2);

                        // Execute the command to update the teaching staff record
                        staffCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if the update fails
                    MessageBox.Show($"Error Updating TeachingStaff: {ex.Message}");
                }
            } // The connection is automatically closed and disposed of here
        }

        public void UpdateAdministration(Administration admin)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                // Update Users table
                try
                {
                    // SQL query to update user details in the Users table
                    string userQuery = "UPDATE Users SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE ID = @ID";
                    using (var userCmd = new MySqlCommand(userQuery, conn))
                    {
                        // Assign parameter values for the user update query
                        userCmd.Parameters.AddWithValue("@ID", admin.ID);
                        userCmd.Parameters.AddWithValue("@Name", admin.Name);
                        userCmd.Parameters.AddWithValue("@Telephone", admin.Telephone);
                        userCmd.Parameters.AddWithValue("@Email", admin.Email);

                        // Execute the command to update the user information
                        userCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during user update
                    MessageBox.Show($"Error Updating User: {ex.Message}");
                    return; // Exit the method if user update fails
                }

                // Update Administration table
                try
                {
                    // SQL query to update administration details in the Administration table
                    string adminQuery = "UPDATE Administration SET Salary = @Salary, WorkingHours = @WorkingHours, EmploymentType = @EmploymentType WHERE UserId = @UserId";
                    using (var adminCmd = new MySqlCommand(adminQuery, conn))
                    {
                        // Assign parameter values for the administration update query
                        adminCmd.Parameters.AddWithValue("@UserId", admin.ID);
                        adminCmd.Parameters.AddWithValue("@Salary", admin.Salary);
                        adminCmd.Parameters.AddWithValue("@WorkingHours", admin.Workhour);
                        adminCmd.Parameters.AddWithValue("@EmploymentType", admin.Employment.ToString());

                        // Execute the command to update the administration information
                        adminCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during administration update
                    MessageBox.Show($"Error Updating Administration: {ex.Message}");
                }
            }
        }
        public void UpdateStudent(Student student)
        {
            using (var conn = new MySqlConnection(_connectionString)) // Establish a connection to the database
            {
                conn.Open(); // Open the connection
                try
                {
                    // Update query for the Users table
                    string userquery = "UPDATE Users SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE ID = @ID";
                    using (var userCmd = new MySqlCommand(userquery, conn))
                    {
                        // Adding parameters to prevent SQL injection
                        userCmd.Parameters.AddWithValue("@ID", student.ID);
                        userCmd.Parameters.AddWithValue("@Name", student.Name);
                        userCmd.Parameters.AddWithValue("@Telephone", student.Telephone);
                        userCmd.Parameters.AddWithValue("@Email", student.Email);

                        userCmd.ExecuteNonQuery(); // Execute the command
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating User: {ex.Message}"); // Handle user update errors
                    return; // Exit if user update fails
                }

                try
                {
                    // Update query for the Students table
                    string stuquery = "UPDATE Students SET CurrentSubject1 = @CurrentSubject1, CurrentSubject2 = @CurrentSubject2, PreviousSubject1 = @PreviousSubject1, PreviousSubject2 = @PreviousSubject2 WHERE UserId = @UserId";
                    using (var stucmd = new MySqlCommand(stuquery, conn))
                    {
                        // Adding parameters for the student update
                        stucmd.Parameters.AddWithValue("@UserId", student.ID);
                        stucmd.Parameters.AddWithValue("@CurrentSubject1", student.Subject1);
                        stucmd.Parameters.AddWithValue("@CurrentSubject2", student.Subject2);
                        stucmd.Parameters.AddWithValue("@PreviousSubject1", student.Presubject1);
                        stucmd.Parameters.AddWithValue("@PreviousSubject2", student.Presubject2);

                        stucmd.ExecuteNonQuery(); // Execute the command
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating Student: {ex.Message}"); // Handle student update errors
                }
            }
        }
        public void DeleteTeachingStaff(int userId)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                try
                {
                    // SQL query to delete a teaching staff record based on UserId
                    string deleteTeachingStaffQuery = "DELETE FROM TeachingStaff WHERE UserId = @UserId";
                    using (var teachingStaffCmd = new MySqlCommand(deleteTeachingStaffQuery, conn))
                    {
                        teachingStaffCmd.Parameters.AddWithValue("@UserId", userId); // Add the UserId parameter
                        teachingStaffCmd.ExecuteNonQuery(); // Execute the deletion command
                    }

                    // SQL query to delete the corresponding user record from the Users table
                    string deleteUserQuery = "DELETE FROM Users WHERE Id = @Id";
                    using (var userCmd = new MySqlCommand(deleteUserQuery, conn))
                    {
                        userCmd.Parameters.AddWithValue("@Id", userId); // Add the Id parameter
                        userCmd.ExecuteNonQuery(); // Execute the deletion command
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during deletion
                    MessageBox.Show($"Error Deleting User or TeachingStaff: {ex.Message}");
                }
            }
        }
        public void DeleteAdministration(int userId)
        {
            // Establish a connection to the database using the connection string
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open(); // Open the database connection

                try
                {
                    // SQL query to delete the administration record for the specified user
                    string deleteTeachingStaffQuery = "DELETE FROM Administration WHERE UserId = @UserId";
                    using (var teachingStaffCmd = new MySqlCommand(deleteTeachingStaffQuery, conn))
                    {
                        // Assign the user ID parameter for the deletion query
                        teachingStaffCmd.Parameters.AddWithValue("@UserId", userId);
                        teachingStaffCmd.ExecuteNonQuery(); // Execute the command to delete the administration record
                    }

                    // SQL query to delete the user record from the Users table
                    string deleteUserQuery = "DELETE FROM Users WHERE Id = @Id";
                    using (var userCmd = new MySqlCommand(deleteUserQuery, conn))
                    {
                        // Assign the user ID parameter for the deletion query
                        userCmd.Parameters.AddWithValue("@Id", userId);
                        userCmd.ExecuteNonQuery(); // Execute the command to delete the user record
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during deletion
                    MessageBox.Show($"Error Deleting User or Administration: {ex.Message}");
                }
            }
        }
        public void DeleteStudent(int userId)
        {
            using (var conn = new MySqlConnection(_connectionString)) // Establish a database connection
            {
                conn.Open(); // Open the connection

                try
                {
                    // Query to delete the student record
                    string deleteTeachingStaffQuery = "DELETE FROM Students WHERE UserId = @UserId";
                    using (var teachingStaffCmd = new MySqlCommand(deleteTeachingStaffQuery, conn))
                    {
                        teachingStaffCmd.Parameters.AddWithValue("@UserId", userId); // Add parameter to prevent SQL injection
                        teachingStaffCmd.ExecuteNonQuery(); // Execute the delete command
                    }

                    // Query to delete the user record
                    string deleteUserQuery = "DELETE FROM Users WHERE Id = @Id";
                    using (var userCmd = new MySqlCommand(deleteUserQuery, conn))
                    {
                        userCmd.Parameters.AddWithValue("@Id", userId); // Add parameter to prevent SQL injection
                        userCmd.ExecuteNonQuery(); // Execute the delete command
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show($"Error Deleting User or Student: {ex.Message}");
                }
            }
        }

        public List<UserViewModel> GetAllData()
        {
            var users = new List<UserViewModel>();

            string query = @"
    SELECT 'Administration' AS RoleType, UserId AS id, name, telephone, email, salary, WorkingHours AS WorkHours, NULL AS subject1, NULL AS subject2, NULL AS currentSubject1, NULL AS currentSubject2, NULL AS previousSubject1, NULL AS previousSubject2, EmploymentType
    FROM Administration
    JOIN Users ON Administration.UserId = Users.Id
    UNION
    SELECT 'TeachingStaff' AS RoleType, UserId AS id, name, telephone, email, salary, NULL AS WorkHours, Subject1, Subject2, NULL AS currentSubject1, NULL AS currentSubject2, NULL AS previousSubject1, NULL AS previousSubject2, NULL AS EmploymentType
    FROM TeachingStaff
    JOIN Users ON TeachingStaff.UserId = Users.Id
    UNION
    SELECT 'Students' AS RoleType, UserId AS id, name, telephone, email, NULL AS salary, NULL AS WorkHours, NULL AS subject1, NULL AS subject2, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2, NULL AS EmploymentType
    FROM Students
    JOIN Users ON Students.UserId = Users.Id
    ORDER BY RoleType, name;
    ";

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userViewModel = new UserViewModel
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Telephone = reader["telephone"].ToString(),
                                Email = reader["email"].ToString(),
                                RoleType = reader["RoleType"].ToString(),
                                Salary = reader["Salary"] != DBNull.Value ? Convert.ToDecimal(reader["Salary"]) : (decimal?)null,
                                WorkHours = reader["WorkHours"] != DBNull.Value ? Convert.ToInt32(reader["WorkHours"]) : (int?)null,
                                Subject1 = reader["Subject1"]?.ToString(),
                                Subject2 = reader["Subject2"]?.ToString(),
                                CurrentSubject1 = reader["CurrentSubject1"]?.ToString(),
                                CurrentSubject2 = reader["CurrentSubject2"]?.ToString(),
                                PreviousSubject1 = reader["PreviousSubject1"]?.ToString(),
                                PreviousSubject2 = reader["PreviousSubject2"]?.ToString(),
                                EmploymentType = reader["EmploymentType"]?.ToString()
                            };

                            users.Add(userViewModel);
                        }
                    }
                }
            }

            return users;
        }

    }
}

        





