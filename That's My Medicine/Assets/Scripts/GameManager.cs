using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    List<string> medicine = new List<string>();

    float width;
    float height;
    float widthDistance;
    float heightDistance;

    string currentMedicine;

    Transform itemListPosition;

    bool moveBool;
    float tempPosition;
    int moveDirection;
    public float slideSpeed;

    public GameObject letter;
    SpriteRenderer letterSprite;

    public GameObject LetterAmputate;
    public GameObject LetterPray;
    public GameObject LetterSoap;
    public GameObject LetterDistance;
    public GameObject LetterInhalator;
    public GameObject LetterNeedle;
    public GameObject LetterStrip;
    public GameObject LetterBottle;

    void Start()
    {
        widthDistance = Screen.width/8;
        heightDistance = Screen.height/3;

        medicine.Add("Amputate");
        medicine.Add("Pray");
        medicine.Add("Soap");
        medicine.Add("Distance");
        medicine.Add("Inhalator");
        medicine.Add("Needle");
        medicine.Add("Strip");
        medicine.Add("Bottle");

        itemListPosition = GameObject.Find("ItemList").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        if (moveBool)
        {
            itemListPosition.position = new Vector3(itemListPosition.position.x + (moveDirection * slideSpeed), itemListPosition.position.y, itemListPosition.position.z);
        }
        if (itemListPosition.position.x == -1000 || itemListPosition.position.x == -2000 || itemListPosition.position.x == -3000 || itemListPosition.position.x == 0)
        {
            moveBool = false;
        }
    }

    public void MakeMedicine(int amount)
    {
        int randomValue = Random.Range(0, amount);
        currentMedicine = medicine[randomValue];
        Debug.Log(currentMedicine);

        if (currentMedicine == "Amputate")
        {
            LetterAmputate.SetActive(true);
        }
        if (currentMedicine == "Pray")
        {
            LetterPray.SetActive(true);
        }
        if (currentMedicine == "Soap")
        {
            LetterSoap.SetActive(true);
        }
        if (currentMedicine == "Distance")
        {
            LetterDistance.SetActive(true);
        }
        if (currentMedicine == "Inhalator")
        {
            LetterInhalator.SetActive(true);
        }
        if (currentMedicine == "Needle")
        {
            LetterNeedle.SetActive(true);
        }
        if (currentMedicine == "Strip")
        {
            LetterStrip.SetActive(true);
        }
        if (currentMedicine == "Bottle")
        {
            LetterBottle.SetActive(true);
        }
    }

    public void CheckMedicine(string selectedMedicine)
    {
        Debug.Log(selectedMedicine);
        if (selectedMedicine == currentMedicine)
        {
            Debug.Log("SUCCES");
        }
        else
        {
            Debug.Log("FUCK");
        }
    }

    public void MoveList(int movement)
    {
        moveBool = true;
        moveDirection = movement;
    }
}
