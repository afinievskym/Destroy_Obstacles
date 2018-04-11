using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour {

    public GameObject explodeMarker;
    public float rayLenght = 50.0f;
    public GameObject bombPrefab;


    // Update is called once per frame
    void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLenght))
        {
            if (hit.collider)
            {
                if (!explodeMarker.activeSelf)
                {
                    explodeMarker.SetActive(true);
                }
                explodeMarker.transform.position = hit.point;
            }
            else
            {
                explodeMarker.SetActive(false);
            }
        }
        else
        {
            explodeMarker.SetActive(false);
        }
        InstallC4();
    }
    public void InstallC4()
    {
        
            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote))
            {
                if (explodeMarker.activeSelf)
                {
                    //Vector3 markerPosition = explodeMarker.transform.position;
                   //Vector3 installingPosition = new Vector3(markerPosition.x, positionOfC4.position.y, markerPosition.z);
                GameObject bomb = Instantiate(bombPrefab, explodeMarker.transform.position,bombPrefab.transform.rotation);
            }
            }
        }
    } 

