using UnityEngine;

public class GameManager : MonoBehaviour {
    // This method freezes the game when called
    public void GameOver() {
        Time.timeScale = 0f; 
    }
}