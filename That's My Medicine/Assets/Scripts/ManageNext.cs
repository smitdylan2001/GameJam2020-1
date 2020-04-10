using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageNext : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject letter;

    private void OnMouseDown()
    {
        gameManager.MakeMedicine();
        gameManager.NewCharacter();
        
        this.gameObject.SetActive(false);
    }
}
