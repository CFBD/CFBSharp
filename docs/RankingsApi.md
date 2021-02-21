# CFBSharp.Api.RankingsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRankings**](RankingsApi.md#getrankings) | **GET** /rankings | Historical polls and rankings


<a name="getrankings"></a>
# **GetRankings**
> ICollection<RankingWeek> GetRankings (int? year, int? week = null, string seasonType = null)

Historical polls and rankings

Poll rankings

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetRankingsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new RankingsApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)

            try
            {
                // Historical polls and rankings
                ICollection&lt;RankingWeek&gt; result = apiInstance.GetRankings(year, week, seasonType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RankingsApi.GetRankings: " + e.Message );
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

### Return type

[**ICollection<RankingWeek>**](RankingWeek.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

