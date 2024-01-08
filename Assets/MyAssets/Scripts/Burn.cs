using UnityEngine;

public class Burn : MonoBehaviour
{
    [SerializeField] int damage = 5;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == gameObject)
        {
            return;
        }

        if (collider.GetComponent<IDamage>() != null)
        {
            GameManager.instance?.PrintMessage("Fire damage: " + damage);
            collider.GetComponent<IDamage>().DoDamage(damage);
        }
    }
}
