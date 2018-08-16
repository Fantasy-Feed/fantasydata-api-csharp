﻿using System;
using System.Linq;
using FantasyData.Api.Client;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client and get data
            var client = new MLBv3ProjectionsClient("<API key goes here>");
            var projections = client.GetPlayerGameProjectionStatsByDate("2018-03-29").OrderByDescending(p => p.DraftKingsSalary).Take(20).ToList();

            // Write data to console
            foreach(var projection in projections)
            {
                Console.WriteLine($"{projection.PlayerID} - {projection.Name} ({projection.DraftKingsPosition}) DraftKings Salary: {projection.DraftKingsSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

