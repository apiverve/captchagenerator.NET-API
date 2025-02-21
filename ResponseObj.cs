using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("expires")]
    public int expires { get; set; }

    [JsonProperty("solution")]
    public string solution { get; set; }

    [JsonProperty("downloadURL")]
    public string downloadURL { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
