using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    internal class Mahasiswa
    {
        //Fled
        private string _nama;
        private string _nim;
        private float _ipk;
        public float _ipkstandar;
        public float _ipkmaks;
        public float _ipkdibawah;

        //Properti


        public float ipkmaks = 4f;
        public float ipkdibawah = 3f;

        public string Nama
        {
            get
            {
                return _nama;
            } 
            set
            {
                _nama = value;
            }
        }
        public string Nim
        {
            get
            {
                return _nim;
            }
            set
            {
                _nim = value;
            }
        }
        public float Ipk
        {
            get
            {
                return _ipk;
            }
            set
            {
                _ipk = value;
            }
        }
        public float Ipkstandar
        {
            get
            {
                return _ipkstandar;
            }
            set
            {
                _ipkstandar = value;
            }
        }

        public float Ipkmaks
        {
            get
            {
                return _ipkmaks;
            }
            set
            {
                _ipkmaks = value;
            }
        }

        public float Ipkdibawah
        {
            get
            {
                return _ipkdibawah;
            }
            set
            {
                _ipkdibawah = value;
            }
        }


        public void InfoMahasiswa()
        {
            Console.WriteLine("----------Mahasiswa Hadir----------");
            Console.WriteLine("Dengan Nama : {0}", Nama);
            Console.WriteLine("Dengan Nim : {0}", Nim);
            Console.WriteLine("Dengan Ipk : {0}", Ipk);

            if (Ipk > ipkmaks) 
            {
                Console.WriteLine("Jangan asal isi ipk");
            }
            else if (Ipk < ipkdibawah)
            {
                Console.WriteLine("Kamu bodoh");
            }
            else if (Ipk >= ipkmaks && Ipk <= Ipkdibawah)
            {
                Console.WriteLine("Selamat Kamu lulus");
            }
            

            }
        }
    }
