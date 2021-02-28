using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int powerUpCounter;
    public GameObject player;
    public GameObject blob;
    public GameObject body;
    public GameObject tail;
    public GameObject becco;
    public GameObject claw1;
    public GameObject claw2;
    public static PowerUpManager instance;

    public void PowerUp()
    {
        if (powerUpCounter == 1)
        {
            blob.SetActive(false);
            body.SetActive(true);
            becco.SetActive(false);
            tail.SetActive(false);
            claw1.SetActive(false);
            claw2.SetActive(false);
            player.GetComponent<Movement>().enabled = true;
        }

        if (powerUpCounter == 2)
        {
            tail.SetActive(true);
            player.GetComponent<Turn>().enabled = true;
        }

        if (powerUpCounter == 3)
        {
            becco.SetActive(true);
            player.GetComponent<Radar>().enabled = true;
            player.GetComponent<Eat>().enabled = true;
        }

        if (powerUpCounter == 4)
        {
            claw1.SetActive(true);
            claw2.SetActive(true);
            player.GetComponent<Attack>().enabled = true;
        }
    }


    private void Start()
    {
        powerUpCounter = 0;

        if (powerUpCounter == 0)
        {
            blob.SetActive(true);
            body.SetActive(false);
        }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
