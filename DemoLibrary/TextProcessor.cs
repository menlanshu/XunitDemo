using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class TextProcessor
    {
        private const string ConnStrKey = "filePath";
        /// <summary>
        /// Get full path of file name of current data model
        /// </summary>
        /// <param name="fileName">Data Model csv file name</param>
        /// <returns></returns>
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings[ConnStrKey]}\\{fileName}";
        }

        /// <summary>
        /// Load text in file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<T> ConvertToModel<T>(this List<string> lines)
        {
            //initialize a output List<T>
            List<T> output = new List<T>();

            //Convert each line to T and add it to output list
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                //Use activator to create a instance for generic type
                var temp = Activator.CreateInstance(typeof(T));
                int currentCount = 0;

                foreach (var propInfo in typeof(T).GetProperties().Where(x => x.GetCustomAttributes().Count() == 0))
                {
                    if (propInfo.PropertyType == typeof(int))
                    {
                        propInfo.SetValue(temp, int.Parse(cols[currentCount]));
                    }
                    else if(propInfo.PropertyType == typeof(double))
                    {
                        propInfo.SetValue(temp, double.Parse(cols[currentCount]));
                    }
                    else if (propInfo.PropertyType == typeof(decimal))
                    {
                        propInfo.SetValue(temp, decimal.Parse(cols[currentCount]));
                    }
                    else if (propInfo.PropertyType == typeof(Nullable<int>))
                    {
                        propInfo.SetValue(temp, int.TryParse(cols[currentCount], out int intValue) ? int.Parse(cols[currentCount]) : (int?)null);
                    }
                    else if (propInfo.PropertyType == typeof(Nullable<double>))
                    {
                        propInfo.SetValue(temp, double.TryParse(cols[currentCount], out double intValue) ? double.Parse(cols[currentCount]) : (double?)null);
                    }
                    else if (propInfo.PropertyType == typeof(Nullable<decimal>))
                    {
                        propInfo.SetValue(temp, decimal.TryParse(cols[currentCount], out decimal intValue) ? decimal.Parse(cols[currentCount]) : (decimal?)null);
                    }
                    else
                    {
                        propInfo.SetValue(temp, cols[currentCount]);
                    }
                    currentCount++;
                }

                output.Add((T)temp);
            }

            //return output parameter
            return output;
        }

        /// <summary>
        /// Save list of object to text file
        /// </summary>
        /// <typeparam name="T">Model classes such as PrizeModel, PerosnModel, etc.</typeparam>
        /// <param name="models">A instance of an actual model</param>
        /// <param name="fileName">The file name of corresponding mode</param>
        public static void SaveToFile<T>(this List<T> models, string fileName)
        {
            File.WriteAllLines(fileName.FullFilePath(), models.ConvertModelToCSV());
        }

        // Convert Model to CSV file for saving
        public static List<string> ConvertModelToCSV<T>(this List<T> models)
        {
            List<string> lines = new List<string>();

            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (var model in models)
            {
                StringBuilder currentLine = new StringBuilder();
                foreach (PropertyInfo propInfo in properties.Where(x => x.GetCustomAttributes().Count() == 0))
                {
                    currentLine.Append(propInfo.GetValue(model)).Append(",");
                }
                lines.Add(currentLine.Remove(currentLine.Length - 1, 1).ToString());
            }

            return lines;
        }

    }
}
