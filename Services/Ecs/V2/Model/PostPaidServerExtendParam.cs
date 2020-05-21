using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostPaidServerExtendParam 
    {

        /// <summary>
        /// 计费模式：  - 0：按需计费。
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 云服务器所在区域ID。  请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)获取。
        /// </summary>
        [JsonProperty("regionID", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionID { get; set; }

        /// <summary>
        /// 是否配置弹性云服务器自动恢复的功能。  - “true”：配置该功能 - “false”：不配置该功能  &gt; 说明： &gt;  &gt; 此参数为boolean类型，若传入非boolean类型字符，程序将按照【“false”：不配置该功能】方式处理。 &gt;  &gt; 当marketType为spot时，不支持该功能。
        /// </summary>
        [JsonProperty("support_auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAutoRecovery { get; set; }

        /// <summary>
        /// 企业项目ID。  &gt; 说明： &gt;  &gt; 关于企业项目ID的获取及企业项目特性的详细信息，请参见《[企业管理服务用户指南](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)》。 &gt;  &gt; 该字段不传（或传为字符串“0”），则将资源绑定给默认企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 创建竞价实例时，需指定该参数的值为“spot”。  &gt; 说明： &gt;  &gt; 当chargingMode&#x3D;0时且marketType&#x3D;spot时此参数生效。
        /// </summary>
        [JsonProperty("marketType", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketType { get; set; }

        /// <summary>
        /// 用户愿意为竞价实例每小时支付的最高价格。  &gt; 说明： &gt;  &gt; 仅chargingMode&#x3D;0且marketType&#x3D;spot时，该参数设置后生效。 &gt;  &gt; 当chargingMode&#x3D;0且marketType&#x3D;spot时，如果不传递spotPrice，默认使用按需购买的价格作为竞价。
        /// </summary>
        [JsonProperty("spotPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotPrice { get; set; }

        /// <summary>
        /// 是否支持先创建卷，再创建虚拟机。  “true”：配置该功能 “false”：不配置该功能
        /// </summary>
        [JsonProperty("diskPrior", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskPrior { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerExtendParam {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  regionID: ").Append(RegionID).Append("\n");
            sb.Append("  supportAutoRecovery: ").Append(SupportAutoRecovery).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("  spotPrice: ").Append(SpotPrice).Append("\n");
            sb.Append("  diskPrior: ").Append(DiskPrior).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.RegionID == input.RegionID ||
                    (this.RegionID != null &&
                    this.RegionID.Equals(input.RegionID))
                ) && 
                (
                    this.SupportAutoRecovery == input.SupportAutoRecovery ||
                    (this.SupportAutoRecovery != null &&
                    this.SupportAutoRecovery.Equals(input.SupportAutoRecovery))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.MarketType == input.MarketType ||
                    (this.MarketType != null &&
                    this.MarketType.Equals(input.MarketType))
                ) && 
                (
                    this.SpotPrice == input.SpotPrice ||
                    (this.SpotPrice != null &&
                    this.SpotPrice.Equals(input.SpotPrice))
                ) && 
                (
                    this.DiskPrior == input.DiskPrior ||
                    (this.DiskPrior != null &&
                    this.DiskPrior.Equals(input.DiskPrior))
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
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.RegionID != null)
                    hashCode = hashCode * 59 + this.RegionID.GetHashCode();
                if (this.SupportAutoRecovery != null)
                    hashCode = hashCode * 59 + this.SupportAutoRecovery.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.MarketType != null)
                    hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.SpotPrice != null)
                    hashCode = hashCode * 59 + this.SpotPrice.GetHashCode();
                if (this.DiskPrior != null)
                    hashCode = hashCode * 59 + this.DiskPrior.GetHashCode();
                return hashCode;
            }
        }
    }
}
