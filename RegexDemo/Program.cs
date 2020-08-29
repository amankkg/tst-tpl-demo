using System;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\/\/.+");

            Console.WriteLine(listing);
            Console.WriteLine(regex.Replace(listing, ""));
        }

        const string text = @"Tensions between the French and English crowns had gone back centuries to the origins of the English royal family, which was French (Norman, and later, Angevin) in origin. English monarchs had therefore historically held titles and lands within France, which made them vassals to the kings of France. The status of the English king's French fiefs was a major source of conflict between the two monarchies throughout the Middle Ages. French monarchs systematically sought to check the growth of English power, stripping away lands as the opportunity arose, particularly whenever England was at war with Scotland, an ally of France. English holdings in France had varied in size, at some points dwarfing even the French royal domain; by 1337, however, only Gascony was English.

In 1328, Charles IV of France died without sons or brothers and a new principle disallowed female succession. Charles's closest male relative was his nephew Edward III of England, whose mother, Isabella of France, was Charles's sister. Isabella claimed the throne of France for her son, but the French nobility rejected it, maintaining that Isabella could not transmit a right she did not possess. An assemby of French barons decided that a native Frenchman should receive the crown, rather than Edward.[1]

So the throne passed instead, to Charles's patrilineal cousin, Philip, Count of Valois. Edward protested but ultimately submitted and did homage for Gascony. Further French disagreements with Edward induced Philip, during May 1337, to meet with his Great Council in Paris. It was agreed that Gascony should be taken back into Philip's hands, which prompted Edward to renew his claim for the French throne, this time by force of arms.[2]

In the early years of the war, the English, led by their king and his son Edward, the Black Prince, saw resounding successes (notably at Crécy in 1346 and at Poitiers in 1356 where King John II of France was taken prisoner). But by 1378, the French under King Charles the Wise and the leadership of Bertrand du Guesclin had reconquered most of the lands ceded to King Edward in the Treaty of Brétigny (signed in 1360), leaving the English with only a few cities on the continent.

In the following decades, the weakening of royal authority, combined with the devastation caused by the Black Death of 1347–1351 (with the loss of nearly half of the French population[3] and 20 to 33% of the English one[4]) and the major economic crisis that followed, led to a period of civil unrest in both countries, struggles from which England emerged first.

The newly crowned Henry V of England seized the opportunity presented by the mental illness of Charles VI of France and the French civil war between Armagnacs and Burgundians to revive the conflict. Overwhelming victories at Agincourt in 1415 and Verneuil in 1424 as well as an alliance with the Burgundians raised the prospects of an ultimate English triumph and persuaded the English to continue the war over many decades. However, a variety of factors such as the deaths of both Henry and Charles in 1422, the emergence of Joan of Arc which boosted French morale, and the loss of Burgundy as an ally, marking the end of the civil war in France, prevented it.

The Siege of Orléans in 1429 announced the beginning of the end for English hopes of conquest. Even with the eventual capture of Joan by the Burgundians and her execution in 1431, a series of crushing French victories such as those at Patay in 1429, Formigny in 1450 and Castillon in 1453 concluded the war in favour of the Valois dynasty. England permanently lost most of its continental possessions, with only the Pale of Calais remaining under its control on the continent until the Siege of Calais in 1558.

Local conflicts in neighbouring areas, which were contemporarily related to the war, including the War of the Breton Succession (1341–1365), the Castilian Civil War (1366–1369), the War of the Two Peters (1356–1369) in Aragon, and the 1383–85 crisis in Portugal, were used by the parties to advance their agendas.

By the war's end, feudal armies had been largely replaced by professional troops, and aristocratic dominance had yielded to a democratisation of the manpower and weapons of armies. Although primarily a dynastic conflict, the war inspired French and English nationalism. The wider introduction of weapons and tactics supplanted the feudal armies where heavy cavalry had dominated, and artillery became important. The war precipitated the creation of the first standing armies in Western Europe since the Western Roman Empire, and helped change their role in warfare.

In France, civil wars, deadly epidemics, famines, and bandit free-companies of mercenaries reduced the population drastically. In England, political forces over time came to oppose the costly venture. The dissatisfaction of English nobles, resulting from the loss of their continental landholdings, as well as the general shock at losing a war in which investment had been so great, helped lead to the Wars of the Roses (1455–1487).";
        const string listing = @"
using System;
using System.Text.RegularExpressions;

class MyClass
{
   static void Main(string[] args)
   {
      string sInput, sRegex;

      // The string to search.
      sInput = ""aabbccddeeffcccgghhcccciijjcccckkcc"";

      // A very simple regular expression.
      sRegex = ""cc"";

      Regex r = new Regex(sRegex);

        MyClass c = new MyClass();

        // Assign the replace method to the MatchEvaluator delegate.
        MatchEvaluator myEvaluator = new MatchEvaluator(c.ReplaceCC);

        // Write out the original string.
        Console.WriteLine(sInput);

      // Replace matched characters using the delegate method.
      sInput = r.Replace(sInput, myEvaluator);
      
      // Write out the modified string.
      Console.WriteLine(sInput);
   }

    public string ReplaceCC(Match m)
    // Replace each Regex cc match with the number of the occurrence.
    {
        i++;
        return i.ToString() + i.ToString();
    }
    public static int i = 0;
}
// The example displays the following output:
//       aabbccddeeffcccgghhcccciijjcccckkcc
//       aabb11ddeeff22cgghh3344iijj5566kk77";
    }
}
