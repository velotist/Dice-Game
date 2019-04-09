namespace Wuerfelspiel
{
    /**********************************************************************************
     *  die Klasse besitzt:
     *  
     *  ein Feld "name"
     *  eine Eigenschaft "Name" des Feldes "name"
     *  
     *  einen Konstruktor; diesem muss ein String-Parameter (der Name des Spielers)
     *  übergeben werden; die Eigenschaft besitzt nur einen Getter, so dass
     *  der Name des Spielers nicht von außen geändert werden kann
     *  
     *  eine Methode, die einen Parameter des Datentyps der Klasse Würfel als Array
     *  benötigt
     *  durch den Array wird eine Möglichkeit geschaffen mit mehreren Würfeln zu
     *  spielen
     *  
     **********************************************************************************/

    class Player
    {
        private readonly string name;
        //private System.Random estimateEyes = new System.Random();

        public Player(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        //public int ThrowDices(Dice[] dices)
        //{
        //    int result = 0;
        //    result = DiceNow();
        //    return result;
        //}

        //public int DiceNow()
        //{
        //    return estimateEyes.Next(1, 6);
        //}
    }
}