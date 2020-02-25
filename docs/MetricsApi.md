# CFBSharp.Api.MetricsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGamePPA**](MetricsApi.md#getgameppa) | **GET** /ppa/games | Get team game averages for Predicted Points Added (PPA)
[**GetPlayerGamePPA**](MetricsApi.md#getplayergameppa) | **GET** /ppa/players/games | Get player game averages for Predicted Points Added (PPA)
[**GetPlayerSeasonPPA**](MetricsApi.md#getplayerseasonppa) | **GET** /ppa/players/season | Get player season averages for Predicted Points Added (PPA)
[**GetPredictedPoints**](MetricsApi.md#getpredictedpoints) | **GET** /ppa/predicted | Calculate Predicted Points
[**GetPregameWinProbabilities**](MetricsApi.md#getpregamewinprobabilities) | **GET** /metrics/wp/pregame | Get pregame win probabilities
[**GetTeamPPA**](MetricsApi.md#getteamppa) | **GET** /ppa/teams | Get team averages for Predicted Points Added (PPA)
[**GetWinProbabilityData**](MetricsApi.md#getwinprobabilitydata) | **GET** /metrics/wp | Get win probability chart data


<a name="getgameppa"></a>
# **GetGamePPA**
> ICollection<GamePPA> GetGamePPA (int? year, int? week = null, string team = null, string conference = null, bool? excludeGarbageTime = null)

Get team game averages for Predicted Points Added (PPA)

Predicted Points Added (PPA) by game

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetGamePPAExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var year = 56;  // int? | Year filter
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Get team game averages for Predicted Points Added (PPA)
                ICollection&lt;GamePPA&gt; result = apiInstance.GetGamePPA(year, week, team, conference, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetGamePPA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 
 **week** | **int?**| Week filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<GamePPA>**](GamePPA.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayergameppa"></a>
# **GetPlayerGamePPA**
> ICollection<PlayerGamePPA> GetPlayerGamePPA (int? year = null, int? week = null, string team = null, string position = null, int? playerId = null, string threshold = null, bool? excludeGarbageTime = null)

Get player game averages for Predicted Points Added (PPA)

Predicted Points Added (PPA) by player game

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerGamePPAExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var year = 56;  // int? | Year filter (optional) 
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var playerId = 56;  // int? | Player id filter (optional) 
            var threshold = threshold_example;  // string | Minimum play threshold filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Get player game averages for Predicted Points Added (PPA)
                ICollection&lt;PlayerGamePPA&gt; result = apiInstance.GetPlayerGamePPA(year, week, team, position, playerId, threshold, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPlayerGamePPA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **week** | **int?**| Week filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **position** | **string**| Position abbreviation filter | [optional] 
 **playerId** | **int?**| Player id filter | [optional] 
 **threshold** | **string**| Minimum play threshold filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<PlayerGamePPA>**](PlayerGamePPA.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayerseasonppa"></a>
# **GetPlayerSeasonPPA**
> ICollection<PlayerSeasonPPA> GetPlayerSeasonPPA (int? year = null, string team = null, string conference = null, string position = null, int? playerId = null, string threshold = null, bool? excludeGarbageTime = null)

Get player season averages for Predicted Points Added (PPA)

Predicted Points Added (PPA) by player season

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerSeasonPPAExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var year = 56;  // int? | Year filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var playerId = 56;  // int? | Player id filter (optional) 
            var threshold = threshold_example;  // string | Minimum play threshold filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Get player season averages for Predicted Points Added (PPA)
                ICollection&lt;PlayerSeasonPPA&gt; result = apiInstance.GetPlayerSeasonPPA(year, team, conference, position, playerId, threshold, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPlayerSeasonPPA: " + e.Message );
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
 **position** | **string**| Position abbreviation filter | [optional] 
 **playerId** | **int?**| Player id filter | [optional] 
 **threshold** | **string**| Minimum play threshold filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<PlayerSeasonPPA>**](PlayerSeasonPPA.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpredictedpoints"></a>
# **GetPredictedPoints**
> ICollection<PredictedPoints> GetPredictedPoints (int? down, int? distance)

Calculate Predicted Points

Predicted Points

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPredictedPointsExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var down = 56;  // int? | Down filter
            var distance = 56;  // int? | Distance filter

            try
            {
                // Calculate Predicted Points
                ICollection&lt;PredictedPoints&gt; result = apiInstance.GetPredictedPoints(down, distance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPredictedPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **down** | **int?**| Down filter | 
 **distance** | **int?**| Distance filter | 

### Return type

[**ICollection<PredictedPoints>**](PredictedPoints.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpregamewinprobabilities"></a>
# **GetPregameWinProbabilities**
> ICollection<PregameWP> GetPregameWinProbabilities (int? year = null, int? week = null, string team = null, string seasonType = null)

Get pregame win probabilities

Pregame win probabilities

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPregameWinProbabilitiesExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var year = 56;  // int? | Year filter (optional) 
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var seasonType = seasonType_example;  // string | regular or postseason (optional) 

            try
            {
                // Get pregame win probabilities
                ICollection&lt;PregameWP&gt; result = apiInstance.GetPregameWinProbabilities(year, week, team, seasonType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetPregameWinProbabilities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **week** | **int?**| Week filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **seasonType** | **string**| regular or postseason | [optional] 

### Return type

[**ICollection<PregameWP>**](PregameWP.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamppa"></a>
# **GetTeamPPA**
> ICollection<TeamPPA> GetTeamPPA (int? year = null, string team = null, string conference = null, bool? excludeGarbageTime = null)

Get team averages for Predicted Points Added (PPA)

Predicted Points Added (PPA)

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamPPAExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var year = 56;  // int? | Year filter (required if team not specified) (optional) 
            var team = team_example;  // string | Team filter (required if year not specified) (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 

            try
            {
                // Get team averages for Predicted Points Added (PPA)
                ICollection&lt;TeamPPA&gt; result = apiInstance.GetTeamPPA(year, team, conference, excludeGarbageTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetTeamPPA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter (required if team not specified) | [optional] 
 **team** | **string**| Team filter (required if year not specified) | [optional] 
 **conference** | **string**| Conference filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 

### Return type

[**ICollection<TeamPPA>**](TeamPPA.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwinprobabilitydata"></a>
# **GetWinProbabilityData**
> ICollection<PlayWP> GetWinProbabilityData (int? gameId, bool? adjustForSpread = null)

Get win probability chart data

Win probability data

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetWinProbabilityDataExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var gameId = 56;  // int? | Game id filter
            var adjustForSpread = true;  // bool? | Toggles pregame spread adjustments (optional)  (default to true)

            try
            {
                // Get win probability chart data
                ICollection&lt;PlayWP&gt; result = apiInstance.GetWinProbabilityData(gameId, adjustForSpread);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetWinProbabilityData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gameId** | **int?**| Game id filter | 
 **adjustForSpread** | **bool?**| Toggles pregame spread adjustments | [optional] [default to true]

### Return type

[**ICollection<PlayWP>**](PlayWP.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

