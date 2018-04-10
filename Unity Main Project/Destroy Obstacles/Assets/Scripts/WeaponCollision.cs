using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollision : MonoBehaviour {
 
    public GameObject destroyedBoxPrefab;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Box" )
        {
            Transform currentTransform = collision.gameObject.transform;
            GameObject go = Instantiate(destroyedBoxPrefab, currentTransform.transform.position, currentTransform.rotation);

            Destroy(collision.gameObject);
            Destroy(go, 50.0f);
        }
    }
}
