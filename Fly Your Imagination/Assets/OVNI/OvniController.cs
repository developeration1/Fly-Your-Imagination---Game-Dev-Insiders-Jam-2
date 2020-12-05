using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniController : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");

        _rb.MovePosition(_rb.position + Vector2.right * x * speed * Time.fixedDeltaTime);
    }
}
