# CFBSharp.Api.StatsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAdvancedTeamGameStats**](StatsApi.md#getadvancedteamgamestats) | **GET** /stats/game/advanced | Get advanced game team stats
[**GetAdvancedTeamSeasonStats**](StatsApi.md#getadvancedteamseasonstats) | **GET** /stats/season/advanced | Get advanced season team stats
[**GetStatCategories**](StatsApi.md#getstatcategories) | **GET** /stats/categories | Get stat category list
[**GetTeamSeasonStats**](StatsApi.md#getteamseasonstats) | **GET** /stats/season | Get season team stats


<a name="getadvancedteamgamestats"></a>
# **GetAdvancedTeamGameStats**
> ICollection<AdvancedGameStat> GetAdvancedTeamGameStats (int? year = null, int? week = null, string team = null, string opponent = null, bool? excludeGarbageTime = null, string seasonType = null)

Get advanced game team stats

Advanced team game stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetAdvancedTeamGameStatsExample
    {
        public void main()
        {
            var apiInstance = new StatsApi();
            var year = 56;  // int? | Year filter (required if no team specified) (optional) 
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (required if no year specified) (optional) 
            var opponent = opponent_example;  // string | Opponent filter (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular, postseason, or both) (optional) 

            try
            {
                // Get advanced game team stats
                ICollection&lt;AdvancedGameStat&gt; result = apiInstance.GetAdvancedTeamGameStats(year, week, team, opponent, excludeGarbageTime, seasonType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.GetAdvancedTeamGameStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter (required if no team specified) | [optional] 
 **week** | **int?**| Week filter | [optional] 
 **team** | **string**| Team filter (required if no year specified) | [optional] 
 **opponent** | **string**| Opponent filter | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 
 **seasonType** | **string**| Season type filter (regular, postseason, or both) | [optional] 

### Return type

[**ICollection<AdvancedGameStat>**](AdvancedGameStat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadvancedteamseasonstats"></a>
# **GetAdvancedTeamSeasonStats**
> ICollection<AdvancedSeasonStat> GetAdvancedTeamSeasonStats (int? year = null, string team = null, bool? excludeGarbageTime = null, int? startWeek = null, int? endWeek = null)

Get advanced season team stats

Advanced team season stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetAdvancedTeamSeasonStatsExample
    {
        public void main()
        {
            var apiInstance = new StatsApi();
            var year = 56;  // int? | Year filter (required if no team specified) (optional) 
            var team = team_example;  // string | Team filter (required if no year specified) (optional) 
            var excludeGarbageTime = true;  // bool? | Filter to remove garbage time plays from calculations (optional) 
            var startWeek = 56;  // int? | Starting week filter (optional) 
            var endWeek = 56;  // int? | Starting week filter (optional) 

            try
            {
                // Get advanced season team stats
                ICollection&lt;AdvancedSeasonStat&gt; result = apiInstance.GetAdvancedTeamSeasonStats(year, team, excludeGarbageTime, startWeek, endWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.GetAdvancedTeamSeasonStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter (required if no team specified) | [optional] 
 **team** | **string**| Team filter (required if no year specified) | [optional] 
 **excludeGarbageTime** | **bool?**| Filter to remove garbage time plays from calculations | [optional] 
 **startWeek** | **int?**| Starting week filter | [optional] 
 **endWeek** | **int?**| Starting week filter | [optional] 

### Return type

[**ICollection<AdvancedSeasonStat>**](AdvancedSeasonStat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatcategories"></a>
# **GetStatCategories**
> ICollection<string> GetStatCategories ()

Get stat category list

Stat category list

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetStatCategoriesExample
    {
        public void main()
        {
            var apiInstance = new StatsApi();

            try
            {
                // Get stat category list
                ICollection&lt;string&gt; result = apiInstance.GetStatCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.GetStatCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ICollection<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamseasonstats"></a>
# **GetTeamSeasonStats**
> ICollection<TeamSeasonStat> GetTeamSeasonStats (int? year = null, string team = null, string conference = null, int? startWeek = null, int? endWeek = null)

Get season team stats

Team season stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamSeasonStatsExample
    {
        public void main()
        {
            var apiInstance = new StatsApi();
            var year = 56;  // int? | Year filter (required if no team specified) (optional) 
            var team = team_example;  // string | Team filter (required if no year specified) (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var startWeek = 56;  // int? | Starting week filter (optional) 
            var endWeek = 56;  // int? | Starting week filter (optional) 

            try
            {
                // Get season team stats
                ICollection&lt;TeamSeasonStat&gt; result = apiInstance.GetTeamSeasonStats(year, team, conference, startWeek, endWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.GetTeamSeasonStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter (required if no team specified) | [optional] 
 **team** | **string**| Team filter (required if no year specified) | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **startWeek** | **int?**| Starting week filter | [optional] 
 **endWeek** | **int?**| Starting week filter | [optional] 

### Return type

[**ICollection<TeamSeasonStat>**](TeamSeasonStat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

