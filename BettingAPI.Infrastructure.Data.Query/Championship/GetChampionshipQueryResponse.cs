﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingAPI.Infrastructure.Data.Query.Championship
{
    public class GetChampionshipQueryResponse
    {
            [JsonProperty("campeonato_id")]
            public int CampeonatoId { get; set; }

            [JsonProperty("nome")]
            public string Nome { get; set; }

            [JsonProperty("slug")]
            public string Slug { get; set; }

            [JsonProperty("nome_popular")]
            public string NomePopular { get; set; }

            [JsonProperty("edicao_atual")]
            public EdicaoAtual EdicaoAtual { get; set; }

            [JsonProperty("fase_atual")]
            public FaseAtual FaseAtual { get; set; }

            [JsonProperty("rodada_atual")]
            public int RodadaAtual { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("tipo")]
            public string Tipo { get; set; }

            [JsonProperty("logo")]
            public string Logo { get; set; }

            [JsonProperty("_link")]
            public string Link { get; set; }
        }
    }

    public class FaseAtual
    {
        [JsonProperty("fase_id")]
        public int FaseId { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
        [JsonProperty("_link")]
        public string Link { get; set; }
    }

    public class EdicaoAtual
    {
        [JsonProperty("edicao_id")]
        public int EdicaoId { get; set; }
        [JsonProperty("temporada")]
        public int Temporada { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("nome_popular")]
        public string NomePopular { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

