using System.Text;
class program
{
    static void Main(string[]args)
    {
        var localArquivo = "teste.txt"; // aqui vai o local que o arquivo esta salvo, para que a string funcione, tem que usar '/' no lugar das '\'
        var numeroDeBytesLidos = -1; // o valor de -1 é porque é impossivel de ler -1, ele nunca sera retornado pelo read 
        var fluxArquivo = new FileStream(localArquivo, FileMode.Open );
        var buffer = new byte[1024]; //1024 = 1kb eletronica basica 

        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxArquivo.Read(buffer, 0, buffer.Length); // testando o .Length(varre o array inteiro)
           // if (numeroDeBytesLidos == 0) break;           
            EscreveBuffer(buffer);
        }
        //public override int Read(byte[] array, int offset, int count);//a leitura começa a partir do indice 0
    }
    static void EscreveBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding(); // o UTF8Encoding é usado pra traduzir os bytes com base na tabela de caracteres
        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*foreach (var meuByte in buffer) //in ele percorre o buffer todo
        {
            
           if (meuByte != 0)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }*/
    }
}
