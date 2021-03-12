using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_4_171299
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Areas.AreasWebServiceSoapClient area = new Areas.AreasWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Result.Text = area.cuadro(Decimal.Parse(Num1.Text), Decimal.Parse(Num2.Text)).ToString();
        }

        protected void BtnTriangulo_Click(object sender, EventArgs e)
        {
            Result.Text = area.triangulo(Decimal.Parse(Num1.Text), Decimal.Parse(Num2.Text)).ToString();
        }

        protected void BtnCirculo_Click(object sender, EventArgs e)
        {
            Result.Text = area.circulo(Double.Parse(Num3.Text)).ToString();
        }
    }
}