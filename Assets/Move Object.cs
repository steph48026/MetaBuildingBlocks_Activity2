using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour 
{
    public float speed = 3;

    private void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.Self);
    }

}
