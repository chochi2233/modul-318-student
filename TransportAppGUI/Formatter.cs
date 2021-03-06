﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransport
{
    
    class Formatter
    {
        public ITransport transport = new Transport();
        /// <summary>
        /// Splitted den String
        /// </summary>
        /// <param name="value">dieser String wird gesplitted</param>
        /// <param name="sep">die gewünschten separatoren</param>
        /// <returns>string[]</returns>
        public string[] Splitter(string value, char[] sep)
        {
            string[] word = value.Split(sep);
            return word;
        }

        /// <summary>
        /// Formatiert die Zeit zu ShortTime
        /// </summary>
        /// <param name="date">dieser String wird in ein Datum verwandelt und wieder als string zurückgegeben</param>
        /// <returns>string</returns>
        public string Timeformatter(string time)
        {
            DateTime dtFrom = Convert.ToDateTime(time);
            string endtime = dtFrom.ToShortTimeString();
            return endtime;
        }
        /// <summary>
        /// Formatiert das Datum zu ShortDate
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string Dateformatter(string date)
        {
            DateTime dtFrom = Convert.ToDateTime(date);
            string enddate = dtFrom.ToShortDateString();
            return enddate;
        }

        /// <summary>
        /// Sucht die Stationen zusammen, fügt sie in die Combobox und Droppt die Combobox automatisch runter
        /// </summary>
        /// <param name="cb">die ausgewählte Combobox für die Methode</param>
        public void Combosearch(ComboBox cb)
        {
            string cbtext = cb.Text;
            try
            {
                if (cbtext.Length >= 3)
                {
                    Stations stations = new Stations();
                    stations = transport.GetStations(cbtext + ",");
                    cb.Items.Clear();
                    cb.DroppedDown = true;
                    cb.SelectionStart = cb.Text.Length;
                    foreach (Station s in stations.StationList)
                    {
                        cb.Items.Add(s.Name);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zu viele Server Requests");
            }
        }

    }

}
