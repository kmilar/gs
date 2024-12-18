using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItenSlot : MonoBehaviour, IDropHandler 
{
    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
