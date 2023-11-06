using UnityEngine;
using Zenject;

public class StartGame : MonoBehaviour
{
    [Inject] private GameStateHandler _gameStateHandler;
    public void StartGameButton()
    {
        //Міняємо стан гри кнопкою
        _gameStateHandler.UpdateGameStates(GameState.GameStarted);
    }
}
