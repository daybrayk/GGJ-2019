using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsAudio : MonoBehaviour
{
    AudioSource footSource;
    [SerializeField] private float sprintSpeed;

    [SerializeField] private AudioClip[] grassFootClips;
    [SerializeField] private AudioClip[] snowFootClips;
    [SerializeField] private AudioClip[] climbingFootClips;

    public bool sprint = false;
    public bool walkingInSnow = false;
    public bool climbing = false;

    private void Start()
    {
        footSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        FeetSoundEffects();
    }

    private void FeetSoundEffects()
    {
        if (!footSource.isPlaying)
        {
            // Are we running
            if(!sprint)
            {
                footSource.pitch = 1f;
            }
            else
            {
                footSource.pitch = sprintSpeed;
            }
            
            // Are we walking on snow.
            if (walkingInSnow)
            {
                footSource.clip = snowFootClips[Random.Range(0, snowFootClips.Length)];
            }
            // Are we climbing.
            else if (climbing)
            {
                footSource.clip = climbingFootClips[Random.Range(0, climbingFootClips.Length)];
            }
            // If not then just play normal walk sound.
            else
            {
                footSource.clip = grassFootClips[Random.Range(0, grassFootClips.Length)];
            }
            footSource.Play();
        }
    }
}
