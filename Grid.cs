using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Grid
    {
        private Cell[] cells = new Cell[81];
        private int numberOfNonSolved = 81;
        private int[] numberOfPossibleSolution = new int[81];
        private long serialTime;
        private long parallelTime;

        public Grid()
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    cells[(x * 9) + y] = new Cell(x, y, -1, -1);
                    numberOfPossibleSolution[(x * 9) + y] = 9;
                }
            }
        }

        private Cell getCell(int x, int y)
        {
            return cells[(x * 9) + y];
        }

        public long getSerialTime()
        {
            return serialTime;
        }

        public long getParallelTime()
        {
            return parallelTime;
        }

        public void printGrid()
        {
            Console.Write("\n\n");
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    int value = cells[(x * 9) + y].getValue();
                    if (value == -1)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write(value + " ");
                    }
                }
                Console.Write("\n");
            }
        }

        public void addValue(int x, int y, int value, int time)
        {
            setValues(x, y, value, time);
            removePossibleSolutionFromColumn(x, y, value);
            removePossibleSolutionFromRow(x, y, value);
            removePossibleSolutionFromBox(x, y, value);
        }

        public void addValueParallel(int x, int y, int value, int time)
        {
            Task<bool>[] tasks = new Task<bool>[4];

            tasks[0] = new Task<bool>(() => setValues(x, y, value, time));
            tasks[0].Start();

            tasks[1] = new Task<bool>(() => removePossibleSolutionFromColumn(x, y, value));
            tasks[1].Start();

            tasks[2] = new Task<bool>(() => removePossibleSolutionFromRow(x, y, value));
            tasks[2].Start();

            tasks[3] = new Task<bool>(() => removePossibleSolutionFromBox(x, y, value));
            tasks[3].Start();

            Task.WaitAll(tasks);
        }

        private bool setValues(int x, int y, int value, int time)
        {
            numberOfNonSolved--;
            cells[(x * 9) + y].setTime(time);
            cells[(x * 9) + y].setValue(value);
            cells[(x * 9) + y].getPossibleSolutions().Clear();
            numberOfPossibleSolution[(x * 9) + y] = 0;
            return true;
        }

        private bool removePossibleSolutionFromColumn(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != x)
                {
                    if (cells[(i * 9) + y].getPossibleSolutions().Remove(value))
                    {
                        numberOfPossibleSolution[(i * 9) + y]--;
                    }
                }
            }
            return true;
        }

        private bool removePossibleSolutionFromRow(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y)
                {
                    if (cells[(x * 9) + i].getPossibleSolutions().Remove(value))
                    {
                        numberOfPossibleSolution[(x * 9) + i]--;
                    }
                }
            }
            return true;
        }

        private bool removePossibleSolutionFromBox(int x, int y, int value)
        {
            int firstRowOf9x9Box = x - (x % 3);
            int firstColumnOf9x9Box = y - (y % 3);
            for (int r = firstRowOf9x9Box; r < firstRowOf9x9Box + 3; r++)
            {
                for (int c = firstColumnOf9x9Box; c < firstColumnOf9x9Box + 3; c++)
                {
                    if (r != x && c != y)
                    {
                        if (cells[(r * 9) + c].getPossibleSolutions().Remove(value))
                        {
                            numberOfPossibleSolution[(r * 9) + c]--;
                        }
                    }
                }
            }
            return true;
        }

        public bool isSolved()
        {
            return (numberOfNonSolved == 0);
        }

        private bool isNotValid()
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (numberOfPossibleSolution[(x * 9) + y] == 0 && cells[(x * 9) + y].getValue() == -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private int getNumberOfNonSolved()
        {
            return numberOfNonSolved;
        }

        private int[] getFewestPossibleSolution()
        {
            int[] pos = { -1, -1 };
            int minNumberOfSolution = 10;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (numberOfPossibleSolution[(x * 9) + y] < minNumberOfSolution && numberOfPossibleSolution[(x * 9) + y] != 0)
                    {
                        minNumberOfSolution = numberOfPossibleSolution[(x * 9) + y];
                        pos[0] = x;
                        pos[1] = y;
                    }
                }
            }
            return pos;
        }

        private Grid clone()
        {
            Grid newGrid = new Grid();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    int value = cells[(x * 9) + y].getValue();
                    if (value != -1)
                    {
                        newGrid.addValue(x, y, value, cells[(x * 9) + y].getTime());
                    }
                }
            }
            return newGrid;
        }

        private Grid cloneParallel()
        {
            Grid newGrid = new Grid();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    int value = cells[(x * 9) + y].getValue();
                    if (value != -1)
                    {
                        newGrid.addValueParallel(x, y, value, cells[(x * 9) + y].getTime());
                    }
                }
            }
            return newGrid;
        }

        public Cell[] getCellsSorted()
        {
            Cell[] sortedCells = new Cell[81];
            int i = 0;
            foreach (Cell c in cells)
            {
                sortedCells[i] = c;
                i++;
            }
            Array.Sort(sortedCells, delegate (Cell x, Cell y) { return x.getTime().CompareTo(y.getTime()); });
            return sortedCells;
        }

        public static Grid readFile(String path)
        {
            FileManager file = new FileManager();
            return file.readGrid(path);
        }

        public static Grid solveSerial(Grid grid)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Grid newGrid = backtrackingSerial(grid, 1);
            watch.Stop();
            newGrid.serialTime = watch.ElapsedMilliseconds;
            return newGrid;
        }

        private static Grid backtrackingSerial(Grid grid, int time)
        {
            if (grid.isSolved())
            {
                return grid;
            }
            if (grid.isNotValid())
            {
                return grid;
            }
            else
            {
                int[] pos = grid.getFewestPossibleSolution();
                int[] possibleSolutions = grid.getCell(pos[0], pos[1]).getPossibleSolutions().ToArray();
                int numberOfPossibleSolutions = possibleSolutions.Length;

                Grid newGrid = grid.clone();
                
                for (int i = 0; i < numberOfPossibleSolutions; i++)
                {
                    int num = possibleSolutions[i];
                    newGrid.addValue(pos[0], pos[1], num, time);
                    newGrid = backtrackingSerial(newGrid, time + 1);
                    if (newGrid.isSolved())
                    {
                        break;
                    }
                    else
                    {
                        newGrid = grid.clone();
                    }
                    
                }
                return newGrid;
            }
        }

        public static Grid solveParallel(Grid grid)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] pos = grid.getFewestPossibleSolution();
            int[] possibleSolutions = grid.getCell(pos[0], pos[1]).getPossibleSolutions().ToArray();
            int numberOfPossibleSolutions = possibleSolutions.Length;

            Grid newGrid = grid.cloneParallel();
            Task<Grid>[] tasks = new Task<Grid>[numberOfPossibleSolutions];

            for (int i = 0; i < numberOfPossibleSolutions; i++)
            {
                Console.WriteLine(i);
                int num = possibleSolutions[i];
                newGrid = grid.cloneParallel();
                newGrid.addValue(pos[0], pos[1], num, 1);
                tasks[i] = new Task<Grid>(() => backtrackingParallel(newGrid, 2));
                tasks[i].Start();
            }

            Task.WaitAny(tasks);
           
            for (int i = 0; i < numberOfPossibleSolutions; i++)
            {
                if (tasks[i].Result.isSolved())
                {
                    newGrid =  tasks[i].Result;
                    break;
                }
            }

            watch.Stop();
            newGrid.parallelTime = watch.ElapsedMilliseconds;
            return newGrid;
        }

        private static Grid backtrackingParallel(Grid grid, int time)
        {
            if (grid.isSolved())
            {
                return grid;
            }
            if (grid.isNotValid())
            {
                return grid;
            }
            else
            {
                int[] pos = grid.getFewestPossibleSolution();
                int[] possibleSolutions = grid.getCell(pos[0], pos[1]).getPossibleSolutions().ToArray();
                int numberOfPossibleSolutions = possibleSolutions.Length;

                Grid newGrid = grid.cloneParallel();

                for (int i = 0; i < numberOfPossibleSolutions; i++)
                {
                    int num = possibleSolutions[i];
                    newGrid.addValueParallel(pos[0], pos[1], num, time);
                    newGrid = backtrackingParallel(newGrid, time + 1);
                    if (newGrid.isSolved())
                    {
                        break;
                    }
                    else
                    {
                        newGrid = grid.cloneParallel();
                    }
                    
                }
                return newGrid;
            }
        }
    }
}
