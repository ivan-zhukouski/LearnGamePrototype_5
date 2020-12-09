using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsForGood : MonoBehaviour
{
    private Rigidbody prefabRB;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        prefabRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Bad"))
        {
            prefabRB.AddForce(Vector3.up * speed, ForceMode.Impulse );
        }
    }
}
