using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using NaughtyAttributes;

public class ShapeMove : MonoBehaviour {

    public Color targetColor = Color.red;
    private Image image;

    private Vector3 targetScale = new Vector3(2f, 2f, 2f);
    private float duration = 1f;

    void Start() {
        image = GetComponent<Image>();
    }

    [Button]
    private void AnimateScale() {

        transform.DOScale(targetScale, duration)
                 .SetLoops(-1, LoopType.Yoyo)  // -1 for infinite loop, Yoyo to scale back and forth
                 .SetEase(Ease.InOutSine);
    }

    [Button]
    private void AnimateColor() {
        image.DOColor(targetColor, duration)
                .SetLoops(-1, LoopType.Yoyo)  // Infinite loop, Yoyo type for back and forth
                .SetEase(Ease.InOutSine);     // Optional: smooth easing
    }
}