using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public float explosionRadius;// радиус поражения
	public float power;// сила взрыва	
	
	private Rigidbody[] physicObject;// тут будут все физ. объекты которые есть на сцене
	
	void Start(){
		physicObject = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];// Записываем все физ. объекты
	}
    //For test
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.DpadDown, OVRInput.Controller.RTrackedRemote))
        {
            for(int i = 0; i < physicObject.Length; i++){
			if(Vector3.Distance(transform.position,physicObject[i].transform.position) <= explosionRadius){// Исключаем от обработки объекты которые достаточно далеко от взвыва
				physicObject[i].AddExplosionForce(power,transform.position,explosionRadius);// Создание взрыва, с силой power, в позиции transform.position, c радиусом explosionRadius
			}
		}
        }
    }

}
