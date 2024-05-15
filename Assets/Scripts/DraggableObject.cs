using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;

    [HideInInspector] public Transform parentAfterDrag;
    private Vector3 offset;
    private RectTransform rectTransform;

    public ChestManager chestManager;
    public BagManager bagManager;
    public Identifier identifier;

    public int bagid;
    public int chestid;

    void Start()
    {
        rectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        image = GetComponent<Image>();
        chestManager = FindObjectOfType<ChestManager>();
        bagManager = FindObjectOfType<BagManager>();
        identifier = FindObjectOfType<Identifier>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
       //parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
       // image.raycastTarget = false;
        
        bagid = identifier.Bagid;
        chestid = identifier.Chestid;

        bagManager.SetSlotOpen(bagid);
        chestManager.SetSlotOpen(chestid);
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePos = Input.mousePosition;
        //mousePos.z = -3;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos) + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
      
        if (transform.position.x > 8.93f)
        { 
            GameObject chestSlot = chestManager.WhichSlot();
            identifier.Chestid = chestManager.chestID;
            identifier.Bagid = 0;
            transform.SetParent(chestSlot.transform);
        }
        else
        {
            GameObject bagSlot = bagManager.WhichSlot();
            identifier.Bagid = bagManager.bagID;
            identifier.Chestid = 0;
            transform.SetParent(bagSlot.transform);
        }

        //image.raycastTarget = true;    
    }
}