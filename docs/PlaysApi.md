# CFBSharp.Api.PlaysApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlayStatTypes**](PlaysApi.md#getplaystattypes) | **GET** /play/stat/types | Get play stat type lists
[**GetPlayStats**](PlaysApi.md#getplaystats) | **GET** /play/stats | Get play statistics
[**GetPlayTypes**](PlaysApi.md#getplaytypes) | **GET** /play/types | Get play type list
[**GetPlays**](PlaysApi.md#getplays) | **GET** /plays | Get play information. Requires either a week or team to be specified.


<a name="getplaystattypes"></a>
# **GetPlayStatTypes**
> ICollection<PlayStatType> GetPlayStatTypes ()

Get play stat type lists

Type of play stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayStatTypesExample
    {
        public void main()
        {
            var apiInstance = new PlaysApi();

            try
            {
                // Get play stat type lists
                ICollection&lt;PlayStatType&gt; result = apiInstance.GetPlayStatTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayStatTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<PlayStatType>**](PlayStatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplaystats"></a>
# **GetPlayStats**
> ICollection<PlayStat> GetPlayStats (int? year = null, int? week = null, string team = null, int? gameId = null, int? athleteId = null, int? statTypeId = null, string seasonType = null)

Get play statistics

Gets player stats associated by play (limit 1000)

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayStatsExample
    {
        public void main()
        {
            var apiInstance = new PlaysApi();
            var year = 56;  // int? | Year filter (optional) 
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var gameId = 56;  // int? | gameId filter (from /games endpoint) (optional) 
            var athleteId = 56;  // int? | athleteId filter (from /roster endpoint) (optional) 
            var statTypeId = 56;  // int? | statTypeId filter (from /play/stat/types endpoint) (optional) 
            var seasonType = seasonType_example;  // string | regular, postseason, or both (optional) 

            try
            {
                // Get play statistics
                ICollection&lt;PlayStat&gt; result = apiInstance.GetPlayStats(year, week, team, gameId, athleteId, statTypeId, seasonType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayStats: " + e.Message );
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
 **gameId** | **int?**| gameId filter (from /games endpoint) | [optional] 
 **athleteId** | **int?**| athleteId filter (from /roster endpoint) | [optional] 
 **statTypeId** | **int?**| statTypeId filter (from /play/stat/types endpoint) | [optional] 
 **seasonType** | **string**| regular, postseason, or both | [optional] 

### Return type

[**ICollection<PlayStat>**](PlayStat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplaytypes"></a>
# **GetPlayTypes**
> ICollection<PlayType> GetPlayTypes ()

Get play type list

Types of plays

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayTypesExample
    {
        public void main()
        {
            var apiInstance = new PlaysApi();

            try
            {
                // Get play type list
                ICollection&lt;PlayType&gt; result = apiInstance.GetPlayTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlayTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<PlayType>**](PlayType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplays"></a>
# **GetPlays**
> ICollection<Play> GetPlays (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null, int? playType = null)

Get play information. Requires either a week or team to be specified.

Play results

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlaysExample
    {
        public void main()
        {
            var apiInstance = new PlaysApi();
            var year = 56;  // int? | Year filter
            var seasonType = seasonType_example;  // string | Season type filter (optional)  (default to regular)
            var week = 56;  // int? | Week filter (required if team, offense, or defense, not specified) (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var offense = offense_example;  // string | Offensive team filter (optional) 
            var defense = defense_example;  // string | Defensive team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 
            var offenseConference = offenseConference_example;  // string | Offensive conference filter (optional) 
            var defenseConference = defenseConference_example;  // string | Defensive conference filter (optional) 
            var playType = 56;  // int? | Play type filter (optional) 

            try
            {
                // Get play information. Requires either a week or team to be specified.
                ICollection&lt;Play&gt; result = apiInstance.GetPlays(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference, playType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaysApi.GetPlays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 
 **seasonType** | **string**| Season type filter | [optional] [default to regular]
 **week** | **int?**| Week filter (required if team, offense, or defense, not specified) | [optional] 
 **team** | **string**| Team filter | [optional] 
 **offense** | **string**| Offensive team filter | [optional] 
 **defense** | **string**| Defensive team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 
 **offenseConference** | **string**| Offensive conference filter | [optional] 
 **defenseConference** | **string**| Defensive conference filter | [optional] 
 **playType** | **int?**| Play type filter | [optional] 

### Return type

[**ICollection<Play>**](Play.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

