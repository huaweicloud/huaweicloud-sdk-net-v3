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
    /// 创建变更订单请求体。
    /// </summary>
    public class CreateChangeOrderReq 
    {

        /// <summary>
        /// 类型 resizeDesktops(变更规格)、expandVolumes(扩容磁盘)、meteredToPeriod(按需转包周期)。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 周期类型，2：包月；3：包年； type为 meteredToPeriod 并且 is_subscribe &#x3D;&#x3D; true 时不能为空。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 周期数；type为 meteredToPeriod 并且 is_subscribe &#x3D;&#x3D; true 时不能为空。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续费 *  按需转包周期场景支持自动续费； *  0：不自动续费，1：自动续费； *  默认值为0，表示不自动续费；
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 变更后规格产品ID，当是resizeDesktops，必传。
        /// </summary>
        [JsonProperty("resize_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResizeProductId { get; set; }

        /// <summary>
        /// 扩容的云硬盘的ID，当是expandVolumes，必传。
        /// </summary>
        [JsonProperty("expand_volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpandVolumeId { get; set; }

        /// <summary>
        /// 扩容后云硬盘的总大小，当是expandVolumes，必传。范围10-32760，大小为10的倍数。
        /// </summary>
        [JsonProperty("expand_new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandNewSize { get; set; }

        /// <summary>
        /// 专享主机变更桌面数后桌面路数的总大小，当是jobType是resizeExclusiveLites，必传。
        /// </summary>
        [JsonProperty("new_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewQuantity { get; set; }

        /// <summary>
        /// 专享主机桌面数的productId，当是resizeExclusiveLites，必传。
        /// </summary>
        [JsonProperty("exclusive_lites_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExclusiveLitesProductId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public OrderExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChangeOrderReq {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  resizeProductId: ").Append(ResizeProductId).Append("\n");
            sb.Append("  expandVolumeId: ").Append(ExpandVolumeId).Append("\n");
            sb.Append("  expandNewSize: ").Append(ExpandNewSize).Append("\n");
            sb.Append("  newQuantity: ").Append(NewQuantity).Append("\n");
            sb.Append("  exclusiveLitesProductId: ").Append(ExclusiveLitesProductId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateChangeOrderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateChangeOrderReq input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.ResizeProductId != input.ResizeProductId || (this.ResizeProductId != null && !this.ResizeProductId.Equals(input.ResizeProductId))) return false;
            if (this.ExpandVolumeId != input.ExpandVolumeId || (this.ExpandVolumeId != null && !this.ExpandVolumeId.Equals(input.ExpandVolumeId))) return false;
            if (this.ExpandNewSize != input.ExpandNewSize || (this.ExpandNewSize != null && !this.ExpandNewSize.Equals(input.ExpandNewSize))) return false;
            if (this.NewQuantity != input.NewQuantity || (this.NewQuantity != null && !this.NewQuantity.Equals(input.NewQuantity))) return false;
            if (this.ExclusiveLitesProductId != input.ExclusiveLitesProductId || (this.ExclusiveLitesProductId != null && !this.ExclusiveLitesProductId.Equals(input.ExclusiveLitesProductId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.ResizeProductId != null) hashCode = hashCode * 59 + this.ResizeProductId.GetHashCode();
                if (this.ExpandVolumeId != null) hashCode = hashCode * 59 + this.ExpandVolumeId.GetHashCode();
                if (this.ExpandNewSize != null) hashCode = hashCode * 59 + this.ExpandNewSize.GetHashCode();
                if (this.NewQuantity != null) hashCode = hashCode * 59 + this.NewQuantity.GetHashCode();
                if (this.ExclusiveLitesProductId != null) hashCode = hashCode * 59 + this.ExclusiveLitesProductId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
