using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseCarte : MonoBehaviour
{
    public static List<Carta> cardList = new List<Carta>();

    void Awake()
    {
        cardList.Add(new Carta(0, "Goccia d'Acqua", "Una goccia d'acqua pulita e potabile.", Resources.Load<Sprite>("acquaplaceholder")));
        cardList.Add(new Carta(1, "Goccia d'Acqua Sporca", "Una goccia d'acqua sporca da purificare.", Resources.Load<Sprite>("acquasporcaplaceholder")));
        cardList.Add(new Carta(2, "Goccia d'Acqua Economica", "Offri due carte dalla tua mano al tuo avversario e in cambio prendi una carta goccia dal campo avversario.", Resources.Load<Sprite>("acquaplaceholder")));
        cardList.Add(new Carta(3, "Accesso Universale", "Si.", Resources.Load<Sprite>("acquasporcaplaceholder")));
        cardList.Add(new Carta(4, "WC", "Pesca casualmente una carta dalla mano del tuo avversario e mettila nel mazzo degli scarti.", Resources.Load<Sprite>("wcplaceholder")));
        cardList.Add(new Carta(5, "Inquinamento", "Rendi una carta dell'avversario da 'Goccia d'Acqua' a 'Goccia d'Acqua Sporca'.", Resources.Load<Sprite>("inquinamentoplaceholder")));
        cardList.Add(new Carta(6, "Riciclo e Riutilizzo", "Prendi una carta a tua scelta dal mazzo degli scarti e posizionala nella tua mano.", Resources.Load<Sprite>("ricicloplaceholder")));
        cardList.Add(new Carta(7, "Depuratore", "Scarta due carte dalla tua mano e purifica le gocce d'acqua presenti sul tuo campo rendendole potabili.", Resources.Load<Sprite>("depuratoreplaceholder")));
        cardList.Add(new Carta(8, "Rilascio di Sostanze", "Posiziona una tua carta nella mano dell'avversario, obbligandolo ad usarla nel turno successivo.", Resources.Load<Sprite>("rilasciodisostanzeplaceholder")));
        cardList.Add(new Carta(9, "Materiali Pericolosi", "Posiziona due carte dalla tua mano al mazzo degli scarti.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
    }
}
