using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeapon : MonoBehaviour {
    public GameObject teleporterWand;
    public GameObject hammer;
    //public GameObject c4;
    GameObject[] weapons = new GameObject[2];
    int index;

    void Start()
    {
        weapons[0] = teleporterWand;
        weapons[1] = hammer;
        //teleporterWand.SetActive(true);
    }
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.DpadRight, OVRInput.Controller.RTrackedRemote))
        {
            if (index != -1)
            {  
                weapons[index].SetActive(false);
                index++;
                weapons[index].SetActive(true);
                if (index == weapons.Length)
                {
                    index = -1;
                }
            }
            else
            {
                weapons[weapons.Length].SetActive(false);
                index++;
                weapons[index].SetActive(true);
            }
        }
    }
}
