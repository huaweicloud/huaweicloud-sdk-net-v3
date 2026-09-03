using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtocolTestVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http", NullValueHandling = NullValueHandling.Ignore)]
        public HttpVo Http { get; set; }

        /// <summary>
        /// ping拨测任务信息
        /// </summary>
        [JsonProperty("ping", NullValueHandling = NullValueHandling.Ignore)]
        public List<PingVo> Ping { get; set; }

        /// <summary>
        /// ping/http节点地址
        /// </summary>
        [JsonProperty("point_host", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PointHost { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolTestVo {\n");
            sb.Append("  http: ").Append(Http).Append("\n");
            sb.Append("  ping: ").Append(Ping).Append("\n");
            sb.Append("  pointHost: ").Append(PointHost).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtocolTestVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtocolTestVo input)
        {
            if (input == null) return false;
            if (this.Http != input.Http || (this.Http != null && !this.Http.Equals(input.Http))) return false;
            if (this.Ping != input.Ping || (this.Ping != null && input.Ping != null && !this.Ping.SequenceEqual(input.Ping))) return false;
            if (this.PointHost != input.PointHost || (this.PointHost != null && input.PointHost != null && !this.PointHost.SequenceEqual(input.PointHost))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;

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
                if (this.Http != null) hashCode = hashCode * 59 + this.Http.GetHashCode();
                if (this.Ping != null) hashCode = hashCode * 59 + this.Ping.GetHashCode();
                if (this.PointHost != null) hashCode = hashCode * 59 + this.PointHost.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
