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
        cardList.Add(new Carta(2, "Goccia d'Acqua Economica", "Offri una carta dalla tua mano al tuo avversario e in cambio prendi una carta goccia dal campo avversario e posizionala nel tuo campo.", Resources.Load<Sprite>("acquaplaceholder")));
        cardList.Add(new Carta(3, "Accesso Universale", "Viene applicata l'abilità di una tua carta a scelta senza giocarla.", Resources.Load<Sprite>("acquasporcaplaceholder")));
        cardList.Add(new Carta(4, "WC", "Pesca casualmente una carta dalla mano del tuo avversario e mettila nel mazzo degli scarti.", Resources.Load<Sprite>("wcplaceholder")));
        cardList.Add(new Carta(5, "Inquinamento", "Rendi una carta dell'avversario da 'Goccia d'Acqua' a 'Goccia d'Acqua Sporca'.", Resources.Load<Sprite>("inquinamentoplaceholder")));
        cardList.Add(new Carta(6, "Riciclo e Riutilizzo", "Prendi una carta a tua scelta dal mazzo degli scarti e posizionala nella tua mano.", Resources.Load<Sprite>("ricicloplaceholder")));
        cardList.Add(new Carta(7, "Depuratore", "Scarta due carte dalla tua mano e purifica le gocce d'acqua presenti sul tuo campo rendendole 'Gocce d'Acqua'.", Resources.Load<Sprite>("depuratoreplaceholder")));
        cardList.Add(new Carta(8, "Rilascio di Sostanze", "Posiziona una tua carta nella mano dell'avversario, obbligandolo ad usarla nel turno successivo.", Resources.Load<Sprite>("rilasciodisostanzeplaceholder")));
        cardList.Add(new Carta(9, "Materiali Pericolosi", "Posiziona due carte dalla tua mano al mazzo degli scarti.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(10, "Acque Reflue", "Cedi una carta a scelta dal tuo campo al campo avversario.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(11, "Carenza Idrica", "Scegli una carta goccia dal campo avversario e posizionala nel tuo, inoltre l'avversario non potrà posizionare carte goccia nel proprio campo per un turno.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(12, "Prelievo Sostenibile", "Prendi una carta posizionamento a scelta e inseriscila nella tua mano.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(13, "Gestione delle Risorse", "Nel turno successivo l'avversario giocherà a carte scoperte.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(14, "Cooperazione", "Pesca una carta casualmente dalla mano dell'avversario, l'avversario fa lo stesso dalla tua mano.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(15, "Proteggere gli ecosistemi", "Finché questa carta è posizionata sul tuo campo, il tuo avversario non potrà rubarti gocce d'acqua e tu non potrai rubarle al tuo avversario.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(16, "Sostegno allo sviluppo", "Finché questa carta è posizionata sul tuo campo potrai giocare sia una carta abilità sia posizionare una goccia d'acqua nel tuo campo nello stesso turno (l'abilità verrà applicata nel turno successivo al posizionamento).", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(17, "Sviluppo del WC", "Prendi una carta a tua scelta dal mazzo degli scarti e giocala subito", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(18, "Rinforzo delle comunità", "Posizionando questa carta nel tuo campo potrai giocare due turni di fila, l’abilità verrà applicata nel turno successivo al posizionamento, al termine dei due turni la carta verrà messa nel mazzo degli scarti.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(19, "Disastri naturali", "Costringi il tuo avversario a giocare una carta svantaggio, se il tuo avversario ne è privo o non può giocarne, non potrà giocare carte abilità nel prossimo turno.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(20, "Prevenzione dai disastri", "Finché questa carta è posizionata nel tuo campo ti sarà impossibile utilizzare carte svantaggio.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
        cardList.Add(new Carta(21, "Allagamento", "Tutte le carte posizionamento dal tuo campo vengono messe nel mazzo degli scarti.", Resources.Load<Sprite>("materialipericolosiplaceholder")));
    }
}
 
