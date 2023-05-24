using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirobLab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            
            while (true)
            {
                Console.WriteLine("Input numb of players (2 to 6 players) n = ");
                numb = int.Parse(Console.ReadLine());
                if(numb >= 2 && numb <= 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("WRONG INPUT!");
                }
            }
            Deck mydeck = new Deck(numb);
            List<Player> players = new List<Player>();
            mydeck.Shuffle();
            for (int i = 1; i < numb + 1; ++i)
            {
                Console.WriteLine($"Input name for {i} player, name = ");
                string temp = Console.ReadLine();
                players.Add(new Player(temp));
            }
            Console.WriteLine("Dealing cards...");
            mydeck.Deal(players);
            bool game_over = false;
            int turn = 1;
            int player_id;
            bool pair = false;
            bool player_left = false;
            Card spade_queen = new Card(12, Suit.spade);
            while (!game_over)
            {
                Console.WriteLine($"-------------------------TURN {turn}----------------------");
                player_id = turn % numb;
                pair = false;
                player_left = false;
                for (int i = 0; i < players[player_id].Amount; ++i)
                {
                    if (pair)
                    {
                        break;
                    }
                    if(players[player_id].Amount == 2)
                    {
                        if(players[player_id].cards[0] == players[player_id].cards[1])
                        {
                            if (players[player_id].cards[0] == spade_queen || players[player_id].cards[1] == spade_queen)
                            {
                                Console.WriteLine($"Player {players[player_id].name} lost!He has spade queen and some other queen");
                                game_over = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Player {players[player_id].name} won!He has no cards left");
                                player_left = true;
                                numb--;
                                players.RemoveAt(player_id);
                                break;
                            }
                        }

                    }
                    if(players[player_id].cards[i] == spade_queen)
                    {
                        continue;
                    }
                    for (int j = i; j < players[player_id].Amount; ++j)
                    {
                        if (players[player_id].cards[j] == spade_queen)
                        {
                            continue;
                        }
                        if (i == j)
                        {
                            continue;
                        }
                        if(players[player_id].cards[i] == players[player_id].cards[j])
                        {
                            pair = true;
                            Console.WriteLine($"Player {players[player_id].name} has pair: {players[player_id].cards[i]} and" +
                                $"{players[player_id].cards[j]}");
                            if (j > i)
                            {
                                players[player_id].RemoveAt(j);
                                players[player_id].RemoveAt(i);
                            }
                            else
                            {
                                players[player_id].RemoveAt(i);
                                players[player_id].RemoveAt(j);
                            }
                        }
                    }
                }
                if (!pair && !player_left && !game_over)
                {
                    Console.WriteLine($"Player {players[player_id].name} has no pair, so he takes card from {players[(turn+1) % numb].name}");
                    players[player_id].Take(players[(turn + 1) % numb].Give());
                    if(players[(turn + 1) % numb].Amount == 0)
                    {
                        Console.WriteLine($"{players[(turn + 1) % numb].name} also just won the game!");
                        players.RemoveAt((turn + 1) % numb);
                    }
                }
                for(int i = 0; i < players.Count; ++i)
                {
                    Console.WriteLine(players[i].ToString());
                }
                Console.WriteLine($"------------------END OF TURN {turn}----------------------");
                turn++;
            }
            Console.ReadLine();
        }
    }
}
