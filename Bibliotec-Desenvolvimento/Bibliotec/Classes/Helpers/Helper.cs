using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Helpers
{
    internal class Helper
    {
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
    }
}
