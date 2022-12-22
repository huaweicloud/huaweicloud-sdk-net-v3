using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSnapshotResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public SnapshotDetails Snapshot { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSnapshotResponse {\n");
            sb.Append("  snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSnapshotResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSnapshotResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Snapshot == input.Snapshot ||
                    (this.Snapshot != null &&
                    this.Snapshot.Equals(input.Snapshot))
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
                if (this.Snapshot != null)
                    hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                return hashCode;
            }
        }
    }
}
