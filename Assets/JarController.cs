using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JarController : MonoBehaviour
{
    public float jarSpeed = 1f;

    public Text scoreText;

    private int score = 0;

    private void Start() {
        scoreText.text  = "Score: 0/10";
    }

    // Update is called once per frame
    void Update()
    {
            
        if(Input.GetKey(KeyCode.W)){
            this.transform.position += Vector3.forward * jarSpeed;

            if(transform.position.z > 14){
                transform.position = new Vector3(transform.position.x, transform.position.y, 14);

                Debug.Log("transform z " + transform.position.z.ToString());
            }
        }
        
        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * jarSpeed;

            if(transform.position.x < -14){
                transform.position = new Vector3(-14, transform.position.y, transform.position.z);
            }
        }
        
        if(Input.GetKey(KeyCode.S)){
            this.transform.position += Vector3.back * jarSpeed;

            if(transform.position.z < -14){
                transform.position = new Vector3(transform.position.x, transform.position.y, -14);
            }
        }
        
        if(Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * jarSpeed;

            if(transform.position.x > 14){
                transform.position = new Vector3(14, transform.position.y, transform.position.z);
            }
        }

    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Fly"){
            Destroy(other.gameObject);

            // add fly to UI
            score++;

            scoreText.text = "Score: " + score + "/10";
        }
    }

}
