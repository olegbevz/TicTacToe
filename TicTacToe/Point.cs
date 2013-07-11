namespace GamePanelApplication
{
    public struct Point
    {
        private int x;

        private int y;

        public Point(int x, int y)
        {
            this.x = x;

            this.y = y;
        }

        public int X 
        { 
            get
            {
                return this.x;
            } 
        }

        public int Y { get
        {
            return this.y;
        } }
    }
}
