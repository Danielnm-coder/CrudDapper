using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Settings
{
    /// <summary>
    /// Classe para congigurar parametros ultilizados pelo projeto
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Propriedades para retornar a string de conexão do bando de dados 
        /// </summary>
        public static string ConnectionString
        {
            get {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDAula03;Integrated Security=True";
            }

        }
    }
}
