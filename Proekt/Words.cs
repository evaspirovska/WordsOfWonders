using Proekt.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proekt
{

    public class Words
    {
        private Random random;
        public int Category { get; set; }
        private string[][] category1 = { new string[]{ "american", "fried chicken", "popcorn", "waffles", "peanuts", "peanut butter", "pancakes", "donuts", "cookie", "corn", "grilled cheese", "hot dog", "steak", "jelly", "hamburger" },
            new string[]{ "italian", "basil", "lasagna", "risotto", "carbonara", "meatballs", "spaghetti", "cheese", "pasta", "tomatoes", "gelato", "pizza" }, 
            new string[]{ "ovosje_zelencuk", "mango", "avocado", "apple", "brussel sprout", "apricot", "banana", "broccoli", "carrot", "kiwi", "pineapple", "potato", "sweetcorn", "tomato" }};
        private string[][] category2 = { new string[]{ "poznati_artisti", "lichtenstein", "okeefe", "rembrandt", "michelangelo", "dali", "caravagio", "renoir", "cezanne", "pollock", "picasso", "botticelli", "cassatt", "degas", "kahlo", "monet", "chagall", "seurat", "matisse", "warhol" },
            new string[]{ "akteri", "emma stone", "julia roberts", "chris hemsworth", "tom holland", "jennifer aniston", "scarlett johansson", "adam sandler", "will smith", "anne hathaway", "jennifer lawrence", "hugh jackman", "robert downey jr", "sandra bullock", "zendaya", "dwayne johnson", "cameron boyce" },
            new string[]{ "poznati_licnosti", "justin bieber", "chris brown", "tyga", "channing tatum", "miley cyrus", "becky g", "lady gaga", "drake", "selena gomez", "will smith", "katy perry", "kim kardashian", "eminem", "nicky minaj", "austin mahone", "steven frenandez" }};
        private string[][] category3 = { new string[] { "connecting_to_the_internet", "hardware", "protocol", "wifi", "firewall", "data", "application", "network", "byte", "ip address", "data packets", "circuit switching", "wan", "lan", "bandwidth", "local area network", "fibre otpics", "router", "internet", "connect", "digital" },
            new string[]{ "futuristic", "digital", "electro", "flyingcars", "future", "hologram", "hoverboard", "money", "portal", "robot", "technology", "teleportation" },
            new string[]{ "marvel", "captain america", "ironman", "daredevil", "stanford incident", "mark millar", "avengers", "fantastic four", "timely comics", "excelisior", "civil war", "bankrupt", "xmen", "jack kirby", "stan lee", "martin goodman", "marvel", "spiderman" },
            new string[]{ "renaissance", "printing press", "gutenberg", "the last supper", "secularism", "hamlet", "rebirth", "humanism", "individualism", "leonardo da vinci", "the divine comedy", "sonnets", "petrarch", "cervantes", "shakespeare", "romeo and juliet", "michelangelo", "dante", "mona lisa", "don quixote", "sistine chapel" }};
        public Words(int category)
        {
            random = new Random();
            this.Category = category;
        }

        public string[] pick()
        {
            if(Category == 1)
                return category1[random.Next(0, 3)];
            else if (Category == 2)
                return category2[random.Next(0, 3)];
            else
                return category3[random.Next(0, 4)];
        }
    }
}
