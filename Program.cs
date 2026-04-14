






int playerHealth = 10;
int npcHealth = 10;

Console.WriteLine($"Player Health: {playerHealth}");
Console.WriteLine($"NPC Health: {npcHealth}");

Random dice = new Random();

do
{   
    int roll = dice.Next(1,11);
    npcHealth -= roll;
    Console.WriteLine($"Monster takes damage of {roll} health and now has {npcHealth} health");    
    
    if (npcHealth <= 0) continue;

    roll = dice.Next(1,11);
    playerHealth -= roll;
    Console.WriteLine($"Player takes damage of {roll} and now has {playerHealth} health.");

} while (npcHealth > 0 && npcHealth > 0);

Console.WriteLine(playerHealth > npcHealth ? "Player wins!" : "Monster wins!");
