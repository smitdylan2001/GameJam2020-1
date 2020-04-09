using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    public List<string> medicine = new List<string>();

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

    public LetterControll showLetter;

    public GameObject LetterPara;
    public GameObject LetterIbu;
    public GameObject LetterM3;
    public GameObject LetterM4;
    public GameObject LetterM5;

    void Start()
    {
        widthDistance = Screen.width/8;
        heightDistance = Screen.height/3;

        medicine.Add("Ibu");
        medicine.Add("Para");
        medicine.Add("M3");
        medicine.Add("M4");
        medicine.Add("M5");

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
        GameObject letter = GameObject.Find("Letter1");
        Debug.Log(letter);
        letter.SetActive(false);


        Debug.Log (GameObject.Find(medicine[randomValue]));
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
