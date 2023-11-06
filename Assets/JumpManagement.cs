using UnityEngine;
using DG.Tweening;
using TMPro;
using Zenject;

public class JumpManagement : MonoBehaviour
{
    [SerializeField] private Transform rectangleTransform;
    [SerializeField] private Vector3 originalPosition;
    [SerializeField] private TMP_InputField forceInput;
    [SerializeField] private AudioSource jumpSound;
    [Inject] private MessageManager _messageManager;

    private void Start()
    {
        originalPosition = rectangleTransform.position; //Запамятовуємо початку позицію прямокутника
    }
    public void TrimOnClick()
    {
        if (string.IsNullOrEmpty(forceInput.text))
        {
            _messageManager.ShowMessage("Введіть чисто в інпут"); //Повідомлення, якщо користувач нічого не ввів
        }
        else if (int.TryParse(forceInput.text, out int force))
        {
            // Змінюємо положення прямокутника вгору на відстань, залежну від введеної сили
            float jumpHeight = force * 0.1f; // Визначаємо відстань, на яку підніматиметься прямокутник
            Vector3 targetPosition = originalPosition + Vector3.up * jumpHeight;
            rectangleTransform.DOMove(targetPosition, 0.2f).OnComplete(() => rectangleTransform.DOMove(originalPosition, 0.2f)); //Анімація піднімання та повернення
            
            jumpSound.Play(); //Відтворення звуку
        }
        else
        {
            _messageManager.ShowMessage("Ви ввели невірний формат"); //Повідомлення, якщо користувач ввів не число
        }
    }
}