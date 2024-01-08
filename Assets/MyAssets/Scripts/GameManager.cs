using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PrintMessage(string message)
    {
        print(message);
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        PrintMessage("Player score: " + score);
    }
}
