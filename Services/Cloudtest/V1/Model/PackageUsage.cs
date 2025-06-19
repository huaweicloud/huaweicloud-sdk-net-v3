using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 套餐用量信息
    /// </summary>
    public class PackageUsage 
    {

        /// <summary>
        /// 套餐类型
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 套餐用量
        /// </summary>
        [JsonProperty("used_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageUsage {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  usedPercent: ").Append(UsedPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageUsage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageUsage input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.UsedPercent != input.UsedPercent || (this.UsedPercent != null && !this.UsedPercent.Equals(input.UsedPercent))) return false;

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
                if (this.UsedPercent != null) hashCode = hashCode * 59 + this.UsedPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
