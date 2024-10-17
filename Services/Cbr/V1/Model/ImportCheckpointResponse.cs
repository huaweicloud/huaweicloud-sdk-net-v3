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
    public class ImportCheckpointResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public SyncRespBody Sync { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportCheckpointResponse {\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportCheckpointResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportCheckpointResponse input)
        {
            if (input == null) return false;
            if (this.Sync != input.Sync || (this.Sync != null && !this.Sync.Equals(input.Sync))) return false;

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
                if (this.Sync != null) hashCode = hashCode * 59 + this.Sync.GetHashCode();
                return hashCode;
            }
        }
    }
}
