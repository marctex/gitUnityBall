using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;

    public GameObject particleItem;

    public Text txtScore;
    public Text txtWin;

    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        txtWin.text = "";

        txtScore.text = "Score: " + score.ToString(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        rb.AddForce(move * velocity);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(particleItem, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            AddScore();           
        }       
    }

    void AddScore()
    {
        score++;
        txtScore.text = "Score: " + score.ToString();
        if (score == 7)
        {
            txtWin.text = "YOU WIN!!";
        }
    }
}
