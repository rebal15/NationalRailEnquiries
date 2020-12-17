using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailEnquiriesDarwin.Services
{
    class HttpRequestService
    {
        public HttpWebRequest Request { get; set; }
        public Stream ResponseStream { get; set; }
        private StreamReader StreamReader { get; set; }
        public HttpRequestService(string url)
        {
            Request = (HttpWebRequest)WebRequest.Create(url);
        }
        public void Close()
        {
            if (StreamReader != null)
            {
                StreamReader.Close();
            }
        }
        public string Get()
        {
            Request.Method = "GET";
            try
            {
                ResponseStream = Request.GetResponse().GetResponseStream();
            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }
            StreamReader = new StreamReader(ResponseStream);
            return StreamReader.ReadToEnd();
        }
        public async Task<string> GetAsync()
        {
            Request.Method = "GET";
            ResponseStream = (await Request.GetResponseAsync()).GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return await StreamReader.ReadToEndAsync();
        }
        public string Post(Dictionary<string, string> payload)
        {
            var postData = "";
            var i = 0;
            foreach (var item in payload)
            {
                if (i == 0)
                {
                    postData = Uri.EscapeDataString(item.Key) + "=" + Uri.EscapeDataString(item.Value);
                }
                else
                {
                    postData += "&" + Uri.EscapeDataString(item.Key) + "=" + Uri.EscapeDataString(item.Value);
                }
                i++;
            }
            var data = Encoding.ASCII.GetBytes(postData);
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = data.Length;
            using (var stream = Request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            ResponseStream = Request.GetResponse().GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return StreamReader.ReadToEnd();
        }
        public async Task<string> PostAsync(Dictionary<string, string> payload)
        {
            var postData = "";
            var i = 0;
            foreach (var item in payload)
            {
                if (i == 0)
                {
                    postData = Uri.EscapeDataString(item.Key) + "=" + Uri.EscapeDataString(item.Value);
                }
                else
                {
                    postData += "&" + Uri.EscapeDataString(item.Key) + "=" + Uri.EscapeDataString(item.Value);
                }
                i++;
            }
            var data = Encoding.ASCII.GetBytes(postData);
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = data.Length;
            using (var stream = Request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            ResponseStream = (await Request.GetResponseAsync()).GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return await StreamReader.ReadToEndAsync();
        }
        public string PostRaw(string postData)
        {
            var data = Encoding.ASCII.GetBytes(postData);
            Request.Method = "POST";
            Request.ContentType = "text/plain";
            Request.ContentLength = data.Length;
            using (var stream = Request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            ResponseStream = Request.GetResponse().GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return StreamReader.ReadToEnd();
        }
        public void AddHeader(string name, string value)
        {
            Request.Headers.Add(name, value);
        }
        public string PostXml(string postData, string soapAction)
        {
            var data = Encoding.ASCII.GetBytes(postData);
            Request.Method = "POST";
            Request.ContentType = "text/xml";
            Request.ContentLength = data.Length;
            Request.Headers.Add("SOAPAction", soapAction);
            using (var stream = Request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            ResponseStream = Request.GetResponse().GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return StreamReader.ReadToEnd();
        }
        public async Task<string> PostRawAsync(string postData)
        {
            var data = Encoding.ASCII.GetBytes(postData);
            Request.Method = "POST";
            Request.ContentType = "text/plain";
            Request.ContentLength = data.Length;
            using (var stream = Request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            ResponseStream = (await Request.GetResponseAsync()).GetResponseStream();
            StreamReader = new StreamReader(ResponseStream);
            return await StreamReader.ReadToEndAsync();
        }
    }
}
