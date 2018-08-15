using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ValidarCamposCliente
    {
        //Metodo que checka os campos estão nulos ou vazios
        public int ValidarCampos(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(cliente.Sexo))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(cliente.Email))
            {
                return 3;
            }
            if (string.IsNullOrEmpty(cliente.Cpf))
            {
                return 4;
            }
            if (string.IsNullOrEmpty(cliente.DataNasc))
            {
                return 5;
            }
            return 0;
        }
        //Metodo que valida CPF
        public static bool ValidaCPF(string vrCPF)
        {

            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");



            if (valor.Length != 11)

                return false;



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;



            if (igual || valor == "12345678909")

                return false;



            int[] numeros = new int[11];



            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());



            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)

                    return false;

            }

            else if (numeros[9] != 11 - resultado)

                return false;



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)

                    return false;

            }

            else

                if (numeros[10] != 11 - resultado)

                return false;



            return true;

        }
        //Metodo que valida Email
        public static bool ValidarEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }
        //Metodo que valida Data
        public static bool validarData(string data)
        {

            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            if (r.Match(data).Success)
            {

               string[] datasplit = data.Split('/');

                int dia = Convert.ToInt32(datasplit[0]);
                int mes = Convert.ToInt32(datasplit[1]);
                int ano = Convert.ToInt32(datasplit[2]);

                

                if (dia > 31) {
                    return false;
                }else if(mes > 12)
                {
                    return false;
                }else if (ano < 1900)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
