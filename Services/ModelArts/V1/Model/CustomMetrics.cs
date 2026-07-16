using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomMetrics 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("exec", NullValueHandling = NullValueHandling.Ignore)]
        public Exec Exec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http_get", NullValueHandling = NullValueHandling.Ignore)]
        public HttpGet HttpGet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomMetrics {\n");
            sb.Append("  exec: ").Append(Exec).Append("\n");
            sb.Append("  httpGet: ").Append(HttpGet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomMetrics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomMetrics input)
        {
            if (input == null) return false;
            if (this.Exec != input.Exec || (this.Exec != null && !this.Exec.Equals(input.Exec))) return false;
            if (this.HttpGet != input.HttpGet || (this.HttpGet != null && !this.HttpGet.Equals(input.HttpGet))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Exec != null) hashCode = hashCode * 59 + this.Exec.GetHashCode();
                if (this.HttpGet != null) hashCode = hashCode * 59 + this.HttpGet.GetHashCode();
                return hashCode;
            }
        }
    }
}
