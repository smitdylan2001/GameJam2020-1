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
    public GameObject Next;

    public GameObject LetterAmputate;
    public GameObject LetterPray;
    public GameObject LetterSoap;
    public GameObject LetterDistance;
    public GameObject LetterInhalator;
    public GameObject LetterNeedle;
    public GameObject LetterStrip;
    public GameObject LetterBottle;
    public GameObject LetterGlitter;
    public GameObject LetterFresh;
    public GameObject LetterCirkel;
    public GameObject LetterChocola;
    public GameObject LetterBloedzuiger;
    public GameObject LetterSpray;
    public GameObject LetterViagra;
    public GameObject LetterWater;

    public GameObject PeopleAmputate;
    public GameObject PeoplePray;
    public GameObject PeopleSoap;
    public GameObject PeopleDistance;
    public GameObject PeopleInhalator;
    public GameObject PeopleNeedle;
    public GameObject PeopleStrip;
    public GameObject PeopleBottle;
    public GameObject PeopleGlitter;
    public GameObject PeopleFresh;
    public GameObject PeopleCirkel;
    public GameObject PeopleChocola;
    public GameObject PeopleBloedzuiger;
    public GameObject PeopleSpray;
    public GameObject PeopleViagra;
    public GameObject PeopleWater;

    public bool isOnPosition;

    AudioSource succesAudio;
    AudioSource deathAudio;

    int randomValue;

    public GameObject menu;

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
        medicine.Add("Glitter");
        medicine.Add("Fresh");
        medicine.Add("Cirkel");
        medicine.Add("Chocola");
        medicine.Add("Bloedzuiger");
        medicine.Add("Spray");
        medicine.Add("Viagra");
        medicine.Add("Water");

        itemListPosition = itemList.GetComponent<Transform>();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
            Next.SetActive(false);
        }
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
            else if (currentMedicine == "Pray")
            {
                LetterPray.SetActive(true);
                CheckClick.letter = LetterPray;
            }
            else if (currentMedicine == "Soap")
            {
                LetterSoap.SetActive(true);
                CheckClick.letter = LetterSoap;
            }
            else if (currentMedicine == "Distance")
            {
                LetterDistance.SetActive(true);
                CheckClick.letter = LetterDistance;
            }
            else if (currentMedicine == "Inhalator")
            {
                LetterInhalator.SetActive(true);
                CheckClick.letter = LetterInhalator;
            }
            else if (currentMedicine == "Needle")
            {
                LetterNeedle.SetActive(true);
                CheckClick.letter = LetterNeedle;
            }
            else if (currentMedicine == "Strip")
            {
                LetterStrip.SetActive(true);
                CheckClick.letter = LetterStrip;
            }
            else if (currentMedicine == "Bottle")
            {
                LetterBottle.SetActive(true);
                CheckClick.letter = LetterBottle;
            }
            else if (currentMedicine == "Glitter")
            {
                LetterGlitter.SetActive(true);
                CheckClick.letter = LetterGlitter;
            }
            else if (currentMedicine == "Fresh")
            {
                LetterFresh.SetActive(true);
                CheckClick.letter = LetterFresh;
            }
            else if (currentMedicine == "Cirkel")
            {
                LetterCirkel.SetActive(true);
                CheckClick.letter = LetterCirkel;
            }
            else if (currentMedicine == "Chocola")
            {
                LetterChocola.SetActive(true);
                CheckClick.letter = LetterChocola;
            }
            else if (currentMedicine == "Bloedzuiger")
            {
                LetterBloedzuiger.SetActive(true);
                CheckClick.letter = LetterBloedzuiger;
            }
            else if (currentMedicine == "Spray")
            {
                LetterSpray.SetActive(true);
                CheckClick.letter = LetterSpray;
            }
            else if (currentMedicine == "Viagra")
            {
                LetterViagra.SetActive(true);
                CheckClick.letter = LetterViagra;
            }
            else if (currentMedicine == "Water")
            {
                LetterWater.SetActive(true);
                CheckClick.letter = LetterWater;
            }
            isOnPosition = false;
        }
    }
    public void MakeMedicine()
    {
        randomValue = Random.Range(0, medicine.Count);
        if (medicine.Count == 0)
        {
            Debug.LogError("You finished! You killed " + score + " people!");
            scoreCounter.GetComponent<Text>().text = score.ToString() + "Done!";
        }
        else
        {
            currentMedicine = medicine[randomValue];
            Debug.Log(currentMedicine);
        }
    }

    public void CheckMedicine(string selectedMedicine)
    {
        Debug.Log(selectedMedicine);
        if (selectedMedicine == currentMedicine)
        {
            MoveObject.succes = true;
            succesAudio = GameObject.Find("Succes").GetComponent<AudioSource>();
            succesAudio.Play();
            medicine.RemoveAt(randomValue);
            Debug.Log("SUCCES");
        }
        else
        {
            Debug.Log("FUCK"); 
            MoveObject.death = true;
            succesAudio = GameObject.Find("Death").GetComponent<AudioSource>();
            succesAudio.Play();
            medicine.RemoveAt(randomValue);
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
        else if (currentMedicine == "Pray")
        {
            PeoplePray.SetActive(true);
        }
        else if (currentMedicine == "Soap")
        {
            PeopleSoap.SetActive(true);
        }
        else if (currentMedicine == "Distance")
        {
            PeopleDistance.SetActive(true);
        }
        else if (currentMedicine == "Inhalator")
        {
            PeopleInhalator.SetActive(true);
        }
        else if (currentMedicine == "Needle")
        {
            PeopleNeedle.SetActive(true);
        }
        else if (currentMedicine == "Strip")
        {
            PeopleStrip.SetActive(true);
        }
        else if (currentMedicine == "Bottle")
        {
            PeopleBottle.SetActive(true);
        }
        else if (currentMedicine == "Glitter")
        {
            PeopleGlitter.SetActive(true);
        }
        else if (currentMedicine == "Fresh")
        {
            PeopleFresh.SetActive(true);
        }
        else if (currentMedicine == "Cirkel")
        {
            PeopleCirkel.SetActive(true);
        }
        else if (currentMedicine == "Chocola")
        {
            PeopleChocola.SetActive(true);
        }
        else if (currentMedicine == "Bloedzuiger")
        {
            PeopleBloedzuiger.SetActive(true);
        }
        else if (currentMedicine == "Spray")
        {
            PeopleSpray.SetActive(true);
        }
        else if (currentMedicine == "Viagra")
        {
            PeopleViagra.SetActive(true);
        }
        else if (currentMedicine == "Water")
        {
            PeopleWater.SetActive(true);
        }
    }
}
