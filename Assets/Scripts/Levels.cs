using UnityEngine.SceneManagement;

public class Level
{
    public ObstacleRow[] Rows { get; set; }
}

public static class Levels
{
    public static int currentLevelIndex = 1;

    public static Level[] levels = {
        new Level {
            // don't put anything here, this is a dummy level
            Rows = new ObstacleRow[] {}
        },
        new Level {
            Rows = new ObstacleRow[]{
                new ObstacleRow {
                    Obstacles = new ObstacleCode[] {
                        ObstacleCode.Carrot,
                        ObstacleCode.Flamer,
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot
                    },
                },
                new ObstacleRow {
                    Obstacles = new ObstacleCode[] {
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                    },
                    IsParent = true,
                    OffsetChild = true
                },
                new ObstacleRow {
                    Obstacles = new ObstacleCode[] {
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                    },
                }
            },
        },
        new Level {
             Rows = new ObstacleRow[]{
                new ObstacleRow {
                    Obstacles = new ObstacleCode[] {
                        ObstacleCode.Carrot,
                         ObstacleCode.Carrot,
                         ObstacleCode.Carrot,
                         ObstacleCode.Carrot,
                    },
                    IsParent = true,
                    OffsetChild = true
                },
                new ObstacleRow {
                    Obstacles = new ObstacleCode[] {
                         ObstacleCode.Carrot,
                        ObstacleCode.Carrot,
                         ObstacleCode.Carrot,
                         ObstacleCode.Carrot,
                    },
                    IsParent = true,
                },
            },
        },
    };

    public static Level GetLevel()
    {
        return levels[currentLevelIndex];
    }

    public static void Next()
    {
        currentLevelIndex++;
        SceneManager.LoadScene(currentLevelIndex == levels.Length ? "StartScene" : "WheelScene");
    }

    public static void Restart()
    {
        currentLevelIndex = 1;
        SceneManager.LoadScene("WheelScene");
    }
}