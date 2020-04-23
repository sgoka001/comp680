using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using comp680.Models;
using Newtonsoft.Json.Linq;

namespace comp680.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        List<Team> lstTeams = new List<Team>();
        public IActionResult Index()
        {
            return View();
        }

         public async System.Threading.Tasks.Task<IActionResult> NHL()
        {
            //Now define your asynchronous method which will retrieve all your pokemon.
            //Define your baseUrl
            string baseUrl = "https://site.api.espn.com/apis/v2/sports/hockey/nhl/standings";
            //Have your using statements within a try/catch block
            try
            {
                //We will now define your HttpClient with your first using statement which will implements a IDisposable interface.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (content != null)
                            {
                                var json = JObject.Parse(data);
                                //Now log your data object in the console
                                var entries = json["children"][0]["standings"]["entries"];

                                int i = 0;
                                foreach (JObject jObj in entries)
                                {
                                    Team fbt = new Team();
                                    fbt.TeamName = jObj["team"]["name"].ToString();
                                    fbt.TeamDisplayName = jObj["team"]["displayName"].ToString();
                                    fbt.TeamAbbreviation = jObj["team"]["abbreviation"].ToString();
                                    fbt.TeamShortDisplayName = jObj["team"]["shortDisplayName"].ToString();
                                    if (i == 10) //ALLOWS ONLY THE TOP 10 RESULTS
                                        break;

                                    lstTeams.Add(fbt);
                                    i++;
                                }
                            }
                            else
                            {
                                // If not data found
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }

            return View(lstTeams);
        }


        public IActionResult NBA()
        {
            return View();
        }

        public async System.Threading.Tasks.Task<IActionResult> NFL()
        {
            //Now define your asynchronous method which will retrieve all your pokemon.
            //Define your baseUrl
            string baseUrl = "https://site.api.espn.com/apis/v2/sports/football/nfl/standings";
            //Have your using statements within a try/catch block
            try
            {
                //We will now define your HttpClient with your first using statement which will implements a IDisposable interface.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (content != null)
                            {
                                var json = JObject.Parse(data);
                                //Now log your data object in the console
                                var entries = json["children"][0]["standings"]["entries"];

                                int i = 0;
                                foreach (JObject jObj in entries)
                                {
                                    Team fbt = new Team();
                                    fbt.TeamName = jObj["team"]["name"].ToString();
                                    fbt.TeamDisplayName = jObj["team"]["displayName"].ToString();
                                    fbt.TeamAbbreviation = jObj["team"]["abbreviation"].ToString();
                                    fbt.TeamShortDisplayName = jObj["team"]["shortDisplayName"].ToString();
                                    if (i == 10) //ALLOWS ONLY THE TOP 10 RESULTS
                                        break;

                                    lstTeams.Add(fbt);
                                    i++;
                                }
                            }
                            else
                            {
                                // If not data found
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }

            return View(lstTeams);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
