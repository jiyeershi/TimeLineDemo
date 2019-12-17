using UnityEngine;
using UnityEngine.EventSystems;


public class MouseClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click Mouse Down: " + eventData.button);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Click Mouse Up: " + eventData.button);
    }
}
