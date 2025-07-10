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
    /// 
    /// </summary>
    public class OperationForList 
    {

        /// <summary>
        /// 主键UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 录屏记录ID。
        /// </summary>
        [JsonProperty("screen_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenRecordId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 事件类型。 - APP：应用监控。 - FILE：文件监控。 - REG：注册表监控。 - HDP：协议行为监控。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 事件级别。 - INFO：提示。 - ALARM：告警。 - ERROR：异常。
        /// </summary>
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public string EventLevel { get; set; }

        /// <summary>
        /// 事件ID。 - APP_START：应用程序启动 - APP_STOP：应用程序结束 - APP_CRASH：应用程序异常退出 - APP_HANG：应用程序无响应 - APP_INSTALL：应用安装 - APP_UNINSTALL：应用卸裁 - FILE_CREATE：文件创建 - FILE_DELETE：文件删除 - FILE_RENAME：文件改名 - HDP_FILE：文件重定向 - HDP_USB：USB插拔事件 - HDP_CLIPBOARD：剪切板操作 - HDP_INPUTIDLE：空闲无操作 - HDP_PRINT：文件打印
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 事件内容。
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EventData { get; set; }

        /// <summary>
        /// 操作时间（2024-10-15T11:04:41.263Z）。
        /// </summary>
        [JsonProperty("operation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTime { get; set; }

        /// <summary>
        /// 相对于视频开始的时间（秒）。
        /// </summary>
        [JsonProperty("relative_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelativeStartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationForList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  screenRecordId: ").Append(ScreenRecordId).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("  operationTime: ").Append(OperationTime).Append("\n");
            sb.Append("  relativeStartTime: ").Append(RelativeStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationForList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.ScreenRecordId != input.ScreenRecordId || (this.ScreenRecordId != null && !this.ScreenRecordId.Equals(input.ScreenRecordId))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventLevel != input.EventLevel || (this.EventLevel != null && !this.EventLevel.Equals(input.EventLevel))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.EventData != input.EventData || (this.EventData != null && !this.EventData.Equals(input.EventData))) return false;
            if (this.OperationTime != input.OperationTime || (this.OperationTime != null && !this.OperationTime.Equals(input.OperationTime))) return false;
            if (this.RelativeStartTime != input.RelativeStartTime || (this.RelativeStartTime != null && !this.RelativeStartTime.Equals(input.RelativeStartTime))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.ScreenRecordId != null) hashCode = hashCode * 59 + this.ScreenRecordId.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventLevel != null) hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                if (this.OperationTime != null) hashCode = hashCode * 59 + this.OperationTime.GetHashCode();
                if (this.RelativeStartTime != null) hashCode = hashCode * 59 + this.RelativeStartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
