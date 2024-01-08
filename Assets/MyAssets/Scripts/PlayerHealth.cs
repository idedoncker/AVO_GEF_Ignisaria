using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamage
{
    [SerializeField] int initHp = 100;

    public int hitPoints
    {
        get { return initHp; }
        set { initHp = value; }
    }

    public void DoDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            Kill();
        }

        GameManager.instance?.PrintMessage("Player health: " + hitPoints);
    }

    private void Kill()
    {
        GameManager.instance?.PrintMessage("Player died!");

        // snap to checkpoint
    }
}
