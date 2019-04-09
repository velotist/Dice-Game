namespace Wuerfelspiel
{
    /***************************************************************************
     *  die Klasse besitzt:
     *  
     *  ein Feld "eyes"
     *  ein Objekt der Klasse "Random"
     *
     *  einen Standardkonstruktor; dieser nutzt den zweiten Konstruktor
     *  und übergibt den Wert sechs dem Feld "eyes"
     *  
     *  ein zweiter Konstruktor; dieser benötigt einen Integer-Parameter
     *  der Parameter dient der Übergabe einer höchsten Augenzahl
     *  dem Feld "eyes" wird dann der Parameter zugewiesen
     * 
     *  eine Methode, die eine Zahl zwischen 1 und einer maximalen Augenzahl
     *  zurückgibt
     *  
     **************************************************************************/

    class Dice
    {
        public static int eyes;
        //private System.Random estimateEyes = new System.Random();

        public Dice():this(6)
        {   
        }

        public Dice(int value)
        {
            eyes = value;
        }

        //public int DiceNow()
        //{
        //    return estimateEyes.Next(1, eyes);
        //}
    }
}