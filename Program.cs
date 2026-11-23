using Restaurant;

// 1. Le client
Client c1 = new Client("Diallo", "Mamadou", 56906530, "diallo.mamadou@example.com", 0);
// 2. Les repas
Plat p1 = new Plat("Crepe", 15, "Crepe nutela");          // plat du menu
Plat p2 = new Plat("Salade", 10, "Salade de tomates");          // plat du menu
Plat p3 = new Plat("Pâtes", 12, "Pâtes à la carbonara");          // plat seul
Menu m = new Menu("Menu du jour", 22, "Eau minérale");
m.ajouterPlat(p1);
m.ajouterPlat(p2);

// 3. Les commandes (dates différentes)
Commande cmd1 = new Commande(5, new DateTime(2026, 3, 10, 12, 30, 0), 1, false, c1);
Commande cmd2 = new Commande(8, new DateTime(2026, 3, 10, 13, 15, 0), 2, true, c1);
cmd1.ajouterRepas(p3);             // le plat seul
cmd2.ajouterRepas(m);               // le menu

// 4. Servir : les plats du menu d'abord, le menu ensuite
p1.servirRepas();
p2.servirRepas();
m.servirRepas();                  // le menu
p3.servirRepas();                 // le plat seul

// 5. Vérifier et calculer
Console.WriteLine(cmd1.EtatCommande());
Console.WriteLine(cmd2.EtatCommande());
cmd1.CalculerAddition();
cmd2.CalculerAddition();

// 6. Trier par date et afficher
List<Commande> liste = new List<Commande>();
liste.Add(cmd1);
liste.Add(cmd2);
liste.Sort();
foreach (Commande c in liste)
    Console.WriteLine(c);
