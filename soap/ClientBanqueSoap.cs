using soap_client_dotnet.BanqueWSService;
namespace soap_client_dotnet.soap;
public class ClientBanqueSoap
{
    class program
    {
        static void Main(string[] args)
        {
            /*=========================================*/
            BanqueWSService.BanqueWSClient stub = new BanqueWSClient();
            double result = stub.ConversationEuroToDhAsync(100).Result.@return;
            Console.WriteLine(result);
            /* ==========================================  */
            compte compte = stub.getCompteAsync(1).Result.@return;
            Console.Write("Compte :  ---->");
            Console.WriteLine("code  : "+compte.code+"  solde : "+compte.solde);
            /*================================================== */
            compte[] comptes = stub.getAllComptesAsync().Result.@return;
            for (int i = 0; i <comptes.Length ; i++)
            {
                Console.WriteLine("code  : "+comptes[i].code+"  solde : "+comptes[i].solde);
            }
            
            /*=========================================================*/
            Console.ReadLine(); 
            /*=========================================================*/
        }
    }
}