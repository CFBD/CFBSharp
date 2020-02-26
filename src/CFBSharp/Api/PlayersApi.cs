/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.24.5
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using CFBSharp.Client;
using CFBSharp.Model;

namespace CFBSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlayersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get player usage metrics for the season
        /// </summary>
        /// <remarks>
        /// Player usage metrics by season
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>ICollection&lt;PlayerUsage&gt;</returns>
        ICollection<PlayerUsage> GetPlayerUsage (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null);

        /// <summary>
        /// Get player usage metrics for the season
        /// </summary>
        /// <remarks>
        /// Player usage metrics by season
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;PlayerUsage&gt;</returns>
        ApiResponse<ICollection<PlayerUsage>> GetPlayerUsageWithHttpInfo (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null);
        /// <summary>
        /// Search for players
        /// </summary>
        /// <remarks>
        /// Search for players
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>ICollection&lt;PlayerSearchResult&gt;</returns>
        ICollection<PlayerSearchResult> PlayerSearch (string searchTerm, string position = null, string team = null);

        /// <summary>
        /// Search for players
        /// </summary>
        /// <remarks>
        /// Search for players
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;PlayerSearchResult&gt;</returns>
        ApiResponse<ICollection<PlayerSearchResult>> PlayerSearchWithHttpInfo (string searchTerm, string position = null, string team = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get player usage metrics for the season
        /// </summary>
        /// <remarks>
        /// Player usage metrics by season
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>Task of ICollection&lt;PlayerUsage&gt;</returns>
        System.Threading.Tasks.Task<ICollection<PlayerUsage>> GetPlayerUsageAsync (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null);

        /// <summary>
        /// Get player usage metrics for the season
        /// </summary>
        /// <remarks>
        /// Player usage metrics by season
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;PlayerUsage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<PlayerUsage>>> GetPlayerUsageAsyncWithHttpInfo (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null);
        /// <summary>
        /// Search for players
        /// </summary>
        /// <remarks>
        /// Search for players
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>Task of ICollection&lt;PlayerSearchResult&gt;</returns>
        System.Threading.Tasks.Task<ICollection<PlayerSearchResult>> PlayerSearchAsync (string searchTerm, string position = null, string team = null);

        /// <summary>
        /// Search for players
        /// </summary>
        /// <remarks>
        /// Search for players
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;PlayerSearchResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<PlayerSearchResult>>> PlayerSearchAsyncWithHttpInfo (string searchTerm, string position = null, string team = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PlayersApi : IPlayersApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayersApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlayersApi(CFBSharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = CFBSharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CFBSharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CFBSharp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get player usage metrics for the season Player usage metrics by season
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>ICollection&lt;PlayerUsage&gt;</returns>
        public ICollection<PlayerUsage> GetPlayerUsage (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)
        {
             ApiResponse<ICollection<PlayerUsage>> localVarResponse = GetPlayerUsageWithHttpInfo(year, team, conference, position, playerId, excludeGarbageTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get player usage metrics for the season Player usage metrics by season
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;PlayerUsage&gt;</returns>
        public ApiResponse< ICollection<PlayerUsage> > GetPlayerUsageWithHttpInfo (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling PlayersApi->GetPlayerUsage");

            var localVarPath = "./player/usage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter
            if (playerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "playerId", playerId)); // query parameter
            if (excludeGarbageTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeGarbageTime", excludeGarbageTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerUsage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<PlayerUsage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<PlayerUsage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerUsage>)));
        }

        /// <summary>
        /// Get player usage metrics for the season Player usage metrics by season
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>Task of ICollection&lt;PlayerUsage&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<PlayerUsage>> GetPlayerUsageAsync (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)
        {
             ApiResponse<ICollection<PlayerUsage>> localVarResponse = await GetPlayerUsageAsyncWithHttpInfo(year, team, conference, position, playerId, excludeGarbageTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get player usage metrics for the season Player usage metrics by season
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="playerId">Player id filter (optional)</param>
        /// <param name="excludeGarbageTime">Filter to remove garbage time plays from calculations (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;PlayerUsage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<PlayerUsage>>> GetPlayerUsageAsyncWithHttpInfo (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling PlayersApi->GetPlayerUsage");

            var localVarPath = "./player/usage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter
            if (playerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "playerId", playerId)); // query parameter
            if (excludeGarbageTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeGarbageTime", excludeGarbageTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerUsage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<PlayerUsage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<PlayerUsage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerUsage>)));
        }

        /// <summary>
        /// Search for players Search for players
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>ICollection&lt;PlayerSearchResult&gt;</returns>
        public ICollection<PlayerSearchResult> PlayerSearch (string searchTerm, string position = null, string team = null)
        {
             ApiResponse<ICollection<PlayerSearchResult>> localVarResponse = PlayerSearchWithHttpInfo(searchTerm, position, team);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for players Search for players
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;PlayerSearchResult&gt;</returns>
        public ApiResponse< ICollection<PlayerSearchResult> > PlayerSearchWithHttpInfo (string searchTerm, string position = null, string team = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling PlayersApi->PlayerSearch");

            var localVarPath = "./player/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchTerm != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PlayerSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<PlayerSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<PlayerSearchResult>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerSearchResult>)));
        }

        /// <summary>
        /// Search for players Search for players
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>Task of ICollection&lt;PlayerSearchResult&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<PlayerSearchResult>> PlayerSearchAsync (string searchTerm, string position = null, string team = null)
        {
             ApiResponse<ICollection<PlayerSearchResult>> localVarResponse = await PlayerSearchAsyncWithHttpInfo(searchTerm, position, team);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for players Search for players
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Term to search on</param>
        /// <param name="position">Position abbreviation filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;PlayerSearchResult&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<PlayerSearchResult>>> PlayerSearchAsyncWithHttpInfo (string searchTerm, string position = null, string team = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling PlayersApi->PlayerSearch");

            var localVarPath = "./player/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchTerm != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PlayerSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<PlayerSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<PlayerSearchResult>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerSearchResult>)));
        }

    }
}
