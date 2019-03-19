using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Mahasiswa
    {
        //Properties
        public string nim { get; set; }
        public string nama { get; set; }
        public float ipk { get; set; }

        //Method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("NIM : {0}", nim );
            Console.WriteLine("IPK : {0}", ipk);
            Console.WriteLine("Telah melakukan registrasi");
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses KRS\n", nama);
        }
    }
}
