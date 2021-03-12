using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejercicio_4_171299
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadro(decimal lado1, decimal lado2)
        {
            decimal resultado = lado1 * lado2;
            return resultado;
        }

        [WebMethod]
        public decimal triangulo(decimal base1, decimal altura2)
        {
            decimal resultado = (base1 * altura2) / 2;
            return resultado;
        }

        [WebMethod]
        public double circulo(double radio)
        {
            double resultado = Math.PI * (radio * radio);
            return resultado;
        }
    }
}
