using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaga_Estagio
{
    
    internal class Candidato
    {
        public string Nome { get;set; }

        public int Mes {  get; set; }

        public int Dia { get; set; }

        public int Ano { get; set; }

        public string AreaAtuacao { get; set; }

        public string Escolaridade { get; set; }

        public bool Matutino { get; set; }

        public bool Vespertino { get; set; }

        public bool Noturno { get; set; }

       public Candidato() {


            this.Nome = "";
            this.Dia = 0;
            this.Mes = 0;
            this.Ano = 0;
            this.AreaAtuacao = "";
            this.Matutino = false;
            this.Vespertino = false;
            this.Noturno = false;
            this.Escolaridade = "";
       }

        public override string ToString(){
            return $"Nome: {this.Nome} - Dia: {this.Dia} | Mes: {this.Mes} | " +
                  $"Ano: {this.Ano} | Área de atuação: {this.AreaAtuacao} |" +
                  $"Turno: {this.Matutino} | Turno: {this.Vespertino} | Turno: {this.Noturno} " +
                  $" Escolaridade: {this.Escolaridade} ";
        }



    }
}
