using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 执行复制请求体
    /// </summary>
    public class CheckpointReplicateReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("replicate", NullValueHandling = NullValueHandling.Ignore)]
        public CheckpointReplicateParam Replicate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointReplicateReq {\n");
            sb.Append("  replicate: ").Append(Replicate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointReplicateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointReplicateReq input)
        {
            if (input == null) return false;
            if (this.Replicate != input.Replicate || (this.Replicate != null && !this.Replicate.Equals(input.Replicate))) return false;

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
                if (this.Replicate != null) hashCode = hashCode * 59 + this.Replicate.GetHashCode();
                return hashCode;
            }
        }
    }
}
