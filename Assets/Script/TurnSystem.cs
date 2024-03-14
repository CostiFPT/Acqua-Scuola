using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public bool isEnemyTurn;

    public GameObject Turnotuo;
    public GameObject Turnoavv;

    public static bool startTurn;
    
    void Start()
    {
        isYourTurn = true;      //inizialmente è il turno del giocatore
        isEnemyTurn = false;

        startTurn = false;
    }

    void Update()
    {
        if (isYourTurn == true)
        {
            Turnoavv.SetActive(false);      //se è il turno del giocatore viene visualizzato il testo Turnotuo
            Turnotuo.SetActive(true);
        }
        else
        {
            Turnotuo.SetActive(false);      //se è il turno dell'avversario viene visualizzato il testo Turnoavv
            Turnoavv.SetActive(true);
        }
    }

    public void EndYourTurn()
    {
        if(isYourTurn == true)
        {
            isYourTurn = false;         //quando viene premuto il tasto con assegnata la funzione EndYourTurn vengono impostati come falso il turno del giocatore e come vero quello del nemico
            isEnemyTurn = true;
        }
    }

    public void EndOpponentTurn()
    {
        if(isEnemyTurn == true)
        {
            isYourTurn = true;
            isEnemyTurn = false;

            startTurn = true;
        }
    }
}
