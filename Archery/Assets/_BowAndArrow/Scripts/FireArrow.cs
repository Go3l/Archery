using UnityEngine;
using UnityEngine.InputSystem;

public class FireArrow : MonoBehaviour
{
    [Header("References")]
    public Arrow arrow;

    [Header("Input Actions")]
    public InputActionReference fireArrowReference = null;

    [Header("Particle Effecs")]
    public GameObject fx_FireArrow;

    [Header("Audio Clips")]
    public AudioClip clip_FireArrow;

    private void OnEnable()
    {
        fireArrowReference.action.started += ToggleFireArrow;
    }

    private void ToggleFireArrow(InputAction.CallbackContext context)
    {
        if (!arrow.IsArrowInHand) return;
        fx_FireArrow.SetActive(!fx_FireArrow.activeInHierarchy);
    }

    private void OnDisable()
    {
        fireArrowReference.action.started -= ToggleFireArrow;
    }
}
