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
    public class ShowSpResourceResponse : SdkResponse
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
        [JsonProperty("corpCount", NullValueHandling = NullValueHandling.Ignore)]
        public ResDetailDTO CorpCount { get; set; }

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
        /// SP管理员绑定的分组列表。
        /// </summary>
        [JsonProperty("groupList", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryCorpGroupDTO> GroupList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSpResourceResponse {\n");
            sb.Append("  te1080pHardCount: ").Append(Te1080pHardCount).Append("\n");
            sb.Append("  te720pHardCount: ").Append(Te720pHardCount).Append("\n");
            sb.Append("  teSoftCount: ").Append(TeSoftCount).Append("\n");
            sb.Append("  roomCount: ").Append(RoomCount).Append("\n");
            sb.Append("  recordCapability: ").Append(RecordCapability).Append("\n");
            sb.Append("  confCallCount: ").Append(ConfCallCount).Append("\n");
            sb.Append("  liveCount: ").Append(LiveCount).Append("\n");
            sb.Append("  corpCount: ").Append(CorpCount).Append("\n");
            sb.Append("  thirdPartyHardCount: ").Append(ThirdPartyHardCount).Append("\n");
            sb.Append("  hwVisionCount: ").Append(HwVisionCount).Append("\n");
            sb.Append("  ideaHubCount: ").Append(IdeaHubCount).Append("\n");
            sb.Append("  enablePstn: ").Append(EnablePstn).Append("\n");
            sb.Append("  enableSMS: ").Append(EnableSMS).Append("\n");
            sb.Append("  groupList: ").Append(GroupList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSpResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSpResourceResponse input)
        {
            if (input == null) return false;
            if (this.Te1080pHardCount != input.Te1080pHardCount || (this.Te1080pHardCount != null && !this.Te1080pHardCount.Equals(input.Te1080pHardCount))) return false;
            if (this.Te720pHardCount != input.Te720pHardCount || (this.Te720pHardCount != null && !this.Te720pHardCount.Equals(input.Te720pHardCount))) return false;
            if (this.TeSoftCount != input.TeSoftCount || (this.TeSoftCount != null && !this.TeSoftCount.Equals(input.TeSoftCount))) return false;
            if (this.RoomCount != input.RoomCount || (this.RoomCount != null && !this.RoomCount.Equals(input.RoomCount))) return false;
            if (this.RecordCapability != input.RecordCapability || (this.RecordCapability != null && !this.RecordCapability.Equals(input.RecordCapability))) return false;
            if (this.ConfCallCount != input.ConfCallCount || (this.ConfCallCount != null && !this.ConfCallCount.Equals(input.ConfCallCount))) return false;
            if (this.LiveCount != input.LiveCount || (this.LiveCount != null && !this.LiveCount.Equals(input.LiveCount))) return false;
            if (this.CorpCount != input.CorpCount || (this.CorpCount != null && !this.CorpCount.Equals(input.CorpCount))) return false;
            if (this.ThirdPartyHardCount != input.ThirdPartyHardCount || (this.ThirdPartyHardCount != null && !this.ThirdPartyHardCount.Equals(input.ThirdPartyHardCount))) return false;
            if (this.HwVisionCount != input.HwVisionCount || (this.HwVisionCount != null && !this.HwVisionCount.Equals(input.HwVisionCount))) return false;
            if (this.IdeaHubCount != input.IdeaHubCount || (this.IdeaHubCount != null && !this.IdeaHubCount.Equals(input.IdeaHubCount))) return false;
            if (this.EnablePstn != input.EnablePstn || (this.EnablePstn != null && !this.EnablePstn.Equals(input.EnablePstn))) return false;
            if (this.EnableSMS != input.EnableSMS || (this.EnableSMS != null && !this.EnableSMS.Equals(input.EnableSMS))) return false;
            if (this.GroupList != input.GroupList || (this.GroupList != null && input.GroupList != null && !this.GroupList.SequenceEqual(input.GroupList))) return false;

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
                if (this.CorpCount != null) hashCode = hashCode * 59 + this.CorpCount.GetHashCode();
                if (this.ThirdPartyHardCount != null) hashCode = hashCode * 59 + this.ThirdPartyHardCount.GetHashCode();
                if (this.HwVisionCount != null) hashCode = hashCode * 59 + this.HwVisionCount.GetHashCode();
                if (this.IdeaHubCount != null) hashCode = hashCode * 59 + this.IdeaHubCount.GetHashCode();
                if (this.EnablePstn != null) hashCode = hashCode * 59 + this.EnablePstn.GetHashCode();
                if (this.EnableSMS != null) hashCode = hashCode * 59 + this.EnableSMS.GetHashCode();
                if (this.GroupList != null) hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                return hashCode;
            }
        }
    }
}
