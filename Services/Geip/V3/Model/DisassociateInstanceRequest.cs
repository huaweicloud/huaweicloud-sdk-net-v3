using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DisassociateInstanceRequest 
    {

        /// <summary>
        /// 解绑实例后是否保留GCB，false表示解绑实例后会同时删除GCB
        /// </summary>
        [SDKProperty("is_reserve_gcb", IsHeader = true)]
        [JsonProperty("is_reserve_gcb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReserveGcb { get; set; }

        /// <summary>
        /// global_eip_id
        /// </summary>
        [SDKProperty("global_eip_id", IsPath = true)]
        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateInstanceRequest {\n");
            sb.Append("  isReserveGcb: ").Append(IsReserveGcb).Append("\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateInstanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsReserveGcb == input.IsReserveGcb ||
                    (this.IsReserveGcb != null &&
                    this.IsReserveGcb.Equals(input.IsReserveGcb))
                ) && 
                (
                    this.GlobalEipId == input.GlobalEipId ||
                    (this.GlobalEipId != null &&
                    this.GlobalEipId.Equals(input.GlobalEipId))
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
                if (this.IsReserveGcb != null)
                    hashCode = hashCode * 59 + this.IsReserveGcb.GetHashCode();
                if (this.GlobalEipId != null)
                    hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
