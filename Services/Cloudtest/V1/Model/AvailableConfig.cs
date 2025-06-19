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
    /// 
    /// </summary>
    public class AvailableConfig 
    {

        /// <summary>
        /// 自定义关键字是否开通
        /// </summary>
        [JsonProperty("custom_aw_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomAwAvailable { get; set; }

        /// <summary>
        /// 系统关键字是否开通
        /// </summary>
        [JsonProperty("public_aw_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicAwAvailable { get; set; }

        /// <summary>
        /// 一键刷新功能是否开通
        /// </summary>
        [JsonProperty("refresh_aw_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RefreshAwAvailable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableConfig {\n");
            sb.Append("  customAwAvailable: ").Append(CustomAwAvailable).Append("\n");
            sb.Append("  publicAwAvailable: ").Append(PublicAwAvailable).Append("\n");
            sb.Append("  refreshAwAvailable: ").Append(RefreshAwAvailable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailableConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvailableConfig input)
        {
            if (input == null) return false;
            if (this.CustomAwAvailable != input.CustomAwAvailable || (this.CustomAwAvailable != null && !this.CustomAwAvailable.Equals(input.CustomAwAvailable))) return false;
            if (this.PublicAwAvailable != input.PublicAwAvailable || (this.PublicAwAvailable != null && !this.PublicAwAvailable.Equals(input.PublicAwAvailable))) return false;
            if (this.RefreshAwAvailable != input.RefreshAwAvailable || (this.RefreshAwAvailable != null && !this.RefreshAwAvailable.Equals(input.RefreshAwAvailable))) return false;

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
                if (this.CustomAwAvailable != null) hashCode = hashCode * 59 + this.CustomAwAvailable.GetHashCode();
                if (this.PublicAwAvailable != null) hashCode = hashCode * 59 + this.PublicAwAvailable.GetHashCode();
                if (this.RefreshAwAvailable != null) hashCode = hashCode * 59 + this.RefreshAwAvailable.GetHashCode();
                return hashCode;
            }
        }
    }
}
