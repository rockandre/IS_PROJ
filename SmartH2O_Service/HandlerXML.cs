﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace SmartH2O_Service
{
    class HandlerXML
    {
        public string XmlFilePath { get; set; }
        public string XsdFilePath { get; set; }

        private bool isValid = true;
        public string validationMessage { get; set; }

        public HandlerXML(string xmlfile)
        {
            this.XmlFilePath = xmlfile;
        }

        public HandlerXML(string xmlfile, string xsdfile)
        {
            this.XmlFilePath = xmlfile;
            this.XsdFilePath = xsdfile;
        }


        public string readPath(string title, string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);
            XmlNodeList nos = doc.SelectNodes(path);


            return doc.OuterXml;
        }

        public bool ValidateXml()
        {
            validationMessage = "Document valid! ";
            isValid = true;

            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(XmlFilePath);
                ValidationEventHandler eventH = new ValidationEventHandler(MyEvent);
                doc.Schemas.Add(null, XsdFilePath);
                doc.Validate(eventH);
            }
            catch (XmlException ex)
            {
                isValid = false;
                validationMessage = "Invalid document! " + ex.ToString();
            }

            return isValid;
        }

        private void MyEvent(object sender, ValidationEventArgs e)
        {
            isValid = false;
            validationMessage = "Invalid document: " + e.Message;
        }



        public void GetInformationByHour(string date, string hour)
        {
            List<string> lista = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            XmlNodeList nos = doc.SelectNodes("/quality-parameters/PH/value");
            foreach (XmlNode item in nos)
            {
                Console.Write(item.InnerText);
            }

          
        }
        

    }
}
