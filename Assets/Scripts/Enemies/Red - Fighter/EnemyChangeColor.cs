using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChangeColor : MonoBehaviour
{
    [SerializeField] private Material flashMaterial;
    private SpriteRenderer spriteRenderer;
    
    private Material originalMaterial;
    private Coroutine flashRoutine;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalMaterial = spriteRenderer.material;
    }

    public void ChangeColor(){
            if (flashRoutine != null)
            {

                StopCoroutine(flashRoutine);
            }

            flashRoutine = StartCoroutine(FlashRoutine());
    }

    private IEnumerator FlashRoutine()
    {

        spriteRenderer.material = flashMaterial;
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.material = originalMaterial;

        flashRoutine = null;
    }
}
