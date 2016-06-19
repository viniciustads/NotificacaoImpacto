namespace NotificacaoImpacto
{
    class Elementos
    {
        private string diretorios;
        private string palavras;

        public Elementos(string diretorio, string palavra)
        {
            diretorios = diretorio;
            palavras = palavra;
        }

        public string diretorio {
            get
            {
                return diretorios;
            }
        }
        public string palavra {
            get
            {
                return palavras;
            }
        }
        
    }
}
