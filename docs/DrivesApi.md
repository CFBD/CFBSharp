# CFBSharp.Api.DrivesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDrvies**](DrivesApi.md#getdrvies) | **GET** /drives | Get drive information


<a name="getdrvies"></a>
# **GetDrvies**
> ICollection<Drive> GetDrvies (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)

Get drive information

Drive results

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetDrviesExample
    {
        public void main()
        {
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
                // Get drive information
                ICollection&lt;Drive&gt; result = apiInstance.GetDrvies(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrivesApi.GetDrvies: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

