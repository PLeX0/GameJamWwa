using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
public class animButton : MonoBehaviour, IPointerEnterHandler
{

    [SerializeField] private Transform leftTarget;
    [SerializeField] private Transform rightTarget;
    [SerializeField] private AnimationCurve moveCurve;
    [SerializeField] private float moveTime;
    [SerializeField] private Image cloudLeft;
    [SerializeField] private Image cloudRight;
    [SerializeField] private Image cloudCenter;


    private Sequence onPointerEnterSequence;
    public void OnPointerEnter(PointerEventData eventData)
    {

       if(onPointerEnterSequence != null)
        {
            onPointerEnterSequence.Kill();
          
           
        }
        onPointerEnterSequence = DOTween.Sequence();

        onPointerEnterSequence.Append(cloudLeft.transform.DOMove(leftTarget.position, moveTime).SetEase(moveCurve));
        onPointerEnterSequence.Join(cloudRight.transform.DOMove(rightTarget.position, moveTime).SetEase(moveCurve));
    }
    
}
