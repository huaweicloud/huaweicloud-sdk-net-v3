using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlProxyFlavorGroups 
    {

        /// <summary>
        /// 规格组类型，如x86、arm。
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 规格信息。
        /// </summary>
        [JsonProperty("proxy_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyComputeFlavor> ProxyFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlProxyFlavorGroups {\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  proxyFlavors: ").Append(ProxyFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlProxyFlavorGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlProxyFlavorGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.ProxyFlavors == input.ProxyFlavors ||
                    this.ProxyFlavors != null &&
                    input.ProxyFlavors != null &&
                    this.ProxyFlavors.SequenceEqual(input.ProxyFlavors)
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
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.ProxyFlavors != null)
                    hashCode = hashCode * 59 + this.ProxyFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
