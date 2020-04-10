using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    public GameObject endPosition;
    public GameObject succesPosition;
    public GameObject deathPosition;
    float speed;
    bool willMove;
    public GameManager gameManager;
    public static bool succes;
    public static bool death;

    public GameObject nextButton;

    void Awake()
    {
        willMove = true;
        succes = false;
        death = false;
    }

    void Update()
    {
        if (willMove)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), endPosition.transform.position, 100 * Time.deltaTime);
        }
        if (transform.position.x >= 490 && transform.position.x <= 500)
        {
            Debug.Log("to");
            gameManager.isOnPosition = true;
            
        }
        if (succes)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), succesPosition.transform.position,200 * Time.deltaTime);
            
        }
        if (transform.position.x >= 1150)
        {
            
            this.gameObject.SetActive(false);
            nextButton.SetActive(true);

        }
        if (death)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), deathPosition.transform.position, 150 * Time.deltaTime);
        }
        if(transform.position.y < -200)
        {
            this.gameObject.SetActive(false);
            nextButton.SetActive(true);
        }
    }
}
