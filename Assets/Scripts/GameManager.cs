﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject scoreCounter;
    List<string> medicine = new List<string>();

   

    string currentMedicine;

    public GameObject itemList;
    Transform itemListPosition;

    bool moveBool;
    int moveDirection;
    public float slideSpeed;

    public GameObject letter;
    public GameObject book;
    public GameObject UIelements;
    public GameObject Next;
    public GameObject Letters;

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

    int randomValue;

    public GameObject menu;

    public GameObject PerfectEnding;
    public GameObject DecentEnding;
    public GameObject BadEnding;
    public GameObject DevilEnding;
    bool nextWasLast;

    void Start()
    {
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
            if (Next.gameObject.activeInHierarchy == true)
            {
                Next.SetActive(false);
                nextWasLast = true;
            }
            else
            {
                itemList.SetActive(false);
                Letters.SetActive(false);
                book.SetActive(false);
                UIelements.SetActive(false);
                nextWasLast = false;
            }
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
            switch (currentMedicine)
            {
                case "Amputate":
                    LetterAmputate.SetActive(true);
                    CheckClick.letter = LetterAmputate;
                    break;

                case "Pray":
                        LetterPray.SetActive(true);
                        CheckClick.letter = LetterPray;
                        break;
                case "Soap":
                        LetterSoap.SetActive(true);
                        CheckClick.letter = LetterSoap;
                    break;
                case "Distance":
                        LetterDistance.SetActive(true);
                        CheckClick.letter = LetterDistance;
                        break;
                case "Inhalator":
                        LetterInhalator.SetActive(true);
                        CheckClick.letter = LetterInhalator;
                    break;
                case "Needle":
                        LetterNeedle.SetActive(true);
                        CheckClick.letter = LetterNeedle;
                        break;
                case "Strip":
                        LetterStrip.SetActive(true);
                        CheckClick.letter = LetterStrip;
                        break;
                case "Bottle":
                        LetterBottle.SetActive(true);
                        CheckClick.letter = LetterBottle;
                    break;
                case "Glitter":
                        LetterGlitter.SetActive(true);
                        CheckClick.letter = LetterGlitter;
                        break;
                case "Fresh":
                        LetterFresh.SetActive(true);
                        CheckClick.letter = LetterFresh;
                        break;
                case "Cirkel":
                        LetterCirkel.SetActive(true);
                        CheckClick.letter = LetterCirkel;
                        break;
                case "Chocola":
                        LetterChocola.SetActive(true);
                        CheckClick.letter = LetterChocola;
                        break;
                case "Bloedzuiger":
                        LetterBloedzuiger.SetActive(true);
                        CheckClick.letter = LetterBloedzuiger;
                        break;
                case "Spray":
                        LetterSpray.SetActive(true);
                        CheckClick.letter = LetterSpray;
                        break;
                case "Viagra":
                        LetterViagra.SetActive(true);
                        CheckClick.letter = LetterViagra;
                        break;
                case "Water":
                        LetterWater.SetActive(true);
                        CheckClick.letter = LetterWater;
                        break;
            }
            isOnPosition = false;
        }
    }
    public void MakeMedicine()
    {
        randomValue = Random.Range(0, medicine.Count);
        if (medicine.Count == 0)
        {
            if (score == 0)
            {
                PerfectEnding.SetActive(true);
            }
            else if (score > 0 && score < 8)
            {
                DecentEnding.SetActive(true);
            }
            else if (score == 16)
            {
                DevilEnding.SetActive(true);
            }
            else
            {
                BadEnding.SetActive(true);
            }
        }
        else
        {
            currentMedicine = medicine[randomValue];
        }
    }

    public void CheckMedicine(string selectedMedicine)
    {
        if (selectedMedicine == currentMedicine)
        {
            MoveObject.succes = true;
            succesAudio = GameObject.Find("Succes").GetComponent<AudioSource>();
            succesAudio.Play();
            medicine.RemoveAt(randomValue);
        }
        else
        {
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
        switch (currentMedicine)
        {
            case "Amputate":
                PeopleAmputate.SetActive(true);
                break;
            case "Pray":
                PeoplePray.SetActive(true);
                break;
            case "Soap":
                PeopleSoap.SetActive(true);
                break;
            case "Distance":
                PeopleDistance.SetActive(true);
                break;
            case "Inhalator":
                PeopleInhalator.SetActive(true);
                break;
            case "Needle":
                PeopleNeedle.SetActive(true);
                break;
            case "Strip":
                PeopleStrip.SetActive(true);
                break;
            case "Bottle":
                PeopleBottle.SetActive(true);
                break;
            case "Glitter":
                PeopleGlitter.SetActive(true);
                break;
            case "Fresh":
                PeopleFresh.SetActive(true);
                break;
            case "Cirkel":
                PeopleCirkel.SetActive(true);
                break;
            case "Chocola":
                PeopleChocola.SetActive(true);
                break;
            case "Bloedzuiger":
                PeopleBloedzuiger.SetActive(true);
                break;
            case "Spray":
                PeopleSpray.SetActive(true);
                break;
            case "Viagra":
                PeopleViagra.SetActive(true);
                break;
            case "Water":
                PeopleWater.SetActive(true);
                break;
        }
    }

    public void MakeActiveAgain()
    {
        menu.SetActive(false);
        if (nextWasLast)
        {
            Next.SetActive(true);
        }
        if (!nextWasLast)
        {
            itemList.SetActive(true);
            Letters.SetActive(true);
            book.SetActive(true);
            UIelements.SetActive(true);
        }
    }
}
