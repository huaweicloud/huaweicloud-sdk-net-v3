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
    public class UserEventRsp 
    {

        /// <summary>
        /// 项目id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 企业id。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 事件之间的关联id。
        /// </summary>
        [JsonProperty("event_trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTraceId { get; set; }

        /// <summary>
        /// 事件类型。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 事件时间，格式为：UTC时间，例如\&quot;1970-01-01T00:00:00Z\&quot;。
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTime { get; set; }

        /// <summary>
        /// 操作对象类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 操作对象id。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 操作对象名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 客户端类型。
        /// </summary>
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientType { get; set; }

        /// <summary>
        /// 客户端ip。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端mac地址。
        /// </summary>
        [JsonProperty("client_mac", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientMac { get; set; }

        /// <summary>
        /// 客户端版本。
        /// </summary>
        [JsonProperty("client_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 操作用户源ip。
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 是否成功。
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 触发事件的类型，USER-用户触发，SYSTEM-系统触发。
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEventRsp {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  eventTraceId: ").Append(EventTraceId).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  clientMac: ").Append(ClientMac).Append("\n");
            sb.Append("  clientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserEventRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserEventRsp input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.EventTraceId != input.EventTraceId || (this.EventTraceId != null && !this.EventTraceId.Equals(input.EventTraceId))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventTime != input.EventTime || (this.EventTime != null && !this.EventTime.Equals(input.EventTime))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.ClientMac != input.ClientMac || (this.ClientMac != null && !this.ClientMac.Equals(input.ClientMac))) return false;
            if (this.ClientVersion != input.ClientVersion || (this.ClientVersion != null && !this.ClientVersion.Equals(input.ClientVersion))) return false;
            if (this.SourceIp != input.SourceIp || (this.SourceIp != null && !this.SourceIp.Equals(input.SourceIp))) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.EventTraceId != null) hashCode = hashCode * 59 + this.EventTraceId.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventTime != null) hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.ClientMac != null) hashCode = hashCode * 59 + this.ClientMac.GetHashCode();
                if (this.ClientVersion != null) hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.SourceIp != null) hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
