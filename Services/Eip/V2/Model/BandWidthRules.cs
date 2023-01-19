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
    /// 带宽规则对象
    /// </summary>
    public class BandWidthRules 
    {

        /// <summary>
        /// 带宽规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 带宽规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 配置状态，为False时配置不生效。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 出网带宽最大值，单位M bps。取值范围[0,n]，其中n为所属带宽的带宽大小（size字段）。0表示设置为最大带宽。
        /// </summary>
        [JsonProperty("egress_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? EgressSize { get; set; }

        /// <summary>
        /// 出网保障带宽大小，单位M bps。取值范围[0,x]，其中x为所属带宽剩余的保障额。
        /// </summary>
        [JsonProperty("egress_guarented_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? EgressGuarentedSize { get; set; }

        /// <summary>
        /// 功能说明：带宽对应的弹性公网IP信息  约束：WHOLE类型的带宽支持多个弹性公网IP，PER类型的带宽只能对应一个弹性公网IP
        /// </summary>
        [JsonProperty("publicip_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicipInfoResp> PublicipInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandWidthRules {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  egressSize: ").Append(EgressSize).Append("\n");
            sb.Append("  egressGuarentedSize: ").Append(EgressGuarentedSize).Append("\n");
            sb.Append("  publicipInfo: ").Append(PublicipInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandWidthRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandWidthRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.EgressSize == input.EgressSize ||
                    (this.EgressSize != null &&
                    this.EgressSize.Equals(input.EgressSize))
                ) && 
                (
                    this.EgressGuarentedSize == input.EgressGuarentedSize ||
                    (this.EgressGuarentedSize != null &&
                    this.EgressGuarentedSize.Equals(input.EgressGuarentedSize))
                ) && 
                (
                    this.PublicipInfo == input.PublicipInfo ||
                    this.PublicipInfo != null &&
                    input.PublicipInfo != null &&
                    this.PublicipInfo.SequenceEqual(input.PublicipInfo)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.EgressSize != null)
                    hashCode = hashCode * 59 + this.EgressSize.GetHashCode();
                if (this.EgressGuarentedSize != null)
                    hashCode = hashCode * 59 + this.EgressGuarentedSize.GetHashCode();
                if (this.PublicipInfo != null)
                    hashCode = hashCode * 59 + this.PublicipInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
