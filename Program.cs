using System;
using System.Collections.Generic;

namespace LesTableauxExo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Dictionary<string, string> fujita = new Dictionary<string, string>();
            fujita.Add("FO", " Dégats légers");
            fujita.Add("F1", " Dégats modérés");
            fujita.Add("F2", " Dégats importants");
            fujita.Add("F3", " Dégats considérables");
            fujita.Add("F4", " Dégats dévastateurs");
            fujita.Add("F5", " Dégats incroyable");

            Console.WriteLine("Renseigner le type de tornade svp");
            string enterTornado = Console.ReadLine().ToUpper();
            if (fujita.ContainsKey(enterTornado))
            {
                Console.WriteLine(fujita[enterTornado]);
            }
            else
            {
                Console.WriteLine("Entrer une valeur correcte");
            }




























            /*
            string[,] fujita = new string[,]

            {
                { "F0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres."},
                { "F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."},
                { "F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées."},
                { "F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts importants, les forêts et les récoltes sont abattues."},
                { "F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances."},
                { "F5", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu »."},
            };

            string insert = "oui";
            string enterTornado;

            while (insert == "oui")

            {
                Console.WriteLine("Renseigner le type de tornade pour connaitre ses conséquences :" +
                    "\nf0 : Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." + 
                    "\nf1 : Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés." +
                    "\nf2 : Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées." +
                    "\nf3 : Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts importants, les forêts et les récoltes sont abattues." + 
                    "\nf4 : Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances." + 
                    "\nf5 : Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu »." + 
                    "\n"); 
                enterTornado =Console.ReadLine().ToLower();

                switch (enterTornado)

                {
                    case "f0":
                        Console.WriteLine($"Type de tornade :{fujita[0, 0]} => {fujita[0, 1]}");
                        break;
                    case "f1":
                        Console.WriteLine($"Type de tornade :{fujita[1, 0]} => {fujita[1, 1]}");
                        break;
                    case "f2":
                        Console.WriteLine($"Type de tornade :{fujita[2, 0]} => {fujita[2, 1]}");
                        break;
                    case "f3":
                        Console.WriteLine($"Type de tornade :{fujita[3, 0]} => {fujita[3, 1]}");
                        break;
                    case "f4":
                        Console.WriteLine($"Type de tornade :{fujita[4, 0]} => {fujita[4, 1]}");
                        break;
                    case "f5":
                        Console.WriteLine($"Type de tornade :{fujita[5, 0]} => {fujita[5, 1]}");
                        break;
                    default:
                        Console.WriteLine($"Erreur de saisie");
                        break;
                }
                break;
                //Console.WriteLine("\nRecommencer ?\noui\nnon");
                //insert = Console.ReadLine();
            }*/
        }
        }
}

//Créer le tableau fujita suivant :
//À l’aide de la console, inviter l’utilisateur à renseigner le type d’une tornade.
//Dans la console, selon le type renseigné, 
//afficher la description des dégâts causés par le type de tornade à l’aide du tableau fujita préalablement créé.
//F0 ---Dégâts légers : certains dommages sont subis par les cheminées, 
//les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.
//F1 ---Dégâts modérés : les automobiles sont renversées, 
//les abris pour automobiles détruits et les arbres déracinés.
//F2 ---Dégâts importants : les toits sont arrachés par le vent, 
//les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.
//F3 ---Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, 
//les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, 
//les forêts et les récoltes sont abattues.
//F4 ---Dégâts dévastateurs : même dans les habitations solides, 
//l'essentiel des murs, sinon tous, s'effondrent ; 
//tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.
//F5 ---Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. 
//Les tornades F5 peuvent causer des dommages très importants à de grosses structures 
//telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits 
//(parfois surnommé « le doigt de Dieu ».