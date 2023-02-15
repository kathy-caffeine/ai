using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnealingSimulation
{
    public class Annealing
    {
        private string filePath = "";
        private List<int> currentOrder = new List<int>();
        private List<int> nextOrder = new List<int>();
        private double[,] distances;
        private Random random = new Random();
        private double shortestDistance = 0;
        public double temperature = 10000.0;
        public double coolingRate = 0.9999;
        public double absoluteTemperature = 0.00001;
        public bool crunch = true;

        public double ShortestDistance
        {
            get
            {
                return shortestDistance;
            }
            set
            {
                shortestDistance = value;
            }
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        public List<int> CitiesOrder
        {
            get
            {
                return currentOrder;
            }
            set
            {
                currentOrder = value;
            }
        }

        /// <summary>
        /// Load cities from the text file representing the adjacency matrix
        /// </summary>
        private void LoadCities()
        {
            try
            {
                if (filePath != "")
                {
                    StreamReader reader = new StreamReader(filePath);
                    string cities = reader.ReadToEnd();
                    reader.Close();
                    string[] rows = cities.Split('\n');
                    distances = new double[rows.Length, rows.Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] distance = rows[i].Split(' ');
                        for (int j = 0; j < distance.Length; j++)
                        {
                            distances[i, j] = double.Parse(distance[j]);
                        }
                        currentOrder.Add(i);
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать файл.");
                    crunch = false;
                }
            }

            catch (IOException)
            {
                MessageBox.Show("Проблема чтения файла.");
                crunch = false;
            }
            catch(FormatException) 
            {
                MessageBox.Show("Ошибка в записи графа.");
                crunch = false;
            }

            if (currentOrder.Count < 1)
            {
                crunch = false;
            }
        }

        /// <summary>
        /// Calculate the total distance which is the objective function
        /// </summary>
        /// <param name="order">A list containing the order of cities</param>
        /// <returns></returns>
        private double GetTotalDistance(List<int> order)
        {
            double distance = 0;

            for (int i = 0; i < order.Count - 1; i++)
            {
                distance += distances[order[i], order[i + 1]];
            }

            if (order.Count > 0)
            {
                distance += distances[order[order.Count - 1], 0];
            }

            return distance;
        }

        /// <summary>
        /// Get the next random arrangements of cities
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private List<int> GetNextArrangement(List<int> order)
        {
            List<int> newOrder = new List<int>();

            for (int i = 0; i < order.Count; i++)
                newOrder.Add(order[i]);

            //we will only rearrange two cities by random
            //starting point should be always zero - so zero should not be included

            int firstRandomCityIndex = random.Next(1, newOrder.Count);
            int secondRandomCityIndex = random.Next(1, newOrder.Count);

            int dummy = newOrder[firstRandomCityIndex];
            newOrder[firstRandomCityIndex] = newOrder[secondRandomCityIndex];
            newOrder[secondRandomCityIndex] = dummy;

            return newOrder;
        }

        /// <summary>
        /// Annealing Process
        /// </summary>
        public void Anneal()
        {
            int iteration = -1;
            LoadCities();
            if (crunch)
            {
                double distance = GetTotalDistance(currentOrder);

                while (temperature > absoluteTemperature)
                {
                    nextOrder = GetNextArrangement(currentOrder);

                    double deltaDistance = GetTotalDistance(nextOrder) - distance;

                    //if the new order has a smaller distance
                    //or if the new order has a larger distance but satisfies Boltzman condition then accept the arrangement
                    if ((deltaDistance < 0) || 
                        (distance > 0 && Math.Exp(-deltaDistance / temperature) > random.NextDouble()))
                    {
                        for (int i = 0; i < nextOrder.Count; i++)
                            currentOrder[i] = nextOrder[i];

                        distance = deltaDistance + distance;
                    }

                    //cool down the temperature
                    temperature *= coolingRate;

                    iteration++;
                }

                shortestDistance = distance;
            }
        }

        public void reset()
        {
            currentOrder = new List<int>();
            nextOrder = new List<int>();
            shortestDistance = 0;
            temperature = 10000.0;
            coolingRate = 0.9999;
            absoluteTemperature = 0.00001;
            crunch = true;
        }
    }
}
