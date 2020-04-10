using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject scoreCounter;
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
    public GameObject book;
    public GameObject UIelements;

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

    AudioSource succesAudio;
    AudioSource deathAudio;

    int randomValue;

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
            itemList.SetActive(true);
            book.SetActive(true);
            UIelements.SetActive(true);

            if (currentMedicine == "Amputate")
            {
                LetterAmputate.SetActive(true);
                CheckClick.letter = LetterAmputate;
            }
            if (currentMedicine == "Pray")
            {
                LetterPray.SetActive(true);
                CheckClick.letter = LetterPray;
            }
            if (currentMedicine == "Soap")
            {
                LetterSoap.SetActive(true);
                CheckClick.letter = LetterSoap;
            }
            if (currentMedicine == "Distance")
            {
                LetterDistance.SetActive(true);
                CheckClick.letter = LetterDistance;
            }
            if (currentMedicine == "Inhalator")
            {
                LetterInhalator.SetActive(true);
                CheckClick.letter = LetterInhalator;
            }
            if (currentMedicine == "Needle")
            {
                LetterNeedle.SetActive(true);
                CheckClick.letter = LetterNeedle;
            }
            if (currentMedicine == "Strip")
            {
                LetterStrip.SetActive(true);
                CheckClick.letter = LetterStrip;
            }
            if (currentMedicine == "Bottle")
            {
                LetterBottle.SetActive(true);
                CheckClick.letter = LetterBottle;
            }

            isOnPosition = false;
        }
    }
    public void MakeMedicine()
    {
        randomValue = Random.Range(0, medicine.Count);
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
            succesAudio = GameObject.Find("Succes").GetComponent<AudioSource>();
            succesAudio.Play();
            medicine.RemoveAt(randomValue);
        }
        else
        {
            Debug.Log("FUCK"); 
            MoveObject.death = true;
            succesAudio = GameObject.Find("Death").GetComponent<AudioSource>();
            succesAudio.Play();
            score++;
            scoreCounter.GetComponent<Text>().text = score.ToString();
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
