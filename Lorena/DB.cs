using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;

namespace Lorena
{
  public class Salon
  {
    public long id { get; set; }
    public long pid { get; set; }
    public string name { get; set; }
    public float discount { get; set; }
    public short depend { get; set; }
    public string description { get; set; }
  }

  public class Results
  {
    public long id { get; set; }
    public long sid { get; set; }
    public float price { get; set; }
    public float result { get; set; }
  }

  public sealed class DB
  {
    private static volatile DB instance;
    private static object syncRoot = new Object();

    private string dbName = "database.db";

    private DB() {}

    public static DB Get
    {
      get 
      {
         if (instance == null) 
         {
            lock (syncRoot) 
            {
               if (instance == null) 
                 instance = new DB();
            }
         }

         return instance;
      }
    }

    public bool prepare()
    {
      bool res = true;

      if (!System.IO.File.Exists( dbName ))
      {
        SQLiteConnection.CreateFile( dbName );

        using (SQLiteConnection conn = new SQLiteConnection( "Data Source=" + dbName + "; Version=3;" ))
        {
          conn.Open();

          SQLiteCommand cmd = conn.CreateCommand();

          string sqlCommand =
            "CREATE TABLE salon ("
            + "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, "
            + "pid INTEER DEFAULT 0, "
            + "name TEXT DEFAULT '', "
            + "discount REAL DEFAULT 0, "
            + "depend INTEGER(1) DEFAULT 0, "
            + "description TEXT(124) DEFAULT '');"

            + "INSERT INTO salon (pid, name, discount, depend, description) "
            + "VALUES (0, 'Миасс', 4.0, 0, 'Описание для Миасс');"
            + "INSERT INTO salon (pid, name, discount, depend, description) "
            + "VALUES (1, 'Амелия', 5.0, 1, 'Описание для Амелия');"
            + "INSERT INTO salon (pid, name, discount, depend, description) "
            + "VALUES (2, 'Тест1', 2.0, 1, 'Описание для Тест1');"
            + "INSERT INTO salon (pid, name, discount, depend, description) "
            + "VALUES (1, 'Тест2', 0.0, 1, 'Описание для Тест2');"
            + "INSERT INTO salon (pid, name, discount, depend, description) "
            + "VALUES (0, 'Курган', 11.0, 0, 'Описание для Курган');"

            + "CREATE TABLE results ("
            + "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, "
            + "sid INTEER DEFAULT 0, "
            + "price REAL DEFAULT 0, "
            + "result REAL DEFAULT 0);";

          cmd.CommandText = sqlCommand;

          try
          {
            cmd.ExecuteNonQuery();
          }
          catch (SQLiteException ex)
          {
            MessageBox.Show( ex.Message, "Ошибка" );
            res = false;
          }

          conn.Close();
        }
      }

      return res;
    }

    public void execNonQuery( string query )
    {
      using (SQLiteConnection conn = new SQLiteConnection( "Data Source=" + dbName + "; Version=3;" ))
      {
        conn.Open();

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = query;

        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show( ex.Message, "Ошибка" );
        }

        conn.Close();
      }
    }

    public object execScalar( string query )
    {
      object res = null;

      using (SQLiteConnection conn = new SQLiteConnection( "Data Source=" + dbName + "; Version=3;" ))
      {
        conn.Open();

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = query;

        try
        {
          res = cmd.ExecuteScalar();
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show( ex.Message, "Ошибка" );
        }

        conn.Close();
      }

      return res;
    }

    public List<Salon> execReaderSalon( string query )
    {
      List<Salon> res = new List<Salon>();

      using (SQLiteConnection conn = new SQLiteConnection( "Data Source=" + dbName + "; Version=3;" ))
      {
        conn.Open();

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = query;

        try
        {
          SQLiteDataReader r = cmd.ExecuteReader();

          while (r.Read())
          {
            Salon s = new Salon();
            s.id = Convert.ToInt64( r["id"] );
            s.pid = Convert.ToInt64( r["pid"] );
            s.name = Convert.ToString( r["name"] );
            s.discount = Convert.ToSingle( r["discount"] );
            s.depend = Convert.ToInt16( r["depend"] );
            s.description = Convert.ToString( r["description"] );

            res.Add(s);
          }
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show( ex.Message, "Ошибка" );
        }

        conn.Close();
      }

      return res;
    }

    public List<Results> execReaderResults( string query )
    {
      List<Results> res = new List<Results>();

      using (SQLiteConnection conn = new SQLiteConnection( "Data Source=" + dbName + "; Version=3;" ))
      {
        conn.Open();

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = query;

        try
        {
          SQLiteDataReader r = cmd.ExecuteReader();

          while (r.Read())
          {
            Results s = new Results();
            s.id = Convert.ToInt64( r["id"] );
            s.sid = Convert.ToInt64( r["sid"] );
            s.price = Convert.ToSingle( r["price"] );
            s.result = Convert.ToSingle( r["result"] );

            res.Add(s);
          }
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show( ex.Message, "Ошибка" );
        }

        conn.Close();
      }

      return res;
    }
  }
}
