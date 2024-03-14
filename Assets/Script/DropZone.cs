using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool DropOnZone;

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        DropOnZone = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        DropOnZone = false;
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
