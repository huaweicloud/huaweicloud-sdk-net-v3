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
    /// Response Object
    /// </summary>
    public class ShowCorpResourceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("te1080pHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO Te1080pHardCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("te720pHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO Te720pHardCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("teSoftCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO TeSoftCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("roomCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO RoomCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recordCapability", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO RecordCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confCallCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO ConfCallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("liveCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO LiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thirdPartyHardCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO ThirdPartyHardCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hwVisionCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO HwVisionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ideaHubCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO IdeaHubCount { get; set; }

        /// <summary>
        /// 查询云会议室套餐包分配数量结果。
        /// </summary>
        [JsonProperty("vmr", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryVmrPkgResResultDTO> Vmr { get; set; }

        /// <summary>
        /// 在创建企业的时候设置的pstn权限开关。
        /// </summary>
        [JsonProperty("enablePstn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePstn { get; set; }

        /// <summary>
        /// 企业是否通过短信形式发送会议通知。
        /// </summary>
        [JsonProperty("enableSMS", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSMS { get; set; }

        /// <summary>
        /// 企业是否开启混合云模式。
        /// </summary>
        [JsonProperty("enableHybridCloud", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHybridCloud { get; set; }

        /// <summary>
        /// 是否开启云盘。
        /// </summary>
        [JsonProperty("enableCloudDisk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCloudDisk { get; set; }

        /// <summary>
        /// 是否开启UC功能。
        /// </summary>
        [JsonProperty("enableUc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableUc { get; set; }

        /// <summary>
        /// 是否开启Ai会议纪要。
        /// </summary>
        [JsonProperty("enableAiMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAiMinutes { get; set; }

        /// <summary>
        /// 单会议并发呼叫数。
        /// </summary>
        [JsonProperty("singleConfCallCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SingleConfCallCount { get; set; }

        /// <summary>
        /// 会议时长。
        /// </summary>
        [JsonProperty("confLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfLength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCorpResourceResponse {\n");
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
            sb.Append("  vmr: ").Append(Vmr).Append("\n");
            sb.Append("  enablePstn: ").Append(EnablePstn).Append("\n");
            sb.Append("  enableSMS: ").Append(EnableSMS).Append("\n");
            sb.Append("  enableHybridCloud: ").Append(EnableHybridCloud).Append("\n");
            sb.Append("  enableCloudDisk: ").Append(EnableCloudDisk).Append("\n");
            sb.Append("  enableUc: ").Append(EnableUc).Append("\n");
            sb.Append("  enableAiMinutes: ").Append(EnableAiMinutes).Append("\n");
            sb.Append("  singleConfCallCount: ").Append(SingleConfCallCount).Append("\n");
            sb.Append("  confLength: ").Append(ConfLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCorpResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCorpResourceResponse input)
        {
            if (input == null) return false;
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
            if (this.Vmr != input.Vmr || (this.Vmr != null && input.Vmr != null && !this.Vmr.SequenceEqual(input.Vmr))) return false;
            if (this.EnablePstn != input.EnablePstn || (this.EnablePstn != null && !this.EnablePstn.Equals(input.EnablePstn))) return false;
            if (this.EnableSMS != input.EnableSMS || (this.EnableSMS != null && !this.EnableSMS.Equals(input.EnableSMS))) return false;
            if (this.EnableHybridCloud != input.EnableHybridCloud || (this.EnableHybridCloud != null && !this.EnableHybridCloud.Equals(input.EnableHybridCloud))) return false;
            if (this.EnableCloudDisk != input.EnableCloudDisk || (this.EnableCloudDisk != null && !this.EnableCloudDisk.Equals(input.EnableCloudDisk))) return false;
            if (this.EnableUc != input.EnableUc || (this.EnableUc != null && !this.EnableUc.Equals(input.EnableUc))) return false;
            if (this.EnableAiMinutes != input.EnableAiMinutes || (this.EnableAiMinutes != null && !this.EnableAiMinutes.Equals(input.EnableAiMinutes))) return false;
            if (this.SingleConfCallCount != input.SingleConfCallCount || (this.SingleConfCallCount != null && !this.SingleConfCallCount.Equals(input.SingleConfCallCount))) return false;
            if (this.ConfLength != input.ConfLength || (this.ConfLength != null && !this.ConfLength.Equals(input.ConfLength))) return false;

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
                if (this.Vmr != null) hashCode = hashCode * 59 + this.Vmr.GetHashCode();
                if (this.EnablePstn != null) hashCode = hashCode * 59 + this.EnablePstn.GetHashCode();
                if (this.EnableSMS != null) hashCode = hashCode * 59 + this.EnableSMS.GetHashCode();
                if (this.EnableHybridCloud != null) hashCode = hashCode * 59 + this.EnableHybridCloud.GetHashCode();
                if (this.EnableCloudDisk != null) hashCode = hashCode * 59 + this.EnableCloudDisk.GetHashCode();
                if (this.EnableUc != null) hashCode = hashCode * 59 + this.EnableUc.GetHashCode();
                if (this.EnableAiMinutes != null) hashCode = hashCode * 59 + this.EnableAiMinutes.GetHashCode();
                if (this.SingleConfCallCount != null) hashCode = hashCode * 59 + this.SingleConfCallCount.GetHashCode();
                if (this.ConfLength != null) hashCode = hashCode * 59 + this.ConfLength.GetHashCode();
                return hashCode;
            }
        }
    }
}
