using TestProject1.Core;

namespace TestProject1.Page
{
    public class ValidaCepPage : Begin
    {
        public void PreencheCep() 
        {
            EscreveTexto("//*[@id='endereco']", "87035604");
        }

        public void ClicaBtnBusca() 
        {
            ClicaElemento("//*[@id='btn_pesquisar']");
        }

        public void ValidaResultado()
        {
            ValidaDados("//*[@id='resultado-DNEC']/tbody/tr/td[1]", "Rua Pioneiro Hélio dos Reis Figueiredo");
        }
    }
}
