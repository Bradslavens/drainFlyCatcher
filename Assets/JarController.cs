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
        scoreText.text  = "Score: 0";
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

            // add fly to UI
            score++;
            scoreText.text = "Score: " + score;
        }
    }

}
