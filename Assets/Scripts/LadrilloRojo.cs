using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadrilloRojo : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pelota")) {
            Destroy(gameObject);
        }
    }
}
