using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    GameObject playArea;
    Transform Area;
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
        if (this.tag != "Placed")
        {
            this.transform.position = eventData.position;
        }
       //Debug.Log("Drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        playArea = GameObject.Find("PlayArea");
        Area = playArea.transform;
        this.tag = "Untagged";

        if (this.tag != "HandCard")
        {
            this.transform.SetParent(Area);
            this.tag = "Placed";
        }
        if (this.tag != "Placed")
        {
            this.transform.SetParent(parentToReturnTo);
            this.tag = "HandCard";
        }
        //Debug.Log("EndDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        GetComponent<LayoutElement>().ignoreLayout = false;
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
