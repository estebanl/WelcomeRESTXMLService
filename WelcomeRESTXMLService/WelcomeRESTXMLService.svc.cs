﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WelcomeRESTXMLService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WelcomeRESTXMLService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WelcomeRESTXMLService.svc o WelcomeRESTXMLService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WelcomeRESTXMLService : IWelcomeRESTXMLService
    {
        public string Welcome(string yourName)
        {
            return string.Format("Welcome to WCF Web Services with REST and XMl, {0}!", yourName);
        }
        /*
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        */
    }
}
