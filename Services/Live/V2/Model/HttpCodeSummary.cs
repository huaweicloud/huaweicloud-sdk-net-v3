using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpCodeSummary 
    {

        /// <summary>
        /// 状态码信息
        /// </summary>
        [JsonProperty("http_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpCode> HttpCodes { get; set; }

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ 。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpCodeSummary {\n");
            sb.Append("  httpCodes: ").Append(HttpCodes).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpCodeSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpCodeSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpCodes == input.HttpCodes ||
                    this.HttpCodes != null &&
                    input.HttpCodes != null &&
                    this.HttpCodes.SequenceEqual(input.HttpCodes)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HttpCodes != null)
                    hashCode = hashCode * 59 + this.HttpCodes.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
