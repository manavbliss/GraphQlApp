using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace  GraphQlApp
{
    using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public partial class GithubResponse
{
    [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public Data Data { get; set; }
}

public partial class Data
{
    [JsonProperty("allFilms", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public AllFilms AllFilms { get; set; }
}

public partial class AllFilms
{
    [JsonProperty("films", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public Film[] Films { get; set; }
}

public partial class Film
{
    [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("episodeID", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public long? EpisodeId { get; set; }

    [JsonProperty("director", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Director { get; set; }
    }
}

//namespace GraphQlApp
//    {


//        public partial class GithubResponse
//        {
//            [JsonProperty("data")]
//            public Data Data { get; set; }
//        }

//        public partial class Data
//        {
//            [JsonProperty("user")]
//            public User User { get; set; }
//        }

//        public partial class User
//        {
//            [JsonProperty("bio")]
//            public string Bio { get; set; }

//            [JsonProperty("id")]
//            public string Id { get; set; }

//            [JsonProperty("company")]
//            public string Company { get; set; }

//            [JsonProperty("name")]
//            public string Name { get; set; }

//            [JsonProperty("createdAt")]
//            public DateTimeOffset CreatedAt { get; set; }
//        }
//    }







