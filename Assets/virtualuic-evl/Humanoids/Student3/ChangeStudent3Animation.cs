using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStudent3Animation : MonoBehaviour
{
    public Animator humanoidAnimator; 
    public AudioSource humanoidAudioSource;
    public GameObject user;
    public float minimumDistance;
    bool isClose; 
    // Start is called before the first frame update
    void Start()
    {
        isClose = false;
        humanoidAnimator.GetComponent<Animator>();
        humanoidAudioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.localPosition, user.transform.localPosition) <= (minimumDistance - 0.2f) && !isClose) {
            isClose = true;
            humanoidAnimator.SetTrigger("VictoryTrigger");
            humanoidAudioSource.Play();
        }
        else if (Vector3.Distance(gameObject.transform.localPosition, user.transform.localPosition) > (minimumDistance + 0.2f)) {
            isClose = false;
        }
    }
}
