using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioClip[] levelSongs;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.clip = levelSongs[Levels.currentLevelIndex];
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
