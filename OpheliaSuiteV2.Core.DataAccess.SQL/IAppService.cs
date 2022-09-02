using Microsoft.EntityFrameworkCore;

using OpheliaSuiteV2.Core.SSB.Lib.Loggers;

namespace OpheliaSuiteV2.Core.DataAccess.SQL
{
    /// <summary>
    /// Define los atributos y métodos de un servicio de aplicación
    /// </summary>
    public interface IAppService
    {
        #region Properties

        /// <summary>
        /// Contexto de datos
        /// </summary>
        DbContext Context { get; }
        /// <summary>
        /// Obtiene el registrador de eventos
        /// </summary>
        ILogger Logger { get; }

        #endregion
    }
}
