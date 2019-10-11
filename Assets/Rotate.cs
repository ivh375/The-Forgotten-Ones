using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
    	transform.rotation = Quaternion.AngleAxis(90f, Vector3.forward);
    }
}
