using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public Transform lightTransform;
    public Transform objectTransform;
	public int speed = 200;

    void Update()
    {
        lightTransform.RotateAround(objectTransform.position, Vector3.up, speed * Time.deltaTime);
    }

}
