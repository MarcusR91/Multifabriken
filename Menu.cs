using System;

namespace multifabriken_MarcusR91
{
    public class menu
    {
        public void Title()
        {
            Console.WriteLine("Välkommen till Multifabriken!");
            Console.WriteLine("Här kan du handla en massaolika saker, bara klicka dig in på vad du är intresserad av!");

        }

        public void Options()
        {
            System.Console.WriteLine("[1] Köp bil");
            System.Console.WriteLine("[2] köp tofu");
            System.Console.WriteLine("[3] köp godis");
            System.Console.WriteLine("[4] köp snöre");
            System.Console.WriteLine("[5] Kolla varukorgen");
            System.Console.WriteLine("[6] Avsluta shopen");
        }

    }
}