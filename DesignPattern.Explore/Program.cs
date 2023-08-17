using DesignPattern.Explore.Structural.FlyWeight;


// Flyweight Factory oluştur
EnemyFactory enemyFactory = new EnemyFactory();

// Oyun oluştur
Game game = new Game();
game.SpawnEnemy(10, 5, enemyFactory.GetEnemy("Soldier", ConsoleColor.Green));
game.SpawnEnemy(20, 8, enemyFactory.GetEnemy("Soldier", ConsoleColor.Green));
game.SpawnEnemy(15, 3, enemyFactory.GetEnemy("Sniper", ConsoleColor.Red));
game.SpawnEnemy(25, 6, enemyFactory.GetEnemy("Sniper", ConsoleColor.Red));

// Düşmanları görüntüle
game.DisplayEnemies();