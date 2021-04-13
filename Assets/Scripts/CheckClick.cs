using UnityEngine;

public class CheckClick : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject itemList;
    public GameObject uiItems;
    public static GameObject letter;
    public GameObject book;

    private void OnMouseDown()
    {
        string name = gameObject.name;
        gameManager.CheckMedicine(name);
        itemList.SetActive(false);
        uiItems.SetActive(false);
        letter.SetActive(false);
        book.SetActive(false);
    }
}
