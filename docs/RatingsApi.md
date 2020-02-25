# CFBSharp.Api.RatingsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConferenceSPRatings**](RatingsApi.md#getconferencespratings) | **GET** /ratings/sp/conferences | Get average SP+ historical rating data by conference
[**GetSPRatings**](RatingsApi.md#getspratings) | **GET** /ratings/sp | Get SP+ historical rating data (requires either a year or team specified)
[**GetSRSRatings**](RatingsApi.md#getsrsratings) | **GET** /ratings/srs | Get SRS historical rating data (requires either a year or team specified)


<a name="getconferencespratings"></a>
# **GetConferenceSPRatings**
> ICollection<ConferenceSPRating> GetConferenceSPRatings (int? year = null, string conference = null)

Get average SP+ historical rating data by conference

Conference average SP+ ratings by year

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetConferenceSPRatingsExample
    {
        public void main()
        {
            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Get average SP+ historical rating data by conference
                ICollection&lt;ConferenceSPRating&gt; result = apiInstance.GetConferenceSPRatings(year, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingsApi.GetConferenceSPRatings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Season filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 

### Return type

[**ICollection<ConferenceSPRating>**](ConferenceSPRating.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspratings"></a>
# **GetSPRatings**
> ICollection<TeamSPRating> GetSPRatings (int? year = null, string team = null)

Get SP+ historical rating data (requires either a year or team specified)

SP+ rating data

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetSPRatingsExample
    {
        public void main()
        {
            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (required if team not specified) (optional) 
            var team = team_example;  // string | Team filter (required if year not specified) (optional) 

            try
            {
                // Get SP+ historical rating data (requires either a year or team specified)
                ICollection&lt;TeamSPRating&gt; result = apiInstance.GetSPRatings(year, team);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingsApi.GetSPRatings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Season filter (required if team not specified) | [optional] 
 **team** | **string**| Team filter (required if year not specified) | [optional] 

### Return type

[**ICollection<TeamSPRating>**](TeamSPRating.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsrsratings"></a>
# **GetSRSRatings**
> ICollection<TeamSRSRating> GetSRSRatings (int? year = null, string team = null, string conference = null)

Get SRS historical rating data (requires either a year or team specified)

SRS rating data

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetSRSRatingsExample
    {
        public void main()
        {
            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (required if team not specified) (optional) 
            var team = team_example;  // string | Team filter (required if year not specified) (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 

            try
            {
                // Get SRS historical rating data (requires either a year or team specified)
                ICollection&lt;TeamSRSRating&gt; result = apiInstance.GetSRSRatings(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingsApi.GetSRSRatings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Season filter (required if team not specified) | [optional] 
 **team** | **string**| Team filter (required if year not specified) | [optional] 
 **conference** | **string**| Conference filter | [optional] 

### Return type

[**ICollection<TeamSRSRating>**](TeamSRSRating.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

