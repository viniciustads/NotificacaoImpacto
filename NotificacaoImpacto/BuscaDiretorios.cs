using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NotificacaoImpacto
{
    class BuscaDiretorios
    {
        private StreamReader file;
        public static List<Elementos> elm;
       
        
        public void buscar_Diretorios(string diretorio, ListBox.ObjectCollection palavra)
        {
            elm = new List<Elementos>();

            var ext = new List<string> { "*.fpl","*.fpr"};
            
            foreach (string arx in ext)
            {
                Console.Write("DSDS" + arx);
                string[] arquivos = Directory.GetFiles(diretorio, arx, SearchOption.AllDirectories);
            
                               
                foreach (string arq in arquivos)
                {
                    file = new StreamReader(arq);

                string  verifica = file.ReadToEnd();

                foreach (string pal in palavra)
                {
                    
                                if (verifica.Contains(pal.ToUpper()))
                                {                       
                                      elm.Add(new Elementos(Convert.ToString(arq), Convert.ToString(pal)));
                                      break;
                                }                                
                }

                file.Close();         
                }
            }
        }
              
        public List<Elementos> GetElementos()
        {          
            return elm;
        }
               
         
    }
}
