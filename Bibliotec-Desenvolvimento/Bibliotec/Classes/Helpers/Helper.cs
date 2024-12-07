﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Helpers
{
    internal class Helper
    {
        static string workingDirectory = Environment.CurrentDirectory;
        public static string ConverterData(string data)
        {
            if (string.IsNullOrWhiteSpace(data) || data == "__/__/____")
            {
                return null;
            }

            DateTime dataConvertida;
            bool sucesso = DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvertida);

            if (sucesso)
            {
                return dataConvertida.ToString("yyyy-MM-dd");
            }
            else
            {
                return null;
            }
        }

        public static void disableField(TextBox txtBox)
        {
            txtBox.BackColor = Color.DarkGray;
            txtBox.Enabled = false;
        }

        public static void enableField(TextBox txtBox)
        {
            txtBox.BackColor = Color.White;
            txtBox.Enabled = true;
        }

        public static string GetExecutablePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static string GetAssetPath(string assetName)
        {
            string assetsFolder = Path.Combine(GetExecutablePath(), "Assets");
            return Path.Combine(assetsFolder, assetName);
        }
    }
}