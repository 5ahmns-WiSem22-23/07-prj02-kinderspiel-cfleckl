using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameSceneManager gm;
    public GameSceneManager.Item item;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (item)
        {
            case GameSceneManager.Item.Boat:

                if (collision.gameObject.CompareTag("Fish"))
                {
                    gm.CheckForWin();
                }
                Destroy(collision.gameObject);
                break;

            case GameSceneManager.Item.Fish:
                if (collision.gameObject.CompareTag("Border"))
                {
                    gm.GameOver(GameSceneManager.Item.Fish);
                }
                break;
        }
    }
}
