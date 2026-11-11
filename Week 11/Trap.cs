using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private GameObject orangeSquare;

    void Start()
    {
        orangeSquare = new GameObject("OrangeSquare");
        SpriteRenderer sr = orangeSquare.AddComponent<SpriteRenderer>();

        Texture2D tex = new Texture2D(1, 1);
        tex.SetPixel(0, 0, new Color(1f, 0.5f, 0f));
        tex.Apply();

        sr.sprite = Sprite.Create(tex, new Rect(0, 0, 1, 1), new Vector2(0.5f, 0.5f), 1f);
        sr.sortingOrder = 10;

        orangeSquare.transform.position = transform.position + new Vector3(0, 2, 0);
        orangeSquare.SetActive(false);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            orangeSquare.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            orangeSquare.SetActive(false);
        }
    }
}
