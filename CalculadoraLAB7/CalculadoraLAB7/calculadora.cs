using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLAB7
{
    public partial class calculadora : Form
    {
        //static List<string> historial = new List<string>();
        double n1;
        double n2;
        double result =0;
        string op;
        string ans;
        int igual = 0;
        int coma = 0;
        public calculadora()
        {
            InitializeComponent();
        }
        suma suma = new suma();
        resta resta = new resta();
        multiplicacion multiplicacion = new multiplicacion();
        division division = new division();

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "7";
            pantalla_calc.Text = pantalla_calc.Text + "7";
            igual = 0;
            coma = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (coma == 0)
            {
                pantalla_total.Text = pantalla_total.Text + ",";
                pantalla_calc.Text = pantalla_calc.Text + ",";
                coma++;
            }
            else
            {
                pantalla_calc.Clear();
                pantalla_calc.Text = "Syntax Error...";
                pantalla_calc.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)//boton ac
        {
            pantalla_calc.Text = "";
            pantalla_total.Text = "";
            //num++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "5";
            pantalla_calc.Text = pantalla_calc.Text + "5";
            igual = 0;
            coma = 0;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void boton_0_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "0";
            pantalla_calc.Text = pantalla_calc.Text + "0";
            igual = 0;
            coma = 0;
        }

        private void boton_1_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "1";
            pantalla_calc.Text = pantalla_calc.Text + "1";
            igual = 0;
            coma = 0;
        }

        private void boton_2_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "2";
            pantalla_calc.Text = pantalla_calc.Text + "2";
            igual = 0;
            coma = 0;
        }

        private void boton_3_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "3";
            pantalla_calc.Text = pantalla_calc.Text + "3";
            igual = 0;
            coma = 0;
        }

        private void boton_mas_Click(object sender, EventArgs e)
        {
            op = "+";
            try { n1 = double.Parse(pantalla_calc.Text); }
            catch { 
                pantalla_calc.Clear();
                pantalla_calc.Text = "Syntax Error...";
                pantalla_calc.Show();
            }
            pantalla_total.Text = pantalla_total.Text + "+";
            pantalla_calc.Clear();
            coma = 0;
            //num = 0;
        }

        private void boton_menos_Click(object sender, EventArgs e)
        {
            op = "-";
            try { n1 = double.Parse(pantalla_calc.Text); }
            catch
            {
                pantalla_calc.Clear();
                pantalla_calc.Text = "Syntax Error...";
                pantalla_calc.Show();
            }
            pantalla_total.Text = pantalla_total.Text + "-";
            pantalla_calc.Clear();
            coma = 0;
            //num = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            op = "*";
            try { n1 = double.Parse(pantalla_calc.Text); }
            catch
            {
                pantalla_calc.Clear();
                pantalla_calc.Text = "Syntax Error...";
                pantalla_calc.Show();
            }
            pantalla_total.Text = pantalla_total.Text + "*";
            pantalla_calc.Clear();
            coma = 0;
            //num = 0;
        }

        private void boton_div_Click(object sender, EventArgs e)
        {
            op = "/";
            try { n1 = double.Parse(pantalla_calc.Text); }
            catch
            {
                pantalla_calc.Clear();
                pantalla_calc.Text = "Syntax Error...";
                pantalla_calc.Show();
            }
            pantalla_total.Text = pantalla_total.Text + "/";
            //num = 0;
            pantalla_calc.Clear();
            coma = 0;
        }

        private void boton_6_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "6";
            pantalla_calc.Text = pantalla_calc.Text + "6";
            igual = 0;
            coma = 0;
        }

        private void boton_4_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "4";
            pantalla_calc.Text = pantalla_calc.Text + "4";
            igual = 0;
            coma = 0;
        }

        private void boton_9_Click(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "9";
            pantalla_calc.Text = pantalla_calc.Text + "9";
            igual = 0;
            coma = 0;
        }
        private void boton_8_Click_1(object sender, EventArgs e)
        {
            pantalla_total.Text = pantalla_total.Text + "8";
            pantalla_calc.Text = pantalla_calc.Text + "8";
            igual = 0;
            coma = 0;
        }

        private void boton_del_Click(object sender, EventArgs e)
        {
            string s = pantalla_calc.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }
            pantalla_calc.Text = s;
            string v = pantalla_total.Text;
            if (v.Length > 1)
            {
                v = v.Substring(0, v.Length - 1);
            }
            else
            {
                v = "";
            }
            if (coma != 0)
            {
                coma = 0;
            }
            pantalla_total.Text = v;
        }

        private void boton_ans_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = ans;
        }

        private void boton_historial_Click(object sender, EventArgs e)
        {
            
            foreach (string i in suma.historial)
            {
                text_historial.Text =i+"\n";
            }
            panel1.Visible = true;
            text_historial.Show();

        }

        private void boton_igual_Click(object sender, EventArgs e)
        {
            
            if (igual == 0)
            {
                try
                {
                    n2 = double.Parse(pantalla_calc.Text);
                }
                catch
                {
                    pantalla_calc.Clear();
                    pantalla_calc.Text = "Syntax Error...";
                    pantalla_calc.Show();
                }

                //num++;
                //num1++;
                switch (op)
                {
                    case "+":
                        result = suma.Sumar(n1, n2);
                        pantalla_calc.Text = result.ToString();
                        ans = result.ToString();
                        pantalla_total.Text = pantalla_total.Text + "=" + result.ToString();
                        suma.historial.Add(pantalla_total.Text);
                        Thread.Sleep(2000);
                        pantalla_total.Clear();
                        igual++;
                        coma++;
                        n1=0;
                        n2=0;
                        result = 0;
                        op ="";
                        break;
                    case "-":
                        result = resta.Restar(n1, n2);
                        pantalla_calc.Text = result.ToString();
                        ans = result.ToString();
                        pantalla_total.Text = pantalla_total.Text + "=" + result.ToString();
                        suma.historial.Add(pantalla_total.Text);
                        Thread.Sleep(2000);
                        pantalla_total.Clear();
                        igual++;
                        coma++;
                        n1 = 0;
                        n2 = 0;
                        result = 0;
                        op = "";
                        break;
                    case "/":
                        result = division.Dividir(n1, n2);
                        pantalla_calc.Text = result.ToString();
                        ans = result.ToString();
                        pantalla_total.Text = pantalla_total.Text + "=" + result.ToString();
                        suma.historial.Add(pantalla_total.Text);
                        Thread.Sleep(2000);
                        pantalla_total.Clear();
                        igual++;
                        coma++;
                        n1 = 0;
                        n2 = 0;
                        result = 0;
                        op = "";
                        break;
                    case "*":
                        result = multiplicacion.Multiplicar(n1, n2);
                        pantalla_calc.Text = result.ToString();
                        ans = result.ToString();
                        pantalla_total.Text = pantalla_total.Text + "=" + result.ToString();
                        suma.historial.Add(pantalla_total.Text);
                        Thread.Sleep(2000);
                        pantalla_total.Clear();
                        igual++;
                        coma++;
                        n1 = 0;
                        n2 = 0;
                        result = 0;
                        op = "";
                        break;
                }
            }else{  
                    pantalla_calc.Clear();
                    pantalla_calc.Text = "Syntax Error...";
                    pantalla_calc.Show();
                
            }
        }

        
        private void calculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void text_historial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_borrar_historial_Click(object sender, EventArgs e)
        {
            suma.historial.Clear();
            foreach (string i in suma.historial)
            {
                text_historial.Text = i;
                text_historial.Show();

            }
            Thread.Sleep(2000);
            panel1.Visible = false;
            coma++;
            n1 = 0;
            n2 = 0;
            result = 0;
            op = "";
        }

       
    }
}
