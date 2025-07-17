using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 企业资源信息。
    /// </summary>
    public class QueryCorpVcResResultDTO 
    {

        /// <summary>
        /// 云会议室类型列表。
        /// </summary>
        [JsonProperty("vmrPkgList", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryVmrPkgResResultDTO> VmrPkgList { get; set; }

        /// <summary>
        /// 1080P硬终端接入帐号数量。
        /// </summary>
        [JsonProperty("te1080pHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Te1080pHardCount { get; set; }

        /// <summary>
        /// 720P硬终端接入帐号数量。
        /// </summary>
        [JsonProperty("te720pHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Te720pHardCount { get; set; }

        /// <summary>
        /// 软终端账户数量。
        /// </summary>
        [JsonProperty("teSoftCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TeSoftCount { get; set; }

        /// <summary>
        /// 电子白板（SmartRooms）接入帐号数量。
        /// </summary>
        [JsonProperty("roomCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoomCount { get; set; }

        /// <summary>
        /// 录播存储空间 (单位:G)。
        /// </summary>
        [JsonProperty("recordCapability", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCapability { get; set; }

        /// <summary>
        /// 会议并发方数量。
        /// </summary>
        [JsonProperty("confCallCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfCallCount { get; set; }

        /// <summary>
        /// 直播端口数量。
        /// </summary>
        [JsonProperty("liveCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LiveCount { get; set; }

        /// <summary>
        /// 第三方硬终端接入帐号数量。
        /// </summary>
        [JsonProperty("thirdPartyHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThirdPartyHardCount { get; set; }

        /// <summary>
        /// 智慧屏终端接入帐号数量。
        /// </summary>
        [JsonProperty("hwVisionCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? HwVisionCount { get; set; }

        /// <summary>
        /// IdeaHub终端接入帐号数量。
        /// </summary>
        [JsonProperty("ideaHubCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdeaHubCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCorpVcResResultDTO {\n");
            sb.Append("  vmrPkgList: ").Append(VmrPkgList).Append("\n");
            sb.Append("  te1080pHardCount: ").Append(Te1080pHardCount).Append("\n");
            sb.Append("  te720pHardCount: ").Append(Te720pHardCount).Append("\n");
            sb.Append("  teSoftCount: ").Append(TeSoftCount).Append("\n");
            sb.Append("  roomCount: ").Append(RoomCount).Append("\n");
            sb.Append("  recordCapability: ").Append(RecordCapability).Append("\n");
            sb.Append("  confCallCount: ").Append(ConfCallCount).Append("\n");
            sb.Append("  liveCount: ").Append(LiveCount).Append("\n");
            sb.Append("  thirdPartyHardCount: ").Append(ThirdPartyHardCount).Append("\n");
            sb.Append("  hwVisionCount: ").Append(HwVisionCount).Append("\n");
            sb.Append("  ideaHubCount: ").Append(IdeaHubCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCorpVcResResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCorpVcResResultDTO input)
        {
            if (input == null) return false;
            if (this.VmrPkgList != input.VmrPkgList || (this.VmrPkgList != null && input.VmrPkgList != null && !this.VmrPkgList.SequenceEqual(input.VmrPkgList))) return false;
            if (this.Te1080pHardCount != input.Te1080pHardCount || (this.Te1080pHardCount != null && !this.Te1080pHardCount.Equals(input.Te1080pHardCount))) return false;
            if (this.Te720pHardCount != input.Te720pHardCount || (this.Te720pHardCount != null && !this.Te720pHardCount.Equals(input.Te720pHardCount))) return false;
            if (this.TeSoftCount != input.TeSoftCount || (this.TeSoftCount != null && !this.TeSoftCount.Equals(input.TeSoftCount))) return false;
            if (this.RoomCount != input.RoomCount || (this.RoomCount != null && !this.RoomCount.Equals(input.RoomCount))) return false;
            if (this.RecordCapability != input.RecordCapability || (this.RecordCapability != null && !this.RecordCapability.Equals(input.RecordCapability))) return false;
            if (this.ConfCallCount != input.ConfCallCount || (this.ConfCallCount != null && !this.ConfCallCount.Equals(input.ConfCallCount))) return false;
            if (this.LiveCount != input.LiveCount || (this.LiveCount != null && !this.LiveCount.Equals(input.LiveCount))) return false;
            if (this.ThirdPartyHardCount != input.ThirdPartyHardCount || (this.ThirdPartyHardCount != null && !this.ThirdPartyHardCount.Equals(input.ThirdPartyHardCount))) return false;
            if (this.HwVisionCount != input.HwVisionCount || (this.HwVisionCount != null && !this.HwVisionCount.Equals(input.HwVisionCount))) return false;
            if (this.IdeaHubCount != input.IdeaHubCount || (this.IdeaHubCount != null && !this.IdeaHubCount.Equals(input.IdeaHubCount))) return false;

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
                if (this.VmrPkgList != null) hashCode = hashCode * 59 + this.VmrPkgList.GetHashCode();
                if (this.Te1080pHardCount != null) hashCode = hashCode * 59 + this.Te1080pHardCount.GetHashCode();
                if (this.Te720pHardCount != null) hashCode = hashCode * 59 + this.Te720pHardCount.GetHashCode();
                if (this.TeSoftCount != null) hashCode = hashCode * 59 + this.TeSoftCount.GetHashCode();
                if (this.RoomCount != null) hashCode = hashCode * 59 + this.RoomCount.GetHashCode();
                if (this.RecordCapability != null) hashCode = hashCode * 59 + this.RecordCapability.GetHashCode();
                if (this.ConfCallCount != null) hashCode = hashCode * 59 + this.ConfCallCount.GetHashCode();
                if (this.LiveCount != null) hashCode = hashCode * 59 + this.LiveCount.GetHashCode();
                if (this.ThirdPartyHardCount != null) hashCode = hashCode * 59 + this.ThirdPartyHardCount.GetHashCode();
                if (this.HwVisionCount != null) hashCode = hashCode * 59 + this.HwVisionCount.GetHashCode();
                if (this.IdeaHubCount != null) hashCode = hashCode * 59 + this.IdeaHubCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
