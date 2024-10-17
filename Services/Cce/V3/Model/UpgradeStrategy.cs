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
    /// 升级配置
    /// </summary>
    public class UpgradeStrategy 
    {

        /// <summary>
        /// 升级策略类型，当前仅支持原地升级类型\&quot;inPlaceRollingUpdate\&quot;
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inPlaceRollingUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public InPlaceRollingUpdate InPlaceRollingUpdate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeStrategy {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  inPlaceRollingUpdate: ").Append(InPlaceRollingUpdate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeStrategy input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.InPlaceRollingUpdate != input.InPlaceRollingUpdate || (this.InPlaceRollingUpdate != null && !this.InPlaceRollingUpdate.Equals(input.InPlaceRollingUpdate))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InPlaceRollingUpdate != null) hashCode = hashCode * 59 + this.InPlaceRollingUpdate.GetHashCode();
                return hashCode;
            }
        }
    }
}
