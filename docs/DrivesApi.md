# CFBSharp.Api.DrivesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDrives**](DrivesApi.md#getdrives) | **GET** /drives | Drive data and results


<a name="getdrives"></a>
# **GetDrives**
> ICollection<Drive> GetDrives (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)

Drive data and results

Get game drives

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetDrivesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new DrivesApi();
            var year = 56;  // int? | Year filter
            var seasonType = seasonType_example;  // string | Season type filter (optional)  (default to regular)
            var week = 56;  // int? | Week filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var offense = offense_example;  // string | Offensive team filter (optional) 
            var defense = defense_example;  // string | Defensive team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 
            var offenseConference = offenseConference_example;  // string | Offensive conference filter (optional) 
            var defenseConference = defenseConference_example;  // string | Defensive conference filter (optional) 

            try
            {
                // Drive data and results
                ICollection&lt;Drive&gt; result = apiInstance.GetDrives(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrivesApi.GetDrives: " + e.Message );
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
 **week** | **int?**| Week filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **offense** | **string**| Offensive team filter | [optional] 
 **defense** | **string**| Defensive team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 
 **offenseConference** | **string**| Offensive conference filter | [optional] 
 **defenseConference** | **string**| Defensive conference filter | [optional] 

### Return type

[**ICollection<Drive>**](Drive.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

