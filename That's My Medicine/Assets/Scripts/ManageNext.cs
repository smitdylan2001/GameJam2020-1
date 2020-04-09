using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageNext : MonoBehaviour
{
    public GameManager gameManager;

    private void OnMouseDown()
    {
        gameManager.MakeMedicine(8);
    }
}
