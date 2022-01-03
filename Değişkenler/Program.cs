using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            char chr = '2';     // 2 byte   

            String degisken2 = null ; 
            String degisken = " "; 

            byte b = 5 ;        // 1 byte   0..255              arası
            sbyte s = 127 ;     // 1 byte   -128..127           arası
            short sh = 4 ;      // 2 byte   -32,768..32768      arası
            ushort ush = 4;     // 2 byte   0..65365            arası

            Int16 i16 = 2 ;     // 2 byte   
            int   i = 2 ;       // 4 byte
            Int32 i32 = 2 ;     // 4 byte
            Int64 i64 = 4 ;     // 8 byte

            uint ui = 4;        // 4 byte
            long l = 4 ;        // 8 byte
            ulong ul = 8 ;      // 8 byte 

            float f = 5 ;      // 4 byte
            double d = 5 ;     // 8 byte 
            decimal de = 5 ;   // 16 byte    
            
            bool b1 =true ;    
            bool b2 = false ; 

            DateTime dt = DateTime.Now ; 

            Console.WriteLine(dt); 

            object ob1 = "x";
            object ob2 = 'y';
            object ob3 = 4;
            object ob4 = 4.3;

            // String denemeleri !!!!!

            String str1 = string.Empty; 
            str1 = "Timuçin AYDOĞDU" ; 
            string ad = "Timuçin" ; 
            string soyad = "AYDOĞDU" ; 
            string tamad = ad +" " + soyad;

            Console.WriteLine(tamad);

            // İnteger tanımlama şekilleri !!!!!

            int integer1 = 3 ; 
            int integer2 = 5 ; 
            int integer3 = integer1 +integer2;

            Console.WriteLine(integer3) ; 

            // Boolean tanemleme şekilleri !!!!!!!

            Boolean bool1 = 10>2 ; 

            // Değişken Dönüşümleri !!!!!

            string str20 = "20"; 
            int int20 = 20 ; 

            string yenideger = str20 + int20.ToString(); 
            Console.WriteLine(yenideger); 
            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); 

            int int22 = int20 +int.Parse( str20 );
            Console.WriteLine(int22);

            // Date time yapıları 

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); 
            Console.WriteLine(datetime); 

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy"); 
            Console.WriteLine(datetime1); 



        }
    }
}
