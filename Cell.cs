using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cell
    {
        private int x;
        private int y;
        private int value;
        private int time;
        private LinkedList<int> possibleSolutions = new LinkedList<int>();

        public Cell(int x, int y, int value, int time)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            this.time = time;
            for (int i = 1; i < 10; i++)
            {
                possibleSolutions.AddLast(i);
            }
        }
        public int getValue()
        {
            return value;
        }

        public int getTime()
        {
            return time;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public LinkedList<int> getPossibleSolutions()
        {
            return possibleSolutions;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public void setTime(int time)
        {
            this.time = time;
        }

    }
}
