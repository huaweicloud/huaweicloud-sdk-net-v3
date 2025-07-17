using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 主持人允许观众入会入会请求消息体
    /// </summary>
    public class RestAllowAudienceReqBody 
    {

        /// <summary>
        /// 主持人是否允许入会 1：允许入会
        /// </summary>
        [JsonProperty("allowAudience", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowAudience { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestAllowAudienceReqBody {\n");
            sb.Append("  allowAudience: ").Append(AllowAudience).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestAllowAudienceReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestAllowAudienceReqBody input)
        {
            if (input == null) return false;
            if (this.AllowAudience != input.AllowAudience || (this.AllowAudience != null && !this.AllowAudience.Equals(input.AllowAudience))) return false;

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
                if (this.AllowAudience != null) hashCode = hashCode * 59 + this.AllowAudience.GetHashCode();
                return hashCode;
            }
        }
    }
}
