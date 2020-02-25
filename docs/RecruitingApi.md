# CFBSharp.Api.RecruitingApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRecruitingGroups**](RecruitingApi.md#getrecruitinggroups) | **GET** /recruiting/groups | Get position group aggregated ratings
[**GetRecruitingPlayers**](RecruitingApi.md#getrecruitingplayers) | **GET** /recruiting/players | Get player recruiting rankings and data. Requires either a year or team to be specified.
[**GetRecruitingTeams**](RecruitingApi.md#getrecruitingteams) | **GET** /recruiting/teams | Get team recruiting rankings


<a name="getrecruitinggroups"></a>
# **GetRecruitingGroups**
> ICollection<PositionGroupRecruitingRating> GetRecruitingGroups (int? startYear = null, int? endYear = null, string team = null, string conference = null)

Get position group aggregated ratings

Gets a list of aggregated statistics by team and position grouping

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetRecruitingGroupsExample
    {
        public void main()
        {
            var apiInstance = new RecruitingApi();
            var startYear = 56;  // int? | Starting year (optional) 
            var endYear = 56;  // int? | Ending year (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | conference filter (optional) 

            try
            {
                // Get position group aggregated ratings
                ICollection&lt;PositionGroupRecruitingRating&gt; result = apiInstance.GetRecruitingGroups(startYear, endYear, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetRecruitingGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startYear** | **int?**| Starting year | [optional] 
 **endYear** | **int?**| Ending year | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| conference filter | [optional] 

### Return type

[**ICollection<PositionGroupRecruitingRating>**](PositionGroupRecruitingRating.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecruitingplayers"></a>
# **GetRecruitingPlayers**
> ICollection<Recruit> GetRecruitingPlayers (int? year = null, string classification = null, string position = null, string state = null, string team = null)

Get player recruiting rankings and data. Requires either a year or team to be specified.

Player recruiting rankings

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetRecruitingPlayersExample
    {
        public void main()
        {
            var apiInstance = new RecruitingApi();
            var year = 56;  // int? | Recruiting class year (required if team no specified) (optional) 
            var classification = classification_example;  // string | Type of recruit (HighSchool, JUCO, PrepSchool) (optional)  (default to HighSchool)
            var position = position_example;  // string | Position abbreviation filter (optional) 
            var state = state_example;  // string | State or province abbreviation filter (optional) 
            var team = team_example;  // string | Committed team filter (required if year not specified) (optional) 

            try
            {
                // Get player recruiting rankings and data. Requires either a year or team to be specified.
                ICollection&lt;Recruit&gt; result = apiInstance.GetRecruitingPlayers(year, classification, position, state, team);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetRecruitingPlayers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Recruiting class year (required if team no specified) | [optional] 
 **classification** | **string**| Type of recruit (HighSchool, JUCO, PrepSchool) | [optional] [default to HighSchool]
 **position** | **string**| Position abbreviation filter | [optional] 
 **state** | **string**| State or province abbreviation filter | [optional] 
 **team** | **string**| Committed team filter (required if year not specified) | [optional] 

### Return type

[**ICollection<Recruit>**](Recruit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecruitingteams"></a>
# **GetRecruitingTeams**
> ICollection<TeamRecruitingRank> GetRecruitingTeams (int? year = null, string team = null)

Get team recruiting rankings

Team recruiting rankings

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetRecruitingTeamsExample
    {
        public void main()
        {
            var apiInstance = new RecruitingApi();
            var year = 56;  // int? | Recruiting class year (optional) 
            var team = team_example;  // string | Team filter (optional) 

            try
            {
                // Get team recruiting rankings
                ICollection&lt;TeamRecruitingRank&gt; result = apiInstance.GetRecruitingTeams(year, team);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecruitingApi.GetRecruitingTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Recruiting class year | [optional] 
 **team** | **string**| Team filter | [optional] 

### Return type

[**ICollection<TeamRecruitingRank>**](TeamRecruitingRank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

