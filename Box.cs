class Box {
    public int Height { get; set; }
    public int Width { get; set; }

    public Box(int height, int width) {
        this.Height = height;
        this.Width = width;
    }

    public static Box operator+ (Box a, Box b) {
        Box c = new Box(a.Height + b.Height, a.Width + b.Width);
        return c;
    }
}