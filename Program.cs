namespace diziler2{
    

    class Program{
        static void Main(String[] args){
            //Sort sıralama işlemi

            int[] sayilar={23,78,98,35,12,75,18,3};
            Console.WriteLine("Sort Metodu");
            Array.Sort(sayilar); //diziyi küçükten büyüge sıralar
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Celar Metodu");
            Array.Clear(sayilar,3,2);//verdigimiz diziden verdiğimiz index ve sonrasında istediğimiz kadar veriyi sıfır yapar.
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("Reverse Metodu");
            Array.Reverse(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("IndexOf Metodu");               
            Console.WriteLine(Array.IndexOf(sayilar,75));
            

            Console.WriteLine("Resize Metodu");

            Array.Resize<int>(ref sayilar,10);
            sayilar[8]=120;
            sayilar[9]=155;
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}
