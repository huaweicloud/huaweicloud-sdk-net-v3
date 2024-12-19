using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 更新合规规则包的请求体。
    /// </summary>
    public class UpdateConformancePackRequestBody 
    {

        /// <summary>
        /// 合规规则包名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 合规规则包参数。
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConformancePackRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConformancePackRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateConformancePackRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.VarsStructure != input.VarsStructure || (this.VarsStructure != null && input.VarsStructure != null && !this.VarsStructure.SequenceEqual(input.VarsStructure))) return false;

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
                if (this.VarsStructure != null) hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                return hashCode;
            }
        }
    }
}
