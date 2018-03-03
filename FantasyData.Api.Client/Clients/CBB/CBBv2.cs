﻿using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client
{
    public partial class CBBv2Client : BaseClient
    {
        public CBBv2Client(string apiKey) : base(apiKey) { }
        public CBBv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/cbb/v2/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/cbb/v2/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/cbb/v2/{format}/BoxScores/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/cbb/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<Season>("/cbb/v2/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/cbb/v2/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// League Hierarchy
        /// </summary>
        public List<Conference> GetLeagueHierarchy()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Conference>>("/cbb/v2/{format}/LeagueHierarchy", parameters);
        }

        /// <summary>
        /// Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/cbb/v2/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/cbb/v2/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Details by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Player>>("/cbb/v2/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGame>>("/cbb/v2/{format}/PlayerGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGame>("/cbb/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/cbb/v2/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerSeason>("/cbb/v2/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/cbb/v2/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGameProjection>>("/cbb/v2/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerGameProjection GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGameProjection>("/cbb/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/cbb/v2/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/cbb/v2/{format}/TeamGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/cbb/v2/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/cbb/v2/{format}/teams", parameters);
        }

        /// <summary>
        /// Tournament Hierarchy
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Tournament GetTournament(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<Tournament>("/cbb/v2/{format}/Tournament/{season}", parameters);
        }

    }
}

