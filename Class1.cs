using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Class1
    {
        //БД

using System.Windows.Controls;
using System.Data.SqlClient;

     public static Frame MainFrame { get; set; }
    public static SqlConnection connection { get; set; }

    InitializeComponent();
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    builder.DataSource = @"DESKTOP-C848VBU\SQLEXPRESS";
            builder.InitialCatalog = "PAVILIONS";
            builder.IntegratedSecurity = true;
            Manager.connection = new SqlConnection(builder.ConnectionString);
    MainFrame.Navigate(new Table1());
            Manager.MainFrame = MainFrame;
переход
            Manager.MainFrame.Navigate(new Table3())
добавление
            if (Userlogin.Text.Length =""){}
             else
{
    try
    {
        ClassBook.connection.Open();
        string registration = "insert into Client VALUES(@name_value, @email_value, @pass_value )";
        SqlCommand cmd = new SqlCommand(registration, ClassBook.connection);
        Удаление
                try
        {
            Manager.connection.Open();
            string Delete = "DELETE FROM Pavilions WHERE id_pavilion = (@id_pavilion)";
            SqlCommand cmd = new SqlCommand(Delete, Manager.connection);
            SqlParameter Delete_param = new SqlParameter("@id_pavilion", Remove_Pavilion_Text.Text);
            cmd.Parameters.Add(Delete_param);
            cmd.ExecuteNonQuery();
            Notify.Content = "Павильон удален!!!";
        }
        catch (SqlException err)
        { Notify.Content = "Невозможно удалить павильон"; }
        Manager.connection.Close();
    }
Редактирование
                       Manager.connection.Open();
    string registration = "UPDATE Pavilions SET id_shop_center = @Number_SC_value,";
    SqlCommand cmd = new SqlCommand(registration, Manager.connection);
    Вывод
        {
        Manager.connection.Open();
        string cmd = "SELECT dbo.Shoping_Center.shop_center_name AS [Название торгового центра], dbo.Shoping_Center.status AS [Статус торгового центра], dbo.Pavilions.floor AS Этаж, " +
            "dbo.Pavilions.area AS [Площадь павильона], dbo.Pavilions.status AS [Статус павильона], dbo.Pavilions.var_coefficient AS [кдс], " +
            "dbo.Pavilions.price_metr AS [Цена за метр] FROM Pavilions INNER JOIN " +
            "dbo.Shoping_Center ON id_shop_center = Shoping_Center.shop_center_id"; // Из какой таблицы нужен вывод 
        SqlCommand createCommand = new SqlCommand(cmd, Manager.connection);
        createCommand.ExecuteNonQuery();

        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
        DataTable dt = new DataTable("Pavilions"); // В скобках указываем название таблицы
        dataAdp.Fill(dt);
        DataGridView.ItemsSource = dt.DefaultView; // Сам вывод 
        Manager.connection.Close();
    }

    Ввод
                   string registration = "insert into Pavilions VALUES(@Number_SC_value,...)";
    SqlCommand cmd = new SqlCommand(registration, Manager.connection);
}
}
