using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public event Action<int> isNextLevelStarted;
    public int nextLevel;

    public void SetScreenVisiblity(GameObject obj) => obj.SetActive(true);

    public void SetScreenInvisiblity(GameObject obj) => obj.SetActive(false);
    
    public void StartScene(int value) => SceneManager.LoadScene(value);
    private void OnTriggerEnter2D(Collider2D other) 
    {
        isNextLevelStarted?.Invoke(nextLevel);
    }
}
