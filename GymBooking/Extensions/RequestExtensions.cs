﻿namespace GymBooking.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjax(this HttpRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return request.Headers["X-Requested-with"] == "XMLHttpRequest";
        }
    }
}
