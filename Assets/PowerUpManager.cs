using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int powerUpCounter;
    public GameObject player;

    private void Start()
    {
        powerUpCounter = 0;
    }

    private void Update()
    {
        if (powerUpCounter == 1)
        {
            player.GetComponent<Movement>().enabled = true;
        }
        if (powerUpCounter == 2)
        {
            player.GetComponent<Turn>().enabled = true;
        }
        if (powerUpCounter == 3)
        {
            player.GetComponent<Radar>().enabled = true;
        }
        if (powerUpCounter == 3)
        {
            player.GetComponent<Eat>().enabled = true;
        }

        if (powerUpCounter == 4)
        {
            player.GetComponent<Attack>().enabled = true;
        }
    }
}
