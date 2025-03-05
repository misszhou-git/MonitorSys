using System;
using System.Data;
using System.Data.SqlClient;
using QQDESK.Models;

public static class DatabaseHelper
{
    private static string GetConnectionString()
    {
        // 请根据实际情况修改下面的连接字符串
        return @"Server=localhost;Database=Monitor_Winform;Trusted_Connection=True;";
    }

    public static SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(GetConnectionString());
        try
        {
            connection.Open();
            Console.WriteLine(("数据库连接成功！")); 
        }
        catch (Exception ex)
        {
            MessageBox.Show("数据库连接失败：" + ex.Message);
        }
        return connection;
    }

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="user">当前用户类</param>
    public static void AddUser(User user)
    {
        try
        {
            string sql = "INSERT INTO Users (Id,Account,UserName, Password,Email,Phone) " +
                "VALUES (@Id,@Account,@UserName,@Password,@Email,@Phone)";
            using (SqlCommand command = new SqlCommand(sql, GetConnection()))
            {
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@Account", user.Account);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    //删除
    //更新
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="Id">当前用户id或null</param>
    public static List<User> QueryUser(string Id)
    {
        List<User> users = new List<User>();
        try
        {
            if (Id == null)
            {
                //查询所有
                string sql = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(sql, GetConnection());
                // 执行查询并获取SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 构建用户数据
                        User data = new User();
                        data.Id = reader.GetString(reader.GetOrdinal("Id"));
                        data.Account = reader.GetString(reader.GetOrdinal("Account"));
                        data.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                        data.Password = reader.GetString(reader.GetOrdinal("Password"));
                        data.Email = reader.GetString(reader.GetOrdinal("Email"));
                        data.Phone = reader.GetString(reader.GetOrdinal("Phone"));

                        users.Add(data); // 或者将数据绑定到WinForms控件中
                    }
                    
                }
             
            }
            else
            {
                
            }
        }
        catch { }
        return users;
    }

}