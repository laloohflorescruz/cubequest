using UnityEngine;

public class CollectibleSphere : MonoBehaviour
{
    public GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameController.SphereCollected();
            Destroy(gameObject);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
