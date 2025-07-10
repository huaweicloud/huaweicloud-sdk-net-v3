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
    /// Request Object
    /// </summary>
    public class ListDesktopOperationsRequest 
    {

        /// <summary>
        /// 录屏记录UUID。
        /// </summary>
        [SDKProperty("record_id", IsPath = true)]
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 事件类型。 - APP：应用监控。 - FILE：文件监控。 - REG：注册表监控。 - HDP：协议行为监控。
        /// </summary>
        [SDKProperty("event_type", IsQuery = true)]
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 事件ID。 - APP_START：应用程序启动 - APP_STOP：应用程序结束 - APP_CRASH：应用程序异常退出 - APP_HANG：应用程序无响应 - APP_INSTALL：应用安装 - APP_UNINSTALL：应用卸裁 - FILE_CREATE：文件创建 - FILE_DELETE：文件删除 - FILE_RENAME：文件改名 - HDP_FILE：文件重定向 - HDP_USB：USB插拔事件 - HDP_CLIPBOARD：剪切板操作 - HDP_INPUTIDLE：空闲无操作 - HDP_PRINT：文件打印
        /// </summary>
        [SDKProperty("event_id", IsQuery = true)]
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 事件级别。 - INFO：提示。 - ALARM：告警。 - ERROR：异常。
        /// </summary>
        [SDKProperty("event_level", IsQuery = true)]
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public string EventLevel { get; set; }

        /// <summary>
        /// 事件内容。
        /// </summary>
        [SDKProperty("event_data", IsQuery = true)]
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EventData { get; set; }

        /// <summary>
        /// 用于分页查询，返回录屏记录数量的限制。默认100。范围0~1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopOperationsRequest {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopOperationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopOperationsRequest input)
        {
            if (input == null) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.EventLevel != input.EventLevel || (this.EventLevel != null && !this.EventLevel.Equals(input.EventLevel))) return false;
            if (this.EventData != input.EventData || (this.EventData != null && !this.EventData.Equals(input.EventData))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EventLevel != null) hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
