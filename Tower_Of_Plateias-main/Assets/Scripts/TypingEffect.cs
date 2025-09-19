using System.Collections;
using UnityEngine;
using TMPro;

public class TypingEffect : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    public float typingSpeed = 0.05f; // velocidade de digitação

    private string fullText;

    void Start()
    {
        fullText = tmpText.text;
        tmpText.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            tmpText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
