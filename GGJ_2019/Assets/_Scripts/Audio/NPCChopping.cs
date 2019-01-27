using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NPCChopping : MonoBehaviour
{
    private float counter;
   [SerializeField] private float choppingSpeed;

    [SerializeField] private AudioClip[] gruntSounds;
    [SerializeField] private AudioClip[] ChoppingSounds;

    private int state = 0;
    private AudioSource audioSource;
	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        counter += Time.deltaTime;
        
        if(counter >= choppingSpeed)
        {
            if (!audioSource.isPlaying)
            {
                if (state == 0)
                {
                    // Grunt Away my friend
                    audioSource.clip = gruntSounds[Random.Range(0, gruntSounds.Length)];
                    state = 1;
                }
                else if (state == 1)
                {
                    //Chop Away NPC
                    audioSource.clip = ChoppingSounds[Random.Range(0, ChoppingSounds.Length)];
                    state = 0;
                }
                audioSource.Play();
            }
            counter = 0;
        }
	}
}
