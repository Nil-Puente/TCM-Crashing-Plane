using Unity.VisualScripting;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) //Detectar collisio
    {
        Destroy(gameObject);
    }
}
