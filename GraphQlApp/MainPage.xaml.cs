using System;
using System.Collections.Generic;
using System.ComponentModel;
using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQlApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
          


            //ResponseLabel.Text = "Fetching data";
            //var client = new HttpClient();
            //client.DefaultRequestHeaders.Add("Authorization", "");
            //client.DefaultRequestHeaders.Add("User-Agent", "");
            //var stringContent = new StringContent "{/ "query { user(login: manavbliss) { bio, id, company, name, createdAt } }\"}"};



            //var httpRes

            //var client = new GraphQLClient("https://api.github.com/graphql");
            var client = new GraphQLClient("https://swapi.apis.guru/");
           // client.DefaultRequestHeaders.Add("User-Agent", "Graphql Api");
            //client.DefaultRequestHeaders.Add("Authorization", "bearer 7e434a81dcf48fc753e4aceca78e5c9174747bcc");

            //var stringContent = new StringContent("{\"query\":\"query {user(login: manavbliss) { bio, id, company, name, createdAt } }\"}");

            GraphQLRequest graphQlRequest = new GraphQLRequest()
            {



                //Query = "query {user(login: manavbliss) { bio,id,company,name,createdAt }}"
           Query =  "query{ allFilms{ films { id,title,episodeID,director } }}"
   



    };

          



            GraphQLResponse graphQLResponse = await client.PostAsync(graphQlRequest);
            //List<Film> films = graphQLResponse.Data.allFilms.films;

            //List<Film> items = ((JArray)Array).Select(x => new SelectableEnumItem
            //{
            //    title = (string)x["title"],

            //}).ToList();
            //film_list.ItemsSource = films;



            List<Film> films = graphQLResponse.Data.allFilms.films.ToObject<List<Film>>();

            
            film_list.ItemsSource = films;



            Console.WriteLine("Manav" +films[0].Title);

            foreach (var film in films)
            {
                Console.WriteLine("Title {0}", film.Title);
            }



            //posts = JsonConvert.DeserializeObject<List<Models.Film>>(graphQLResponse.Data.allFilms.films.title);
            ////Assigning the ObservableCollection to MyListView in the XAML of this file

            //Post_List.ItemsSource = posts;


            base.OnAppearing();

        }
    }
}
