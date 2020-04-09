using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClick : MonoBehaviour
{
    public GameManager gameManager;

    private void OnMouseDown()
    {
        string name = gameObject.name;
        gameManager.CheckMedicine(name);
    }
}
