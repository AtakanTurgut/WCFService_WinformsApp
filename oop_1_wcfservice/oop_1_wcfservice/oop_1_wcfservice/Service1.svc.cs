﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace oop_1_wcfservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static string sqlBaglantiDemo = "Database=ardacnk2_oop; Data Source=localhost; UID=ardac_oopuser; PASSWORD=OopUser32.";
        MySqlConnection baglantiDemo = new MySqlConnection(Service1.sqlBaglantiDemo);

        int err = 0;
        public int personelEkle(string ad, string soyad, int tur)
        {
            baglantiDemo.Open();
            MySqlCommand personelEkleCommand = new MySqlCommand("insert " +
                "into personel (ad,soyad,tur) values ('" + ad + "','" + soyad + "','" + tur + "')", baglantiDemo);

            int sonuc = personelEkleCommand.ExecuteNonQuery();
            if (sonuc == 0)
            {
                err++;
            }
            return err;
        }
    }
}
