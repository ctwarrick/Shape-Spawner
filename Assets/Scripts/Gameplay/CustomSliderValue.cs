//
// Original SliderValue Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// Edited by Chris Warrick for the Shape Spawner project
//
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

/// <summary>
/// A customized slider value which shows spawn distance in meters
/// </summary>
public class CustomSliderValue : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro textMesh;

    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (textMesh == null)
        {
            textMesh = GetComponent<TextMeshPro>();
        }

        if (textMesh != null)
        {
            decimal newDistance = (decimal)Camera.main.GetComponent<ObjectSpawner>().SpawnDistance;
            newDistance = Math.Round(newDistance, 2);
            textMesh.text = newDistance.ToString();
        }
    }
}

