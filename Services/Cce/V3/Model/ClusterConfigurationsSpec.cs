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
    /// Configuration的规格信息
    /// </summary>
    public class ClusterConfigurationsSpec 
    {

        /// <summary>
        /// 组件配置项列表
        /// </summary>
        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterConfigurationsSpecPackages> Packages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterConfigurationsSpec {\n");
            sb.Append("  packages: ").Append(Packages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterConfigurationsSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterConfigurationsSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Packages == input.Packages ||
                    this.Packages != null &&
                    input.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages)
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
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
                return hashCode;
            }
        }
    }
}
