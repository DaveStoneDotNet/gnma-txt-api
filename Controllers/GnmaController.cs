using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using Cooper.Gnma.Text.Models;
using Cooper.Gnma.Text.Models.Requests;
using Cooper.Gnma.Text.Models.Responses;
using Cooper.Gnma.Text.DataAccess;

namespace Cooper.Gnma.Text.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class GnmaController : Controller
    {
        private IOptions<AppSettings> appSettings;
        private FileDataAccess fileDataAccess;

        public GnmaController(IOptions<AppSettings> appSettings)
        {
            this.appSettings = appSettings;
            this.fileDataAccess = new FileDataAccess();
        }

        #region GetData
        /// <summary>
        /// http://localhost:5000/api/gnma/GetData
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]"), Route("gnma/GetData")]
        public async Task<String> GetData()
        {
            return await Task.Run(() => $"{DateTime.Now.ToLongTimeString()} : 10 SECOND DELAYED SERVER DATA WITH MONKIES" );
        }
        #endregion GetData

        #region GetLookups
        /// <summary>
        /// http://localhost:5000/api/gnma/GetLookups
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]"), Route("gnma/GetLookups")]
        public async Task<String> GetLookups()
        {
            return await Task.Run(() => "LOOKUP DATA");
        }
        #endregion GetLookups

        #region GetConfig
        /// <summary>
        /// http://localhost:5000/api/gnma/GetConfig
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]"), Route("gnma/GetConfig")]
        public async Task<String> GetConfig()
        {
            return await Task.Run(() => "CONFIG DATA");
        }
        #endregion GetConfig

        #region GetUser
        /// <summary>
        /// http://localhost:5000/api/gnma/GetUser
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]"), Route("gnma/GetUser")]
        public async Task<String> GetUser()
        {
            return await Task.Run(() => "USER DATA");
        }
        #endregion GetUser

        // ---------------------------------------------------------------------------------------------------

        // POST api/gnmaGetFileInfos
        [HttpPost("[action]")]
        [Route("Gnma/GetFileInfos")]
        public async Task<FileInfoResponse> GetFileInfos([FromBody]FileInfoRequest request)
        {
            request.Path = this.appSettings.Value.GnmaTextFilePath;
            return await this.fileDataAccess.GetFileInfosAsync(request);
        }

        // POST api/gnmaGetGnmaTextFile
        [HttpPost("[action]")]
        [Route("Gnma/GetGnmaTextFile")]
        public async Task<GnmaTextFileResponse> GetGnmaTextFile([FromBody]FileInfoRequest request)
        {
            return await this.fileDataAccess.GetGnmaTextFileAsync(request);
        }

        // POST api/gnmaSaveGnmaTextFile
        [HttpPost("[action]")]
        [Route("Gnma/SaveGnmaTextFile")]
        public async Task<GnmaTextFileResponse> SaveGnmaTextFile([FromBody]SaveGnmaTextFileRequest request)
        {
            return await this.fileDataAccess.SaveGnmaTextFileAsync(request);
        }

        // GET api/gnmaGetFileShareLocation
        [HttpGet("[action]")]
        [Route("Gnma/GetFileShareLocation")]
        public async Task<FileShareLocationResponse> GetFileShareLocation()
        {
            return await Task.Run(() => new FileShareLocationResponse { Path = this.appSettings.Value.GnmaTextFilePath });
        }

        // GET api/gnmaGetPoolRecordLayouts
        [HttpGet("[action]")]
        [Route("Gnma/GetPoolRecordLayouts")]
        public async Task<PoolRecordLayoutsResponse> GetPoolRecordLayouts()
        {
            return await this.fileDataAccess.GetPoolRecordLayoutsAsync();
        }
    }
}
