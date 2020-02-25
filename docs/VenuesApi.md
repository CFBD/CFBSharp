# CFBSharp.Api.VenuesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVenues**](VenuesApi.md#getvenues) | **GET** /venues | Get venue information


<a name="getvenues"></a>
# **GetVenues**
> ICollection<Venue> GetVenues ()

Get venue information

Venues

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetVenuesExample
    {
        public void main()
        {
            var apiInstance = new VenuesApi();

            try
            {
                // Get venue information
                ICollection&lt;Venue&gt; result = apiInstance.GetVenues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenuesApi.GetVenues: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<Venue>**](Venue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

