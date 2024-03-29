﻿using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    public GameObject endPosition;
    public GameObject succesPosition;
    public GameObject deathPosition;
	readonly float speed=300; 
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
    }

    private void Start()
    {
        //TODO improve
        bell = GameObject.Find("Bell").GetComponent<AudioSource>();
        bell.Play();
    }

    void Update()
    {
        if (willMove)
        {
            this.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), endPosition.transform.position, (speed -50) * Time.deltaTime);
            transform.rotation = Quaternion.Euler(20 * Mathf.Sin(Time.time * 5  ), 0f, Mathf.Sin(Time.time * 5) * 3);
        }
        if (transform.position.x >= 485 && transform.position.x <= 495)
        {
            gameManager.isOnPosition = true;
        }
        if (succes)
        {
            willMove = false;
            this.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), succesPosition.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(20 * Mathf.Sin(Time.time * 5), 0f, Mathf.Sin(Time.time * 5) * 3);
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
            transform.rotation = Quaternion.Euler(40 * Mathf.Sin(Time.time * 12), 0f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(Time.time * 7) *12);
        }
        if (transform.position.y < -100)
        {
            this.gameObject.SetActive(false);
            nextButton.SetActive(true);
        }
    }
}
