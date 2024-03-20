using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinText;
    public GameObject LostText;
    public GameObject WaterZone;
    public GameObject Hand;
    public int WaterCount;
    public int CardsinDeck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WaterCount = 0;
        foreach (Transform childTransform in WaterZone.transform)
        {
            if(childTransform.GetComponent<DisplayCarta>().id == 0)
            {
                WaterCount++;
            }
            //Debug.Log(WaterCount);
        }
        //Debug.Log(WaterCount);
        if (WaterCount >= 5)
        {
            WinText.SetActive(true);
        }
        else
        {
            WinText.SetActive(false);
        }

        if(Deck.deckSize == 0 && Hand.transform.childCount == 0)
        {
            LostText.SetActive(true);
        }
        else
        {
            LostText.SetActive(false);
        }
    }
}
