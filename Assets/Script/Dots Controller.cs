using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DotsController : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Point;
    public GameObject winner;
    private float horizontal;
    private float vertical;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        transform.Translate(movement * 5f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Vector2 firstPosition = new Vector2(-5.9f, 0f);
            transform.position = firstPosition;
        }

        if (col.gameObject.CompareTag("Enemys"))
        {
            Vector2 firstPosition = new Vector2(-6.994f, -3.998f);
            transform.position = firstPosition;
        }

        if (col.gameObject.CompareTag("Box"))
        {
            winner.SetActive(true);
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }

        if (col.gameObject.CompareTag("BoxWithPoint"))
        {
            gameManager.WinWithPoint();
        }

        if (col.gameObject.CompareTag("point"))
        {
            var name = col.attachedRigidbody.name;
            Destroy(GameObject.Find(name));

            if (gameManager != null) // Check if reference is valid
            {
                gameManager.OnPointEaten();
            }
        }
    }
}
