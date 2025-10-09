using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MasterFlavorSpec 
    {

        /// <summary>
        /// **参数解释**： 控制节点规格 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 控制节点支持的可用区
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Azs { get; set; }

        /// <summary>
        /// **参数解释**： 控制节点所在可用区支持的故障域
        /// </summary>
        [JsonProperty("azFaultDomains", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> AzFaultDomains { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterFlavorSpec {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("  azFaultDomains: ").Append(AzFaultDomains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MasterFlavorSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MasterFlavorSpec input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;
            if (this.AzFaultDomains != input.AzFaultDomains || (this.AzFaultDomains != null && input.AzFaultDomains != null && !this.AzFaultDomains.SequenceEqual(input.AzFaultDomains))) return false;

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
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                if (this.AzFaultDomains != null) hashCode = hashCode * 59 + this.AzFaultDomains.GetHashCode();
                return hashCode;
            }
        }
    }
}
