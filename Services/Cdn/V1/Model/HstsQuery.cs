using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// HSTS：配置HSTS后，将强制客户端（如浏览器）使用 HTTPS 协议访问服务器，提升访问安全性。
    /// </summary>
    public class HstsQuery 
    {

        /// <summary>
        /// 状态，on：打开，off：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 过期时间,即：响应头“Strict-Transport-Security”在客户端的缓存时间。单位:秒。
        /// </summary>
        [JsonProperty("max_age", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// 包含子域名，on：包含，off：不包含。
        /// </summary>
        [JsonProperty("include_subdomains", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeSubdomains { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HstsQuery {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  maxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  includeSubdomains: ").Append(IncludeSubdomains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HstsQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HstsQuery input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.MaxAge != input.MaxAge || (this.MaxAge != null && !this.MaxAge.Equals(input.MaxAge))) return false;
            if (this.IncludeSubdomains != input.IncludeSubdomains || (this.IncludeSubdomains != null && !this.IncludeSubdomains.Equals(input.IncludeSubdomains))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MaxAge != null) hashCode = hashCode * 59 + this.MaxAge.GetHashCode();
                if (this.IncludeSubdomains != null) hashCode = hashCode * 59 + this.IncludeSubdomains.GetHashCode();
                return hashCode;
            }
        }
    }
}
