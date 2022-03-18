using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaturitaKonzole
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fsr = new FileStream("složka ne vstup", FileMode.Open);
            FileStream fsw = new FileStream("složka ne vstup", FileMode.Create);
            StreamReader sr = new StreamReader(fsr);
            StreamWriter sw = new StreamWriter(fsw);

            string sValue;
            while ((sValue = sr.ReadLine()) != null)
            {
                sw.WriteLine(sValue)
            }

            sw.Flush();

            sr.Close();
            sw.Close();


        }
    }
}
