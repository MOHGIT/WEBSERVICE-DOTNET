using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            BanqueService.BanqueServiceClient Banqueclient = new BanqueService.BanqueServiceClient();
            
            List<BanqueService.compte> comptes = Banqueclient.getComptes().ToList<BanqueService.compte>() ;
            
            System.Console.WriteLine("liste des comptes :");
            foreach (BanqueService.compte compte in comptes) 
            {
                System.Console.WriteLine("***compte****");
                System.Console.WriteLine("Code :" + compte.code);
                System.Console.WriteLine("solde :" + compte.solde);
                System.Console.WriteLine("***Fin***");
            }
            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("enter un montant en euro :");
            string mont=System.Console.ReadLine();
            double mt = Banqueclient.ConversionEuroToDh(double.Parse(mont));
            System.Console.WriteLine("montant en dhirams pour "+mont+ " euros : "+mt);
            
            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("saisir un code de compte :");
            string code = System.Console.ReadLine();
            BanqueService.compte cmpt=Banqueclient.getCompte(long.Parse(code));
            System.Console.WriteLine("compte "+code+ ":");
            System.Console.WriteLine("code : " + cmpt.code);
            System.Console.WriteLine("solde : " + cmpt.solde);
            System.Console.ReadLine();
        }

    }
}
