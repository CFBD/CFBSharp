# CFBSharp.Api.DraftApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDraftPicks**](DraftApi.md#getdraftpicks) | **GET** /draft/picks | List of NFL Draft picks
[**GetNFLPositions**](DraftApi.md#getnflpositions) | **GET** /draft/positions | List of NFL positions
[**GetNFLTeams**](DraftApi.md#getnflteams) | **GET** /draft/teams | List of NFL teams


<a name="getdraftpicks"></a>
# **GetDraftPicks**
> ICollection<DraftPick> GetDraftPicks (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null)

List of NFL Draft picks

List of NFL Draft picks

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetDraftPicksExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftApi();
            var year = 56;  // int? | Year filter (optional) 
            var nflTeam = nflTeam_example;  // string | NFL team filter (optional) 
            var college = college_example;  // string | Player college filter (optional) 
            var conference = conference_example;  // string | College confrence abbreviation filter (optional) 
            var position = position_example;  // string | NFL position filter (optional) 

            try
            {
                // List of NFL Draft picks
                ICollection&lt;DraftPick&gt; result = apiInstance.GetDraftPicks(year, nflTeam, college, conference, position);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftApi.GetDraftPicks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **nflTeam** | **string**| NFL team filter | [optional] 
 **college** | **string**| Player college filter | [optional] 
 **conference** | **string**| College confrence abbreviation filter | [optional] 
 **position** | **string**| NFL position filter | [optional] 

### Return type

[**ICollection<DraftPick>**](DraftPick.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnflpositions"></a>
# **GetNFLPositions**
> ICollection<DraftPosition> GetNFLPositions ()

List of NFL positions

List of NFL positions

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetNFLPositionsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftApi();

            try
            {
                // List of NFL positions
                ICollection&lt;DraftPosition&gt; result = apiInstance.GetNFLPositions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftApi.GetNFLPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<DraftPosition>**](DraftPosition.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnflteams"></a>
# **GetNFLTeams**
> ICollection<DraftTeam> GetNFLTeams ()

List of NFL teams

List of NFL teams

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetNFLTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftApi();

            try
            {
                // List of NFL teams
                ICollection&lt;DraftTeam&gt; result = apiInstance.GetNFLTeams();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftApi.GetNFLTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<DraftTeam>**](DraftTeam.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

