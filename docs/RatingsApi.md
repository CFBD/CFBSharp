# CFBSharp.Api.RatingsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConferenceSPRatings**](RatingsApi.md#getconferencespratings) | **GET** /ratings/sp/conferences | Historical SP+ ratings by conference
[**GetSPRatings**](RatingsApi.md#getspratings) | **GET** /ratings/sp | Historical SP+ ratings
[**GetSRSRatings**](RatingsApi.md#getsrsratings) | **GET** /ratings/srs | Historical SRS ratings


<a name="getconferencespratings"></a>
# **GetConferenceSPRatings**
> ICollection<ConferenceSPRating> GetConferenceSPRatings (int? year = null, string conference = null)

Historical SP+ ratings by conference

Get average SP+ historical rating data by conference

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
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Historical SP+ ratings by conference
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

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspratings"></a>
# **GetSPRatings**
> ICollection<TeamSPRating> GetSPRatings (int? year = null, string team = null)

Historical SP+ ratings

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
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (required if team not specified) (optional) 
            var team = team_example;  // string | Team filter (required if year not specified) (optional) 

            try
            {
                // Historical SP+ ratings
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

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsrsratings"></a>
# **GetSRSRatings**
> ICollection<TeamSRSRating> GetSRSRatings (int? year = null, string team = null, string conference = null)

Historical SRS ratings

SRS rating data (requires either a year or team specified)

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
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RatingsApi();
            var year = 56;  // int? | Season filter (required if team not specified) (optional) 
            var team = team_example;  // string | Team filter (required if year not specified) (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 

            try
            {
                // Historical SRS ratings
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

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

