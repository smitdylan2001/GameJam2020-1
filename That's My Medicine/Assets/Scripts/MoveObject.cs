using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    public GameObject endPosition;
    public GameObject succesPosition;
    public GameObject deathPosition;
    float speed=300; 
    bool willMove;
    public GameManager gameManager;
    public static bool succes;
    public static bool death;

    public GameObject nextButton;
    AudioSource bell;


    void Awake()
    {
        willMove = true;
        succes = false;
        death = false;
        Debug.Log("running");
    }
    private void Start()
    {
        bell = GameObject.Find("Bell").GetComponent<AudioSource>();
        bell.Play();
    }

    void Update()
    {
        if (willMove)
        {
            this.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), endPosition.transform.position, speed * Time.deltaTime);
        }
        if (transform.position.x >= 485 && transform.position.x <= 495)
        {
            gameManager.isOnPosition = true;
            Debug.Log("runnin");
        }
        if (succes)
        {
            willMove = false;
            this.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), succesPosition.transform.position, speed * Time.deltaTime);
        }
        if (transform.position.x >= 1080)
        {
            this.gameObject.SetActive(false);
            nextButton.SetActive(true);
        }
        if (death)
        {
            willMove = false;
            this.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), deathPosition.transform.position, speed * Time.deltaTime);
        }
        if(transform.position.y < -100)
        {
            this.gameObject.SetActive(false);
            nextButton.SetActive(true);
        }
    }
}
