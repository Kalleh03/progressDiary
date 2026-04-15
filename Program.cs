// This one eludes me still, the logic behind saving hp and displaying random is still odd. 
// The same can be said of the while loop which i haven't used much yet. 
// Perhaps that's the problem... 

int playerHealth = 10;
int npcHealth = 10;



Random dice = new Random();

do
{   
   int roll = dice.Next(1,11);
   npcHealth -= roll;
   Console.WriteLine($"Monster is hit, takes {roll} damage. Monster has {npcHealth}HP left.");
   if (npcHealth <= 0) continue;

   roll = dice.Next(1,11);
   playerHealth -= roll;
   Console.WriteLine($"Player is hit, takes {roll} damage. Hero has {playerHealth}HP left.");
   

} while (npcHealth > 0 && playerHealth > 0);

Console.WriteLine(playerHealth > npcHealth ? "Hero wins!" : "Monster wins!");
