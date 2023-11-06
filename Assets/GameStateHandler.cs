using UnityEngine;
using Zenject;

public class GameStateHandler : MonoBehaviour
{
    [SerializeField] private GameObject StartGameScreen; //референс на цей обєкт в сцені
    [SerializeField] private GameObject MainGameScreen; //референс на цей обєкт в сцені
    //public event Action<GameState> OnGameStateChanged;

    private void Start()
    {
        UpdateGameStates(GameState.StartGame);
    }

    public void UpdateGameStates(GameState state)
    {
        StartGameScreen.SetActive(state == GameState.StartGame); //Показуємо стартову панель
        MainGameScreen.SetActive(state == GameState.GameStarted); //Показуємо основну панель
    }
}
public enum GameState
{
    StartGame,
    GameStarted
}