using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LatestScore : MonoBehaviour
{
    [SerializeField]
    TMP_Text _textMeshPro;

    private void Awake()
    {
        int latestScore = StaticData.puntos;
        _textMeshPro.text = "Your latest score is: " + latestScore;
    }
}
