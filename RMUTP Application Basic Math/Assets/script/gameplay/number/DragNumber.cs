using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DragNumber : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public Camera mainCamera;
    Vector2 startPosition;
    Vector2 currentPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 touchPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        currentPosition = mainCamera.ScreenToWorldPoint(touchPosition);
        transform.position = currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent != startParent)
        {
            transform.position = startPosition;
        }
    }
}
