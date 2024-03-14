using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Carta
{
    public int id;
    public string cardName;
    public string cardDescription;
    public Sprite spriteCard;

    void Card()
    {
        
    }

    public Carta(int Id, string Nome, string Descrizione, Sprite Sprite)
    {
        id = Id;
        cardName = Nome;
        cardDescription = Descrizione;
        spriteCard = Sprite;
    }
}
