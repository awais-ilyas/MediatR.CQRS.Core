using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class Response
    {
        public static Responce<T> Fail<T>(string message, T data = default) => new Responce<T>(data, message, true);
        public static Responce<T> Ok<T>(T data, string message) => new Responce<T>(data, message, false);
    }

    public class Responce<T>
    {
        public Responce(T data, string msg, bool success)
        {
            Data = data;
            Message = msg;
            Success = success;
        }
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
