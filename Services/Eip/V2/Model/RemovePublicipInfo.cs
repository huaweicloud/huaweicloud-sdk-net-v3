using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 共享带宽插入/移除弹性公网IP的publicip_info字段
    /// </summary>
    public class RemovePublicipInfo 
    {

        /// <summary>
        /// 功能说明：若publicip_id为弹性公网IP的id，则该字段可自动忽略。若publicip_id为IPv6端口PORT的id，则该字段必填：5_dualStack(目前仅北京4局点支持)
        /// </summary>
        [JsonProperty("publicip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipType { get; set; }

        /// <summary>
        /// 功能说明：带宽对应的弹性公网IP或IPv6端口PORT的唯一标识
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemovePublicipInfo {\n");
            sb.Append("  publicipType: ").Append(PublicipType).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemovePublicipInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemovePublicipInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipType == input.PublicipType ||
                    (this.PublicipType != null &&
                    this.PublicipType.Equals(input.PublicipType))
                ) && 
                (
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
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
                if (this.PublicipType != null)
                    hashCode = hashCode * 59 + this.PublicipType.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
