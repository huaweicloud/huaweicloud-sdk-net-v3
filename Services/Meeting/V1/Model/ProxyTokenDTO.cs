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
    /// 代理鉴权信息。
    /// </summary>
    public class ProxyTokenDTO 
    {

        /// <summary>
        /// 代理鉴权服务器的短token字符串。
        /// </summary>
        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 代理鉴权服务器的长token字符串。
        /// </summary>
        [JsonProperty("longAccessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string LongAccessToken { get; set; }

        /// <summary>
        /// Token有效时长，单位：秒。
        /// </summary>
        [JsonProperty("validPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValidPeriod { get; set; }

        /// <summary>
        /// 中台地址。
        /// </summary>
        [JsonProperty("middleEndUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleEndUrl { get; set; }

        /// <summary>
        /// 中台内网地址。
        /// </summary>
        [JsonProperty("middleEndInnerUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleEndInnerUrl { get; set; }

        /// <summary>
        /// 是否开启二次路由。
        /// </summary>
        [JsonProperty("enableRerouting", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRerouting { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyTokenDTO {\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  longAccessToken: ").Append(LongAccessToken).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  middleEndUrl: ").Append(MiddleEndUrl).Append("\n");
            sb.Append("  middleEndInnerUrl: ").Append(MiddleEndInnerUrl).Append("\n");
            sb.Append("  enableRerouting: ").Append(EnableRerouting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyTokenDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyTokenDTO input)
        {
            if (input == null) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.LongAccessToken != input.LongAccessToken || (this.LongAccessToken != null && !this.LongAccessToken.Equals(input.LongAccessToken))) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;
            if (this.MiddleEndUrl != input.MiddleEndUrl || (this.MiddleEndUrl != null && !this.MiddleEndUrl.Equals(input.MiddleEndUrl))) return false;
            if (this.MiddleEndInnerUrl != input.MiddleEndInnerUrl || (this.MiddleEndInnerUrl != null && !this.MiddleEndInnerUrl.Equals(input.MiddleEndInnerUrl))) return false;
            if (this.EnableRerouting != input.EnableRerouting || (this.EnableRerouting != null && !this.EnableRerouting.Equals(input.EnableRerouting))) return false;

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
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.LongAccessToken != null) hashCode = hashCode * 59 + this.LongAccessToken.GetHashCode();
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.MiddleEndUrl != null) hashCode = hashCode * 59 + this.MiddleEndUrl.GetHashCode();
                if (this.MiddleEndInnerUrl != null) hashCode = hashCode * 59 + this.MiddleEndInnerUrl.GetHashCode();
                if (this.EnableRerouting != null) hashCode = hashCode * 59 + this.EnableRerouting.GetHashCode();
                return hashCode;
            }
        }
    }
}
