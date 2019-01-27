using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TorchAudioComponent : MonoBehaviour
{
    [SerializeField] private AudioClip torchFireClip;
    private AudioSource fireSource;

    [Header("0 is for 2D, 1 is For 3D effects")]
    [Range(0,1)]
    [SerializeField] private float audioSpatialBlend;

    [SerializeField] private float minHearingDistance;
    [SerializeField] private float maxHearingDistance;
	// Use this for initialization

	void Start ()
    {
        fireSource = GetComponent<AudioSource>();
        // Make Sound 3D
        fireSource.clip = torchFireClip;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        minHearingDistance = Mathf.Clamp(minHearingDistance,0, maxHearingDistance);

        fireSource.minDistance = minHearingDistance;
        fireSource.maxDistance = maxHearingDistance;

        fireSource.spatialBlend = audioSpatialBlend;
        //Check if audio Source has stop player
        if (!fireSource.isPlaying)
        {
            fireSource.loop = true;
            fireSource.Play();
        }
	}
}
