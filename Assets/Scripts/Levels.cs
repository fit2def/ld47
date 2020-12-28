using UnityEngine;
using UnityEngine.SceneManagement;

public class Level
{
    public ObstacleRow[] Rows { get; set; }
    public string Name { get; set; }
}

public static class Levels
{
    public static bool loadNext = false;
    public static int currentLevelIndex = 0;

    public static bool gameJustStarted = true;

    public static Level[] levels = {
        new Level {
        Name = "1",
        Rows = new ObstacleRow[] {
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        },
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Carrot,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        },
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        },
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        }
        }
        }
        },
        new Level {
        Name = "2",
        Rows = new ObstacleRow[] {
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Carrot,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        IsParent = true
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        }, // 2 
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },
        }, // 3
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        },
        IsParent = true
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },
        }, // 5

        }
        },
        new Level {
        Name = "3",
        Rows = new ObstacleRow[] {
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Carrot,
        ObstacleCode.BrickWall,
        ObstacleCode.Nothing,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        },
        IsParent = true,
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.FastButton,
        ObstacleCode.BrickWall,
        },
        },
        ObstacleRow.Empty (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        IsParent = true,
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        IsParent = true,
        OffsetChild = true
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        IsParent = true,
        OffsetChild = true
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        },
        ObstacleRow.Empty (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.FastButton,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        },

        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,

        },
        },

        },

        },
        new Level {
        Name = "4",
        Rows = new ObstacleRow[] {
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.SlowButton,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        IsParent = true,
        OffsetChild = true,
        },
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        },
        IsParent = true,
        OffsetChild = true
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        },
        },
        ObstacleRow.Empty (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.SlowButton,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.FastButton,
        },
        IsParent = true,
        OffsetChild = true
        },
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer(),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },
        IsParent = true,
        OffsetChild = true
        },
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        },
        ObstacleRow.Empty (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        ObstacleCode.BrickWall,
        ObstacleCode.Pipe,
        },
        IsParent = true,
        OffsetChild = true
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.SlowButton,
        ObstacleCode.FastButton,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        ObstacleCode.BrickWall,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        },
        },
        }
        },
        new Level {
        Name = "5",
        Rows = new ObstacleRow[] {
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        },
        IsParent = true,
        OffsetChild = false
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Nothing,
        ObstacleCode.Carrot,
        },

        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        },
        IsParent = true,
        OffsetChild = true
        },
        ObstacleRow.Spacer (),
        ObstacleRow.Spacer (),
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Carrot,
        ObstacleCode.Carrot,
        ObstacleCode.Carrot,
        ObstacleCode.Carrot,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        ObstacleCode.Flamer,
        },
        },
        new ObstacleRow {
        Obstacles = new ObstacleCode[] {
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        ObstacleCode.FastButton,
        }
        }
        },
        },
        new Level {
        Name = "6",
        Rows = new ObstacleRow[] {
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Carrot,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing
            },
            IsParent = true,
            OffsetChild = false
            },
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (true),
        ObstacleRow.PipeRow (false),
        ObstacleRow.Empty(),
       new ObstacleRow() {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.FastButton,
            ObstacleCode.SlowButton,
            ObstacleCode.FastButton,
            ObstacleCode.SlowButton
            },
       },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Nothing,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = false,
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Carrot
            },
            IsParent = true,
            OffsetChild = true,
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.SlowButton
            },
        },
         /* MAZE ONE*/
       ObstacleRow.Spacer(),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.FastButton,
            ObstacleCode.Carrot,
            ObstacleCode.FastButton,
            ObstacleCode.FastButton
            },
            IsParent = true,
            OffsetChild = true
        },
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
       new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.BrickWall,
            ObstacleCode.SlowButton,
            ObstacleCode.BrickWall,
            ObstacleCode.BrickWall
            },
            IsParent = true,
            OffsetChild = false
        },


        ObstacleRow.Empty(),
        ObstacleRow.Empty(),

         /* MAZE TWO*/
        ObstacleRow.Spacer(),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing
            },
            IsParent = true,
            OffsetChild = true
        },
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Nothing,
            ObstacleCode.Nothing,
            ObstacleCode.Flamer,
            ObstacleCode.Nothing
            },
            IsParent = true,
            OffsetChild = true
        },
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.FastButton,
            ObstacleCode.FastButton,
            ObstacleCode.FastButton,
            ObstacleCode.Carrot
            },
            IsParent = true,
            OffsetChild = true
        },
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
       ObstacleRow.PipeRow(false),
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Nothing,
            ObstacleCode.Flamer,
            ObstacleCode.Nothing,
            ObstacleCode.Nothing
            },
            IsParent = true,
            OffsetChild = true
        },
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.PipeRow(true),
        ObstacleRow.Empty(),
        ObstacleRow.Empty(),



    /* THE HOME STRETCH */
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.FastButton
            },
            IsParent = true,
            OffsetChild = true
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },
            IsParent = true,
            OffsetChild = true
        },
         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe
            },

        },

        ObstacleRow.Empty(),

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },


        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
 new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

         new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },


        ObstacleRow.Empty(),
        ObstacleRow.Empty(),

        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Pipe,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
            IsParent = true,
            OffsetChild = true
        },
        new ObstacleRow {
            Obstacles = new ObstacleCode[] {
            ObstacleCode.Flamer,
            ObstacleCode.Carrot,
            ObstacleCode.Flamer,
            ObstacleCode.Flamer
            },
        },


}// rows end
        } //level end
    };

    public static Level GetLevel()
    {
        return levels[currentLevelIndex];
    }

    public static void Next()
    {
        currentLevelIndex++;

        if (currentLevelIndex == levels.Length)
        {
            gameJustStarted = true;
            currentLevelIndex = 0;
        }

        SceneManager.LoadScene("WheelScene");
    }

    public static void Restart()
    {
        SceneManager.LoadScene("WheelScene");
    }

    public static void StartLevel(int index)
    {
        if (index < levels.Length)
        {
            currentLevelIndex = index;
            gameJustStarted = false;
            SceneManager.LoadScene("WheelScene");
        }
    }

    public static bool InHell() => currentLevelIndex == Levels.levels.Length - 1;
}