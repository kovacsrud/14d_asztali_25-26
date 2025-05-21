using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfKutyakDb.model;
using System.Data.SQLite;

namespace WpfKutyakDb
{
    public static class DbRepo
    {
        public static List<Kutyanev> GetKutyanevek()
        {
            List<Kutyanev> kutyanevek= new List<Kutyanev>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyanevek";
                    
                    using (SQLiteCommand command=new SQLiteCommand(sqlCommand,connection))
                    {
                        using (SQLiteDataReader reader=command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kutyanev kutyanev = new Kutyanev();
                                kutyanev.Id = Convert.ToInt32(reader["Id"]);
                                kutyanev.KutyaNev = reader["kutyanev"].ToString();

                                kutyanevek.Add(kutyanev);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }

            return kutyanevek;
        }

        public static void UjKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection=new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "insert into kutyanevek (kutyanev) values(@kutyanev)";

                    using (SQLiteCommand command=new SQLiteCommand(insertCommand,connection))
                    {
                        command.Parameters.AddWithValue("@kutyanev",kutyanev.KutyaNev);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok} sor beszúrva.");
                    }

                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show($"Adatbázis hiba:{sqlex.Message}", "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }

        public static void ModositKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string updateCommand = "update kutyanevek set kutyanev=@kutyanev where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(updateCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id",kutyanev.Id);
                        command.Parameters.AddWithValue("@kutyanev", kutyanev.KutyaNev);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok} sor módosítva.");
                    }

                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show($"Adatbázis hiba:{sqlex.Message}", "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

        public static void TorolKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string deleteCommand = "delete from kutyanevek where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", kutyanev.Id);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok} sor törölve.");
                    }

                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show($"Adatbázis hiba:{sqlex.Message}", "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

        public static List<Rendeles> GetRendelesiAdatok()
        {
            List<Rendeles> rendelesLista = new List<Rendeles>();

            try
            {
                using (SQLiteConnection connection=new SQLiteConnection(DbTools.connectionString))
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
                        using (SQLiteDataReader reader=command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rendeles rendeles = new Rendeles();
                                rendeles.Id = Convert.ToInt32(reader["Id"]);
                                rendeles.NevId = Convert.ToInt32(reader["nevid"]);
                                rendeles.FajtaId= Convert.ToInt32(reader["fajtaid"]);
                                rendeles.Eletkor= Convert.ToInt32(reader["eletkor"]);
                                rendeles.UtolsoEll = reader["utolsoell"].ToString();
                                rendeles.FajtaNev = reader["fajtanev"].ToString();
                                rendeles.KutyaNev = reader["kutyanev"].ToString();

                                rendelesLista.Add(rendeles);

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }


            return rendelesLista;
        }
    }
}
