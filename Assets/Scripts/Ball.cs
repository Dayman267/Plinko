using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Action OnTouch;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Target"))
        {
            OnTouch?.Invoke();
            Destroy(gameObject);
        }
    }
}
