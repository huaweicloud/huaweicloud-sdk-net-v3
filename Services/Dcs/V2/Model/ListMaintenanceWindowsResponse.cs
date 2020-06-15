using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMaintenanceWindowsResponse : SdkResponse
    {

        /// <summary>
        /// 支持的维护时间窗列表。
        /// </summary>
        [JsonProperty("maintain_windows", NullValueHandling = NullValueHandling.Ignore)]
        public List<MaintainWindows> MaintainWindows { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMaintenanceWindowsResponse {\n");
            sb.Append("  maintainWindows: ").Append(MaintainWindows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMaintenanceWindowsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMaintenanceWindowsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaintainWindows == input.MaintainWindows ||
                    this.MaintainWindows != null &&
                    input.MaintainWindows != null &&
                    this.MaintainWindows.SequenceEqual(input.MaintainWindows)
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
                if (this.MaintainWindows != null)
                    hashCode = hashCode * 59 + this.MaintainWindows.GetHashCode();
                return hashCode;
            }
        }
    }
}
