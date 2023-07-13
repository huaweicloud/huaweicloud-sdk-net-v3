using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 可选的HTTP头插入，可以将从负载均衡器到后端云服务器的路径中需要被后端云服务器用到的信息写入HTTP中，随报文传递到后端云服务器使。例如可通过X-Forwarded-ELB-IP开关，将负载均衡器的弹性公网IP传到后端云服务器。
    /// </summary>
    public class ListenerInsertHeaders 
    {

        /// <summary>
        /// X-Forwarded-ELB-IP设为true可以将ELB实例的eip地址从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBIP { get; set; }

        /// <summary>
        /// X-Forwarded-Port设为true可以将ELB实例的监听端口从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedPort { get; set; }

        /// <summary>
        /// X-Forwarded-For-Port设为true可以将客户端的源端口从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-For-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedForPort { get; set; }

        /// <summary>
        /// X-Forwarded-Host设为true可以将客户请求头的X-Forwarded-Host设置为请求头的Host带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedHost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListenerInsertHeaders {\n");
            sb.Append("  xForwardedELBIP: ").Append(XForwardedELBIP).Append("\n");
            sb.Append("  xForwardedPort: ").Append(XForwardedPort).Append("\n");
            sb.Append("  xForwardedForPort: ").Append(XForwardedForPort).Append("\n");
            sb.Append("  xForwardedHost: ").Append(XForwardedHost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListenerInsertHeaders);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListenerInsertHeaders input)
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
                    this.XForwardedPort == input.XForwardedPort ||
                    (this.XForwardedPort != null &&
                    this.XForwardedPort.Equals(input.XForwardedPort))
                ) && 
                (
                    this.XForwardedForPort == input.XForwardedForPort ||
                    (this.XForwardedForPort != null &&
                    this.XForwardedForPort.Equals(input.XForwardedForPort))
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
                if (this.XForwardedPort != null)
                    hashCode = hashCode * 59 + this.XForwardedPort.GetHashCode();
                if (this.XForwardedForPort != null)
                    hashCode = hashCode * 59 + this.XForwardedForPort.GetHashCode();
                if (this.XForwardedHost != null)
                    hashCode = hashCode * 59 + this.XForwardedHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
