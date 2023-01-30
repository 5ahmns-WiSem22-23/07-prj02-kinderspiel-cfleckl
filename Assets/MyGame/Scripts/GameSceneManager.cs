using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static string winner;

    public GameObject redFish;
    public GameObject blueFish;
    public GameObject greenFish;
    public GameObject yellowFish;
    public GameObject boat;

    public float maxXDistance;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
            Debug.Log("asdfghjkl");
        }
    }

    void MoveItem(GameObject item)
    {
        item.transform.position = new Vector3(item.transform.position.x + 2, item.transform.position.y, item.transform.position.z);
    }

    void CheckFishProgress(GameObject fish)
    {
        if(fish.transform.position.x >= maxXDistance)
        {
            winner = "fish";
            SceneManager.LoadScene("StartScene");
        }
    }

    void RollDice ()
    {
        int random = Random.Range(1, 7);

        switch (random)
        {
            case 1:
                //red
                MoveItem(redFish);
                CheckFishProgress(redFish);
                break;

            case 2:
                //blue
                MoveItem(blueFish);
                CheckFishProgress(blueFish);
                break;

            case 3:
                //green
                MoveItem(greenFish);
                CheckFishProgress(greenFish);
                break;

            case 4:
                //yellow
                MoveItem(yellowFish);
                CheckFishProgress(yellowFish);
                break;

            case 5:
                //boat
                MoveItem(boat);
                CheckFishProgress(boat);
                break;

            case 6:
                //boat
                MoveItem(boat);
                CheckFishProgress(boat);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            winner = "boat";
            SceneManager.LoadScene("EndScene");
           
        }
    }

}
