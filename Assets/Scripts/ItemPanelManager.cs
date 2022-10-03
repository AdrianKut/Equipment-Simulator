using DG.Tweening;
using TMPro;
using UnityEngine;

public class ItemPanelManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshNameItem;
    [SerializeField] private TextMeshProUGUI _textMeshContent;

    [Header("DOTween")]
    [SerializeField] private float _durationScaleIn;
    [SerializeField] private float _endValueScaleIn;
    [SerializeField] private Ease _easeTypeIn;

    [SerializeField] private float _durationScaleOut;
    [SerializeField] private float _endValueScaleOut;
    [SerializeField] private Ease _easeTypeOut;

    private void OnEnable()
    {
        ShowPanel();
    }

    private void OnDisable()
    {
        HidePanel();
    }

    public void ShowPanel()
    {
        transform.DOScale(_endValueScaleIn, _durationScaleIn).SetEase(_easeTypeIn);
    }

    public void HidePanel()
    {
        transform.DOScale(_endValueScaleOut, _durationScaleOut).SetEase(_easeTypeIn);
    }

    public void SetConentItemPanel(string title, string content)
    {
        _textMeshNameItem.text = title;
        _textMeshContent.text = content;
    }
}
