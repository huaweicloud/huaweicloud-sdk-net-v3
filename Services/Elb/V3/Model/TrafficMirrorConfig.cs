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
    /// 
    /// </summary>
    public class TrafficMirrorConfig 
    {

        /// <summary>
        /// 流量镜像的目的后端服务器组ID。
        /// </summary>
        [JsonProperty("target_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetIds { get; set; }

        /// <summary>
        /// 镜像请求是否携带请求体，默认true。
        /// </summary>
        [JsonProperty("mirror_request_body_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MirrorRequestBodyEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrafficMirrorConfig {\n");
            sb.Append("  targetIds: ").Append(TargetIds).Append("\n");
            sb.Append("  mirrorRequestBodyEnable: ").Append(MirrorRequestBodyEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrafficMirrorConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrafficMirrorConfig input)
        {
            if (input == null) return false;
            if (this.TargetIds != input.TargetIds || (this.TargetIds != null && input.TargetIds != null && !this.TargetIds.SequenceEqual(input.TargetIds))) return false;
            if (this.MirrorRequestBodyEnable != input.MirrorRequestBodyEnable || (this.MirrorRequestBodyEnable != null && !this.MirrorRequestBodyEnable.Equals(input.MirrorRequestBodyEnable))) return false;

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
                if (this.TargetIds != null) hashCode = hashCode * 59 + this.TargetIds.GetHashCode();
                if (this.MirrorRequestBodyEnable != null) hashCode = hashCode * 59 + this.MirrorRequestBodyEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
