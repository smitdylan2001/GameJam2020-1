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

    public GameObject itemList;
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

    public GameObject PeopleAmputate;
    public GameObject PeoplePray;
    public GameObject PeopleSoap;
    public GameObject PeopleDistance;
    public GameObject PeopleInhalator;
    public GameObject PeopleNeedle;
    public GameObject PeopleStrip;
    public GameObject PeopleBottle;

    public bool isOnPosition;

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

        itemListPosition = itemList.GetComponent<Transform>();
        
    }

    void FixedUpdate()
    {
        if (moveBool)
        {
            itemListPosition.position = new Vector3(itemListPosition.position.x + (moveDirection * slideSpeed), itemListPosition.position.y, itemListPosition.position.z);
        }
        if (moveBool && (itemListPosition.position.x == -1000 || itemListPosition.position.x == -2000 || itemListPosition.position.x == -3000 || itemListPosition.position.x == 0))
        {
            moveBool = false;
        }
        ShowLetter();
    }

    void ShowLetter()
    {
        if (isOnPosition)
        {
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
            isOnPosition = false;
        }
    }
    public void MakeMedicine(int amount)
    {
        int randomValue = Random.Range(0, amount);
        currentMedicine = medicine[randomValue];
        Debug.Log(currentMedicine);

        
    }

    public void CheckMedicine(string selectedMedicine)
    {
        Debug.Log(selectedMedicine);
        if (selectedMedicine == currentMedicine)
        {
            Debug.Log("SUCCES");
            MoveObject.succes = true;
        }
        else
        {
            Debug.Log("FUCK"); 
            MoveObject.death = true;
        }
    }

    public void MoveList(int movement)
    {
        moveBool = true;
        moveDirection = movement;
    }

    public void NewCharacter()
    {
        if (currentMedicine == "Amputate")
        {
            PeopleAmputate.SetActive(true);
        }
        if (currentMedicine == "Pray")
        {
            PeoplePray.SetActive(true);
        }
        if (currentMedicine == "Soap")
        {
            PeopleSoap.SetActive(true);
        }
        if (currentMedicine == "Distance")
        {
            PeopleDistance.SetActive(true);
        }
        if (currentMedicine == "Inhalator")
        {
            PeopleInhalator.SetActive(true);
        }
        if (currentMedicine == "Needle")
        {
            PeopleNeedle.SetActive(true);
        }
        if (currentMedicine == "Strip")
        {
            PeopleStrip.SetActive(true);
        }
        if (currentMedicine == "Bottle")
        {
            PeopleBottle.SetActive(true);
        }
    }
}
