using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DatBase_Conected
{
    /// <summary>
    /// Структура для получения введённых пользователем данных 
    /// для вставки и изменения в таблице VEHICLE
    /// </summary>
    public struct VehDataStruct
    {
        public bool correct;
        public string veh_id;
        public string box_id;
        public string plate;
        public string mileage;
        public string last_month_cost;
        public string full_cost;
        public string start_date_of_use;
        /// <summary>
        /// Очищение полей структуры
        /// </summary>
        public void Clear()
        {
            correct = false;
            veh_id = "";
            box_id = "";
            plate = "";
            mileage = "";
            last_month_cost = "";
            full_cost = "";
            start_date_of_use = "";
        }
    }

    /// <summary>
    /// Структура для получения введённых пользователем данных 
    /// для вставки и изменения в таблице REPAIRS
    /// </summary>
    public struct RepDataStruct
    {
        public bool correct;
        public string repair_id;
        public string crew_id;
        public string vehicle_id;
        public string repair_cost;
        /// <summary>
        /// Очищение полей структуры
        /// </summary>
        public void Clear()
        {
            correct = false;
            repair_id = "";
            crew_id = "";
            vehicle_id = "";
            repair_cost = "";
        }
    }

    /// <summary>
    /// Структура для получения введённых пользователем данных 
    /// для вставки и изменения в таблице PATHS
    /// </summary>
    public struct PathDataStruct
    {
        public bool correct;
        public string path_id;
        public string passangers;
        public string[] pointList;
        /// <summary>
        /// Очищение полей структуры
        /// </summary>
        public void Clear()
        {
            correct = false;
            path_id = "";
            passangers = "";
            pointList = new string[0];
        }
    }

    /// <summary>
    /// Класс с полезными функциями для работы с БД
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Возвращение строки или NULL, если строка пустая
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringOrNull(string str)
        {
            return (str == "") ? "NULL" : str;
        }

        /// <summary>
        /// Заменяет запятую в строке на точку
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceComaToDot(string str)
        {
            return Regex.Replace(str, @",", ".");
        }
    }
}
