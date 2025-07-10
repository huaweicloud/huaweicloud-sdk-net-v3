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
    /// 包周期资源对象。
    /// </summary>
    public class Resource 
    {

        /// <summary>
        /// 订购周期类型：2：月；3：年；4：包小时（仅限带宽加油包购买场景使用）5：绝对时间；（追加附属资源场景使用，比如主机上追加云硬盘）6：一次性（chargingMode&#x3D;1 一次性计费场景使用），必填
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 订购周期数。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public AddVolumes AddVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDesktopReq CreateDesktops { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rebuild_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public RebuildDesktopsReq RebuildDesktops { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attach_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public AttachInstancesReq AttachDesktops { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_exclusive_hosts", NullValueHandling = NullValueHandling.Ignore)]
        public CreateExclusiveHostsReq CreateExclusiveHosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize_exclusive_lites", NullValueHandling = NullValueHandling.Ignore)]
        public ResizeExclusiveLitesReq ResizeExclusiveLites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_desktop_pool", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDesktopPoolReq CreateDesktopPool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expand_desktop_pool", NullValueHandling = NullValueHandling.Ignore)]
        public ExpandDesktopPoolOrderReq ExpandDesktopPool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_desktops_internet", NullValueHandling = NullValueHandling.Ignore)]
        public ApplyDesktopsInternet ApplyDesktopsInternet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_subnet_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public ApplySubnetBandwidthReq ApplySubnetBandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subscribe_user_sharer", NullValueHandling = NullValueHandling.Ignore)]
        public SubscribeUserSharerReq SubscribeUserSharer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  addVolumes: ").Append(AddVolumes).Append("\n");
            sb.Append("  createDesktops: ").Append(CreateDesktops).Append("\n");
            sb.Append("  rebuildDesktops: ").Append(RebuildDesktops).Append("\n");
            sb.Append("  attachDesktops: ").Append(AttachDesktops).Append("\n");
            sb.Append("  createExclusiveHosts: ").Append(CreateExclusiveHosts).Append("\n");
            sb.Append("  resizeExclusiveLites: ").Append(ResizeExclusiveLites).Append("\n");
            sb.Append("  createDesktopPool: ").Append(CreateDesktopPool).Append("\n");
            sb.Append("  expandDesktopPool: ").Append(ExpandDesktopPool).Append("\n");
            sb.Append("  applyDesktopsInternet: ").Append(ApplyDesktopsInternet).Append("\n");
            sb.Append("  applySubnetBandwidth: ").Append(ApplySubnetBandwidth).Append("\n");
            sb.Append("  subscribeUserSharer: ").Append(SubscribeUserSharer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Resource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Resource input)
        {
            if (input == null) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.AddVolumes != input.AddVolumes || (this.AddVolumes != null && !this.AddVolumes.Equals(input.AddVolumes))) return false;
            if (this.CreateDesktops != input.CreateDesktops || (this.CreateDesktops != null && !this.CreateDesktops.Equals(input.CreateDesktops))) return false;
            if (this.RebuildDesktops != input.RebuildDesktops || (this.RebuildDesktops != null && !this.RebuildDesktops.Equals(input.RebuildDesktops))) return false;
            if (this.AttachDesktops != input.AttachDesktops || (this.AttachDesktops != null && !this.AttachDesktops.Equals(input.AttachDesktops))) return false;
            if (this.CreateExclusiveHosts != input.CreateExclusiveHosts || (this.CreateExclusiveHosts != null && !this.CreateExclusiveHosts.Equals(input.CreateExclusiveHosts))) return false;
            if (this.ResizeExclusiveLites != input.ResizeExclusiveLites || (this.ResizeExclusiveLites != null && !this.ResizeExclusiveLites.Equals(input.ResizeExclusiveLites))) return false;
            if (this.CreateDesktopPool != input.CreateDesktopPool || (this.CreateDesktopPool != null && !this.CreateDesktopPool.Equals(input.CreateDesktopPool))) return false;
            if (this.ExpandDesktopPool != input.ExpandDesktopPool || (this.ExpandDesktopPool != null && !this.ExpandDesktopPool.Equals(input.ExpandDesktopPool))) return false;
            if (this.ApplyDesktopsInternet != input.ApplyDesktopsInternet || (this.ApplyDesktopsInternet != null && !this.ApplyDesktopsInternet.Equals(input.ApplyDesktopsInternet))) return false;
            if (this.ApplySubnetBandwidth != input.ApplySubnetBandwidth || (this.ApplySubnetBandwidth != null && !this.ApplySubnetBandwidth.Equals(input.ApplySubnetBandwidth))) return false;
            if (this.SubscribeUserSharer != input.SubscribeUserSharer || (this.SubscribeUserSharer != null && !this.SubscribeUserSharer.Equals(input.SubscribeUserSharer))) return false;

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
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.AddVolumes != null) hashCode = hashCode * 59 + this.AddVolumes.GetHashCode();
                if (this.CreateDesktops != null) hashCode = hashCode * 59 + this.CreateDesktops.GetHashCode();
                if (this.RebuildDesktops != null) hashCode = hashCode * 59 + this.RebuildDesktops.GetHashCode();
                if (this.AttachDesktops != null) hashCode = hashCode * 59 + this.AttachDesktops.GetHashCode();
                if (this.CreateExclusiveHosts != null) hashCode = hashCode * 59 + this.CreateExclusiveHosts.GetHashCode();
                if (this.ResizeExclusiveLites != null) hashCode = hashCode * 59 + this.ResizeExclusiveLites.GetHashCode();
                if (this.CreateDesktopPool != null) hashCode = hashCode * 59 + this.CreateDesktopPool.GetHashCode();
                if (this.ExpandDesktopPool != null) hashCode = hashCode * 59 + this.ExpandDesktopPool.GetHashCode();
                if (this.ApplyDesktopsInternet != null) hashCode = hashCode * 59 + this.ApplyDesktopsInternet.GetHashCode();
                if (this.ApplySubnetBandwidth != null) hashCode = hashCode * 59 + this.ApplySubnetBandwidth.GetHashCode();
                if (this.SubscribeUserSharer != null) hashCode = hashCode * 59 + this.SubscribeUserSharer.GetHashCode();
                return hashCode;
            }
        }
    }
}
