using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
   private Camera _maincamera;


    private void Awake()
    {
        _maincamera = Camera.main;

        if ( _maincamera != null )
        {
            Debug.LogError("Main camera is null");
        }    

    }

    private void Update()
    {
        //玩家位置到鼠标位置的向量
        Vector3 position = _maincamera.WorldToScreenPoint(transform.position);
        Vector3 direction = Input.mousePosition- position;
        //向量到鼠标位置的夹角
        float angle = Mathf.Atan2(direction.x,direction.y)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-angle,Vector3.forward);
    }

}
