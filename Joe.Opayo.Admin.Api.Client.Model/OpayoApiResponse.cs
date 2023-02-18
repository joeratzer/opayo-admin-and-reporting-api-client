﻿using System.Text;
using Joe.Opayo.Admin.Api.Client.Model.Extensions;

namespace Joe.Opayo.Admin.Api.Client.Model
{
    public class OpayoApiResponse
    {
        public OpayoApiResponse(string? content, bool success)
        {
            Content = content;
            Messages = new List<string>();
            Success = success;
        }

        public string? Content { get; set; }
        public List<string> Messages { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{nameof(Content)}: {Content}. ");
            sb.Append($"{nameof(Messages)}: {Messages.ToCsv()}. ");
            sb.Append($"{nameof(Success)}: {Success}. ");
            return sb.ToString().Trim();
        }
    }
}