using UnityEngine;
using TMPro;

public class MessageManager : MonoBehaviour
{
    public TMP_Text messageText;
    private float messageDisplayTime = 2f; // Час, протягом якого повідомлення буде відображатися
    private float timer;

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                HideMessage(); // При закінченні таймера приховати повідомлення
            }
        }
    }

    public void ShowMessage(string message)
    {
        //Показуємо потрібне повідомлення
        messageText.text = message;
        messageText.gameObject.SetActive(true);
        timer = messageDisplayTime;
    }

    public void HideMessage()
    {
        //Ховаємо повідомлення
        messageText.gameObject.SetActive(false);
    }
}
