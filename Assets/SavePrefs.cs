using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    public int PLAYER_1_TORAL_SCORE, PLAYER_2_TORAL_SCORE, PLAYER_1_BEST_RESULT, PLAYER_2_BEST_RESULT, CURRENT_PLAYER, CURRENT_SCORE;

    public void SaveDataPlayer1() 
    {
        PlayerPrefs.SetInt("player_1_total_score", PLAYER_1_TORAL_SCORE);
        PlayerPrefs.SetInt("player_1_best_result", PLAYER_1_BEST_RESULT);
        PlayerPrefs.Save();
    }

    public void SaveDataPlayer2() 
    {
        PlayerPrefs.SetInt("player_2_total_score", PLAYER_2_TORAL_SCORE);
        PlayerPrefs.SetInt("player_2_best_result", PLAYER_2_BEST_RESULT);
        PlayerPrefs.Save();
    }

    public void LoadData() 
    {
        PLAYER_1_BEST_RESULT = PlayerPrefs.GetInt("player_1_best_result");
        PLAYER_2_BEST_RESULT = PlayerPrefs.GetInt("player_2_best_result");
        PLAYER_1_TORAL_SCORE = PlayerPrefs.GetInt("player_1_total_score");
        PLAYER_2_TORAL_SCORE = PlayerPrefs.GetInt("player_2_total_score");
    }

    public void SetNullData()
    {
        PlayerPrefs.SetInt("player_1_total_score", 0);
        PlayerPrefs.SetInt("player_1_best_result", 0);
        PlayerPrefs.SetInt("player_2_total_score", 0);
        PlayerPrefs.SetInt("player_2_best_result", 0);
    }

    public void SetCurrentScore(int value)
    {
        CURRENT_SCORE += value;
        PlayerPrefs.SetInt("current_score", CURRENT_SCORE);
    }

    public void LoadCurrentScore()
    {
        CURRENT_SCORE = PlayerPrefs.GetInt("current_score");
    }

    public void SetNullCurrentScore()
    {
        CURRENT_SCORE = 0;
        PlayerPrefs.SetInt("current_score", CURRENT_SCORE);
    }

    public void SetCurrentPlayer(int value)
    {
        CURRENT_PLAYER = value;
        PlayerPrefs.SetInt("current_player", CURRENT_PLAYER);
    }
}
