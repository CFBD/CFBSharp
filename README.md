# CFBSharp - the C# library for the College Football Data API

This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 4.4.7
- SDK version: 4.4.7
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

            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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
                // Betting lines
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
*BettingApi* | [**GetLines**](docs/BettingApi.md#getlines) | **GET** /lines | Betting lines
*CoachesApi* | [**GetCoaches**](docs/CoachesApi.md#getcoaches) | **GET** /coaches | Coaching records and history
*ConferencesApi* | [**GetConferences**](docs/ConferencesApi.md#getconferences) | **GET** /conferences | Conferences
*DraftApi* | [**GetDraftPicks**](docs/DraftApi.md#getdraftpicks) | **GET** /draft/picks | List of NFL Draft picks
*DraftApi* | [**GetNFLPositions**](docs/DraftApi.md#getnflpositions) | **GET** /draft/positions | List of NFL positions
*DraftApi* | [**GetNFLTeams**](docs/DraftApi.md#getnflteams) | **GET** /draft/teams | List of NFL teams
*DrivesApi* | [**GetDrives**](docs/DrivesApi.md#getdrives) | **GET** /drives | Drive data and results
*GamesApi* | [**GetAdvancedBoxScore**](docs/GamesApi.md#getadvancedboxscore) | **GET** /game/box/advanced | Advanced box scores
*GamesApi* | [**GetCalendar**](docs/GamesApi.md#getcalendar) | **GET** /calendar | Season calendar
*GamesApi* | [**GetGameMedia**](docs/GamesApi.md#getgamemedia) | **GET** /games/media | Game media information and schedules
*GamesApi* | [**GetGameWeather**](docs/GamesApi.md#getgameweather) | **GET** /games/weather | Game weather information (Patreon only)
*GamesApi* | [**GetGames**](docs/GamesApi.md#getgames) | **GET** /games | Games and results
*GamesApi* | [**GetPlayerGameStats**](docs/GamesApi.md#getplayergamestats) | **GET** /games/players | Player game stats
*GamesApi* | [**GetScoreboard**](docs/GamesApi.md#getscoreboard) | **GET** /scoreboard | Live game results (Patreon only)
*GamesApi* | [**GetTeamGameStats**](docs/GamesApi.md#getteamgamestats) | **GET** /games/teams | Team game stats
*GamesApi* | [**GetTeamRecords**](docs/GamesApi.md#getteamrecords) | **GET** /records | Team records
*MetricsApi* | [**GetGamePPA**](docs/MetricsApi.md#getgameppa) | **GET** /ppa/games | Team Predicated Points Added (PPA/EPA) by game
*MetricsApi* | [**GetPlayerGamePPA**](docs/MetricsApi.md#getplayergameppa) | **GET** /ppa/players/games | Player Predicated Points Added (PPA/EPA) broken down by game
*MetricsApi* | [**GetPlayerSeasonPPA**](docs/MetricsApi.md#getplayerseasonppa) | **GET** /ppa/players/season | Player Predicated Points Added (PPA/EPA) broken down by season
*MetricsApi* | [**GetPredictedPoints**](docs/MetricsApi.md#getpredictedpoints) | **GET** /ppa/predicted | Predicted Points (i.e. Expected Points or EP)
*MetricsApi* | [**GetPregameWinProbabilities**](docs/MetricsApi.md#getpregamewinprobabilities) | **GET** /metrics/wp/pregame | Pregame win probability data
*MetricsApi* | [**GetTeamPPA**](docs/MetricsApi.md#getteamppa) | **GET** /ppa/teams | Predicted Points Added (PPA/EPA) data by team
*MetricsApi* | [**GetWinProbabilityData**](docs/MetricsApi.md#getwinprobabilitydata) | **GET** /metrics/wp | Win probability chart data
*PlayersApi* | [**GetPlayerSeasonStats**](docs/PlayersApi.md#getplayerseasonstats) | **GET** /stats/player/season | Player stats by season
*PlayersApi* | [**GetPlayerUsage**](docs/PlayersApi.md#getplayerusage) | **GET** /player/usage | Player usage metrics broken down by season
*PlayersApi* | [**GetReturningProduction**](docs/PlayersApi.md#getreturningproduction) | **GET** /player/returning | Team returning production metrics
*PlayersApi* | [**GetTransferPortal**](docs/PlayersApi.md#gettransferportal) | **GET** /player/portal | Transfer portal by season
*PlayersApi* | [**PlayerSearch**](docs/PlayersApi.md#playersearch) | **GET** /player/search | Search for player information
*PlaysApi* | [**GetLivePlays**](docs/PlaysApi.md#getliveplays) | **GET** /live/plays | Live metrics and PBP (Patreon only)
*PlaysApi* | [**GetPlayStatTypes**](docs/PlaysApi.md#getplaystattypes) | **GET** /play/stat/types | Types of player play stats
*PlaysApi* | [**GetPlayStats**](docs/PlaysApi.md#getplaystats) | **GET** /play/stats | Play stats by play
*PlaysApi* | [**GetPlayTypes**](docs/PlaysApi.md#getplaytypes) | **GET** /play/types | Play types
*PlaysApi* | [**GetPlays**](docs/PlaysApi.md#getplays) | **GET** /plays | Play by play data
*RankingsApi* | [**GetRankings**](docs/RankingsApi.md#getrankings) | **GET** /rankings | Historical polls and rankings
*RatingsApi* | [**GetConferenceSPRatings**](docs/RatingsApi.md#getconferencespratings) | **GET** /ratings/sp/conferences | Historical SP+ ratings by conference
*RatingsApi* | [**GetEloRatings**](docs/RatingsApi.md#geteloratings) | **GET** /ratings/elo | Historical Elo ratings
*RatingsApi* | [**GetSPRatings**](docs/RatingsApi.md#getspratings) | **GET** /ratings/sp | Historical SP+ ratings
*RatingsApi* | [**GetSRSRatings**](docs/RatingsApi.md#getsrsratings) | **GET** /ratings/srs | Historical SRS ratings
*RecruitingApi* | [**GetRecruitingGroups**](docs/RecruitingApi.md#getrecruitinggroups) | **GET** /recruiting/groups | Recruit position group ratings
*RecruitingApi* | [**GetRecruitingPlayers**](docs/RecruitingApi.md#getrecruitingplayers) | **GET** /recruiting/players | Player recruiting ratings and rankings
*RecruitingApi* | [**GetRecruitingTeams**](docs/RecruitingApi.md#getrecruitingteams) | **GET** /recruiting/teams | Team recruiting rankings and ratings
*StatsApi* | [**GetAdvancedTeamGameStats**](docs/StatsApi.md#getadvancedteamgamestats) | **GET** /stats/game/advanced | Advanced team metrics by game
*StatsApi* | [**GetAdvancedTeamSeasonStats**](docs/StatsApi.md#getadvancedteamseasonstats) | **GET** /stats/season/advanced | Advanced team metrics by season
*StatsApi* | [**GetStatCategories**](docs/StatsApi.md#getstatcategories) | **GET** /stats/categories | Team stat categories
*StatsApi* | [**GetTeamSeasonStats**](docs/StatsApi.md#getteamseasonstats) | **GET** /stats/season | Team statistics by season
*TeamsApi* | [**GetFbsTeams**](docs/TeamsApi.md#getfbsteams) | **GET** /teams/fbs | FBS team list
*TeamsApi* | [**GetRoster**](docs/TeamsApi.md#getroster) | **GET** /roster | Team rosters
*TeamsApi* | [**GetTalent**](docs/TeamsApi.md#gettalent) | **GET** /talent | Team talent composite rankings
*TeamsApi* | [**GetTeamMatchup**](docs/TeamsApi.md#getteammatchup) | **GET** /teams/matchup | Team matchup history
*TeamsApi* | [**GetTeams**](docs/TeamsApi.md#getteams) | **GET** /teams | Team information
*VenuesApi* | [**GetVenues**](docs/VenuesApi.md#getvenues) | **GET** /venues | Arena and venue information


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AdvancedGameStat](docs/AdvancedGameStat.md)
 - [Model.AdvancedGameStatOffense](docs/AdvancedGameStatOffense.md)
 - [Model.AdvancedGameStatOffenseRushingPlays](docs/AdvancedGameStatOffenseRushingPlays.md)
 - [Model.AdvancedGameStatOffenseStandardDowns](docs/AdvancedGameStatOffenseStandardDowns.md)
 - [Model.AdvancedSeasonStat](docs/AdvancedSeasonStat.md)
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
 - [Model.Coach](docs/Coach.md)
 - [Model.CoachSeasons](docs/CoachSeasons.md)
 - [Model.Conference](docs/Conference.md)
 - [Model.ConferenceSPRating](docs/ConferenceSPRating.md)
 - [Model.ConferenceSPRatingDefense](docs/ConferenceSPRatingDefense.md)
 - [Model.ConferenceSPRatingOffense](docs/ConferenceSPRatingOffense.md)
 - [Model.DraftPick](docs/DraftPick.md)
 - [Model.DraftPickHometownInfo](docs/DraftPickHometownInfo.md)
 - [Model.DraftPosition](docs/DraftPosition.md)
 - [Model.DraftTeam](docs/DraftTeam.md)
 - [Model.Drive](docs/Drive.md)
 - [Model.DriveStartTime](docs/DriveStartTime.md)
 - [Model.Game](docs/Game.md)
 - [Model.GameLines](docs/GameLines.md)
 - [Model.GameLinesLines](docs/GameLinesLines.md)
 - [Model.GameMedia](docs/GameMedia.md)
 - [Model.GamePPA](docs/GamePPA.md)
 - [Model.GamePPAOffense](docs/GamePPAOffense.md)
 - [Model.GameWeather](docs/GameWeather.md)
 - [Model.LivePlayByPlay](docs/LivePlayByPlay.md)
 - [Model.LivePlayByPlayDrives](docs/LivePlayByPlayDrives.md)
 - [Model.LivePlayByPlayPlays](docs/LivePlayByPlayPlays.md)
 - [Model.LivePlayByPlayTeams](docs/LivePlayByPlayTeams.md)
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
 - [Model.PortalPlayer](docs/PortalPlayer.md)
 - [Model.PositionGroupRecruitingRating](docs/PositionGroupRecruitingRating.md)
 - [Model.PredictedPoints](docs/PredictedPoints.md)
 - [Model.PregameWP](docs/PregameWP.md)
 - [Model.RankingWeek](docs/RankingWeek.md)
 - [Model.RankingWeekPolls](docs/RankingWeekPolls.md)
 - [Model.RankingWeekRanks](docs/RankingWeekRanks.md)
 - [Model.Recruit](docs/Recruit.md)
 - [Model.RecruitHometownInfo](docs/RecruitHometownInfo.md)
 - [Model.ReturningProduction](docs/ReturningProduction.md)
 - [Model.ScoreboardGame](docs/ScoreboardGame.md)
 - [Model.ScoreboardGameBetting](docs/ScoreboardGameBetting.md)
 - [Model.ScoreboardGameHomeTeam](docs/ScoreboardGameHomeTeam.md)
 - [Model.ScoreboardGameVenue](docs/ScoreboardGameVenue.md)
 - [Model.ScoreboardGameWeather](docs/ScoreboardGameWeather.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamEloRating](docs/TeamEloRating.md)
 - [Model.TeamGame](docs/TeamGame.md)
 - [Model.TeamGameStats](docs/TeamGameStats.md)
 - [Model.TeamGameTeams](docs/TeamGameTeams.md)
 - [Model.TeamLocation](docs/TeamLocation.md)
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
 - [Model.Week](docs/Week.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

