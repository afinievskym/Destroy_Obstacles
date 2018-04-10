using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeapon : MonoBehaviour
{
    
    public GameObject hammer;
    public GameObject c4;
    GameObject[] weapons = new GameObject[2];
    int index = 0;

    void Start()
    {
        
        weapons[0] = hammer;
        weapons[1] = c4;
    }
    void Update()
    {
        if (index != weapons.Length)
        {
            if (OVRInput.GetUp(OVRInput.Button.DpadRight, OVRInput.Controller.RTrackedRemote))
            {
                    weapons[index].SetActive(false);
                    index++;
                    weapons[index].SetActive(true);
                    
                }
            if(OVRInput.GetUp(OVRInput.Button.DpadLeft, OVRInput.Controller.RTrackedRemote))
                {
                    weapons[index].SetActive(false);
                    index--;
                if(index != -1)
                {
                    weapons[index].SetActive(true);
                }
                else
                {
                    index = 0;
                    weapons[index].SetActive(true);
                }
                }
            }
        else
        {
            index = 0;
            weapons[index].SetActive(true);
        }
    }
}
