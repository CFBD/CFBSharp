# CFBSharp.Api.GamesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAdvancedBoxScore**](GamesApi.md#getadvancedboxscore) | **GET** /game/box/advanced | Advanced box scores
[**GetCalendar**](GamesApi.md#getcalendar) | **GET** /calendar | Season calendar
[**GetGameMedia**](GamesApi.md#getgamemedia) | **GET** /games/media | Game media information and schedules
[**GetGameWeather**](GamesApi.md#getgameweather) | **GET** /games/weather | Game weather information (Patreon only)
[**GetGames**](GamesApi.md#getgames) | **GET** /games | Games and results
[**GetPlayerGameStats**](GamesApi.md#getplayergamestats) | **GET** /games/players | Player game stats
[**GetScoreboard**](GamesApi.md#getscoreboard) | **GET** /scoreboard | Live game results (Patreon only)
[**GetTeamGameStats**](GamesApi.md#getteamgamestats) | **GET** /games/teams | Team game stats
[**GetTeamRecords**](GamesApi.md#getteamrecords) | **GET** /records | Team records


<a name="getadvancedboxscore"></a>
# **GetAdvancedBoxScore**
> BoxScore GetAdvancedBoxScore (int? gameId)

Advanced box scores

Get advanced box score data

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetAdvancedBoxScoreExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var gameId = 56;  // int? | Game id parameters

            try
            {
                // Advanced box scores
                BoxScore result = apiInstance.GetAdvancedBoxScore(gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetAdvancedBoxScore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gameId** | **int?**| Game id parameters | 

### Return type

[**BoxScore**](BoxScore.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalendar"></a>
# **GetCalendar**
> ICollection<Week> GetCalendar (int? year)

Season calendar

Get calendar of weeks by season

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetCalendarExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year filter

            try
            {
                // Season calendar
                ICollection&lt;Week&gt; result = apiInstance.GetCalendar(year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetCalendar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 

### Return type

[**ICollection<Week>**](Week.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgamemedia"></a>
# **GetGameMedia**
> ICollection<GameMedia> GetGameMedia (int? year, int? week = null, string seasonType = null, string team = null, string conference = null, string mediaType = null)

Game media information and schedules

Game media information (TV, radio, etc)

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetGameMediaExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year filter
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular, postseason, or both) (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 
            var mediaType = mediaType_example;  // string | Media type filter (tv, radio, web, ppv, or mobile) (optional) 

            try
            {
                // Game media information and schedules
                ICollection&lt;GameMedia&gt; result = apiInstance.GetGameMedia(year, week, seasonType, team, conference, mediaType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetGameMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular, postseason, or both) | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 
 **mediaType** | **string**| Media type filter (tv, radio, web, ppv, or mobile) | [optional] 

### Return type

[**ICollection<GameMedia>**](GameMedia.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgameweather"></a>
# **GetGameWeather**
> ICollection<GameWeather> GetGameWeather (int? year, int? week = null, string seasonType = null, string team = null, string conference = null)

Game weather information (Patreon only)

Weather information for the hour of kickoff

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetGameWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year filter
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular, postseason, or both) (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 

            try
            {
                // Game weather information (Patreon only)
                ICollection&lt;GameWeather&gt; result = apiInstance.GetGameWeather(year, week, seasonType, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetGameWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular, postseason, or both) | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 

### Return type

[**ICollection<GameWeather>**](GameWeather.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgames"></a>
# **GetGames**
> ICollection<Game> GetGames (int? year, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null, int? id = null)

Games and results

Get game results

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetGamesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team (optional) 
            var home = home_example;  // string | Home team filter (optional) 
            var away = away_example;  // string | Away team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var id = 56;  // int? | id filter for querying a single game (optional) 

            try
            {
                // Games and results
                ICollection&lt;Game&gt; result = apiInstance.GetGames(year, week, seasonType, team, home, away, conference, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetGames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team | [optional] 
 **home** | **string**| Home team filter | [optional] 
 **away** | **string**| Away team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **id** | **int?**| id filter for querying a single game | [optional] 

### Return type

[**ICollection<Game>**](Game.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayergamestats"></a>
# **GetPlayerGameStats**
> ICollection<PlayerGame> GetPlayerGameStats (int? year, int? week = null, string seasonType = null, string team = null, string conference = null, string category = null, int? gameId = null)

Player game stats

Player stats broken down by game

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerGameStatsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var category = category_example;  // string | Category filter (e.g defensive) (optional) 
            var gameId = 56;  // int? | Game id filter (optional) 

            try
            {
                // Player game stats
                ICollection&lt;PlayerGame&gt; result = apiInstance.GetPlayerGameStats(year, week, seasonType, team, conference, category, gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetPlayerGameStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **category** | **string**| Category filter (e.g defensive) | [optional] 
 **gameId** | **int?**| Game id filter | [optional] 

### Return type

[**ICollection<PlayerGame>**](PlayerGame.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscoreboard"></a>
# **GetScoreboard**
> ICollection<ScoreboardGame> GetScoreboard ()

Live game results (Patreon only)

Get live game results

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetScoreboardExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();

            try
            {
                // Live game results (Patreon only)
                ICollection&lt;ScoreboardGame&gt; result = apiInstance.GetScoreboard();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetScoreboard: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<ScoreboardGame>**](ScoreboardGame.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamgamestats"></a>
# **GetTeamGameStats**
> ICollection<TeamGame> GetTeamGameStats (int? year, int? week = null, string seasonType = null, string team = null, string conference = null, int? gameId = null)

Team game stats

Team stats broken down by game

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamGameStatsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var gameId = 56;  // int? | Game id filter (optional) 

            try
            {
                // Team game stats
                ICollection&lt;TeamGame&gt; result = apiInstance.GetTeamGameStats(year, week, seasonType, team, conference, gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetTeamGameStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **gameId** | **int?**| Game id filter | [optional] 

### Return type

[**ICollection<TeamGame>**](TeamGame.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamrecords"></a>
# **GetTeamRecords**
> ICollection<TeamRecord> GetTeamRecords (int? year = null, string team = null, string conference = null)

Team records

Get team records by year

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 

            try
            {
                // Team records
                ICollection&lt;TeamRecord&gt; result = apiInstance.GetTeamRecords(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetTeamRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 

### Return type

[**ICollection<TeamRecord>**](TeamRecord.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

