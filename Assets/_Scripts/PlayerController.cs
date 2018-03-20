using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;
    public bool isFlat = true;
    
    // Direction variables that read acceleration input to be added
    // as velocity to Rigidbody2d component
    float dirX, dirY, dirZ;


    static bool youWin;
    static bool dead;
    private Rigidbody rb;

    // Text game object can be added in inspector because of [SerializeField] line
    [SerializeField]
    GameObject winText;

    // Use this for initialization
    void Start()
    {

        youWin = false;
        dead = false;

        // Turn WinText off at the start
        winText.gameObject.SetActive(false);

        // Getting Rigidbody2D component of the ball game object
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {



        // If you win
        if (youWin)
        {

            // then turn YouWin sign on
            winText.gameObject.SetActive(true);

            // Restart scene to play again in 2 seconds
            Invoke("NextScene", 2f);
        }

        if (dead)
        {
            Invoke("RestartScene", 1f);
        }

    }

    void FixedUpdate()
    {
        //Vector3 tilt = Input.acceleration;

        //if (isFlat)
        //{
        //    tilt = Quaternion.Euler(90, 0, 0) * tilt;
        //}

        //rb.AddForce(tilt);
        //Debug.DrawRay(transform.position + Vector3.up, tilt, Color.red);
        transform.localScale = transform.localScale;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }

    // Method is inviked by exit hole game object when ball thouches its collider
    public static void setYouWinToTrue()
    {
        youWin = true;
    }

    public static void setDeadToTrue()
    {
        dead = true;
    }

    // Method to restart current scene
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Method to load next scene
    void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "LevelTest")
        {
            SceneManager.LoadScene("MainMenu");
        } else
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
