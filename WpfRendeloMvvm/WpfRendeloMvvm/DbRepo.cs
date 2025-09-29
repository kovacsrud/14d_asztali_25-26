using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using WpfRendeloMvvm.Mvvm.Model;
using System.Windows;

namespace WpfRendeloMvvm
{
    public static class DbRepo
    {
        public static List<Kutyanev> GetKutyanevek()
        {
            List<Kutyanev> kutyanevek= new List<Kutyanev>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Config.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyanevek";
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand,connection))
                    {
                        using (SQLiteDataReader reader=command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kutyanev kutyanev = new Kutyanev {
                                    Id=Convert.ToInt32(reader["Id"]),
                                    KutyaNev=reader["kutyanev"].ToString()
                                };

                                kutyanevek.Add(kutyanev);
                            }
                        }
                    }
                }
            }
            catch(SQLiteException ex) { 
                MessageBox.Show("Adatbázis hiba:"+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }


            return kutyanevek;
        }

        public static List<Rendeles> GetRendelesek()
        {
            List<Rendeles> rendelesek= new List<Rendeles>();

            try
            {
                using (SQLiteConnection connection=new SQLiteConnection(Config.connectionString))
                {
                    connection.Open();
                    string sqlCommand = @"select kutya.Id as Id,
                                         fajtaid,
                                         nevid,
                                         eletkor,
                                         utolsoell,
                                         kutyanev,
                                         nev as fajtanev
                                         from kutya,kutyanevek,kutyafajtak
                                         where kutya.fajtaid=kutyafajtak.Id and kutya.nevid=kutyanevek.Id";
                    using (SQLiteCommand command=new SQLiteCommand(sqlCommand,connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) {
                                Rendeles rendeles = new Rendeles
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    NevId = Convert.ToInt32(reader["nevid"]),
                                    FajtaId = Convert.ToInt32(reader["fajtaid"]),
                                    Eletkor = Convert.ToInt32(reader["eletkor"]),
                                    UtolsoEll = reader["utolsoell"].ToString(),
                                    Fajta = reader["fajtanev"].ToString(),
                                    Nev = reader["kutyanev"].ToString()

                                };

                                rendelesek.Add(rendeles);
                            }
                        }
                    }

                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Adatbázis hiba:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return rendelesek;
        }

    }
}
