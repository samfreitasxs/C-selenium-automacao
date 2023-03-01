using TestProject1.Core;

namespace TestProject1.Page
{
    public class ValidaCepPage : Begin
    {
        public void PreencheCep() 
        {
            EscreveTexto("//*[@id=\'endereco\']", "30492040");
        }

        public void ClicaBtnBusca() 
        {
            ClicaElemento("//*[@id=\'btn_pesquisar\']");
        }

        public void ValidaResultado()
        {
            ValidaDados("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]", "Rua Ernani Agricola");
        }


        public void ValidaResultadoTotal()
        {
            string[] dados =
            {
                "Rua Ernani Agricola", //0
                "Buritis",  //1
                "Belo Horizonte/MG", //2
                "30492-040" //3
             };

            for (int i = 0; i < dados.Length; i++)
            {
                ValidaDados("//*[@id=\'resultado-DNEC\']/tbody/tr/td[" + (i + 1) + "]", dados[i]);
                System.Console.WriteLine(dados[i]);
            }
        }

        public void ValidaMultiplosCeps()
        {
            string[] ceps =
            {
                "30492040",
                "01409020",
                "30455610",
                "01409030"
            };

            string[] logradouros =
            {
                "Rua Ernani Agricola",
                "Rua Lupércio de Camargo",
                "Avenida Professor Mário Werneck - até 1923/1924",
                "Rua Professor Azevedo Amaral"
            };

            for (int i = 0; i < ceps.Length; i++)
            {
                EscreveTexto("//*[@id='endereco']", ceps[i]);
                ClicaElemento("//*[@id='btn_pesquisar']");
                ValidaDados("//*[@id='resultado-DNEC']/tbody/tr/td[1]", logradouros[i]);
                ClicaElemento("//*[@id='btn_nbusca']");
                System.Console.WriteLine(ceps[i]);
            }
        }

    }
}
