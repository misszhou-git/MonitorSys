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

    //新增

    public static void AddUser(User user)
    {
        try
        {
            string query = "INSERT INTO Users (UserName, Password) VALUES (@user.UserName, @user.Password)";
            SqlCommand command = new SqlCommand(query, GetConnection());
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}