using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{    
    static class QuickSort
    {

        public static List<int> liste = new List<int>();
        /*Partition fonksiyonumuza son elemanı pivot olarak aldırıyoruz,
        pivot elemanı kendinden büyükleri sağına, küçükleri ise soluna aldırdık.*/
        public static int Partition(string[] A, int LB, int UB) //dizimizi, sol ve sağ elemanlarımızı tanımladık
        {
            int Pv = UB, Lo = LB, Hi = UB - 1; //pivotu en sağdaki sayı seçtiğimiz için UB'yi bir eksiltip pivotun yanına alıyoruz
            while (Lo <= UB && Hi >= LB) //döngümüze uyan durumlarda
            {
                if (int.Parse(A[Hi]) > int.Parse(A[Pv])) //eğer dizimizin hi değeri pivot değerinden büyük ise
                {
                    Hi--; continue; // hi değerini sola kaydırıyoruz
                }
                if (int.Parse(A[Lo]) < int.Parse(A[Pv]))//eğer dizimizin lo değeri pivot değerinden küçük ise
                {
                    Lo++; continue; // lo değerini sağa kaydırıyoruz
                }
                if (Lo < Hi) //lo değerimiz hi değerinden düşük ise
                {
                    string temp1 = A[Hi]; //dizimizin hi değişkenini temp1 değişkenine atıyoruz
                    A[Hi] = A[Lo]; // hi ve lov değerlerini eşitliyoruz
                    A[Lo] = temp1;// lo değerini temp1 değişkenine atıyoruz
                }
                else
                {
                    break; //uymuyorsa kırıyoruz döngümüzü
                }
            }
            string temp = A[Pv];//temp değişkenini pivot yapıyoruz
            A[Pv] = A[Lo];//pivot değerimizi lo değerliyle eşitleyip temp değişkenine atıyoruz
            A[Lo] = temp;
            Pv = Lo;//pivotumuz Lo değeri oluyor
            return Pv;
        }
        /*QuickSort'u uygulayan ana işlev
A[] --> Sıralanacak dizi,
LB --> Başlangıç dizini,
UB --> Bitiş dizini*/
        public static void QuickSorting(string[] A, int LB, int UB)
        {
            if (LB <= UB)
            {
                /* Pv pivot indeksidir, a[Pv] şimdi
doğru yerde */
                int Pv = Partition(A, LB, UB);                
                liste.Add(Pv);
                //önce öğeleri ayrı ayrı sıralıyoruz
                QuickSorting(A, LB, Pv - 1);
                // böldükten sonra tekrar pivotu kaydırıp bölme işlemi yaptırıyoruz
                QuickSorting(A, Pv + 1, UB);
            }
            return; //sıralama bitene kadar tekrarlattırıyoruz
        }
        public static int PartitionDescending(string[] A, int LB, int UB) //büyükten küçüğe kaydırma işlemi
        {
            int Pv = UB, Lo = LB, Hi = UB - 1; //pivotu en sağdaki sayı seçtiğimiz için UB'yi bir eksiltip pivotun yanına alıyoruz
            while (Lo <= UB && Hi >= LB)
            {
                if (int.Parse(A[Hi]) < int.Parse(A[Pv])) //eğer hi değerimiz pivottan küçükse
                {
                    Hi--; continue; //hi değerini sola kaydırıyoruz
                }
                if (int.Parse(A[Lo]) > int.Parse(A[Pv]))
                {
                    Lo++; continue;//eğer Lo değerimiz pivotumuzdan büyük ise Lo'yu bir sağa kaydırıp değerimize bakıyoruz
                }
                if (Lo < Hi)//eğer lo değerimiz hi değerinden küçükse
                {
                    string temp1 = A[Hi];//dizimizin hi değerini temp1 olarak tanımlıyoruz
                    A[Hi] = A[Lo];//dizimizin hi değerini lo değerine eşitliyoruz
                    A[Lo] = temp1;//dizimizin lo değeri temp1 değişkeni olmus oluyor.
                }
                else
                {
                    break; //hiç biri olmuyorsa kırıyoruz
                }
            }
            string temp = A[Pv];//döngüden çıktıktan sonra pivotumuzu temp değişkenine atıyoruz
            A[Pv] = A[Lo];//pivotumuz lo değeriyle eşit oluyor çünkü en küçük sayımız en sağda kalıcak
            A[Lo] = temp;//yeni pivotumuzu temp değişkenimiz yapıyoruz

            Pv = Lo;
            return Pv;
        }
        public static void QuickSortingDescending(string[] A, int LB, int UB)
        {
            if (LB <= UB) //soldaki sayı sağdaki sayıdan küçük veya eşit ise
            {
                int Pv = PartitionDescending(A, LB, UB); //dizimizi tanımladık
                //sıralama işlemini yaptırıyoruz
                QuickSortingDescending(A, LB, Pv - 1);
                QuickSortingDescending(A, Pv + 1, UB);
            }
            return;
        }
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
