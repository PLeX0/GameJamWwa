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
    [SerializeField] private Transform leftStart;
    [SerializeField] private Transform rightStart;
    [SerializeField] private AnimationCurve moveCurve;
    [SerializeField] private float moveTime;
    [SerializeField] private Image cloudLeft;
    [SerializeField] private Image cloudRight;
    [SerializeField] private Image cloudCenter;

    private void Start()
    {
        leftStart = cloudLeft.transform;
        rightStart = cloudRight.transform;
    }

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

        float timer = 2f;
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Debug.Log("chmurka");
            onPointerEnterSequence.Append(cloudLeft.transform.DOMove(leftStart.position, moveTime).SetEase(moveCurve));
            onPointerEnterSequence.Join(cloudRight.transform.DOMove(rightStart.position, moveTime).SetEase(moveCurve));
        }
    }
    
}
