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
    /// 资源配额实例详情
    /// </summary>
    public class QuotaShowResp 
    {

        /// <summary>
        /// 功能说明：根据type过滤查询指定类型的配额 取值范围：vpc，subnet，securityGroup，securityGroupRule，publicIp，vpn，vpngw，vpcPeer，firewall，shareBandwidth，shareBandwidthIP
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 功能说明：已创建的资源个数 取值范围：0~quota数
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 功能说明：资源的最大配额数 取值范围：各类型资源默认配额数~Integer最大值 约束：资源的默认配额数可以修改，而且配额需要提前在底层配置，参考默认配置为：vpc默认5，子网默认100，安全组默认100，安全组规则默认5000，弹性公网IP默认10，vpn默认5，vpngw默认2，vpcPeer默认50，firewall默认200，shareBandwidth默认5，shareBandwidthIP默认20
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// 允许修改的配额最小值
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaShowResp {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaShowResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaShowResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                return hashCode;
            }
        }
    }
}
