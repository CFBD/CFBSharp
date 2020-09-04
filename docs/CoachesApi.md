# CFBSharp.Api.CoachesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCoaches**](CoachesApi.md#getcoaches) | **GET** /coaches | Coaching records and history


<a name="getcoaches"></a>
# **GetCoaches**
> ICollection<InlineResponse200> GetCoaches (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null)

Coaching records and history

Coaching history

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetCoachesExample
    {
        public void main()
        {
            var apiInstance = new CoachesApi();
            var firstName = firstName_example;  // string | First name filter (optional) 
            var lastName = lastName_example;  // string | Last name filter (optional) 
            var team = team_example;  // string | Team name filter (optional) 
            var year = 56;  // int? | Year filter (optional) 
            var minYear = 56;  // int? | Minimum year filter (inclusive) (optional) 
            var maxYear = 56;  // int? | Maximum year filter (inclusive) (optional) 

            try
            {
                // Coaching records and history
                ICollection&lt;InlineResponse200&gt; result = apiInstance.GetCoaches(firstName, lastName, team, year, minYear, maxYear);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachesApi.GetCoaches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**| First name filter | [optional] 
 **lastName** | **string**| Last name filter | [optional] 
 **team** | **string**| Team name filter | [optional] 
 **year** | **int?**| Year filter | [optional] 
 **minYear** | **int?**| Minimum year filter (inclusive) | [optional] 
 **maxYear** | **int?**| Maximum year filter (inclusive) | [optional] 

### Return type

[**ICollection<InlineResponse200>**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

