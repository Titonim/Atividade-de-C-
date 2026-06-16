// Algoritmo 1
string personagem;

Console.WriteLine("Digite o nome do seu personagem: ");
personagem = Console.ReadLine();
Console.WriteLine("Olá " + personagem + ", sua jornada de 100 horas no mundo de C# começou. Boa sorte!.");

// Algoritmo 2

int pontuacao, pontuacao2, total;

Console.WriteLine("Pontuação da primeira missão: ");
pontuacao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pontuação da segunda missão missão: ");
pontuacao2 = Convert.ToInt32(Console.ReadLine());

total = pontuacao + pontuacao2;
Console.WriteLine("Pontuação total: " + total);

// Algoritmo 3

double preco, total_1;
int quantidade;
Console.WriteLine("Qual o preço da poção: ");
preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade requisitada: ");
quantidade = Convert.ToInt32(Console.ReadLine());
total_1 = preco * quantidade;

Console.WriteLine("Valor total a pagar: " + total_1);

// Algoritmo 4

int metros;
float pixels;

Console.WriteLine("Pocição dompersonagem em metros: ");
metros = Convert.ToInt32(Console.ReadLine());

pixels = metros * 64;
Console.WriteLine("Converção em pixels: " + pixels);

// Algoritmo 5

int xp1, xp2, xp3;
float media;

Console.WriteLine("XP ganho na ultima missão: ");
xp1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("XP ganho na ultima missão: ");
xp2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("XP ganho na ultima missão: ");
xp3 = Convert.ToInt32(Console.ReadLine());

media = (float)(xp1 + xp2 + xp3) / 3;

Console.WriteLine("Média do xp ganho nas ultimas missões: " + media);

// Algoritmo 6

float celcius, fahrenheit;

Console.WriteLine("Temperatura em graus celcius: ");
celcius = float.Parse(Console.ReadLine());
fahrenheit = (float)(celcius * 1.8 + 32);
Console.WriteLine("Temperatura convetida para fahrenheit: " + fahrenheit);

// Algoritmo 7

int id, id_ant, id_post;

Console.WriteLine("ID de skin desejada: ");
id = Convert.ToInt32(Console.ReadLine());

id_ant = id - 1;
id_post = id + 1;
Console.WriteLine("Id anterior: " + id_ant + " Id posterior: " + id_post);

// Algoritmo 8

double hp, hp_20;

Console.WriteLine("Pontos de HP atual: ");
hp = Convert.ToDouble(Console.ReadLine());

hp_20 = hp * 0.2;

if (hp == hp_20)
{
    Console.WriteLine("ALERTA: Vida Crítica! Use uma poção!");
}
else
{
    Console.WriteLine("HP estável");
}

//algoritmo 9

int idade;

Console.WriteLine("Qual a sua idade");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Altorizado.");
}
else
{
    Console.WriteLine("Não altorizado!");
}

// Algoritmo 10

int time_alfa, time_omega;

Console.WriteLine("Eliminações da equipe Omega: ");
time_omega = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Eliminações da equipe Alfa: ");
time_alfa = Convert.ToInt32(Console.ReadLine());

if (time_alfa > time_omega)
{
    Console.WriteLine("Equipe Alfa ganhou!! ");
}
else if (time_omega > time_alfa)
{
    Console.WriteLine("Equipe Omega ganhou!! ");
}
else
{
    Console.WriteLine("A partida terminou em empate! ");

}

// Algoritmo 11

int id_personagem;

Console.WriteLine("ID do jogador: ");
id_personagem = Convert.ToInt32(Console.ReadLine());

if (id_personagem % 2 == 0)
{
    Console.WriteLine("Bem-Vindo a guilda, Magos do Alvorecer!");
}
else
{
    Console.WriteLine("Bem-Vindo a guilda, Guerreiros da noite!");
}

// Algoritmo 12

string username, senha;

Console.WriteLine("Seu esurname: ");
username = Console.ReadLine();
Console.WriteLine("Senha de verificação: ");
senha = Console.ReadLine();

if (username == "godmode" && senha == "666")
{
    Console.WriteLine("Trapaça Ativada: Modo Imortal Habilitado.");
}
else
{
    Console.WriteLine("Código inválido!");
}

// Algoritmo 13

int peso;

Console.WriteLine("Qual o peso dos itens carregados: ");
peso = Convert.ToInt32(Console.ReadLine());

if(peso < 50)
{
    Console.WriteLine("Consegue carregar os itens. ");
}
else
{
    Console.WriteLine("Peso sobrecarregado! ");
}

// Algortimo 14

int mmr;

Console.WriteLine("sua pontuação do ranqueado (MMR): ");
mmr = Convert.ToInt32(Console.ReadLine());

if (mmr < 1000)
{
    Console.WriteLine("Rank Bronze.");
}
else if (mmr >= 1000 && mmr < 2000)
{
    Console.WriteLine("Rank Prata.");
}
else
{
    Console.WriteLine("Rank ouro.");

}

// Algoritmo 15

int inimigos;

for (inimigos = 1; inimigos <= 50; inimigos++) ;
{
    Console.WriteLine(inimigos + " Gerado com sucesso!!");
}

// Algoritmo 16

int round;

for (round = 2; round <= 100; round += 2) ;
{
    Console.WriteLine("Round-" +  round);
}

// Algoritmo 17

int timer;

for (timer = 10; timer >= 0; timer--) ;
{
    Console.WriteLine(timer);
}
Console.WriteLine("FIGHT! COMEÇOU O ROUND!");

// Algoritmo 18

int producao,producao1 ,dia;
dia = 1;
producao1 = 0;
while (dia == 7)
{
    Console.WriteLine("Farm no " + dia + "º dia: ");
    producao = Convert.ToInt32(Console.ReadLine());
    dia++;
    producao1 = producao1 + producao;
}
Console.WriteLine("Total da farm ultimos 7 dias: "+ producao1);

// Algoritnmo 19

int ataque, multi, soma;

Console.WriteLine("Dano base do personagem: ");
ataque = Convert.ToInt32(Console.ReadLine());

for(multi = 1; multi <= 10; multi++)
{
    soma = ataque * multi;
    Console.WriteLine(ataque + " * " + multi + " = " + soma);
}

// Algoritmo 20

string chave;
chave = "";
while (chave != "Abracadabra")
{
    Console.WriteLine("Chave do baú: ");
    chave = Console.ReadLine();
}

Console.WriteLine("Baú aberto.");

// Algoritmo 21

int n, dificuldade, media1 = 0;

Console.WriteLine("Quantidade de leveis da dungeon");
n = Convert.ToInt32(Console.ReadLine());

while(n > 0)
{
    Console.WriteLine("Dificuldade do nivel: " + n + " da dungeon (1 a 5): ");
    dificuldade = Convert.ToInt32(Console.ReadLine());

    media1 = dificuldade + media1;
}
media1 = media1 / n;

Console.WriteLine("Média de dificuldade da dungeon: " + media1);

// Algoritmo 22

int lootBox, raridade, comum=0, raro=0;

for (lootBox = 10; lootBox >= 0; lootBox--)
{
    Console.WriteLine("Valor de raridade da " + lootBox + "º loot box(1 a 100): ");
    raridade = Convert.ToInt32(Console.ReadLine());

    if(raridade >= 1 && raridade <= 49)
    {
        comum++;
    }
    else
    {
        raro++;
    }
}
Console.WriteLine("Quantidade de loot comum: " + comum);
Console.WriteLine("Quantidade de loot raro: " + raro);

// Algoritmo 23
int pontuacao1, maior = 0;
Console.WriteLine("Pontuação da partida anterior: ");
pontuacao1 = Convert.ToInt32(Console.ReadLine());
while (pontuacao1 != 0)
{
    if(pontuacao1 > maior)
    {
        maior = pontuacao1;
    }
    Console.WriteLine("Pontuação da partida anterior: ");
    pontuacao1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Maior pontuação registrada: " + maior);

// Algoritmo 24

int manaTotal, mana;
manaTotal = 1000;

while (manaTotal > 0)
{
    Console.WriteLine("Mana gasta no feitiço: ");
    mana = Convert.ToInt32(Console.ReadLine());
    manaTotal = manaTotal - mana;
    Console.WriteLine("Mana: "+ manaTotal);
}
Console.WriteLine("Mana esgotada!, recarregar.");

// Algoritimo 25

int players, kills, killstotais = 0, maior1 = 0;
string nome, mvp;
for (players = 5; players >= 0; players--)
{
    Console.WriteLine("Nome do jogador: ");
    nome = Console.ReadLine();
    Console.WriteLine("Kills do jogador: ");
    kills = Convert.ToInt32(Console.ReadLine());

    killstotais = killstotais + kills;

    if(kills > maior1)
    {
        maior1 = kills;
        mvp = nome;
    }
}
Console.WriteLine("Totais de kill da equipe: " + killstotais);
Console.WriteLine("Player com mais kills: ");
Console.WriteLine("Quantidades de kills: " + maior1);