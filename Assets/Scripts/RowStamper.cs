using System;
using UnityEngine;

public class RowStamper : MonoBehaviour
{
    [SerializeField] float delay = 5f;
    [SerializeField] float spacing = 1f;
    private Wheel wheel;
    int generationCount;
    private Level level;
    private int rowIndex;
    void Start()
    {
        wheel = FindObjectOfType<Wheel>();
        level = Levels.GetLevel();

        for (int i = 0; i < level.Rows.Length; i++)
        {
            // if the row has no parent, schedule it.
            if (i == 0 || !level.Rows[i - 1].IsParent)
            {
                generationCount = 0;
                float invokeAfterSeconds = i * spacing + delay;
                Invoke("StampHierarchy", invokeAfterSeconds);
            }
        }
    }

    private void StampHierarchy()
    {
        bool offset = rowIndex > 0 && level.Rows[rowIndex - 1].OffsetChild;
        Stamp(level.Rows[rowIndex], offset);

        print(rowIndex);
        if (level.Rows[rowIndex++].IsParent)
        {
            generationCount++;
            StampHierarchy();
        }
    }

    private void Stamp(ObstacleRow row, bool offset)
    {
        if (row.Obstacles.Length != Constants.OBSTACLES_PER_ROW)
            throw new Exception($"Must be {Constants.OBSTACLES_PER_ROW} obstacles per row.");

        for (int i = 0; i < row.Obstacles.Length; i++)
        {
            if (row.Obstacles[i] == ObstacleCode.Nothing) continue;

            GameObject prefab =
                Resources.Load($"Obstacles/{row.Obstacles[i].ToString()}") as GameObject;

            GameObject obstacle = Instantiate(prefab, transform.position, transform.rotation);

            obstacle.transform.SetParent(wheel.gameObject.transform, true);

            Vector3 pos = obstacle.transform.position;
            pos.x = GetObstacleXPosition(i);

            if (offset)
            {
                float rotationDegrees = -generationCount / Constants.WHEEL_RADIUS * 90f; //check
                float t = -rotationDegrees * (float)Math.PI / 180f;
                pos.y = Constants.WHEEL_RADIUS * Mathf.Cos(t);
                pos.z = -Constants.WHEEL_RADIUS * Mathf.Sin(t);
                obstacle.transform.Rotate(rotationDegrees, 0, 0);
            }

            obstacle.transform.position = pos;
        }
    }

    private float GetObstacleXPosition(int index)
    {
        float start = -Constants.WHEEL_WIDTH * .5f;
        float obstacleLaneWidth = Constants.WHEEL_WIDTH / Constants.OBSTACLES_PER_ROW;
        float laneOffset = .5f * obstacleLaneWidth;
        return start + index * obstacleLaneWidth + laneOffset;
    }
}
