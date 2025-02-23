using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    //declaracion variables
    
    public Rigidbody2D rigibody2dPelota;

    public float pelotaSpeed = 300f;
    
    private Vector2 velocidad;
    
    private Vector2 startPosition;
    
    // Start is called before the first frame update
    void Start() {
        startPosition = transform.position;
        //esto es para que la pelota se mueve de manera aleatoria
        velocidad.x = Random.Range(-1f,1f);

        velocidad.y = 1;
        
        rigibody2dPelota.AddForce(velocidad * pelotaSpeed);

    }

    void Update()
    {
        velocidad.x = Random.Range(-1f,1f);
        velocidad.y = 1;

    }
    
    private void OnCollisionEnter2D(Collision2D collision2)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (collision2.gameObject.CompareTag("suelo"))
        {
            GameManager.Instance.PerderVidas();
        }
    }
    
    public void ResetBall() {
        transform.position = startPosition;
        velocidad.x = Random.Range(-1f,1f);

        velocidad.y = 1;
        
        rigibody2dPelota.AddForce(velocidad * pelotaSpeed);
    }
}