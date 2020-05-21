using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLAB7
{
    public partial class calculadora : Form
    {
        int num = 0;
        double n1;
        double n2;
        string op;
        string historial;
        string ans;
        
        public calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "7";
        }
        suma suma = new suma();
        resta resta = new resta();
        multiplicacion multiplicacion = new multiplicacion();
        division division = new division();


        private void button17_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = "";
            pantalla_total.Text = "";
            num++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            op = "*";
            n1 = double.Parse(pantalla_calc.Text);
            pantalla_calc.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boton_0_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "0";
        }

        private void boton_1_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "1";
        }

        private void boton_2_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "2";
        }

        private void boton_3_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "3";
        }

        private void boton_mas_Click(object sender, EventArgs e)
        {
            op = "+";
            n1 = double.Parse(pantalla_calc.Text);
            pantalla_calc.Clear();
        }

        private void boton_menos_Click(object sender, EventArgs e)
        {
            op = "-";
            n1 = double.Parse(pantalla_calc.Text);
            pantalla_calc.Clear();
        }

        private void boton_igual_Click(object sender, EventArgs e)
        {
            double num2; 
            if (num == 0) {
                pantalla_total.Text = n1.ToString();
                num2 = double.Parse(pantalla_calc.Text);
                num++;
            }
            
            n2 = double.Parse(pantalla_calc.Text);
            double s, r, m, d;
            switch (op)
            {
                case "+":
                    pantalla_total.Text = pantalla_total.Text + "+" + num2;
                    s = suma.Sumar(n1, n2);
                    pantalla_calc.Text = s.ToString();
                    ans= s.ToString();
                    break;
                case "-":
                    pantalla_total.Text = pantalla_total.Text + "-" + n2.ToString();
                    r = resta.Restar(n1, n2);
                    pantalla_calc.Text = r.ToString();
                    ans = r.ToString();
                    break;
                case "/":
                    pantalla_total.Text = pantalla_total.Text + "/" + n2.ToString();
                    d = division.Dividir(n1, n2);
                    pantalla_calc.Text = d.ToString();
                    ans = d.ToString();
                    break;
                case "*":
                    pantalla_total.Text = pantalla_total.Text + "*" + n2.ToString();
                    m = multiplicacion.Multiplicar(n1, n2);
                    pantalla_calc.Text = m.ToString();
                    ans = m.ToString();
                    break;
            }
        }

        private void boton_div_Click(object sender, EventArgs e)
        {
            op = "/";
            n1 = double.Parse(pantalla_calc.Text);
            pantalla_calc.Clear();
        }

        private void boton_6_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "6";
        }

        private void boton_4_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "4";
        }

        private void boton_8_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "8";
        }

        private void boton_9_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "9";
        }

        private void boton_del_Click(object sender, EventArgs e)
        {
            string s = pantalla_calc.Text;
            if (s.Length > 1){
                s = s.Substring(0, s.Length - 1);
            }else{
                s = "";
            }
            pantalla_calc.Text = s;
        }

        private void boton_8_Click_1(object sender, EventArgs e)
        {
            pantalla_calc.Text = pantalla_calc.Text + "8";
        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void boton_ans_Click(object sender, EventArgs e)
        {
            pantalla_calc.Text = ans;
        }
    }
}
