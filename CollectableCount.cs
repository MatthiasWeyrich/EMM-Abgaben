using UnityEngine;
using UnityEngine.UI;

public class CollectableCount : MonoBehaviour
{
    public Text count;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player.get_collected() == 30)
        {
            count.text = "VICTORY!!!";
        }
        else
        {
            count.text = "SCORE: " + player.get_collected();
        }
    }
}
