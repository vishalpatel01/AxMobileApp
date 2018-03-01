using Android.App;
using Android.OS;
using Android.Widget;
using System.Threading.Tasks;
using System.Net;
using System;
using System.IO;
using System.Json;
using System.Net.Http;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using SampleOne.xmltoobject;
using System.Text.RegularExpressions;
using Android.Views;

namespace SampleOne
{
    [Activity(Label = "SampleOne", MainLauncher = true, Icon = "@drawable/IconAx")]
    public class MainActivity : Activity
    {
        Button btnLog;
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            btnLog = FindViewById<Button>(Resource.Id.btnLog);
            btnLog.Click += BtnLog_Click;
        }

        private async void BtnLog_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(DashboardActivityA));
            //string url = "http://223.196.116.19:8089/20180113_072244_7330484_00001.xml";
            ////JsonValue json = await FetchWeatherAsync(url);

            //Uri geturi = new Uri(url); //replace your xml url  
            //HttpClient client = new HttpClient();
            //HttpResponseMessage responseGet = await client.GetAsync(geturi);
            //string response = await responseGet.Content.ReadAsStringAsync();//Getting response  
            ////string Text = HtmlToPlainText(response);

            ////Convert object to xml format.
            //Object obj = ObjectToXML(response, typeof(Envelope));

            ////Conversion of c# object to Envelope class object instant 
            //Envelope MainObj = (Envelope)obj;
            //List<PriceDiscTable> PriceDiscTableItems = MainObj.Body.MessageParts.KSIItemPriceDiscAdm.PriceDiscTable;
        }

        private async Task<JsonValue> FetchWeatherAsync(string url)
        {
            // Create an HTTP web request using the URL:
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (WebResponse response = await request.GetResponseAsync())
            {
                // Get a stream representation of the HTTP web response:
                using (Stream stream = response.GetResponseStream())
                {
                   
                    // Use this stream to build a JSON document object:
                    JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
                    Console.Out.WriteLine("Response: {0}", jsonDoc.ToString());

                    // Return the JSON document:
                    return jsonDoc;
                }
            }
        }

        public static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch (Exception exp)
            {
                //Handle Exception Code
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }

        private static string HtmlToPlainText(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
            const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR />
            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            //Decode html specific characters
            text = System.Net.WebUtility.HtmlDecode(text);
            //Remove tag whitespace/line breaks
            text = tagWhiteSpaceRegex.Replace(text, "><");
            //Replace <br /> with line breaks
            text = lineBreakRegex.Replace(text, System.Environment.NewLine);
            //Strip formatting
            text = stripFormattingRegex.Replace(text, string.Empty);

            return text;
        }
    }
}

