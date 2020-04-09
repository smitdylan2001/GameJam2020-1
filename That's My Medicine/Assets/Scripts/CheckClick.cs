using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClick : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnMouseDown()
    {
        Debug.Log("WORKS");
        string name = gameObject.name;
        gameManager.CheckMedicine(name);
    }
}
