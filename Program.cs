using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanlist2
{
    public class Program
    {
        public class Dosen
        {
            public string Nik { get; set; }
            public string NamaDosen { get; set; }
        }

        public class Mahasiswa
        {
            public string Nim { get; set; }
            public string NamaMahasiswa { get; set; }
        }
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);

            Console.WriteLine("Nim\tNama");
            Console.WriteLine("============");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0} \t{1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            //untuk mengakses elemen list dosen
            //Console.WriteLine("{0}, \t{1}", dosen.Nik, dosen.NamaDosen);

            Console.ReadKey();
        }
    }
}

