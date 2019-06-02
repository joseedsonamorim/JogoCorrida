using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStab : MonoBehaviour {


    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;
	

	void Update ()
    {
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX, carY, carZ - carZ);
	}
}
