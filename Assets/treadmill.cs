using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treadmill : MonoBehaviour
{
    public float speed;
    Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += Vector3.left * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }
}
