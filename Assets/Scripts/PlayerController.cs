using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int lives;
    private float speed;

    private GameManager gameManager;

    private float horizontalInput;
    private float verticalInput;

    public GameObject bulletPrefab;
    public GameObject explosionPrefab;
    public AudioClip shooting;

<<<<<<< Updated upstream
=======
    public GameObject Shield;
    public AudioClip shieldDown;
    private bool isShieldActive = false;

>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        lives = 3;
        speed = 5.0f;
        gameManager.ChangeLivesText(lives);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    public void LoseALife()
    {
<<<<<<< Updated upstream
        //lives = lives - 1;
        //lives -= 1;
=======
        if (isShieldActive)
        {
            // Shield absorbs the hit
            isShieldActive = false;
            if (Shield != null)
                Shield.SetActive(false);
                AudioSource.PlayClipAtPoint(shieldDown, transform.position);
            return;
        }

>>>>>>> Stashed changes
        lives--;
        gameManager.ChangeLivesText(lives);
        if (lives == 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
            AudioSource.PlayClipAtPoint(shooting, transform.position);
        }
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        float horizontalScreenSize = gameManager.horizontalScreenSize;
        float verticalScreenSize = gameManager.verticalScreenSize;

        if (transform.position.x <= -horizontalScreenSize || transform.position.x > horizontalScreenSize)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }

        if (transform.position.y <= -verticalScreenSize || transform.position.y > verticalScreenSize)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        }

    }
<<<<<<< Updated upstream
=======

    public void DeactivateShield()
    {
        if (isShieldActive) {
           isShieldActive = false;
           Shield.SetActive(false);
           AudioSource.PlayClipAtPoint(shieldDown, transform.position);
        }
    }

    private IEnumerator ShieldTimer()
    {
        yield return new WaitForSeconds(5f);
        DeactivateShield();
    }

>>>>>>> Stashed changes
}
