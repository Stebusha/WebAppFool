namespace BlazorWebApp.Models
{
    public class Player{
        List<Card>? inHand;
        PlayerType? playerType;
        public string Name{get; set;} = string.Empty;
        public int TurnNumber{get;set;}
        public bool Taken{get;set;}
        public bool IsFool {get;set;}
    }
}