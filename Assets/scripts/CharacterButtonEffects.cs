using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CharacterButtonEffects : MonoBehaviour
{
    public AudioSource audioSource; // Fuente de audio para efectos sonoros

    // Sonidos para cada personaje
    public AudioClip[] characterSounds; // Clips de sonido para efectos

    public enum Character
    {
        Raxxar,
        Ragnavaldr,
        Kairon,
        PepeLouy,
        AlmaFellas,
        Prometeo,
        Barled,
        Invitado
    }

    public Character selectedCharacter; // El personaje seleccionado

    public Button button;

    private void Awake()
    {
        // Asigna automáticamente el Button del GameObject
        button = GetComponent<Button>();
        button.onClick.AddListener(ApplyEffect);
    }

    public void ApplyEffect()
    {
        // Cancela cualquier animación previa
        DOTween.Kill(button.gameObject);

        // Efectos según el personaje
        switch (selectedCharacter)
        {
            case Character.Raxxar:
                PlayEffect(characterSounds[0], Vector3.one * 1.5f, Ease.OutBounce);
                break;

            case Character.Ragnavaldr:
                PlayEffect(characterSounds[1], Vector3.one * 2f, Ease.OutElastic);
                break;

            case Character.Kairon:
                PlayEffect(characterSounds[2], Vector3.one * 1.2f, Ease.OutQuad);
                break;

            case Character.PepeLouy:
                PlayEffect(characterSounds[3], Vector3.one * 1.3f, Ease.OutCirc);
                break;

            case Character.AlmaFellas:
                PlayEffect(characterSounds[4], Vector3.one * 1.1f, Ease.OutBounce);
                break;

            case Character.Prometeo:
                PlayEffect(characterSounds[5], Vector3.one * 1.6f, Ease.OutElastic);
                break;

            case Character.Barled:
                PlayEffect(characterSounds[6], Vector3.one * 1.4f, Ease.OutQuad);
                break;

            case Character.Invitado:
                PlayEffect(characterSounds[7], Vector3.one, Ease.Linear);
                break;
        }
    }

    private void PlayEffect(AudioClip sound, Vector3 scale, Ease ease)
    {
        // Efecto sonoro
        if (audioSource != null && sound != null)
        {
            audioSource.clip = sound;
            audioSource.Play();
        }

        // Efecto visual de escalado usando DOTween
        button.transform.localScale = Vector3.zero;
        button.transform.DOScale(scale, 0.5f).SetEase(ease);

        // Restablecer escala al finalizar
        button.transform.DORestart(button.transform);
    }
}
