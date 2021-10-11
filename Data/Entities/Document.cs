using System;

namespace FunctionApp.Data.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        public Guid FileId { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }
        public string Filetype { get; set; }
        public string Data { get; set; }
    }
}