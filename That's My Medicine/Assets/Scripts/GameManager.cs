using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    List<string> medicine;

    float width;
    float height;
    float widthDistance;
    float heightDistance;

    string currentMedicine;

    // Start is called before the first frame update
    void Start()
    {
        widthDistance = Screen.width/8;
        heightDistance = Screen.height/3;

        medicine.Add("ibu");
        medicine.Add("para");
        medicine.Add("M3");
        medicine.Add("M4");
        medicine.Add("M5");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeMedicine(int amount)
    {
        //int whichMedicine =
        currentMedicine = medicine[2];
        Debug.Log(currentMedicine);


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
}
