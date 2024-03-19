using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCarta : MonoBehaviour
{
    public List<Carta> displayCarta = new List<Carta>();
    public int displayId;

    public int id;
    public int type;
    public string cardName;
    public string cardDescription;
    public Sprite spriteCard;

    public TMP_Text idText;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCardsInDeck = Deck.deckSize;
        
        displayCarta[0] = DatabaseCarte.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCarta[0].id;
        cardName = displayCarta[0].cardName;
        cardDescription = displayCarta[0].cardDescription;
        spriteCard = displayCarta[0].spriteCard;

        nameText.text = " " + cardName;
        descriptionText.text = " " + cardDescription;
        idText.text = " " + id;
        artImage.sprite = spriteCard;

        Hand = GameObject.Find("Hand");
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }
        
        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            displayCarta[0] = Deck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            Deck.deckSize -= 1;
            cardBack = false;
            this.tag = "HandCard";
        }

        type = 3;

        if(id == 0 || id == 1)
        {
            type = 1;
        }
        if(id == 2 || id == 3)
        {
            type = 2;
        }
    }
}
