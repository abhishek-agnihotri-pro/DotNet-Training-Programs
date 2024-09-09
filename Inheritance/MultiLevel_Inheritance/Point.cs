class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    // public Point(){
    //     X = 0;
    //     Y = 0;
    // }

    public Point(int x = 0, int y = 0){
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Co ordinates:({X},{Y})";
    }

}