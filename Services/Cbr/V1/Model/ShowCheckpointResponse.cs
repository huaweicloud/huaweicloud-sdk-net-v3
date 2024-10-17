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
    /// Response Object
    /// </summary>
    public class ShowCheckpointResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checkpoint", NullValueHandling = NullValueHandling.Ignore)]
        public CheckpointCreate Checkpoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCheckpointResponse {\n");
            sb.Append("  checkpoint: ").Append(Checkpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCheckpointResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCheckpointResponse input)
        {
            if (input == null) return false;
            if (this.Checkpoint != input.Checkpoint || (this.Checkpoint != null && !this.Checkpoint.Equals(input.Checkpoint))) return false;

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
                if (this.Checkpoint != null) hashCode = hashCode * 59 + this.Checkpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
