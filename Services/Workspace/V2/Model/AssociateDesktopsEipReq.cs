using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面绑定EIP请求体。
    /// </summary>
    public class AssociateDesktopsEipReq 
    {

        /// <summary>
        /// 桌面绑定的Eip的id。
        /// </summary>
        [JsonProperty("eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EipId { get; set; }

        /// <summary>
        /// 桌面id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateDesktopsEipReq {\n");
            sb.Append("  eipId: ").Append(EipId).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateDesktopsEipReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateDesktopsEipReq input)
        {
            if (input == null) return false;
            if (this.EipId != input.EipId || (this.EipId != null && !this.EipId.Equals(input.EipId))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;

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
                if (this.EipId != null) hashCode = hashCode * 59 + this.EipId.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                return hashCode;
            }
        }
    }
}
