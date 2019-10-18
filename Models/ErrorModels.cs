﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicList2.Models
{
    /// <summary>
    /// Model returned by various error responses.
    /// </summary>
    public class ErrorModel
    {
        public int Code;
        public string Message;

        public ErrorModel(int code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// Error model object for 400 Bad Request.
        /// </summary>
        /// <returns>ErrorModel</returns>
        public static ErrorModel BadRequest() => 
            new ErrorModel(400, "bad request");

        /// <summary>
        /// Error model object for 404 Not Found.
        /// </summary>
        /// <returns>ErrorModel</returns>
        public static ErrorModel NotFound() => 
            new ErrorModel(404, "not found");

        /// <summary>
        /// Error mdoel object when to creating object
        /// already exists.
        /// </summary>
        /// <returns>ErrorModel</returns>
        public static ErrorModel AlreadyExists() =>
            new ErrorModel(400, "already exists");

        public static ErrorModel RateLimited() =>
            new ErrorModel(429, "you are being rate limited");
    }
}
