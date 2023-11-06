using UnityEngine;
using DG.Tweening;

public class PlayerAnimation : MonoBehaviour
{
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale; // Запамятовуємо початковий розмір прямокутника
    }

    private void OnMouseDown()
    {
        // Збільшуємо розмір прямокутника на 20%, потім повертаємо його до початкового розміру
        transform.DOScale(originalScale * 1.2f, 0.5f).OnComplete(() => transform.DOScale(originalScale, 0.5f));
    }
}