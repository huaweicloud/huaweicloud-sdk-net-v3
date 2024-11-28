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
    /// Response Object
    /// </summary>
    public class ShowMultiTenantResponse : SdkResponse
    {

        /// <summary>
        /// 实例多租特性开关。 - true:开启 - false:关闭。
        /// </summary>
        [JsonProperty("multi_tenant_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiTenantSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMultiTenantResponse {\n");
            sb.Append("  multiTenantSwitch: ").Append(MultiTenantSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMultiTenantResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMultiTenantResponse input)
        {
            if (input == null) return false;
            if (this.MultiTenantSwitch != input.MultiTenantSwitch || (this.MultiTenantSwitch != null && !this.MultiTenantSwitch.Equals(input.MultiTenantSwitch))) return false;

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
                if (this.MultiTenantSwitch != null) hashCode = hashCode * 59 + this.MultiTenantSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
