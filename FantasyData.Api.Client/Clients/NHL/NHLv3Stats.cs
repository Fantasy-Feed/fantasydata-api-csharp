﻿using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client
{
    public partial class NHLv3StatsClient : BaseClient
    {
        public NHLv3StatsClient(string apiKey) : base(apiKey) { }
        public NHLv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/nhl/stats/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/v3/nhl/stats/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/v3/nhl/stats/{format}/BoxScores/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/v3/nhl/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<Season>("/v3/nhl/stats/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DfsSlate>>("/v3/nhl/stats/{format}/DfsSlatesByDate/{date}", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/v3/nhl/stats/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// Line Combinations by Season
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<TeamLine> GetLinesBySeason(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamLine>>("/v3/nhl/stats/{format}/LinesBySeason/{season}", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/nhl/stats/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/nhl/stats/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/nhl/stats/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/nhl/stats/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Free Agent
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/nhl/stats/{format}/FreeAgents", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000007</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/v3/nhl/stats/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nhl/stats/{format}/PlayerGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGame>("/v3/nhl/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/nhl/stats/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerSeason>("/v3/nhl/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/nhl/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Player>>("/v3/nhl/stats/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/nhl/stats/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/nhl/stats/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Standing>>("/v3/nhl/stats/{format}/Standings/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/v3/nhl/stats/{format}/TeamGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/nhl/stats/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Team Stats Allowed by Position
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<TeamSeason> GetTeamStatsAllowedByPosition(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/nhl/stats/{format}/TeamStatsAllowedByPosition/{season}", parameters);
        }

        /// <summary>
        /// Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nhl/stats/{format}/teams", parameters);
        }

        /// <summary>
        /// Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nhl/stats/{format}/AllTeams", parameters);
        }

    }
}

