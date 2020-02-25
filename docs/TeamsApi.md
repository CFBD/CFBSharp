# CFBSharp.Api.TeamsApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFbsTeams**](TeamsApi.md#getfbsteams) | **GET** /teams/fbs | Get list of major division teams for a given year
[**GetRoster**](TeamsApi.md#getroster) | **GET** /roster | Get team roster
[**GetTalent**](TeamsApi.md#gettalent) | **GET** /talent | Get team talent rankings
[**GetTeamMatchup**](TeamsApi.md#getteammatchup) | **GET** /teams/matchup | Get matchup history
[**GetTeams**](TeamsApi.md#getteams) | **GET** /teams | Get team information


<a name="getfbsteams"></a>
# **GetFbsTeams**
> ICollection<Team> GetFbsTeams (int? year = null)

Get list of major division teams for a given year

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
            var apiInstance = new TeamsApi();
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // Get list of major division teams for a given year
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroster"></a>
# **GetRoster**
> ICollection<Player> GetRoster (string team, int? year = null)

Get team roster

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
            var apiInstance = new TeamsApi();
            var team = team_example;  // string | Team name
            var year = 56;  // int? | Season year (optional) 

            try
            {
                // Get team roster
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
 **team** | **string**| Team name | 
 **year** | **int?**| Season year | [optional] 

### Return type

[**ICollection<Player>**](Player.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettalent"></a>
# **GetTalent**
> ICollection<TeamTalent> GetTalent (int? year = null)

Get team talent rankings

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
            var apiInstance = new TeamsApi();
            var year = 56;  // int? | Year filter (optional) 

            try
            {
                // Get team talent rankings
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteammatchup"></a>
# **GetTeamMatchup**
> ICollection<TeamMatchup> GetTeamMatchup (string team1, string team2, int? minYear = null, int? maxYear = null)

Get matchup history

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
            var apiInstance = new TeamsApi();
            var team1 = team1_example;  // string | First team
            var team2 = team2_example;  // string | Second team
            var minYear = 56;  // int? | Minimum year (optional) 
            var maxYear = 56;  // int? | Maximum year (optional) 

            try
            {
                // Get matchup history
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteams"></a>
# **GetTeams**
> ICollection<Team> GetTeams (string conference = null)

Get team information

Team information

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
            var apiInstance = new TeamsApi();
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Get team information
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

