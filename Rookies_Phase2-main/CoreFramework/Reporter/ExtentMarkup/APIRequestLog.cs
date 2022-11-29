﻿using AventStack.ExtentReports.MarkupUtils;
using CoreFramework.APICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Reporter.ExtentMarkup
{
    public class APIRequestLog : IMarkup
    {
        private APIRequest request { get; set; }
        private APIResponse response { get; set; }

        public APIRequestLog(APIRequest request, APIResponse response)
        {
            this.request = request;
            this.response = response;
        }
        public string GetMarkup()
        {
            string log = $@"
                <p>Request url: {request.url}<p>
                <p>Response body: {response.responseBody}</p>
                <p>Response status code: {response.responseStatusCode} <p>
            ";
            return log;
        }
    }
}
