using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchResizeServersOption 
    {

        /// <summary>
        /// flavor
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerId> Servers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_options", NullValueHandling = NullValueHandling.Ignore)]
        public CpuOptions CpuOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("promotion", NullValueHandling = NullValueHandling.Ignore)]
        public Promotion Promotion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResizeServersOption {\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("  cpuOptions: ").Append(CpuOptions).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  promotion: ").Append(Promotion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResizeServersOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResizeServersOption input)
        {
            if (input == null) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.Servers != input.Servers || (this.Servers != null && input.Servers != null && !this.Servers.SequenceEqual(input.Servers))) return false;
            if (this.CpuOptions != input.CpuOptions || (this.CpuOptions != null && !this.CpuOptions.Equals(input.CpuOptions))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.Promotion != input.Promotion || (this.Promotion != null && !this.Promotion.Equals(input.Promotion))) return false;

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
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Servers != null) hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.CpuOptions != null) hashCode = hashCode * 59 + this.CpuOptions.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Promotion != null) hashCode = hashCode * 59 + this.Promotion.GetHashCode();
                return hashCode;
            }
        }
    }
}
