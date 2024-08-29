using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBandwidthRequest 
    {

        /// <summary>
        /// - 功能说明：每页返回的个数 - 取值范围：取值范围：1~[2000]，其中2000为局点差异项，具体取值由局点决定
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// - 功能说明：分页查询起始的资源ID，为空时为查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// - 功能说明：带宽唯一标识
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// display in the form \&quot;fields&#x3D;id&amp;fields&#x3D;name&amp;...\&quot;  Supported fields：id/name/tenant_id/size/ratio_95peak_plus/ingress_size/bandwidth_type/admin_state/billing_info/charge_mode/type/publicip_info/enable_bandwidth_rules/rule_quota/bandwidth_rules/public_border_group/created_at/updated_at/lock_infos
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// - 功能说明：带宽类型，共享带宽默认为share。 - 取值范围：share，bgp，telcom，sbgp等。   - share：共享带宽   - bgp：动态bgp   - telcom ：联通   - sbgp：静态bgp
        /// </summary>
        [SDKProperty("bandwidth_type", IsQuery = true)]
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// - 功能说明：宽带名称，按照宽带名称过滤
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// - 功能说明：根据宽带名称模糊查询过滤
        /// </summary>
        [SDKProperty("name_like", IsQuery = true)]
        [JsonProperty("name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLike { get; set; }

        /// <summary>
        /// - 功能说明：根据入云大小过滤
        /// </summary>
        [SDKProperty("ingress_size", IsQuery = true)]
        [JsonProperty("ingress_size", NullValueHandling = NullValueHandling.Ignore)]
        public string IngressSize { get; set; }

        /// <summary>
        /// - 功能说明：根据宽带状态过滤
        /// </summary>
        [SDKProperty("admin_state", IsQuery = true)]
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminState { get; set; }

        /// <summary>
        /// - 功能说明：根据计费信息过滤
        /// </summary>
        [SDKProperty("billing_info", IsQuery = true)]
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// - 功能说明：根据标签过滤
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// - 功能说明：根据是否带宽分组使能过滤 - 取值范围：true、false
        /// </summary>
        [SDKProperty("enable_bandwidth_rules", IsQuery = true)]
        [JsonProperty("enable_bandwidth_rules", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableBandwidthRules { get; set; }

        /// <summary>
        /// - 功能说明：根据规则数值过滤
        /// </summary>
        [SDKProperty("rule_quota", IsQuery = true)]
        [JsonProperty("rule_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleQuota { get; set; }

        /// <summary>
        /// - 功能说明：根据站点信息过滤
        /// </summary>
        [SDKProperty("public_border_group", IsQuery = true)]
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// - 功能说明：按流量计费,按带宽计费还是按增强型95计费 - 取值范围：bandwidth（按带宽计费），traffic（按流量计费），95peak_plus（按增强型95计费），不返回或者为空时表示是bandwidth - 约束：只有共享带宽支持95peak_plus（按增强型95计费），按增强型95计费时需要指定保底百分比，默认是20%
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// - 功能说明：带宽大小。共享带宽的大小有最小值限制，默认为5M，可能因局点不同而不同。 - 取值范围：默认5Mbit/s~2000Mbit/s（具体范围以各区域配置为准，请参见控制台对应页面显示）。   调整带宽时的最小单位会根据带宽范围不同存在差异。 - 小于等于300Mbit/s：默认最小单位为1Mbit/s。 - 300Mbit/s~1000Mbit/s：默认最小单位为50Mbit/s。 - 大于1000Mbit/s：默认最小单位为500Mbit/s。
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// - 功能说明：带宽类型，标识是否是共享带宽 - 取值范围：WHOLE，PER。   - WHOLE表示共享带宽   - PER表示独享带宽
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBandwidthRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameLike: ").Append(NameLike).Append("\n");
            sb.Append("  ingressSize: ").Append(IngressSize).Append("\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enableBandwidthRules: ").Append(EnableBandwidthRules).Append("\n");
            sb.Append("  ruleQuota: ").Append(RuleQuota).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBandwidthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.BandwidthType == input.BandwidthType ||
                    (this.BandwidthType != null &&
                    this.BandwidthType.Equals(input.BandwidthType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameLike == input.NameLike ||
                    (this.NameLike != null &&
                    this.NameLike.Equals(input.NameLike))
                ) && 
                (
                    this.IngressSize == input.IngressSize ||
                    (this.IngressSize != null &&
                    this.IngressSize.Equals(input.IngressSize))
                ) && 
                (
                    this.AdminState == input.AdminState ||
                    (this.AdminState != null &&
                    this.AdminState.Equals(input.AdminState))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.EnableBandwidthRules == input.EnableBandwidthRules ||
                    (this.EnableBandwidthRules != null &&
                    this.EnableBandwidthRules.Equals(input.EnableBandwidthRules))
                ) && 
                (
                    this.RuleQuota == input.RuleQuota ||
                    (this.RuleQuota != null &&
                    this.RuleQuota.Equals(input.RuleQuota))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.BandwidthType != null)
                    hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameLike != null)
                    hashCode = hashCode * 59 + this.NameLike.GetHashCode();
                if (this.IngressSize != null)
                    hashCode = hashCode * 59 + this.IngressSize.GetHashCode();
                if (this.AdminState != null)
                    hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnableBandwidthRules != null)
                    hashCode = hashCode * 59 + this.EnableBandwidthRules.GetHashCode();
                if (this.RuleQuota != null)
                    hashCode = hashCode * 59 + this.RuleQuota.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
