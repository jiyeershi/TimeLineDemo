using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class RoleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private NavMeshAgent man;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        man = GetComponent<NavMeshAgent>();
    }

    public int ClickBtnFlag = 0;

    // Update is called once per frame
    void Update()
    {
        man.SetDestination(target.position);
        bool isClickLeft = Input.GetMouseButtonDown(ClickBtnFlag);
        if (isClickLeft)
        {
            //Debug.Log("Click mouse on : " + ClickBtnFlag);
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        if (eventData.button == PointerEventData.InputButton.Left)
        {
            
        }else if (eventData.button == PointerEventData.InputButton.Right)
        {
            
        }
        
        Debug.Log("Click Mouse Down: " + eventData.button);
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Click Mouse Up: " + eventData.button);
    }
}
