using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour
{
    public Text waveCounterText;
    private SpawnManager spawnManager;

    private void Start()
    {
        // Find the SpawnManager script in the scene
        spawnManager = FindObjectOfType<SpawnManager>();
        if (spawnManager == null)
        {
            Debug.LogError("SpawnManager not found in the scene.");
            enabled = false; // Disable this script if SpawnManager is missing
        }

        // Ensure the waveCounterText reference is set in the Inspector
        if (waveCounterText == null)
        {
            Debug.LogError("Wave Counter Text reference not set.");
            enabled = false; // Disable this script if Text reference is missing
        }
    }

    private void Update()
    {
        // Update the UI text with the current wave number
        waveCounterText.text = "Wave: " + spawnManager.waveNumber;
    }
}