﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace WebService
{
    public class DistanceManager
    {
        private static DistanceManager instance;

        private DistanceManager() { }

        public static DistanceManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DistanceManager();
                }
                return instance;
            }
        }
        public double DistanceInKmBetween(string departurePoint, string destination)
        {
            using (WebClient wc = new WebClient())
            {
                string url = wc.DownloadString(@"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
                                               departurePoint + "&destinations=" + destination +
                                               "&mode=driving&sensor=false&language=en-EN&units=km"
                                               );

                XDocument xmldoc = XDocument.Parse(url);

                Console.WriteLine(xmldoc.ToString());

                if (xmldoc.Root.Element("row").Element("element").Element("status").Value == "OK")
                {
                    string metersString = xmldoc.Root.Element("row").Element("element").Element("distance").Element("value").Value;
                    double km = (Convert.ToDouble(metersString) / 1000);
                    return km;
                }
                return 0;
            }
        }
    }
}
