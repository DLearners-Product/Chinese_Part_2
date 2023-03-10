using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapObjectController : MonoBehaviour
{
    // Three panels containing texts
    public GameObject overviewPane_1;
    public GameObject overviewPane_2;
    public GameObject overviewPane_3;
    public Button closeButton;

    // Lists to store all the images in the map
    public List<GameObject> imageSet1;
    public List<GameObject> imageSet2;
    public List<GameObject> imageSet3;

    // Clicking the objects with this function can activate 1st pane.
    public void FirstPaneActive()
    {
        overviewPane_1.gameObject.SetActive(true);
        overviewPane_2.gameObject.SetActive(false);
        overviewPane_3.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(true);
        // loop to make the images non selectable
        foreach(GameObject image in imageSet1)
        {
            image.GetComponent<Image>().color = new Color32(225, 225, 225, 100);
            Destroy(image.GetComponent<Button>());
            //break;
        }
        
    } 
    // Clicking the objects with this function can activate 2nd pane.
    public void SecondPaneActive()
    {
        overviewPane_1.gameObject.SetActive(false);
        overviewPane_2.gameObject.SetActive(true);
        overviewPane_3.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(true);
        // loop to make the images non selectable
        foreach (GameObject image in imageSet2)
        {
            Destroy(image.GetComponent<Button>());
            image.GetComponent<Image>().color = new Color32(225,225,225, 100);
            //break;
        }
    } 
    // Clicking the objects with this function can activate 3rd pane.
    public void ThirdPaneActive()
    {
        overviewPane_1.gameObject.SetActive(false);
        overviewPane_2.gameObject.SetActive(false);
        overviewPane_3.gameObject.SetActive(true);
        closeButton.gameObject.SetActive(true);
        // loop to make the images non selectable
        foreach (GameObject image in imageSet3)
        {
            Destroy(image.GetComponent<Button>());
            image.GetComponent<Image>().color = new Color32(225, 225, 225, 100);
            //break;
        }
    }
}
