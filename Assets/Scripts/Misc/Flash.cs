using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    [SerializeField] private Material whiteFlashMat;
    [SerializeField] private float restoreDefaultMatTime = .2f;

    private Material defaultMat;
    private SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultMat = spriteRenderer.material;
    }

    public float GetRestoreMatTime() {
        return restoreDefaultMatTime;
    }

    public IEnumerator FlashRoutine() {
        spriteRenderer.material = whiteFlashMat;
        yield return new WaitForSeconds(restoreDefaultMatTime);
        spriteRenderer.material = defaultMat;
    }
}
