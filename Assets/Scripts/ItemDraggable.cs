using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public void OnEndDrag(PointerEventData eventData)
	{
		//transform.position = Input.mousePosition;
	} 
	public void OnDrag(PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}
    public void OnBeginDrag(PointerEventData eventData)
    {
        //transform.SetParent(transform.root);
        //transform.
    }
}
