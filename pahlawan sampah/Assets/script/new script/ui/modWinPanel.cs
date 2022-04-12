using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class modWinPanel : MonoBehaviour
{
    [Header("header")]
    [SerializeField]
    private Transform _headerArea;
    [SerializeField]
    private Text _titleField;

    [Header("Content")]
    [SerializeField]
    private Transform _contentArea;
    [SerializeField]
    private Image _imageShow;
    [SerializeField]
    private Text _textShow;

    [Header("footer")]
    [SerializeField]
    private Transform _footerArea;
    [SerializeField]
    private Button _confirmButton;
    [SerializeField]
    private Button _declineButton;
    [SerializeField]
    private Button _alternateButton;


}
