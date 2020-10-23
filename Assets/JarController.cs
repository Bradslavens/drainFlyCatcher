using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarController : MonoBehaviour
{
    public float jarSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate Jars randomly
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.position += Vector3.forward * jarSpeed;
        }
        
        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * jarSpeed;
        }
        
        if(Input.GetKey(KeyCode.S)){
            this.transform.position += Vector3.back * jarSpeed;
        }
        
        if(Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * jarSpeed;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Fly"){
            Destroy(other.gameObject);
        }
    }

}
