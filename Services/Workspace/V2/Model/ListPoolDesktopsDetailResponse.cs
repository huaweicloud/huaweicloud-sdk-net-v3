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
    /// Response Object
    /// </summary>
    public class ListPoolDesktopsDetailResponse : SdkResponse
    {

        /// <summary>
        /// 池桌面详情。
        /// </summary>
        [JsonProperty("pool_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolDesktopsDetailInfo> PoolDesktops { get; set; }

        /// <summary>
        /// 桌面总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 按需桌面总数。
        /// </summary>
        [JsonProperty("on_demand_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnDemandDesktopsNum { get; set; }

        /// <summary>
        /// 包周期桌面总数。
        /// </summary>
        [JsonProperty("period_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodDesktopsNum { get; set; }

        /// <summary>
        /// 按需免费桌面总数。
        /// </summary>
        [JsonProperty("on_demand_free_image_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnDemandFreeImageDesktopsNum { get; set; }

        /// <summary>
        /// 按需收费桌面总数。
        /// </summary>
        [JsonProperty("on_demand_charge_image_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnDemandChargeImageDesktopsNum { get; set; }

        /// <summary>
        /// 包周期免费桌面总数。
        /// </summary>
        [JsonProperty("period_free_image_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodFreeImageDesktopsNum { get; set; }

        /// <summary>
        /// 包周期收费桌面总数。
        /// </summary>
        [JsonProperty("period_charge_image_desktops_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodChargeImageDesktopsNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inconsistent_type", NullValueHandling = NullValueHandling.Ignore)]
        public InconsistentTypeEnum? InconsistentType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoolDesktopsDetailResponse {\n");
            sb.Append("  poolDesktops: ").Append(PoolDesktops).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  onDemandDesktopsNum: ").Append(OnDemandDesktopsNum).Append("\n");
            sb.Append("  periodDesktopsNum: ").Append(PeriodDesktopsNum).Append("\n");
            sb.Append("  onDemandFreeImageDesktopsNum: ").Append(OnDemandFreeImageDesktopsNum).Append("\n");
            sb.Append("  onDemandChargeImageDesktopsNum: ").Append(OnDemandChargeImageDesktopsNum).Append("\n");
            sb.Append("  periodFreeImageDesktopsNum: ").Append(PeriodFreeImageDesktopsNum).Append("\n");
            sb.Append("  periodChargeImageDesktopsNum: ").Append(PeriodChargeImageDesktopsNum).Append("\n");
            sb.Append("  inconsistentType: ").Append(InconsistentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoolDesktopsDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoolDesktopsDetailResponse input)
        {
            if (input == null) return false;
            if (this.PoolDesktops != input.PoolDesktops || (this.PoolDesktops != null && input.PoolDesktops != null && !this.PoolDesktops.SequenceEqual(input.PoolDesktops))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.OnDemandDesktopsNum != input.OnDemandDesktopsNum || (this.OnDemandDesktopsNum != null && !this.OnDemandDesktopsNum.Equals(input.OnDemandDesktopsNum))) return false;
            if (this.PeriodDesktopsNum != input.PeriodDesktopsNum || (this.PeriodDesktopsNum != null && !this.PeriodDesktopsNum.Equals(input.PeriodDesktopsNum))) return false;
            if (this.OnDemandFreeImageDesktopsNum != input.OnDemandFreeImageDesktopsNum || (this.OnDemandFreeImageDesktopsNum != null && !this.OnDemandFreeImageDesktopsNum.Equals(input.OnDemandFreeImageDesktopsNum))) return false;
            if (this.OnDemandChargeImageDesktopsNum != input.OnDemandChargeImageDesktopsNum || (this.OnDemandChargeImageDesktopsNum != null && !this.OnDemandChargeImageDesktopsNum.Equals(input.OnDemandChargeImageDesktopsNum))) return false;
            if (this.PeriodFreeImageDesktopsNum != input.PeriodFreeImageDesktopsNum || (this.PeriodFreeImageDesktopsNum != null && !this.PeriodFreeImageDesktopsNum.Equals(input.PeriodFreeImageDesktopsNum))) return false;
            if (this.PeriodChargeImageDesktopsNum != input.PeriodChargeImageDesktopsNum || (this.PeriodChargeImageDesktopsNum != null && !this.PeriodChargeImageDesktopsNum.Equals(input.PeriodChargeImageDesktopsNum))) return false;
            if (this.InconsistentType != input.InconsistentType || (this.InconsistentType != null && !this.InconsistentType.Equals(input.InconsistentType))) return false;

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
                if (this.PoolDesktops != null) hashCode = hashCode * 59 + this.PoolDesktops.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.OnDemandDesktopsNum != null) hashCode = hashCode * 59 + this.OnDemandDesktopsNum.GetHashCode();
                if (this.PeriodDesktopsNum != null) hashCode = hashCode * 59 + this.PeriodDesktopsNum.GetHashCode();
                if (this.OnDemandFreeImageDesktopsNum != null) hashCode = hashCode * 59 + this.OnDemandFreeImageDesktopsNum.GetHashCode();
                if (this.OnDemandChargeImageDesktopsNum != null) hashCode = hashCode * 59 + this.OnDemandChargeImageDesktopsNum.GetHashCode();
                if (this.PeriodFreeImageDesktopsNum != null) hashCode = hashCode * 59 + this.PeriodFreeImageDesktopsNum.GetHashCode();
                if (this.PeriodChargeImageDesktopsNum != null) hashCode = hashCode * 59 + this.PeriodChargeImageDesktopsNum.GetHashCode();
                if (this.InconsistentType != null) hashCode = hashCode * 59 + this.InconsistentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
