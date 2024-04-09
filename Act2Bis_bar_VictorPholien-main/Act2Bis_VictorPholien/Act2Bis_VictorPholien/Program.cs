namespace Act2Bis_VictorPholien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            Barman Victor = new Barman();
            Cave cave = new Cave();
            Shaker shaker = new Shaker();
            

            Recette cubaLibre = new Recette();


            // Création d'un Mojito
            Recette mojito = new Recette();
            mojito.Ingredients = new Portion[]
            {
                new Portion(new Liquide("rhum", "alcool"), 40),
                new Portion(new Liquide("eau gazeuse", "soft"), 60),
                new Portion(new Liquide("menthe", "herbe"), 10),
                new Portion(new Liquide("citron vert", "fruit"), 20),
                new Portion(new Liquide("sucre de canne", "sucre"), 10)
            };

            // Création d'un Martini
            Recette martini = new Recette();
            martini.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vermouth", "alcool"), 60),
                new Portion(new Liquide("gin", "alcool"), 40),
                new Portion(new Liquide("olive", "garniture"), 1)
            };

            // Création d'un Daiquiri
            Recette daiquiri = new Recette();
            daiquiri.Ingredients = new Portion[]
            {
                new Portion(new Liquide("rhum blanc", "alcool"), 60),
                new Portion(new Liquide("jus de citron vert", "fruit"), 30),
                new Portion(new Liquide("sirop de sucre", "sirop"), 20)
            };

            // Création d'un Cosmopolitan
            Recette cosmopolitan = new Recette();
            cosmopolitan.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vodka", "alcool"), 40),
                new Portion(new Liquide("jus de canneberge", "jus de fruit"), 30),
                new Portion(new Liquide("triple sec", "alcool"), 20),
                new Portion(new Liquide("jus de citron", "fruit"), 10)
            };


            // Création d'un Margarita
            Recette margarita = new Recette();
            margarita.Ingredients = new Portion[]
            {
                new Portion(new Liquide("tequila", "alcool"), 50),
                new Portion(new Liquide("jus de citron vert", "fruit"), 30),
                new Portion(new Liquide("triple sec", "alcool"), 20),
                new Portion(new Liquide("sel", "garniture"), 1)
            };

            // Création d'un Manhattan
            Recette manhattan = new Recette();
            manhattan.Ingredients = new Portion[]
            {
                new Portion(new Liquide("whisky", "alcool"), 50),
                new Portion(new Liquide("vermouth doux", "alcool"), 30),
                new Portion(new Liquide("angostura", "bitter"), 2),
                new Portion(new Liquide("cerise", "garniture"), 1)
            };

            // Création d'un Pina Colada
            Recette pinaColada = new Recette();
            pinaColada.Ingredients = new Portion[]
            {
                new Portion(new Liquide("rhum blanc", "alcool"), 50),
                new Portion(new Liquide("jus d'ananas", "jus de fruit"), 100),
                new Portion(new Liquide("crème de coco", "crème"), 50)
            };

            // Création d'un Long Island Iced Tea
            Recette longIslandIcedTea = new Recette();
            longIslandIcedTea.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vodka", "alcool"), 15),
                new Portion(new Liquide("rhum", "alcool"), 15),
                new Portion(new Liquide("gin", "alcool"), 15),
                new Portion(new Liquide("tequila", "alcool"), 15),
                new Portion(new Liquide("triple sec", "alcool"), 15),
                new Portion(new Liquide("jus de citron", "fruit"), 25),
                new Portion(new Liquide("cola", "soft"), 25)
            };

            // Création d'un Blue Lagoon
            Recette blueLagoon = new Recette();
            blueLagoon.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vodka", "alcool"), 50),
                new Portion(new Liquide("curacao bleu", "liqueur"), 30),
                new Portion(new Liquide("jus de citron", "fruit"), 10),
                new Portion(new Liquide("limonade", "soft"), 50)
            };

            // Création d'un Tequila Sunrise
            Recette tequilaSunrise = new Recette();
            tequilaSunrise.Ingredients = new Portion[]
            {
                new Portion(new Liquide("tequila", "alcool"), 50),
                new Portion(new Liquide("jus d'orange", "jus de fruit"), 100),
                new Portion(new Liquide("sirop de grenadine", "sirop"), 10)
            };

            // Création d'un Mai Tai
            Recette maiTai = new Recette();
            maiTai.Ingredients = new Portion[]
            {
                new Portion(new Liquide("rhum", "alcool"), 40),
                new Portion(new Liquide("jus de citron", "fruit"), 20),
                new Portion(new Liquide("sirop d'orgeat", "sirop"), 15),
                new Portion(new Liquide("liqueur d'orange", "liqueur"), 15),
                new Portion(new Liquide("sirop de sucre", "sirop"), 10)
            };

            // Création d'un White Russian
            Recette whiteRussian = new Recette();
            whiteRussian.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vodka", "alcool"), 50),
                new Portion(new Liquide("liqueur de café", "liqueur"), 20),
                new Portion(new Liquide("crème fraîche", "crème"), 30)
            };

            // Création d'un Singapore Sling
            Recette singaporeSling = new Recette();
            singaporeSling.Ingredients = new Portion[]
            {
                new Portion(new Liquide("gin", "alcool"), 30),
                new Portion(new Liquide("jus d'ananas", "jus de fruit"), 30),
                new Portion(new Liquide("liqueur de cerise", "liqueur"), 15),
                new Portion(new Liquide("jus de citron", "fruit"), 10),
                new Portion(new Liquide("soda", "soft"), 60)
            };

            // Création d'un Bloody Mary
            Recette bloodyMary = new Recette();
            bloodyMary.Ingredients = new Portion[]
            {
                new Portion(new Liquide("vodka", "alcool"), 50),
                new Portion(new Liquide("jus de tomate", "jus de fruit"), 100),
                new Portion(new Liquide("jus de citron", "fruit"), 10),
                new Portion(new Liquide("sauce Worcestershire", "sauce"), 5),
                new Portion(new Liquide("tabasco", "sauce"), 2)
            };

            // Récapitulatif :
            // Mojito : Rhum (40ml), Eau gazeuse (60ml), Menthe (10 feuilles), Citron vert (20ml), Sucre de canne (10g)
            // Martini : Vermouth (60ml), Gin (40ml), Olive (1)
            // Daiquiri : Rhum blanc (60ml), Jus de citron vert (30ml), Sirop de sucre (20ml)
            // Cosmopolitan : Vodka (40ml), Jus de canneberge (30ml), Triple sec (20ml), Jus de citron (10ml)
            // Margarita : Tequila (50ml), Jus de citron vert (30ml), Triple sec (20ml), Sel (1 pincée)
            // Manhattan : Whisky (50ml), Vermouth doux (30ml), Angostura (2 traits), Cerise (1)
            // Pina Colada : Rhum blanc (50ml), Jus d'ananas (100ml), Crème de coco (50ml)
            // Long Island Iced Tea : Vodka (15ml), Rhum (15ml), Gin (15ml), Tequila (15ml), Triple sec (15ml), Jus de citron (25ml), Cola (25ml)
            // Blue Lagoon : Vodka (50ml), Curacao bleu (30ml), Jus de citron (10ml), Limonade (50ml)
            // Tequila Sunrise : Tequila (50ml), Jus d'orange (100ml), Sirop de grenadine (10ml)
            // Mai Tai : Rhum (40ml), Jus de citron (20ml), Sirop d'orgeat (15ml), Liqueur d'orange (15ml), Sirop de sucre (10ml)
            // White Russian : Vodka (50ml), Liqueur de café (20ml), Crème fraîche (30ml)
            // Singapore Sling : Gin (30ml), Jus d'ananas (30ml), Liqueur de cerise (15ml), Jus de citron (10ml), Soda (60ml)
            // Bloody Mary : Vodka (50ml), Jus de tomate (100ml), Jus de citron (10ml), Sauce Worcestershire (5ml), Tabasco (2 gouttes)


    }
}
}
