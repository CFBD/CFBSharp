# CFBSharp - the C# library for the College Football Data API

This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.2.0
- SDK version: 2.2.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Add the package using the dotnet CLI:
```powershell
dotnet add package CFBSharp
```

Then use the relevant namespaces:
```csharp
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new BettingApi();
            var gameId = 56;  // int? | Game id filter (optional) 
            var year = 56;  // int? | Year/season filter for games (optional) 
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team (optional) 
            var home = home_example;  // string | Home team filter (optional) 
            var away = away_example;  // string | Away team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 

            try
            {
                // Get betting line information
                ICollection<GameLines> result = apiInstance.GetLines(gameId, year, week, seasonType, team, home, away, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BettingApi.GetLines: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.collegefootballdata.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BettingApi* | [**GetLines**](docs/BettingApi.md#getlines) | **GET** /lines | Get betting line information
*CoachesApi* | [**GetCoaches**](docs/CoachesApi.md#getcoaches) | **GET** /coaches | Get coach records and school history
*ConferencesApi* | [**GetConferences**](docs/ConferencesApi.md#getconferences) | **GET** /conferences | Get conference list
*DrivesApi* | [**GetDrvies**](docs/DrivesApi.md#getdrvies) | **GET** /drives | Get drive information
*GamesApi* | [**GetAdvancedBoxScore**](docs/GamesApi.md#getadvancedboxscore) | **GET** /game/box/advanced | Get advanced box score
*GamesApi* | [**GetGameMedia**](docs/GamesApi.md#getgamemedia) | **GET** /games/media | Get game media information (TV, radio, etc)
*GamesApi* | [**GetGames**](docs/GamesApi.md#getgames) | **GET** /games | Get game information
*GamesApi* | [**GetPlayerGameStats**](docs/GamesApi.md#getplayergamestats) | **GET** /games/players | Get player statistics by game
*GamesApi* | [**GetTeamGameStats**](docs/GamesApi.md#getteamgamestats) | **GET** /games/teams | Get team statistics by game
*GamesApi* | [**GetTeamRecords**](docs/GamesApi.md#getteamrecords) | **GET** /records | Get records by year
*MetricsApi* | [**GetGamePPA**](docs/MetricsApi.md#getgameppa) | **GET** /ppa/games | Get team game averages for Predicted Points Added (PPA)
*MetricsApi* | [**GetPlayerGamePPA**](docs/MetricsApi.md#getplayergameppa) | **GET** /ppa/players/games | Get player game averages for Predicted Points Added (PPA)
*MetricsApi* | [**GetPlayerSeasonPPA**](docs/MetricsApi.md#getplayerseasonppa) | **GET** /ppa/players/season | Get player season averages for Predicted Points Added (PPA)
*MetricsApi* | [**GetPredictedPoints**](docs/MetricsApi.md#getpredictedpoints) | **GET** /ppa/predicted | Calculate Predicted Points
*MetricsApi* | [**GetPregameWinProbabilities**](docs/MetricsApi.md#getpregamewinprobabilities) | **GET** /metrics/wp/pregame | Get pregame win probabilities
*MetricsApi* | [**GetTeamPPA**](docs/MetricsApi.md#getteamppa) | **GET** /ppa/teams | Get team averages for Predicted Points Added (PPA)
*MetricsApi* | [**GetWinProbabilityData**](docs/MetricsApi.md#getwinprobabilitydata) | **GET** /metrics/wp | Get win probability chart data
*PlayersApi* | [**GetPlayerSeasonStats**](docs/PlayersApi.md#getplayerseasonstats) | **GET** /stats/player/season | Get player stats aggregated by season
*PlayersApi* | [**GetPlayerUsage**](docs/PlayersApi.md#getplayerusage) | **GET** /player/usage | Get player usage metrics for the season
*PlayersApi* | [**GetReturningProduction**](docs/PlayersApi.md#getreturningproduction) | **GET** /player/returning | Get returning production metrics
*PlayersApi* | [**PlayerSearch**](docs/PlayersApi.md#playersearch) | **GET** /player/search | Search for players
*PlaysApi* | [**GetPlayStatTypes**](docs/PlaysApi.md#getplaystattypes) | **GET** /play/stat/types | Get play stat type lists
*PlaysApi* | [**GetPlayStats**](docs/PlaysApi.md#getplaystats) | **GET** /play/stats | Get play statistics
*PlaysApi* | [**GetPlayTypes**](docs/PlaysApi.md#getplaytypes) | **GET** /play/types | Get play type list
*PlaysApi* | [**GetPlays**](docs/PlaysApi.md#getplays) | **GET** /plays | Get play information. Requires either a week or team to be specified.
*RankingsApi* | [**GetRankings**](docs/RankingsApi.md#getrankings) | **GET** /rankings | Get historical rankings and polls
*RatingsApi* | [**GetConferenceSPRatings**](docs/RatingsApi.md#getconferencespratings) | **GET** /ratings/sp/conferences | Get average SP+ historical rating data by conference
*RatingsApi* | [**GetSPRatings**](docs/RatingsApi.md#getspratings) | **GET** /ratings/sp | Get SP+ historical rating data (requires either a year or team specified)
*RatingsApi* | [**GetSRSRatings**](docs/RatingsApi.md#getsrsratings) | **GET** /ratings/srs | Get SRS historical rating data (requires either a year or team specified)
*RecruitingApi* | [**GetRecruitingGroups**](docs/RecruitingApi.md#getrecruitinggroups) | **GET** /recruiting/groups | Get position group aggregated ratings
*RecruitingApi* | [**GetRecruitingPlayers**](docs/RecruitingApi.md#getrecruitingplayers) | **GET** /recruiting/players | Get player recruiting rankings and data. Requires either a year or team to be specified.
*RecruitingApi* | [**GetRecruitingTeams**](docs/RecruitingApi.md#getrecruitingteams) | **GET** /recruiting/teams | Get team recruiting rankings
*StatsApi* | [**GetAdvancedTeamGameStats**](docs/StatsApi.md#getadvancedteamgamestats) | **GET** /stats/game/advanced | Get advanced game team stats
*StatsApi* | [**GetAdvancedTeamSeasonStats**](docs/StatsApi.md#getadvancedteamseasonstats) | **GET** /stats/season/advanced | Get advanced season team stats
*StatsApi* | [**GetStatCategories**](docs/StatsApi.md#getstatcategories) | **GET** /stats/categories | Get stat category list
*StatsApi* | [**GetTeamSeasonStats**](docs/StatsApi.md#getteamseasonstats) | **GET** /stats/season | Get season team stats
*TeamsApi* | [**GetFbsTeams**](docs/TeamsApi.md#getfbsteams) | **GET** /teams/fbs | Get list of major division teams for a given year
*TeamsApi* | [**GetRoster**](docs/TeamsApi.md#getroster) | **GET** /roster | Get team roster
*TeamsApi* | [**GetTalent**](docs/TeamsApi.md#gettalent) | **GET** /talent | Get team talent rankings
*TeamsApi* | [**GetTeamMatchup**](docs/TeamsApi.md#getteammatchup) | **GET** /teams/matchup | Get matchup history
*TeamsApi* | [**GetTeams**](docs/TeamsApi.md#getteams) | **GET** /teams | Get team information
*VenuesApi* | [**GetVenues**](docs/VenuesApi.md#getvenues) | **GET** /venues | Get venue information


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AdvancedGameStat](docs/AdvancedGameStat.md)
 - [Model.AdvancedGameStatOffense](docs/AdvancedGameStatOffense.md)
 - [Model.AdvancedGameStatOffenseRushingPlays](docs/AdvancedGameStatOffenseRushingPlays.md)
 - [Model.AdvancedGameStatOffenseStandardDowns](docs/AdvancedGameStatOffenseStandardDowns.md)
 - [Model.AdvancedSeasonStat](docs/AdvancedSeasonStat.md)
 - [Model.AdvancedSeasonStatDefense](docs/AdvancedSeasonStatDefense.md)
 - [Model.AdvancedSeasonStatOffense](docs/AdvancedSeasonStatOffense.md)
 - [Model.AdvancedSeasonStatOffenseFieldPosition](docs/AdvancedSeasonStatOffenseFieldPosition.md)
 - [Model.AdvancedSeasonStatOffenseRushingPlays](docs/AdvancedSeasonStatOffenseRushingPlays.md)
 - [Model.AdvancedSeasonStatOffenseStandardDowns](docs/AdvancedSeasonStatOffenseStandardDowns.md)
 - [Model.BoxScore](docs/BoxScore.md)
 - [Model.BoxScorePlayers](docs/BoxScorePlayers.md)
 - [Model.BoxScorePlayersAverage](docs/BoxScorePlayersAverage.md)
 - [Model.BoxScorePlayersPpa](docs/BoxScorePlayersPpa.md)
 - [Model.BoxScorePlayersUsage](docs/BoxScorePlayersUsage.md)
 - [Model.BoxScoreTeams](docs/BoxScoreTeams.md)
 - [Model.BoxScoreTeamsExplosiveness](docs/BoxScoreTeamsExplosiveness.md)
 - [Model.BoxScoreTeamsFieldPosition](docs/BoxScoreTeamsFieldPosition.md)
 - [Model.BoxScoreTeamsHavoc](docs/BoxScoreTeamsHavoc.md)
 - [Model.BoxScoreTeamsOverall](docs/BoxScoreTeamsOverall.md)
 - [Model.BoxScoreTeamsPpa](docs/BoxScoreTeamsPpa.md)
 - [Model.BoxScoreTeamsRushing](docs/BoxScoreTeamsRushing.md)
 - [Model.BoxScoreTeamsScoringOpportunities](docs/BoxScoreTeamsScoringOpportunities.md)
 - [Model.BoxScoreTeamsSuccessRates](docs/BoxScoreTeamsSuccessRates.md)
 - [Model.Conference](docs/Conference.md)
 - [Model.ConferenceSPRating](docs/ConferenceSPRating.md)
 - [Model.Drive](docs/Drive.md)
 - [Model.DriveStartTime](docs/DriveStartTime.md)
 - [Model.Game](docs/Game.md)
 - [Model.GameLines](docs/GameLines.md)
 - [Model.GameLinesLines](docs/GameLinesLines.md)
 - [Model.GameMedia](docs/GameMedia.md)
 - [Model.GamePPA](docs/GamePPA.md)
 - [Model.GamePPAOffense](docs/GamePPAOffense.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.Play](docs/Play.md)
 - [Model.PlayStat](docs/PlayStat.md)
 - [Model.PlayStatType](docs/PlayStatType.md)
 - [Model.PlayType](docs/PlayType.md)
 - [Model.PlayWP](docs/PlayWP.md)
 - [Model.Player](docs/Player.md)
 - [Model.PlayerGame](docs/PlayerGame.md)
 - [Model.PlayerGameAthletes](docs/PlayerGameAthletes.md)
 - [Model.PlayerGameCategories](docs/PlayerGameCategories.md)
 - [Model.PlayerGamePPA](docs/PlayerGamePPA.md)
 - [Model.PlayerGamePPAAveragePPA](docs/PlayerGamePPAAveragePPA.md)
 - [Model.PlayerGameSchool](docs/PlayerGameSchool.md)
 - [Model.PlayerGameTeams](docs/PlayerGameTeams.md)
 - [Model.PlayerGameTypes](docs/PlayerGameTypes.md)
 - [Model.PlayerSearchResult](docs/PlayerSearchResult.md)
 - [Model.PlayerSeasonPPA](docs/PlayerSeasonPPA.md)
 - [Model.PlayerSeasonPPAAveragePPA](docs/PlayerSeasonPPAAveragePPA.md)
 - [Model.PlayerSeasonStat](docs/PlayerSeasonStat.md)
 - [Model.PlayerUsage](docs/PlayerUsage.md)
 - [Model.PlayerUsageUsage](docs/PlayerUsageUsage.md)
 - [Model.PositionGroupRecruitingRating](docs/PositionGroupRecruitingRating.md)
 - [Model.PredictedPoints](docs/PredictedPoints.md)
 - [Model.PregameWP](docs/PregameWP.md)
 - [Model.RankingWeek](docs/RankingWeek.md)
 - [Model.RankingWeekPolls](docs/RankingWeekPolls.md)
 - [Model.RankingWeekRanks](docs/RankingWeekRanks.md)
 - [Model.Recruit](docs/Recruit.md)
 - [Model.ReturningProduction](docs/ReturningProduction.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamGame](docs/TeamGame.md)
 - [Model.TeamGameStats](docs/TeamGameStats.md)
 - [Model.TeamGameTeams](docs/TeamGameTeams.md)
 - [Model.TeamMatchup](docs/TeamMatchup.md)
 - [Model.TeamMatchupGames](docs/TeamMatchupGames.md)
 - [Model.TeamPPA](docs/TeamPPA.md)
 - [Model.TeamPPAOffense](docs/TeamPPAOffense.md)
 - [Model.TeamPPAOffenseCumulative](docs/TeamPPAOffenseCumulative.md)
 - [Model.TeamRecord](docs/TeamRecord.md)
 - [Model.TeamRecordTotal](docs/TeamRecordTotal.md)
 - [Model.TeamRecruitingRank](docs/TeamRecruitingRank.md)
 - [Model.TeamSPRating](docs/TeamSPRating.md)
 - [Model.TeamSPRatingDefense](docs/TeamSPRatingDefense.md)
 - [Model.TeamSPRatingDefenseHavoc](docs/TeamSPRatingDefenseHavoc.md)
 - [Model.TeamSPRatingOffense](docs/TeamSPRatingOffense.md)
 - [Model.TeamSPRatingSpecialTeams](docs/TeamSPRatingSpecialTeams.md)
 - [Model.TeamSRSRating](docs/TeamSRSRating.md)
 - [Model.TeamSeason](docs/TeamSeason.md)
 - [Model.TeamSeasonStat](docs/TeamSeasonStat.md)
 - [Model.TeamTalent](docs/TeamTalent.md)
 - [Model.Venue](docs/Venue.md)
 - [Model.VenueLocation](docs/VenueLocation.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
