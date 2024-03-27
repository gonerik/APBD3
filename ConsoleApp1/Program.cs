// See https://aka.ms/new-console-template for more information

using APBD2.Class;

CoCooling c1 = new CoCooling(30, 3, 4,"Banana");
Contain c2 = new CoGaz(40, 3, 6);
Contain c3 = new CoLiquid(50, 6, 5,true);
List<Contain> clist = new List<Contain>();
clist.Add(c1);
clist.Add(c2);
clist.Add(c3);
c1.load(10);
c1.load(10);
c1.load(10);
c1.empty();
c2.load(20);
c2.empty();
Ship s = new Ship(20,5,100);
Ship s1 = new Ship(20, 5, 120);
s.board(c1);
s.board(c2);
s.board(clist);
Console.WriteLine(s);
Console.WriteLine(c1);
s.unboard("KON-C-0");
s.swapContainers(c1,"KON-G-1");
s.swapShips(c1,s1);