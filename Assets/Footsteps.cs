using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepAudio;
    public float moveSpeedThreshold = 0.1f;

    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float speed = (transform.position - lastPosition).magnitude / Time.deltaTime;

        if (speed > moveSpeedThreshold)
        {
            if (!footstepAudio.isPlaying)
            {
                footstepAudio.Play();
            }
        }
        else
        {
            footstepAudio.Stop();
        }

        lastPosition = transform.position;
    }
}