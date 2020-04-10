using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClick : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject itemList;
    public GameObject uiItems;

    private void OnMouseDown()
    {
        string name = gameObject.name;
        gameManager.CheckMedicine(name);
        itemList.SetActive(false);
        uiItems.SetActive(false);
    }
}
