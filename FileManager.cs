using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FileManager
    {
        public Grid readGrid(String path)
        {
            Grid grid = new Grid();
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string ln;
                    int x = 0;
                    while ((ln = file.ReadLine()) != null)
                    {
                        int y = 0;
                        foreach (char ch in ln)
                        {
                            if (!ch.Equals('*'))
                            {
                                int value = ch - '0';
                                if (x < 9 && y < 9)
                                {
                                    grid.addValue(x, y, value, 0);
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            y++;
                        }
                        x++;
                    }
                    file.Close();
                }
                return grid;
            }
            else
            {
                return null;
            }

        }
    }
}
