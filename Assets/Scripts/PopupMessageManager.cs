using DG.Tweening;
using TMPro;
using UnityEngine;

public class PopupMessageManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshContent;

    [Header("DOTween")]
    [SerializeField] private float _durationScaleIn;
    [SerializeField] private float _endValueScaleIn;
    [SerializeField] private Ease _easeTypeIn;

    [SerializeField] private float _timeToDestroy = 2f;

    private void OnEnable()
    {
        _textMeshContent.gameObject.transform.DOScale(_endValueScaleIn, _durationScaleIn).SetEase(_easeTypeIn);
        Destroy(gameObject, _timeToDestroy);
    }

    public void SetText(string text)
    {
        _textMeshContent.text = text;
    }
}
