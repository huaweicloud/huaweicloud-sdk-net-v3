using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateHostParam 
    {

        /// <summary>
        /// 自动放置，off-取消自动放置，on-打开自动放置。
        /// </summary>
        [JsonProperty("auto_placement", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// 云办公主机名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云办公主机id。
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHostParam {\n");
            sb.Append("  autoPlacement: ").Append(AutoPlacement).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHostParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHostParam input)
        {
            if (input == null) return false;
            if (this.AutoPlacement != input.AutoPlacement || (this.AutoPlacement != null && !this.AutoPlacement.Equals(input.AutoPlacement))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;

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
                if (this.AutoPlacement != null) hashCode = hashCode * 59 + this.AutoPlacement.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HostId != null) hashCode = hashCode * 59 + this.HostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
