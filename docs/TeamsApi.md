# CFBSharp.Api.TeamsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFbsTeams**](TeamsApi.md#getfbsteams) | **GET** /teams/fbs | FBS team list
[**GetRoster**](TeamsApi.md#getroster) | **GET** /roster | Team rosters
[**GetTalent**](TeamsApi.md#gettalent) | **GET** /talent | Team talent composite rankings
[**GetTeamMatchup**](TeamsApi.md#getteammatchup) | **GET** /teams/matchup | Team matchup history
[**GetTeams**](TeamsApi.md#getteams) | **GET** /teams | Team information


<a name="getfbsteams"></a>
# **GetFbsTeams**
> ICollection<Team> GetFbsTeams (int? year = null)

FBS team list

Information on major division teams

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetFbsTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new TeamsApi();
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // FBS team list
                ICollection&lt;Team&gt; result = apiInstance.GetFbsTeams(year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetFbsTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 

### Return type

[**ICollection<Team>**](Team.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroster"></a>
# **GetRoster**
> ICollection<Player> GetRoster (string team = null, int? year = null)

Team rosters

Roster data

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetRosterExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new TeamsApi();
            var team = team_example;  // string | Team name (optional) 
            var year = 56;  // int? | Season year (optional) 

            try
            {
                // Team rosters
                ICollection&lt;Player&gt; result = apiInstance.GetRoster(team, year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetRoster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **team** | **string**| Team name | [optional] 
 **year** | **int?**| Season year | [optional] 

### Return type

[**ICollection<Player>**](Player.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettalent"></a>
# **GetTalent**
> ICollection<TeamTalent> GetTalent (int? year = null)

Team talent composite rankings

Team talent composite

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTalentExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new TeamsApi();
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // Team talent composite rankings
                ICollection&lt;TeamTalent&gt; result = apiInstance.GetTalent(year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTalent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 

### Return type

[**ICollection<TeamTalent>**](TeamTalent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteammatchup"></a>
# **GetTeamMatchup**
> ICollection<TeamMatchup> GetTeamMatchup (string team1, string team2, int? minYear = null, int? maxYear = null)

Team matchup history

Matchup history

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamMatchupExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new TeamsApi();
            var team1 = team1_example;  // string | First team
            var team2 = team2_example;  // string | Second team
            var minYear = 56;  // int? | Minimum year (optional) 
            var maxYear = 56;  // int? | Maximum year (optional) 

            try
            {
                // Team matchup history
                ICollection&lt;TeamMatchup&gt; result = apiInstance.GetTeamMatchup(team1, team2, minYear, maxYear);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamMatchup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **team1** | **string**| First team | 
 **team2** | **string**| Second team | 
 **minYear** | **int?**| Minimum year | [optional] 
 **maxYear** | **int?**| Maximum year | [optional] 

### Return type

[**ICollection<TeamMatchup>**](TeamMatchup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteams"></a>
# **GetTeams**
> ICollection<Team> GetTeams (string conference = null)

Team information

Get team information

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Bearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Bearer", "Bearer");

            var apiInstance = new TeamsApi();
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Team information
                ICollection&lt;Team&gt; result = apiInstance.GetTeams(conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conference** | **string**| Conference abbreviation filter | [optional] 

### Return type

[**ICollection<Team>**](Team.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

