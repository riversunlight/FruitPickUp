using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // 操作に対する動き
    void Move()
    {
        Vector3 pos = this.transform.position;
        if (Input.GetKey(KeyCode.A)) pos.x -= 0.1f;
        if (Input.GetKey(KeyCode.D)) pos.x += 0.1f;
        this.transform.position = pos;
    }
}
