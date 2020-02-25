# CFBSharp.Api.BettingApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLines**](BettingApi.md#getlines) | **GET** /lines | Get betting line information


<a name="getlines"></a>
# **GetLines**
> ICollection<GameLines> GetLines (int? year, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null)

Get betting line information

Closing betting lines

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetLinesExample
    {
        public void main()
        {
            var apiInstance = new BettingApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team (optional) 
            var home = home_example;  // string | Home team filter (optional) 
            var away = away_example;  // string | Away team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Get betting line information
                ICollection&lt;GameLines&gt; result = apiInstance.GetLines(year, week, seasonType, team, home, away, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BettingApi.GetLines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team | [optional] 
 **home** | **string**| Home team filter | [optional] 
 **away** | **string**| Away team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 

### Return type

[**ICollection<GameLines>**](GameLines.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

