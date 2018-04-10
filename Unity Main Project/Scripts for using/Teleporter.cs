using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public GameObject teleportMarker;
    public Transform positionOfPlayer;
    public float rayLenght = 50.0f;

	void Start () {
        OVRTouchpad.Create();
        OVRTouchpad.TouchHandler += TouchpadHandler;
	}
	
	void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, rayLenght))
        {
            if(hit.collider.tag == "Floor")
            {
                if (!teleportMarker.activeSelf)
                {
                    teleportMarker.SetActive(true);
                }
                teleportMarker.transform.position = hit.point;
            }
            else
            {
                teleportMarker.SetActive(false);
            }
        }
        else
        {
            teleportMarker.SetActive(false);
        }
	}
    public void TouchpadHandler(object sender, System.EventArgs e)
    {
        OVRTouchpad.TouchArgs args = (OVRTouchpad.TouchArgs)e;
        if(args.TouchType == OVRTouchpad.TouchEvent.SingleTap)
        {
            // Нужно проверить куда пользователь смотрит, прежде чем его телепортировать
            if (teleportMarker.activeSelf)
            {
                Vector3 markerPosition = teleportMarker.transform.position;
                    positionOfPlayer.position = new Vector3(markerPosition.x, positionOfPlayer.position.y , markerPosition.z);
             
                    
            }

        }
    }
}
