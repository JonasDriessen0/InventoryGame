using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SlotHover : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private GameObject selectionOutline;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        selectionOutline.transform.DOMove(transform.position, 0.17f);
    }
}
