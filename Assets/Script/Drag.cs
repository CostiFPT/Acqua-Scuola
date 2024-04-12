using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private int Times;
    GameObject playArea1;
    GameObject playArea2;
    GameObject playArea3;
    GameObject playArea4;
    GameObject playArea5;
    GameObject TurnSys;
    Transform WaterArea;
    Transform PlacingArea;
    Transform DiscardArea;
    Transform WCScarti;
    Transform Hand;
    Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        //Debug.Log("BeginDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        GetComponent<LayoutElement>().ignoreLayout = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        TurnSys = GameObject.Find("DeckGiocatore");

        if (this.tag != "Placed1" && this.tag != "Placed2" && this.tag != "Placed3" && TurnSys.GetComponent<TurnSystem>().HadPlayed != true)
        {
            this.transform.position = eventData.position;
        }
        //Debug.Log("Drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        playArea1 = GameObject.Find("PlayArea");
        WaterArea = playArea1.transform;
        playArea2 = GameObject.Find("PlacingArea");
        PlacingArea = playArea2.transform;
        playArea3 = GameObject.Find("DiscardArea");
        DiscardArea = playArea3.transform;
        playArea4 = GameObject.Find("WCScarti");
        WCScarti = playArea4.transform;
        playArea5 = GameObject.Find("Hand");
        Hand = playArea5.transform;
        TurnSys = GameObject.Find("DeckGiocatore");

        if (TurnSys.GetComponent<TurnSystem>().HadPlayed != true)
        {
            if (this.tag != "Placed1" && this.tag != "Placed2" && this.tag != "Placed3")
            {
                this.tag = "Untagged";
            }

            if (this.tag != "HandCard" && playArea1.GetComponent<DropZone>().DropOnZone == true && this.tag != "Placed2" && this.tag != "Placed3" && this.GetComponent<DisplayCarta>().type == 1)
            {
                this.transform.SetParent(WaterArea);
                this.tag = "Placed1";
                TurnSys.GetComponent<TurnSystem>().HadPlayed = true;
            }
            if (this.tag == "Placed1")
            {
                this.transform.SetParent(WaterArea);
                this.tag = "Placed1";
            }

            if (this.tag != "HandCard" && playArea2.GetComponent<DropZone1>().DropOnZone == true && this.tag != "Placed1" && this.tag != "Placed3" && this.GetComponent<DisplayCarta>().type != 1)
            {
                this.transform.SetParent(PlacingArea);
                this.tag = "Placed2";
                TurnSys.GetComponent<TurnSystem>().HadPlayed = true;
            }
            if (this.tag == "Placed2")
            {
                if (this.GetComponent<DisplayCarta>().type == 2)
                {
                    this.transform.SetParent(PlacingArea);
                    this.tag = "Placed2";
                }
                else
                {
                    this.transform.SetParent(PlacingArea);
                    this.tag = "Placed2";
                    if (this.GetComponent<DisplayCarta>().id == 7 && Times < 1)
                    {
                        StartCoroutine(Depuratore());
                    }
                    if (this.GetComponent<DisplayCarta>().id == 5 && Times < 1)
                    {
                        StartCoroutine(Inquinamento());
                    }
                    if (this.GetComponent<DisplayCarta>().id == 6 && Times < 1)
                    {
                        StartCoroutine(RicicloeRiutilizzo());
                    }
                    if (this.GetComponent<DisplayCarta>().id == 9 && Times < 1)
                    {
                        StartCoroutine(MatPericolosi());
                    }
                    if (this.GetComponent<DisplayCarta>().id == 21 && Times < 1)
                    {
                        StartCoroutine(Allagamento());
                    }
                    if (this.GetComponent<DisplayCarta>().id == 17 && Times < 1)
                    {
                        StartCoroutine(WCPot());
                    }
                    StartCoroutine(RemoveCard());
                    Times = 0;
                }
            }

            if (this.tag != "HandCard" && playArea3.GetComponent<DropZone2>().DropOnZone == true && this.tag != "Placed1" && this.tag != "Placed2")
            {
                this.transform.SetParent(DiscardArea);
                this.tag = "Placed3";
                TurnSys.GetComponent<TurnSystem>().HadPlayed = true;
            }
            if (this.tag == "Placed3")
            {
                this.transform.SetParent(DiscardArea);
                this.tag = "Placed3";
            }

            if (this.tag != "Placed1" && this.tag != "Placed2" && this.tag != "Placed3")
            {
                this.transform.SetParent(parentToReturnTo);
                this.tag = "HandCard";
            }
        }

        //Debug.Log("EndDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        GetComponent<LayoutElement>().ignoreLayout = false;
    }

    IEnumerator RemoveCard()
    {
        yield return new WaitForSeconds(1);
        gameObject.transform.SetParent(DiscardArea);
        gameObject.tag = "Placed3";

    }

    IEnumerator Depuratore()
    {
        yield return new WaitForSeconds(1);
        GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed1");
        foreach (GameObject Card in allCards)
        {
            if (Card.GetComponent<DisplayCarta>().id == 1)
            {
                if (Card.transform.eulerAngles.z != 90)
                {
                    Card.transform.Rotate(0, 0, 90, Space.World);
                }
                else
                {
                    Card.transform.Rotate(0, 0, -90, Space.World);
                }
            }

            Card.GetComponent<DisplayCarta>().id = 0;
        }
        Times++;
    }

    IEnumerator Inquinamento()
    {
        GameObject[] allWaters = GameObject.FindGameObjectsWithTag("Placed1"); //aiuto

        GameObject randomCard;
        int index;

        do
        {
            yield return new WaitForSeconds(1);
            index = Random.Range(0, allWaters.Length);
            randomCard = allWaters[index];
            Debug.Log(index);
            Debug.Log(allWaters);
        } while (randomCard.GetComponent<DisplayCarta>().id != 1);

        if (randomCard.transform.eulerAngles.z != 90)
        {
            randomCard.transform.Rotate(0, 0, 90, Space.World);
        }
        else
        {
            randomCard.transform.Rotate(0, 0, -90, Space.World);
        }

        randomCard.GetComponent<DisplayCarta>().id = 1;
        Times++;
    }

    IEnumerator MatPericolosi()
    {
        yield return new WaitForSeconds(1);
        GameObject[] allCards = GameObject.FindGameObjectsWithTag("HandCard");

        for (int i = 0; i < 2; i++)
        {
            Debug.Log(allCards);

            int index1 = Random.Range(0, allCards.Length);
            int index2 = Random.Range(0, allCards.Length);

            GameObject element1 = allCards[index1];
            GameObject element2 = allCards[index2];

            Debug.Log(element1 + ", " + element2);

            element1.tag = "Untagged";
            element2.tag = "Untagged";

            element1.transform.SetParent(DiscardArea);
            element2.transform.SetParent(DiscardArea);

            element1.tag = "Placed3";
            element2.tag = "Placed3";
        }
    }

    IEnumerator Allagamento()
    {
        yield return new WaitForSeconds(1);
        GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed2");
        foreach (GameObject Card in allCards)
        {
            Card.transform.SetParent(DiscardArea);
            Card.tag = "Placed3";
        }
        Times++;
    }

    IEnumerator WCPot()
    {
        yield return new WaitForSeconds(1);
        GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed3");

        playArea4.transform.Translate(-2000, 0, 0, Space.World);

        foreach (GameObject Card in allCards)
        {
            Card.transform.SetParent(WCScarti);

            Button button = Card.AddComponent<Button>();

            GameObject CardCopy = Card;
            button.onClick.AddListener(() => OnCardClick(CardCopy));
        }
        Times++;
    }

    public void OnCardClick(GameObject CardCopy)
    {
        Debug.Log("Hai cliccato");
        CardCopy.transform.SetParent(PlacingArea);      //finire e differenziare le carte piazzabili dalle acque, bottone funzionante?? un po' strano
        CardCopy.tag = "Placed2";
        Destroy(CardCopy.GetComponent<Button>());

        GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed3");

        foreach(GameObject Card in allCards)
        {
            Card.transform.SetParent(DiscardArea);
            Button button = Card.GetComponent<Button>();
            Destroy(button);
        }

        playArea4.transform.Translate(2000, 0, 0, Space.World);
    }

    IEnumerator RicicloeRiutilizzo()
    {
        yield return new WaitForSeconds(1);
        GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed3");

        playArea4.transform.Translate(-2000, 0, 0, Space.World);

        foreach (GameObject Card in allCards)
        {
            Card.transform.SetParent(WCScarti);

            Button button = Card.AddComponent<Button>();

            GameObject CardCopy = Card;
            button.onClick.AddListener(() => OnCardClickRiciclo(CardCopy));
        }
        Times++;
    }

    public void OnCardClickRiciclo(GameObject CardCopy)
    {
        Debug.Log("Hai cliccato");
        CardCopy.transform.SetParent(Hand);
        CardCopy.tag = "HandCard";
        Destroy(CardCopy.GetComponent<Button>());

         GameObject[] allCards = GameObject.FindGameObjectsWithTag("Placed3");

        foreach (GameObject Card in allCards)
        {
            Card.transform.SetParent(DiscardArea);
            Button button = Card.GetComponent<Button>();
            Destroy(button);
        }

        playArea4.transform.Translate(2000, 0, 0, Space.World);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
