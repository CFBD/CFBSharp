# CFBSharp.Api.PlayersApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlayerUsage**](PlayersApi.md#getplayerusage) | **GET** /player/usage | Get player usage metrics for the season
[**GetReturningProduction**](PlayersApi.md#getreturningproduction) | **GET** /player/returning | Get returning production metrics
[**PlayerSearch**](PlayersApi.md#playersearch) | **GET** /player/search | Search for players


<a name="getplayerusage"></a>
# **GetPlayerUsage**
> ICollection<PlayerUsage> GetPlayerUsage (int? year, string team = null, string conference = null, string position = null, int? playerId = null, bool? excludeGarbageTime = null)

Get player usage metrics for the season

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
            var apiInstance = new PlayersApi();
            var year = 56;  // int? | Year filter (default to 2019)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var playerId = 56;  // int? | Player id filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Get player usage metrics for the season
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
 **year** | **int?**| Year filter | [default to 2019]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **position** | **string**| Position abbreviation filter | [optional] 
 **playerId** | **int?**| Player id filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<PlayerUsage>**](PlayerUsage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturningproduction"></a>
# **GetReturningProduction**
> ICollection<ReturningProduction> GetReturningProduction (int? year = null, string team = null, string conference = null)

Get returning production metrics

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
            var apiInstance = new PlayersApi();
            var year = 56;  // int? | Year filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Get returning production metrics
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playersearch"></a>
# **PlayerSearch**
> ICollection<PlayerSearchResult> PlayerSearch (string searchTerm, string position = null, string team = null, int? year = null)

Search for players

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
            var apiInstance = new PlayersApi();
            var searchTerm = searchTerm_example;  // string | Term to search on
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // Search for players
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

