# CFBSharp.Api.PlayersApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlayerSeasonStats**](PlayersApi.md#getplayerseasonstats) | **GET** /stats/player/season | Player stats by season
[**GetPlayerUsage**](PlayersApi.md#getplayerusage) | **GET** /player/usage | Player usage metrics broken down by season
[**GetReturningProduction**](PlayersApi.md#getreturningproduction) | **GET** /player/returning | Team returning production metrics
[**PlayerSearch**](PlayersApi.md#playersearch) | **GET** /player/search | Search for player information


<a name="getplayerseasonstats"></a>
# **GetPlayerSeasonStats**
> ICollection<PlayerSeasonStat> GetPlayerSeasonStats (int? year, string team = null, string conference = null, int? startWeek = null, int? endWeek = null, string seasonType = null, string category = null)

Player stats by season

Season player stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerSeasonStatsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new PlayersApi();
            var year = 56;  // int? | Year filter
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var startWeek = 56;  // int? | Start week filter (optional) 
            var endWeek = 56;  // int? | Start week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular, postseason, or both) (optional) 
            var category = category_example;  // string | Stat category filter (e.g. passing) (optional) 

            try
            {
                // Player stats by season
                ICollection&lt;PlayerSeasonStat&gt; result = apiInstance.GetPlayerSeasonStats(year, team, conference, startWeek, endWeek, seasonType, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayerSeasonStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **startWeek** | **int?**| Start week filter | [optional] 
 **endWeek** | **int?**| Start week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular, postseason, or both) | [optional] 
 **category** | **string**| Stat category filter (e.g. passing) | [optional] 

### Return type

[**ICollection<PlayerSeasonStat>**](PlayerSeasonStat.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayerusage"></a>
# **GetPlayerUsage**
> ICollection<PlayerUsage> GetPlayerUsage (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)

Player usage metrics broken down by season

Player usage metrics by season

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerUsageExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new PlayersApi();
            var year = 56;  // int? | Year filter (default to 2020)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var playerId = 56;  // int? | Player id filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Player usage metrics broken down by season
                ICollection&lt;PlayerUsage&gt; result = apiInstance.GetPlayerUsage(year, team, conference, position, playerId, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayerUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [default to 2020]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **position** | **string**| Position abbreviation filter | [optional] 
 **playerId** | **int?**| Player id filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<PlayerUsage>**](PlayerUsage.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturningproduction"></a>
# **GetReturningProduction**
> ICollection<ReturningProduction> GetReturningProduction (int? year = null, string team = null, string conference = null)

Team returning production metrics

Returning production metrics

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetReturningProductionExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new PlayersApi();
            var year = 56;  // int? | Year filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Team returning production metrics
                ICollection&lt;ReturningProduction&gt; result = apiInstance.GetReturningProduction(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayersApi.GetReturningProduction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 

### Return type

[**ICollection<ReturningProduction>**](ReturningProduction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playersearch"></a>
# **PlayerSearch**
> ICollection<PlayerSearchResult> PlayerSearch (string searchTerm, string position = null, string team = null, int? year = null)

Search for player information

Search for players

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class PlayerSearchExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new PlayersApi();
            var searchTerm = searchTerm_example;  // string | Term to search on
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // Search for player information
                ICollection&lt;PlayerSearchResult&gt; result = apiInstance.PlayerSearch(searchTerm, position, team, year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayersApi.PlayerSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**| Term to search on | 
 **position** | **string**| Position abbreviation filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **year** | **int?**| Year filter | [optional] 

### Return type

[**ICollection<PlayerSearchResult>**](PlayerSearchResult.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

