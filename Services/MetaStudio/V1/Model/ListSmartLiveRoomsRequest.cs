using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSmartLiveRoomsRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。  格式为(YYYYMMDD&#39;T&#39;HHMMSS&#39;Z&#39;)。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息。
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 按直播间名称模糊查询。
        /// </summary>
        [SDKProperty("room_name", IsQuery = true)]
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// 按数字人形象ID查询。
        /// </summary>
        [SDKProperty("dh_id", IsQuery = true)]
        [JsonProperty("dh_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DhId { get; set; }

        /// <summary>
        /// 按形象名称模糊查询。
        /// </summary>
        [SDKProperty("model_name", IsQuery = true)]
        [JsonProperty("model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// 当前直播间直播状态。 WAITING，PROCESSING，SUCCESS，FAILED，CANCELED对应直播任务状态 NULL 对应没有直播任务 可多个状态查询，使用英文逗号分隔。
        /// </summary>
        [SDKProperty("live_state", IsQuery = true)]
        [JsonProperty("live_state", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveState { get; set; }

        /// <summary>
        /// 最近直播任务起始时间。格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。格式遵循：RFC 3339 如\&quot;2021-01-10T10:43:17Z\&quot;。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 按直播间类型查询。直播间类型。 * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。
        /// </summary>
        [SDKProperty("room_type", IsQuery = true)]
        [JsonProperty("room_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomType { get; set; }

        /// <summary>
        /// 按照自己拥有的和别人分享以及公共的模板进行查询 * OWNED 自己拥有且暂未共享的 * SHARED_TO_OHTERS 分享给别人的 * SHARED_FROM_OHTERS 别人分享给我的 * PUBLIC 公共模板
        /// </summary>
        [SDKProperty("template_own_type", IsQuery = true)]
        [JsonProperty("template_own_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateOwnType { get; set; }

        /// <summary>
        /// 直播间确认状态。此状态仅用于特定用户需要人工确认场景。 - unconfirm: 未确认 - confirmed：已确认 - reject： 拒绝
        /// </summary>
        [SDKProperty("confirm_state", IsQuery = true)]
        [JsonProperty("confirm_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfirmState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSmartLiveRoomsRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  dhId: ").Append(DhId).Append("\n");
            sb.Append("  modelName: ").Append(ModelName).Append("\n");
            sb.Append("  liveState: ").Append(LiveState).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  roomType: ").Append(RoomType).Append("\n");
            sb.Append("  templateOwnType: ").Append(TemplateOwnType).Append("\n");
            sb.Append("  confirmState: ").Append(ConfirmState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSmartLiveRoomsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSmartLiveRoomsRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.DhId != input.DhId || (this.DhId != null && !this.DhId.Equals(input.DhId))) return false;
            if (this.ModelName != input.ModelName || (this.ModelName != null && !this.ModelName.Equals(input.ModelName))) return false;
            if (this.LiveState != input.LiveState || (this.LiveState != null && !this.LiveState.Equals(input.LiveState))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.RoomType != input.RoomType || (this.RoomType != null && !this.RoomType.Equals(input.RoomType))) return false;
            if (this.TemplateOwnType != input.TemplateOwnType || (this.TemplateOwnType != null && !this.TemplateOwnType.Equals(input.TemplateOwnType))) return false;
            if (this.ConfirmState != input.ConfirmState || (this.ConfirmState != null && !this.ConfirmState.Equals(input.ConfirmState))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                if (this.DhId != null) hashCode = hashCode * 59 + this.DhId.GetHashCode();
                if (this.ModelName != null) hashCode = hashCode * 59 + this.ModelName.GetHashCode();
                if (this.LiveState != null) hashCode = hashCode * 59 + this.LiveState.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.RoomType != null) hashCode = hashCode * 59 + this.RoomType.GetHashCode();
                if (this.TemplateOwnType != null) hashCode = hashCode * 59 + this.TemplateOwnType.GetHashCode();
                if (this.ConfirmState != null) hashCode = hashCode * 59 + this.ConfirmState.GetHashCode();
                return hashCode;
            }
        }
    }
}
