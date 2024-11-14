using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceMaintenanceWindowResponse : SdkResponse
    {

        /// <summary>
        /// 参数解释： 实例的可维护时间窗。
        /// </summary>
        [JsonProperty("maintenance_window", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintenanceWindow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceMaintenanceWindowResponse {\n");
            sb.Append("  maintenanceWindow: ").Append(MaintenanceWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceMaintenanceWindowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceMaintenanceWindowResponse input)
        {
            if (input == null) return false;
            if (this.MaintenanceWindow != input.MaintenanceWindow || (this.MaintenanceWindow != null && !this.MaintenanceWindow.Equals(input.MaintenanceWindow))) return false;

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
                if (this.MaintenanceWindow != null) hashCode = hashCode * 59 + this.MaintenanceWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
