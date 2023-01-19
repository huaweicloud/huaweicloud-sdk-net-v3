using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 监听器HTTP扩展头部对象。
    /// </summary>
    public class InsertHeader 
    {

        /// <summary>
        /// 负载均衡器弹性公网IP透传开关。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBIP { get; set; }

        /// <summary>
        /// X-Forwarded-Host设为true可以将客户请求头的第一个X-Forwarded-Host设置为请求头的Host带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedHost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertHeader {\n");
            sb.Append("  xForwardedELBIP: ").Append(XForwardedELBIP).Append("\n");
            sb.Append("  xForwardedHost: ").Append(XForwardedHost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsertHeader);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsertHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XForwardedELBIP == input.XForwardedELBIP ||
                    (this.XForwardedELBIP != null &&
                    this.XForwardedELBIP.Equals(input.XForwardedELBIP))
                ) && 
                (
                    this.XForwardedHost == input.XForwardedHost ||
                    (this.XForwardedHost != null &&
                    this.XForwardedHost.Equals(input.XForwardedHost))
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
                if (this.XForwardedELBIP != null)
                    hashCode = hashCode * 59 + this.XForwardedELBIP.GetHashCode();
                if (this.XForwardedHost != null)
                    hashCode = hashCode * 59 + this.XForwardedHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
