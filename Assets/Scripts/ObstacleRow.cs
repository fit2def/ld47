public class ObstacleRow
{
    public ObstacleCode[] Obstacles { get; set; }

    public bool IsParent { get; set; }

    public bool OffsetChild { get; set; }

    public static ObstacleRow Empty()
    {
        return new ObstacleRow
        {
            Obstacles = new ObstacleCode[]{
                ObstacleCode.Nothing,
                ObstacleCode.Nothing,
                ObstacleCode.Nothing,
                ObstacleCode.Nothing,
            },
        };
    }
}
