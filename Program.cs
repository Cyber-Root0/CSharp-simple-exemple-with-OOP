using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ClasseConta.Test
{
    public class Program
    {
        /// <summary>
        /// Main Method in this project :)
        /// </summary>
        public static void Main(){
            Conta newaccount = new Conta();            
            newaccount.SetAllData(GetIdAccount(),GetTitular(),GetAmountValue());
            newaccount.Sacar(10);
            newaccount.ShowAllData();
        }
        /// <summary>
        /// Static method to get amont value
        /// </summary>
        /// <returns>Double || Exception</returns>
        public static double GetAmountValue(){
            Console.Write("Digite o saldo da conta: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount==null){
                throw new Exception("O saldo deve ser um double válido!");
            }
            return amount;
        }
        /// <summary>
        /// Static function to get account id
        /// </summary>
        /// <returns>Int || Exception</returns>
        public static int GetIdAccount(){
            Console.Write("Digite o id da conta: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id==null){
                throw new Exception("O id do titular deve ser preenchido!");
            }
            return id;
        }
        /// <summary>
        /// Static function to get titular name
        /// </summary>
        /// <returns> String || Exception</returns>
        public static string GetTitular(){
            Console.Write("Digite o nome do titular: ");
            string titula = Console.ReadLine();
            if (titula == null || titula==""){
                throw new Exception("O nome do titular deve ser prenchido");
            }
            return titula;
        }
    }
}