using UnityEngine;

public class Hamster : MonoBehaviour
{
    [SerializeField] float horizontalSpeed = 5f;
    [SerializeField] AudioClip carrotSound;
    [SerializeField] AudioClip jumpSound;

    [SerializeField] AudioClip scorchedSound;
    [SerializeField] AudioClip splatSound;

    private float xAllowance = 9;

    private Animator animator;
    private AudioSource sound;

    Wheel wheel;

    ParticleSystem splatter;

    public int carrots = 0;

    private bool waitingForNextLevel = false;

    public Animator[] carrotControllers;

    void Start()
    {
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        wheel = FindObjectOfType<Wheel>();
        splatter = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitingForNextLevel) ProcessInput();

        DebugLevelSelect();
    }

    void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) MoveRight();
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) MoveLeft();
    }

    void Jump()
    {
        animator.Play("Jump");
    }

    public void PlayJumpSound()
    {
        sound.PlayOneShot(jumpSound);
    }

    void MoveRight()
    {
        float x = horizontalSpeed * Time.deltaTime;
        float proposedXPos = x + transform.position.x;
        x = proposedXPos > xAllowance ? x - (proposedXPos - xAllowance) : x;

        transform.Translate(Vector3.right * x);
    }

    void MoveLeft()
    {
        float x = horizontalSpeed * Time.deltaTime;
        float proposedXPos = transform.position.x - x;

        x = proposedXPos < -xAllowance ? x - (-xAllowance - proposedXPos) : x;

        transform.Translate(Vector3.left * x);
    }

    void DebugLevelSelect()
    {
        for (int i = 1; i < 10; i++)
        {
            if (Input.GetKeyDown($"[{i}]"))
            {
                Levels.StartLevel(i);
            }
        }
    }

    public void GetCarrot()
    {
        carrotControllers[carrots].Play("SlideCarrot");
        sound.PlayOneShot(carrotSound);
        carrots++;

        if (carrots == 5)
        {
            //todo - play fanfare sound
            Pause();
            Invoke("LoadNextScene", 3f);
        }
    }

    private void LoadNextScene()
    {
        Levels.Next();
    }

    public void Splat()
    {
        if (!waitingForNextLevel)
        {
            Pause();
            // todo - blood splat + sound
            SkinnedMeshRenderer mesh = GetComponentInChildren<SkinnedMeshRenderer>();
            mesh.enabled = false;
            sound.PlayOneShot(splatSound);
            splatter.Play();
            Invoke("Die", 3f);
        }

    }

    public void Scorch()
    {
        if (!waitingForNextLevel)
        {
            sound.PlayOneShot(scorchedSound);
            SkinnedMeshRenderer mesh = GetComponentInChildren<SkinnedMeshRenderer>();
            Material charred = Resources.Load("Materials/Flamer") as Material;
            mesh.material = charred;
            Pause();
            Invoke("Die", 3f);
        }

    }

    private void Die()
    {
        Levels.Restart();
    }

    private void Pause()
    {
        animator.SetBool("noAnims", true);
        waitingForNextLevel = true;

        Invoke("StopWheel", .25f);
    }

    private void StopWheel()
    {

        wheel.speed = 0f;
    }
}
