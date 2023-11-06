using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private MessageManager messageManager;
    [SerializeField] private GameStateHandler gameStateHandler;
    public override void InstallBindings()
    {
        Container.BindInstance(messageManager).AsSingle();
        Container.BindInstance(gameStateHandler).AsSingle();
    }
}
