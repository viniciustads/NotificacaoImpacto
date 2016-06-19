using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NotificacaoImpacto
{
    class BuscaDiretorios
    {
        private StreamReader file;
        public static List<Elementos> elm;
        dddddd
        
        public void buscar_Diretorios(string diretorio, ListBox.ObjectCollection palavra)
        {           
            string[] arquivos = Directory.GetFiles(diretorio, "*.fpr", SearchOption.AllDirectories);

            elm = new List<Elementos>();
                    
                foreach (string arq in arquivos)
                {
                    file = new StreamReader(arq);

                string  verifica = file.ReadToEnd();

                foreach (string pal in palavra)
                {
                    
                                if (verifica.Contains(pal))
                                {                       
                                      elm.Add(new Elementos(Convert.ToString(arq), Convert.ToString(pal)));
                                      break;
                                }                                
                }

                file.Close();         
                }                        
         }
              
        public List<Elementos> GetElementos()
        {          
            return elm;
        }
               
         
    }
}
