using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class RoleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private NavMeshAgent man;
    public bool followMouseRotate = false;

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
        //man.SetDestination(target.position);
        bool isClickLeft = Input.GetMouseButtonDown(ClickBtnFlag);
        //左键点击移动
        if (isClickLeft)
        {
            Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool ishit=Physics.Raycast(ray,out hit);
            if (ishit)
            {
                Vector3 hitPlaneVec3;
                
                //if (hit.collider.gameObject.name == "Plane")
                {
                    hitPlaneVec3 = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                    Debug.Log(string.Format("Mouse hit plane: x= {0}, y = {1}, z = {2}", hitPlaneVec3.x, hitPlaneVec3.y, hitPlaneVec3.z));
                    man.SetDestination(hitPlaneVec3);
                }
            }
        }
        
        //鼠标旋转视角
        if (followMouseRotate)
        {
            Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            if (!Mathf.Approximately(x, 0f) || !Mathf.Approximately(y, 0f))
            {
                Debug.Log(string.Format("Mouse Rotate: x = {0}, y = {1}", x, y));
            }

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
