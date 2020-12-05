using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniMagnet : MonoBehaviour
{
    [SerializeField]
    float magnetForce = .5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Cow"))
        {
            collision.attachedRigidbody.MovePosition(Vector2.MoveTowards(collision.attachedRigidbody.position, transform.parent.position, magnetForce * Time.deltaTime));
        }
    }
}
