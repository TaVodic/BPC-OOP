using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class TempArch
    {
        private List<YearTemp> _archive;

        public TempArch(List<YearTemp> YT)
        {
            _archive = YT;
        }

        public void Save(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (YearTemp temp in _archive)
                {
                    sw.Write(temp.year.ToString() + ": ");
                    foreach (double mt in temp.monthTemp)
                    {
                        sw.Write(mt.ToString() + "; ");
                    }
                    sw.Write('\n');
                }
            }

        }

        public void Load(string path)
        {
            _archive.Clear();
            StreamReader fileToRead = File.OpenText(path);

            string line;
            while ((line = fileToRead.ReadLine()) != null)
            {
                var numbers = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var year = Convert.ToInt16(numbers[0].Trim(':'));
                var temps = new List<double>();
                foreach (var number in numbers.Skip(1))
                {
                    var i = Convert.ToDouble(number.Trim(';').Trim('\n'));
                    //Console.WriteLine(i);                    
                    temps.Add(i);
                }

                var yearTemp = new YearTemp(temps, year);
                _archive.Add(yearTemp);
            }

            fileToRead.Close();
        }

        public void Calibration(double _const)
        {
            foreach (YearTemp temp in _archive)
            {
                for (int i = 0; i < temp.monthTemp.Count; i++)
                {
                    temp.monthTemp[i] += _const;
                }                
            }
        }

        public YearTemp Find(int year)
        {
            foreach (YearTemp temp in _archive)
            {
                if (temp.year == year)
                {
                    return temp;
                }
            }
            return null;
        }

        public void PrintTemp()
        {
            foreach (YearTemp yt in _archive)
            {
                Console.Write(yt.year + ": ");
                foreach (double mt in yt.monthTemp)
                {
                    Console.Write(mt + "; ");
                }
                Console.WriteLine();
            }
        }

        public void PrintAvgTemp()
        {
            foreach (YearTemp yt in _archive)
            {
                Console.Write(yt.year + ": ");

                Console.Write(yt.GetAvgTemp());

                Console.WriteLine();
            }
        }

        public void PrintAvgMonth()
        {
            double[] doubles = new double[8];
            foreach (YearTemp yt in _archive)
            {
                for (int i = 0; i < yt.monthTemp.Count; i++)
                {
                    doubles[i] += yt.monthTemp[i];
                }
            }

            Console.Write("Avg temp: ");
            foreach (var db in doubles)
            {
                Console.Write((db/_archive.Count) + "; ");
            }
        }
    }
}
