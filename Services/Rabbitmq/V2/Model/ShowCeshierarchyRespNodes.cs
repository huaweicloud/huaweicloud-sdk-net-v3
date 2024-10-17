using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowCeshierarchyRespNodes 
    {

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("available_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCeshierarchyRespNodes {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availableZone: ").Append(AvailableZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCeshierarchyRespNodes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCeshierarchyRespNodes input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AvailableZone != input.AvailableZone || (this.AvailableZone != null && !this.AvailableZone.Equals(input.AvailableZone))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AvailableZone != null) hashCode = hashCode * 59 + this.AvailableZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
