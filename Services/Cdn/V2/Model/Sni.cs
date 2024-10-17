using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 回源SNI。
    /// </summary>
    public class Sni 
    {

        /// <summary>
        /// 是否开启回源SNI，on：打开，off：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// CDN节点回源需要访问的源站域名。如test.example.com。   &gt; 1. 开启回源SNI时必填。   &gt; 2. 不支持泛域名，仅支持输入数字、“-”、“.”、英文大小写字符。
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sni {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Sni);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Sni input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;

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
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
