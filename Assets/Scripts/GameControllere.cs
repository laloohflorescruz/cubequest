using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text winText;
    public int totalSpheres = 5;
    public int collectedSpheres = 0;
    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    public void SphereCollected()
    {

        collectedSpheres++;
        if (collectedSpheres == totalSpheres)
        {
            winText.gameObject.SetActive(true);

        }
    }

    public void UpdateWinMessage(string message)
    {
        winText.text = "You win";

    }
}
