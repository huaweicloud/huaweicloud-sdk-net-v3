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
    public class Events 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Annotations Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 到达时间(时间戳)
        /// </summary>
        [JsonProperty("arrives_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArrivesAt { get; set; }

        /// <summary>
        /// 告警清除时间(时间戳)
        /// </summary>
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndsAt { get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 告警产生时间(时间戳)
        /// </summary>
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartsAt { get; set; }

        /// <summary>
        /// 告警自动清除时间(时间戳)
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timeout { get; set; }

        /// <summary>
        /// 告警规则类型(SQL/关键词)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Events {\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  arrivesAt: ").Append(ArrivesAt).Append("\n");
            sb.Append("  endsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Events);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Events input)
        {
            if (input == null) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && !this.Annotations.Equals(input.Annotations))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.ArrivesAt != input.ArrivesAt || (this.ArrivesAt != null && !this.ArrivesAt.Equals(input.ArrivesAt))) return false;
            if (this.EndsAt != input.EndsAt || (this.EndsAt != null && !this.EndsAt.Equals(input.EndsAt))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StartsAt != input.StartsAt || (this.StartsAt != null && !this.StartsAt.Equals(input.StartsAt))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.ArrivesAt != null) hashCode = hashCode * 59 + this.ArrivesAt.GetHashCode();
                if (this.EndsAt != null) hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartsAt != null) hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
