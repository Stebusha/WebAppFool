namespace BlazorWebApp.Models
{
    public class Deck{
        private List<Card>? cards;
        private SuitType[] suits = {SuitType.Clubs,SuitType.Diams,SuitType.Hearts, SuitType.Spades};
        private RankType[] ranks = {RankType.Six, RankType.Seven, RankType.Eight,RankType.Nine,RankType.Ten,RankType.Jack,RankType.Queen,RankType.King,RankType.Ace}; 
        public static SuitType trumpSuit=SuitType.Clubs;
        public int CardsAmount{get; set;}
    }
}