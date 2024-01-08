using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
}
