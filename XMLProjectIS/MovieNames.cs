﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

using System.Globalization;

namespace MovieNames
{
    public partial class Movies
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("cast")]
        public string[] Cast { get; set; }

        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }
    }

    public enum Genre { Action, Adventure, Animated, Biography, Comedy, Crime, Dance, Disaster, Documentary, Drama, Erotic, Family, Fantasy, FoundFootage, Historical, Horror, Independent, Legal, LiveAction, MartialArts, Musical, Mystery, Noir, Performance, Political, Romance, Satire, ScienceFiction, Short, Silent, Slasher, Sport, Sports, Spy, Superhero, Supernatural, Suspense, Teen, Thriller, War, Western };

    public partial class Movies
    {
        public static Movies[] FromJson(string json) => JsonConvert.DeserializeObject<Movies[]>(json, MovieNames.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Movies[] self) => JsonConvert.SerializeObject(self, MovieNames.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GenreConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GenreConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Genre) || t == typeof(Genre?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Action":
                    return Genre.Action;
                case "Adventure":
                    return Genre.Adventure;
                case "Animated":
                    return Genre.Animated;
                case "Biography":
                    return Genre.Biography;
                case "Comedy":
                    return Genre.Comedy;
                case "Crime":
                    return Genre.Crime;
                case "Dance":
                    return Genre.Dance;
                case "Disaster":
                    return Genre.Disaster;
                case "Documentary":
                    return Genre.Documentary;
                case "Drama":
                    return Genre.Drama;
                case "Erotic":
                    return Genre.Erotic;
                case "Family":
                    return Genre.Family;
                case "Fantasy":
                    return Genre.Fantasy;
                case "Found Footage":
                    return Genre.FoundFootage;
                case "Historical":
                    return Genre.Historical;
                case "Horror":
                    return Genre.Horror;
                case "Independent":
                    return Genre.Independent;
                case "Legal":
                    return Genre.Legal;
                case "Live Action":
                    return Genre.LiveAction;
                case "Martial Arts":
                    return Genre.MartialArts;
                case "Musical":
                    return Genre.Musical;
                case "Mystery":
                    return Genre.Mystery;
                case "Noir":
                    return Genre.Noir;
                case "Performance":
                    return Genre.Performance;
                case "Political":
                    return Genre.Political;
                case "Romance":
                    return Genre.Romance;
                case "Satire":
                    return Genre.Satire;
                case "Science Fiction":
                    return Genre.ScienceFiction;
                case "Short":
                    return Genre.Short;
                case "Silent":
                    return Genre.Silent;
                case "Slasher":
                    return Genre.Slasher;
                case "Sport":
                    return Genre.Sport;
                case "Sports":
                    return Genre.Sports;
                case "Spy":
                    return Genre.Spy;
                case "Superhero":
                    return Genre.Superhero;
                case "Supernatural":
                    return Genre.Supernatural;
                case "Suspense":
                    return Genre.Suspense;
                case "Teen":
                    return Genre.Teen;
                case "Thriller":
                    return Genre.Thriller;
                case "War":
                    return Genre.War;
                case "Western":
                    return Genre.Western;
            }
            throw new Exception("Cannot unmarshal type Genre");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Genre)untypedValue;
            switch (value)
            {
                case Genre.Action:
                    serializer.Serialize(writer, "Action");
                    return;
                case Genre.Adventure:
                    serializer.Serialize(writer, "Adventure");
                    return;
                case Genre.Animated:
                    serializer.Serialize(writer, "Animated");
                    return;
                case Genre.Biography:
                    serializer.Serialize(writer, "Biography");
                    return;
                case Genre.Comedy:
                    serializer.Serialize(writer, "Comedy");
                    return;
                case Genre.Crime:
                    serializer.Serialize(writer, "Crime");
                    return;
                case Genre.Dance:
                    serializer.Serialize(writer, "Dance");
                    return;
                case Genre.Disaster:
                    serializer.Serialize(writer, "Disaster");
                    return;
                case Genre.Documentary:
                    serializer.Serialize(writer, "Documentary");
                    return;
                case Genre.Drama:
                    serializer.Serialize(writer, "Drama");
                    return;
                case Genre.Erotic:
                    serializer.Serialize(writer, "Erotic");
                    return;
                case Genre.Family:
                    serializer.Serialize(writer, "Family");
                    return;
                case Genre.Fantasy:
                    serializer.Serialize(writer, "Fantasy");
                    return;
                case Genre.FoundFootage:
                    serializer.Serialize(writer, "Found Footage");
                    return;
                case Genre.Historical:
                    serializer.Serialize(writer, "Historical");
                    return;
                case Genre.Horror:
                    serializer.Serialize(writer, "Horror");
                    return;
                case Genre.Independent:
                    serializer.Serialize(writer, "Independent");
                    return;
                case Genre.Legal:
                    serializer.Serialize(writer, "Legal");
                    return;
                case Genre.LiveAction:
                    serializer.Serialize(writer, "Live Action");
                    return;
                case Genre.MartialArts:
                    serializer.Serialize(writer, "Martial Arts");
                    return;
                case Genre.Musical:
                    serializer.Serialize(writer, "Musical");
                    return;
                case Genre.Mystery:
                    serializer.Serialize(writer, "Mystery");
                    return;
                case Genre.Noir:
                    serializer.Serialize(writer, "Noir");
                    return;
                case Genre.Performance:
                    serializer.Serialize(writer, "Performance");
                    return;
                case Genre.Political:
                    serializer.Serialize(writer, "Political");
                    return;
                case Genre.Romance:
                    serializer.Serialize(writer, "Romance");
                    return;
                case Genre.Satire:
                    serializer.Serialize(writer, "Satire");
                    return;
                case Genre.ScienceFiction:
                    serializer.Serialize(writer, "Science Fiction");
                    return;
                case Genre.Short:
                    serializer.Serialize(writer, "Short");
                    return;
                case Genre.Silent:
                    serializer.Serialize(writer, "Silent");
                    return;
                case Genre.Slasher:
                    serializer.Serialize(writer, "Slasher");
                    return;
                case Genre.Sport:
                    serializer.Serialize(writer, "Sport");
                    return;
                case Genre.Sports:
                    serializer.Serialize(writer, "Sports");
                    return;
                case Genre.Spy:
                    serializer.Serialize(writer, "Spy");
                    return;
                case Genre.Superhero:
                    serializer.Serialize(writer, "Superhero");
                    return;
                case Genre.Supernatural:
                    serializer.Serialize(writer, "Supernatural");
                    return;
                case Genre.Suspense:
                    serializer.Serialize(writer, "Suspense");
                    return;
                case Genre.Teen:
                    serializer.Serialize(writer, "Teen");
                    return;
                case Genre.Thriller:
                    serializer.Serialize(writer, "Thriller");
                    return;
                case Genre.War:
                    serializer.Serialize(writer, "War");
                    return;
                case Genre.Western:
                    serializer.Serialize(writer, "Western");
                    return;
            }
            throw new Exception("Cannot marshal type Genre");
        }

        public static readonly GenreConverter Singleton = new GenreConverter();
    }
}
