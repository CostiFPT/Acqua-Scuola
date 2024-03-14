using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Carta> deck = new List<Carta>();
    public List<Carta> container = new List<Carta>();
    public static int deckSize;
    public static List<Carta> staticDeck = new List<Carta>();


    public GameObject CardInDeck1;
    public GameObject CardInDeck2;
    public GameObject CardInDeck3;
    public GameObject CardInDeck4;
    public GameObject CardInDeck5;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        deckSize = 40;

        deck[0] = DatabaseCarte.cardList[0];
        deck[1] = DatabaseCarte.cardList[0];
        deck[2] = DatabaseCarte.cardList[0];
        deck[3] = DatabaseCarte.cardList[0];
        deck[4] = DatabaseCarte.cardList[0];
        deck[5] = DatabaseCarte.cardList[1];
        deck[6] = DatabaseCarte.cardList[1];
        deck[7] = DatabaseCarte.cardList[1];
        deck[8] = DatabaseCarte.cardList[1];
        deck[9] = DatabaseCarte.cardList[1];
        deck[10] = DatabaseCarte.cardList[1];
        deck[11] = DatabaseCarte.cardList[1];
        deck[12] = DatabaseCarte.cardList[1];
        deck[13] = DatabaseCarte.cardList[2];
        deck[14] = DatabaseCarte.cardList[2];
        deck[15] = DatabaseCarte.cardList[2];
        deck[16] = DatabaseCarte.cardList[2];
        deck[17] = DatabaseCarte.cardList[2];
        deck[18] = DatabaseCarte.cardList[3];
        deck[19] = DatabaseCarte.cardList[3];
        deck[20] = DatabaseCarte.cardList[3];
        deck[21] = DatabaseCarte.cardList[4];
        deck[22] = DatabaseCarte.cardList[4];
        deck[23] = DatabaseCarte.cardList[4];
        deck[24] = DatabaseCarte.cardList[5];
        deck[25] = DatabaseCarte.cardList[5];
        deck[26] = DatabaseCarte.cardList[6];
        deck[27] = DatabaseCarte.cardList[6];
        deck[28] = DatabaseCarte.cardList[6];
        deck[29] = DatabaseCarte.cardList[6];
        deck[30] = DatabaseCarte.cardList[7];
        deck[31] = DatabaseCarte.cardList[7];
        deck[32] = DatabaseCarte.cardList[7];
        deck[33] = DatabaseCarte.cardList[7];
        deck[34] = DatabaseCarte.cardList[7];
        deck[35] = DatabaseCarte.cardList[8];
        deck[36] = DatabaseCarte.cardList[8];
        deck[37] = DatabaseCarte.cardList[8];
        deck[38] = DatabaseCarte.cardList[9];
        deck[39] = DatabaseCarte.cardList[9];

        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        
        if(deckSize < 32)
        {
            CardInDeck1.SetActive(false);
        }
        if (deckSize < 24)
        {
            CardInDeck2.SetActive(false);
        }
        if (deckSize < 16)
        {
            CardInDeck3.SetActive(false);
        }
        if (deckSize < 8)
        {
            CardInDeck4.SetActive(false);
        }
        if (deckSize < 0)
        {
            CardInDeck5.SetActive(false);
        }

        if(TurnSystem.startTurn == true)
        {
            StartCoroutine(Draw(1));
            TurnSystem.startTurn = false;
        }
    }

    IEnumerator StartGame()
    {
        for (int i = 0; i <= 2; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }

    IEnumerator Draw(int x)
    {
        for(int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }
}
