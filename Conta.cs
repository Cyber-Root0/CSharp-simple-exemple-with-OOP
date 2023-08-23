using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ClasseConta.Test
{
    public class Conta
    {
        /// <summary>
        /// @id
        /// </summary>
        public int id = 0;
        /// <summary>
        /// @titular
        /// </summary>
        public string titular = "";
        /// <summary>
        /// @saldo
        /// </summary>
        public double saldo = 0;
        /// <summary>
        /// Method to set all value in atributtes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titular"></param>
        /// <param name="saldo"></param>
        public void SetAllData(int id, string titular, double saldo){   
            this.id = id;
            this.titular = titular;
            this.saldo = saldo;
        }
        /// <summary>
        /// Method to Get a value from amount account
        /// </summary>
        /// <param name="valor"></param>
        public void Sacar(float valor){
            if (this.saldo >= valor){
                this.saldo = this.saldo - valor;
                Console.WriteLine("Saque efetuado com sucesso!");
            }else{
                throw new Exception("Saque inválido, limite excedido: a conta não possui R$"+valor+" de saldo");
            }
        }
        /// <summary>
        /// Method to add a new value to your account
        /// </summary>
        /// <param name="saldo"></param>
        public void Depositar(float saldo){
            if (saldo!=0){
                this.saldo = saldo;
            }else{
                throw new Exception("Saldo inválido");
            }
        } 
        /// <summary>
        /// Method void to show all atributtes
        /// </summary>
        public void ShowAllData(){
            Console.WriteLine("------------------");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Saldo: " + this.saldo);
        }
    }    
}