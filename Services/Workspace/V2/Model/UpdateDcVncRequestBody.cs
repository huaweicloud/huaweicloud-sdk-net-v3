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
    /// 更新专项自主维护请求体
    /// </summary>
    public class UpdateDcVncRequestBody 
    {

        /// <summary>
        /// - default: 自动开启 - close: 关闭
        /// </summary>
        [JsonProperty("dc_vnc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DcVncIp { get; set; }

        /// <summary>
        /// 中心可用区的子网id，当dc_vnc_ip为default，且站点属于边缘小站时必传
        /// </summary>
        [JsonProperty("center_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CenterSubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDcVncRequestBody {\n");
            sb.Append("  dcVncIp: ").Append(DcVncIp).Append("\n");
            sb.Append("  centerSubnetId: ").Append(CenterSubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDcVncRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDcVncRequestBody input)
        {
            if (input == null) return false;
            if (this.DcVncIp != input.DcVncIp || (this.DcVncIp != null && !this.DcVncIp.Equals(input.DcVncIp))) return false;
            if (this.CenterSubnetId != input.CenterSubnetId || (this.CenterSubnetId != null && !this.CenterSubnetId.Equals(input.CenterSubnetId))) return false;

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
                if (this.DcVncIp != null) hashCode = hashCode * 59 + this.DcVncIp.GetHashCode();
                if (this.CenterSubnetId != null) hashCode = hashCode * 59 + this.CenterSubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
