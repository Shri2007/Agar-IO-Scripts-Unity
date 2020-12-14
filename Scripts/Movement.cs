using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z  = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, moveSpeed * Time.deltaTime / transform.localScale.x);
    }
}
