using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Event 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 告警产生时间(时间戳)
        /// </summary>
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartsAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  startsAt: ").Append(StartsAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.StartsAt == input.StartsAt ||
                    (this.StartsAt != null &&
                    this.StartsAt.Equals(input.StartsAt))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.StartsAt != null)
                    hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
