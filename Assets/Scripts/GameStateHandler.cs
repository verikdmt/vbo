using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameStateHandler : MonoBehaviour
{
    [SerializeField] private GameObject StartGameScreen; //референс на цей обєкт в сцені
    [SerializeField] private GameObject MainGameScreen; //референс на цей обєкт в сцені
    [SerializeField] private Button startButton;
    public event Action<GameState> OnGameStateChanged;

    private void Start()
    {
        UpdateGameStates(GameState.StartGame); 
        startButton.onClick.AddListener(StartGame);
    }
    
    public void StartGame()
    {
        //Міняємо стан гри кнопкою
        UpdateGameStates(GameState.GameStarted);
    }

    private void UpdateGameStates(GameState state)
    {
        StartGameScreen.SetActive(state == GameState.StartGame); //Показуємо стартову панель
        MainGameScreen.SetActive(state == GameState.GameStarted); //Показуємо основну панель
        OnGameStateChanged?.Invoke(state);
    }
}
public enum GameState
{
    StartGame,
    GameStarted
}