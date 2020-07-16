# CFBSharp.Api.ConferencesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConferences**](ConferencesApi.md#getconferences) | **GET** /conferences | Conferences


<a name="getconferences"></a>
# **GetConferences**
> ICollection<Conference> GetConferences ()

Conferences

Get conference list

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetConferencesExample
    {
        public void main()
        {
            var apiInstance = new ConferencesApi();

            try
            {
                // Conferences
                ICollection&lt;Conference&gt; result = apiInstance.GetConferences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConferencesApi.GetConferences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<Conference>**](Conference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

