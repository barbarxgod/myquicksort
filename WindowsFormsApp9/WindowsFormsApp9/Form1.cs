using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp9
{    
    public partial class Form1 : Form
    {
        public Form1()
        {       
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QuickSort.liste.Clear();
                RefreshAnswers();
                if (combosecim.Text == "KUCUKTEN BUYUGE") //kullanıcı seçimini yaptıktan sonra
                {
                    string input = InputTxt.Text; //kullanıcının yazdığı diziyi inputa atıyoruz
                    string[] array = input.Split(','); //inputumuzu array isimli dizimize tanımladık arasında virgül olan sayıları eleman olarak kabul ettirdik

                    QuickSort.QuickSorting(array, 0, (array.Length - 1)); //quicksort sınıfımızda dizimizi sıralattırıyoruz

                    for (int i = 0; i < array.Length; i++)
                    {
                        OutputTxt.Items.Add(array[i]);  //döngümüzün içinde outputumuza dizi elemanlarını yazdırdık
                    }
                    string Pivots = ""; //pivotlarımızı tanımlayıp aşağıdaki döngüde ekrana yazdırıyoruz

                    for (int i = 0; i < QuickSort.liste.Count; i++)
                    {
                        Pivots += array[QuickSort.liste[i]];
                        if (i < QuickSort.liste.Count - 1)
                        {
                            Pivots += ","; //karışmasın diye araya virgül koyuyuorum
                        }
                    }
                    PivotTxt.Text = Pivots;
                }
                else if (combosecim.Text == "BUYUKTEN KUCUGE") //aynı islemimizi büyükten küçüğe seçeneğinde yapıyoruz
                {
                    string input = InputTxt.Text;
                    string[] array = input.Split(',');

                    QuickSort.QuickSortingDescending(array, 0, (array.Length - 1));

                    for (int i = 0; i < array.Length; i++)
                    {
                        OutputTxt.Items.Add(array[i]);
                    }
                    string Pivotss = "";

                    for (int i = 0; i < QuickSort.liste.Count; i++)
                    {
                        Pivotss += array[QuickSort.liste[i]];
                        if (i < QuickSort.liste.Count - 1)
                        {
                            Pivotss += ",";
                        }
                    }
                    PivotTxt.Text = Pivotss;
                }
                else
                {
                    MessageBox.Show("Lütfen sıralama türünü seçin");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
        public void RefreshAnswers()
        {
            OutputTxt.Text = PivotTxt.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {         
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PivotTxt.Text = string.Empty;            
            OutputTxt.Items.Clear();
            combosecim.Text = string.Empty;
        }

        private void OutputTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputTxt.Text = string.Empty;
            OutputTxt.Text = " ";
            OutputTxt.Items.Clear();
            PivotTxt.Text = string.Empty;
        }

        private void myquicksort1_Click(object sender, EventArgs e)
        {
            try
            {
                QuickSort.liste.Clear();
                
                if (combosecim.Text == "KUCUKTEN BUYUGE") //kullanıcı seçimini yaptıktan sonra
                {
                    string input = InputTxt.Text; //kullanıcının yazdığı diziyi inputa atıyoruz
                    string[] array = input.Split(','); //inputumuzu array isimli dizimize tanımladık arasında virgül olan sayıları eleman olarak kabul ettirdik

                    QuickSort.QuickSorting(array, 0, (array.Length - 1)); //quicksort sınıfımızda dizimizi sıralattırıyoruz

                    for (int i = 0; i < array.Length; i++)
                    {
                        OutputTxt.Items.Add(array[i]);  //döngümüzün içinde outputumuza dizi elemanlarını yazdırdık
                    }
                    string Pivots = ""; //pivotlarımızı tanımlayıp aşağıdaki döngüde ekrana yazdırıyoruz

                    for (int i = 0; i < QuickSort.liste.Count; i++)
                    {
                        Pivots += array[QuickSort.liste[i]];
                        if (i < QuickSort.liste.Count - 1)
                        {
                            Pivots += ","; //karışmasın diye araya virgül koyuyuorum
                        }
                    }
                    PivotTxt.Text = Pivots;
                }
                else if (combosecim.Text == "BUYUKTEN KUCUGE") //aynı islemimizi büyükten küçüğe seçeneğinde yapıyoruz
                {
                    string input = InputTxt.Text;
                    string[] array = input.Split(',');

                    QuickSort.QuickSortingDescending(array, 0, (array.Length - 1));

                    for (int i = 0; i < array.Length; i++)
                    {
                        OutputTxt.Items.Add(array[i]);
                    }
                    string Pivotss = "";

                    for (int i = 0; i < QuickSort.liste.Count; i++)
                    {
                        Pivotss += array[QuickSort.liste[i]];
                        if (i < QuickSort.liste.Count - 1)
                        {
                            Pivotss += ",";
                        }
                    }
                    PivotTxt.Text = Pivotss;
                }
                else
                {
                    MessageBox.Show("Lütfen sıralama türünü seçin");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
       

    }
}


