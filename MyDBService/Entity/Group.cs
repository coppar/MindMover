using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace MyDBService.Entity
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserList { get; set; }
        public string RoleList { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Deleted { get; set; }

        public Group(string id, string name, string description, string userList, string roleList, DateTime createdAt, string deleted)
        {
            Id = id;
            Name = name;
            Description = description;
            UserList = userList;
            UserList = userList;
            RoleList = roleList;
            CreatedAt = createdAt;
            Deleted = deleted;
        }
        public Group(string name, string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            UserList = "";
            RoleList = "";
            CreatedAt = DateTime.Now;
            Deleted = "true";
        }
        public Group() { }
        public int Insert()
        {
            // connect to database using app.config connection string
            string DBConnect = ConfigurationManager.ConnectionStrings["MindmoverDb"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "INSERT INTO [Group] (id, name, description, userList, roleList, createdAt, deleted) " +
                "VALUES (@paraId, @paraName, @paraDescription, @paraUserList, @paraRoleList, @paraCreatedAt, @paraDeleted)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraId", Id);
            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraDescription", Description);
            sqlCmd.Parameters.AddWithValue("@paraUserList", UserList);
            sqlCmd.Parameters.AddWithValue("@paraRoleList", RoleList);
            sqlCmd.Parameters.AddWithValue("@paraCreatedAt", CreatedAt);
            sqlCmd.Parameters.AddWithValue("@paraDeleted", Deleted);

            // Open connection the execute NonQuery of sql command   
            myConn.Open();
            
            int result = sqlCmd.ExecuteNonQuery();

            // Close connection
            myConn.Close();

            return result;
        }
        public Group SelectById(string id)
        {
            // connect to database using app.config connection string
            string DBConnect = ConfigurationManager.ConnectionStrings["MindmoverDb"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from [Group] where id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            // Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            // Use the DataAdapter to fill the DataSet with data retrieved
             da.Fill(ds);

            // Read data from DataSet.
            Group grp = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string grpid = row["id"].ToString();
                string name = row["name"].ToString();
                string description = row["description"].ToString();
                string userList = row["userList"].ToString();/*.Split(',').ToList(); */
                string roleList = row["roleList"].ToString();/*.Split(',').ToList(); */
                DateTime createdAt = Convert.ToDateTime(row["createdAt"].ToString());
                string deleted = row["deleted"].ToString();
                Group obj = new Group(grpid, name, description, userList, roleList, createdAt, deleted);
                grp = obj;
            }
            return grp;
        }

        //
        // This method selects all the existing groups
        //
        public List<Group> SelectAll()
        {   
            // connect to database using app.config connection string
            string DBConnect = ConfigurationManager.ConnectionStrings["MindmoverDb"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from [Group]";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            // Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            // Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            // Read data from DataSet to List
            List<Group> grpList = new List<Group>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string description = row["description"].ToString();
                string userList = row["userList"].ToString();/*.Split(',').ToList();*/
                string roleList = row["roleList"].ToString();/*.Split(',').ToList();*/
                DateTime createdAt = Convert.ToDateTime(row["createdAt"].ToString());
                string deleted = row["deleted"].ToString();
                Group obj = new Group(id, name, description, userList, roleList, createdAt, deleted);
                grpList.Add(obj);
            }
            return grpList;
        }
    }
}

