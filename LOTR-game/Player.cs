using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTR_game
{
    public class Player
    {
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public bool ActivePlayer { get; set; }
        public List<Card> CardsInHand { get; set; }
        public List<Card> CardsOnBoard { get; set; }
        public int Resources { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public Player()
        {
            CardsInHand = new List<Card>();
            CardsOnBoard = new List<Card>() { null, null, null, null, null, null };

            //for (int i = 0; i < 6; i++) -- //TODO: Gammal rest som blivit kvar eller feature to be implemented? ;) 
            //{
            //    CardsOnBoard[0] = null;
            //}
        }

        public void LifeChanger() //TODO gissar jag =)
        {

        }

        public void ResourceChanger() //TODO gissar jag =)
        {

        }

        public Card PlayCard()
        {
            Console.WriteLine("Which card do you want to play?"); //TODO: Lite otydligt vilken siffra som motsvarar vilket kort, samma sak när man ska välja var kortet ska placeras
            ConsoleKey playCardChoice = Console.ReadKey().Key;
            int chosenCardIndex = (int)playCardChoice - (int)ConsoleKey.D1; //TODO: Lägga till int.TryParse för att fånga upp elaka/klantiga användare som inte skriver in siffror, samt om man skriver in en siffra out of range

            Card chosenCard = CardsInHand[chosenCardIndex];

            if (chosenCard.Type == CardType.Creature)
            {
                Console.WriteLine("Where do you want to place your creature?");
                ConsoleKey creaturePlacement = Console.ReadKey().Key;
                int chosenPlacementIndex = (int)creaturePlacement - (int)ConsoleKey.D1;

                CardsOnBoard[chosenPlacementIndex] = chosenCard;
            }

            CardsInHand.Remove(chosenCard);
            return chosenCard;

        }

        public void ReceiveCard() //Eller ska dom här vara tomma? I såna fall, förstår inte riktigt varför :D 
        {

        }

        public void ChangePlayerTurn()
        {

        }

        public int SelectAttacker()
        {
            Console.WriteLine("Which creature do you want to attack with?"); //TODO: Här fattade jag inte vad jag skulle mata in, namnet eller en siffra och i så fall vilken? Tryckte på 1an men det hände inget, började skriva "F.." och då kraschade det
            ConsoleKey attackChoice = Console.ReadKey().Key;
            int chosenCardIndex = (int)attackChoice - (int)ConsoleKey.D1;

            Card chosenCard = CardsOnBoard[chosenCardIndex];

            return chosenCardIndex;

        }
    }
}
