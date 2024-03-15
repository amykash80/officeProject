﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Shared
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = null!;

        public T? Result { get; set; }

        public int StatusCode { get; set; }


        public static ApiResponse<T> SuccessResponse(T? result, string message = "Success", int statusCode = HttpStatusCodes.OK)
        {

            return new ApiResponse<T>() { 
            IsSuccess=true,
            Message = message,
            StatusCode = statusCode,
            Result = result,
            
            };


        }

        public static ApiResponse<T> ErrorResponse( string message = "Error", int statusCode = HttpStatusCodes.BadRequest)
        {

            return new ApiResponse<T>()
            {
                IsSuccess = false,
                Message = message,
                StatusCode = statusCode,
            
            };


        }
    }
}