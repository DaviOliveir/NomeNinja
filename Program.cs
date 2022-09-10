Console.WriteLine("Digite Seu Nome :");
string nomeDigitado = Console.ReadLine()!;

string nomeninja = nomeDigitado
.ToLower()

.Replace("a", "KA")

.Replace("á", "KA")

.Replace("ã", "KA")

.Replace("â", "KA")

.Replace("b", "ZU")

.Replace("c", "MI")

.Replace("d", "TE")

.Replace("e", "KU")

.Replace("f", "LU")

.Replace("g", "JI")

.Replace("h", "RI")

.Replace("i", "KI")

.Replace("í", "KI")

.Replace("ì", "KI")

.Replace("j", "ZUS")

.Replace("k", "ME")

.Replace("l", "TA")

.Replace("m", "RIN")

.Replace("n", "TO")

.Replace("o", "MO")

.Replace("õ", "MO")

.Replace("ô", "MO")

.Replace("p", "NO")

.Replace("q", "KE")

.Replace("r", "SHI")

.Replace("s", "ARI")

.Replace("t", "CHI")

.Replace("u", "DO")

.Replace("v", "RU")

.Replace("x", "MEI")

.Replace("w", "NA")

.Replace("y", "FU")

.Replace("z", "ZI")

.ToLower();


string inicial = nomeninja.Substring(0,1).ToUpper();

string restante = nomeninja.Substring(1);

nomeninja = $"{inicial}{restante}";


Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine($"Seu Nome Ninja é {nomeninja}.");

Console.ResetColor();
