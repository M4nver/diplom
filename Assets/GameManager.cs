using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _player;
    public int _score;
    public Text _scoreText, _EndTotalScore;
    public Text _scoreTextPlayer1, _bestResultTextPlayer1, _scoreTextPlayer2, _bestResultTextPlayer2;
    public Menu _menu;
    SavePrefs _data;

    private void Start() 
    {
        Coins.isCoinUpdateAction += TextUpdate;
        _data = gameObject.GetComponent<SavePrefs>();
        _menu.isNextLevelStarted += StartNextLevel;
        //Debug.Log("data1 - " + _score);
        Debug.Log("data1 - " + _data.CURRENT_SCORE);
        _data.LoadCurrentScore();
        _score = _data.CURRENT_SCORE;
        Debug.Log("data2 - " + _data.CURRENT_SCORE);
        SetTextScore(_score);
    }

    public void TextUpdate(int value)  
    {
        _score += value;
        _scoreText.text = _score.ToString();
    }

    public void SetTextScore(int value)
    {
        _scoreText.text = value.ToString();
    }

    public void SetTextScore() 
    {
        _scoreTextPlayer1.text = _data.PLAYER_1_TORAL_SCORE.ToString();
        _bestResultTextPlayer1.text = _data.PLAYER_1_BEST_RESULT.ToString();
        _scoreTextPlayer2.text = _data.PLAYER_2_TORAL_SCORE.ToString();
        _bestResultTextPlayer2.text = _data.PLAYER_2_BEST_RESULT.ToString(); 
    }
    public void SetPlayer(int value) => _player = value;

    private void OnDisable() 
    {
        Coins.isCoinUpdateAction -= TextUpdate;
        _menu.isNextLevelStarted -= StartNextLevel;
    }

    public void StartNextLevel(int value) 
    {
        _data.LoadData();
        _player = PlayerPrefs.GetInt("current_player");
        switch (_player) 
        {
            case 1:
                _data.PLAYER_1_TORAL_SCORE += _score;
                if (_score > _data.PLAYER_1_BEST_RESULT) 
                {
                    _data.PLAYER_1_BEST_RESULT = _score;
                }
                _data.SetCurrentScore(_score);
                _data.SaveDataPlayer1();
                _menu.StartScene(value);
                return;
            case 2:
                _data.PLAYER_2_TORAL_SCORE += _score;
                if (_score > _data.PLAYER_2_BEST_RESULT) 
                {
                    _data.PLAYER_2_BEST_RESULT = _score;
                }
                _data.SetCurrentScore(_score);
                _data.SaveDataPlayer2();
                _menu.StartScene(value);
                return;
        }
        
        
    }

    public void SaveData() 
    {
        
        switch (_player) 
        {
            case 1:
                _data.PLAYER_1_TORAL_SCORE += _score;
                if (_score > _data.PLAYER_1_BEST_RESULT) 
                {
                    _data.PLAYER_1_BEST_RESULT = _score;
                }
                _data.SaveDataPlayer1();
                return;
            case 2:
                if (_score > _data.PLAYER_2_BEST_RESULT) 
                {
                    _data.PLAYER_2_BEST_RESULT = _score;
                }
                _data.SaveDataPlayer2();
                return;
        }
        
        
    }
}
