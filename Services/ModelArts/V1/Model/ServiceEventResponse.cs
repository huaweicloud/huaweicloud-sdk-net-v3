using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 服务事件信息响应数据模型
    /// </summary>
    public class ServiceEventResponse 
    {

        /// <summary>
        /// **参数解释：** 服务事件ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 服务ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("service_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersionId { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件发生计数 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("event_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventCount { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件类型：NORMAL/ABNORMAL/WARNING **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件信息（英文） **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("event_info", NullValueHandling = NullValueHandling.Ignore)]
        public string EventInfo { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件信息（中文） **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("event_info_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string EventInfoCn { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件第一次发生时间 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 服务事件最后发生时间 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceEventResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  serviceVersionId: ").Append(ServiceVersionId).Append("\n");
            sb.Append("  eventCount: ").Append(EventCount).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventInfo: ").Append(EventInfo).Append("\n");
            sb.Append("  eventInfoCn: ").Append(EventInfoCn).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceEventResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.ServiceVersionId != input.ServiceVersionId || (this.ServiceVersionId != null && !this.ServiceVersionId.Equals(input.ServiceVersionId))) return false;
            if (this.EventCount != input.EventCount || (this.EventCount != null && !this.EventCount.Equals(input.EventCount))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventInfo != input.EventInfo || (this.EventInfo != null && !this.EventInfo.Equals(input.EventInfo))) return false;
            if (this.EventInfoCn != input.EventInfoCn || (this.EventInfoCn != null && !this.EventInfoCn.Equals(input.EventInfoCn))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceVersionId != null) hashCode = hashCode * 59 + this.ServiceVersionId.GetHashCode();
                if (this.EventCount != null) hashCode = hashCode * 59 + this.EventCount.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventInfo != null) hashCode = hashCode * 59 + this.EventInfo.GetHashCode();
                if (this.EventInfoCn != null) hashCode = hashCode * 59 + this.EventInfoCn.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
