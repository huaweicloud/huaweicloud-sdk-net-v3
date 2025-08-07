using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceMigrateRecord 
    {

        /// <summary>
        /// 是否关联迁移
        /// </summary>
        [JsonProperty("associated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Associated { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 迁移类型
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 发起迁移的企业项目ID
        /// </summary>
        [JsonProperty("initiate_ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiateEpId { get; set; }

        /// <summary>
        /// 发起迁移的业项目名称
        /// </summary>
        [JsonProperty("initiate_ep_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiateEpName { get; set; }

        /// <summary>
        /// 源企业项目ID
        /// </summary>
        [JsonProperty("origin_ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginEpId { get; set; }

        /// <summary>
        /// 源企业项目名称
        /// </summary>
        [JsonProperty("origin_ep_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginEpName { get; set; }

        /// <summary>
        /// 目标企业项目ID
        /// </summary>
        [JsonProperty("target_ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetEpId { get; set; }

        /// <summary>
        /// 目标企业项目名称
        /// </summary>
        [JsonProperty("target_ep_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetEpName { get; set; }

        /// <summary>
        /// 是否存在失败
        /// </summary>
        [JsonProperty("exist_failed", NullValueHandling = NullValueHandling.Ignore)]
        public string ExistFailed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceMigrateRecord {\n");
            sb.Append("  associated: ").Append(Associated).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  initiateEpId: ").Append(InitiateEpId).Append("\n");
            sb.Append("  initiateEpName: ").Append(InitiateEpName).Append("\n");
            sb.Append("  originEpId: ").Append(OriginEpId).Append("\n");
            sb.Append("  originEpName: ").Append(OriginEpName).Append("\n");
            sb.Append("  targetEpId: ").Append(TargetEpId).Append("\n");
            sb.Append("  targetEpName: ").Append(TargetEpName).Append("\n");
            sb.Append("  existFailed: ").Append(ExistFailed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceMigrateRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceMigrateRecord input)
        {
            if (input == null) return false;
            if (this.Associated != input.Associated || (this.Associated != null && !this.Associated.Equals(input.Associated))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.EventTime != input.EventTime || (this.EventTime != null && !this.EventTime.Equals(input.EventTime))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.InitiateEpId != input.InitiateEpId || (this.InitiateEpId != null && !this.InitiateEpId.Equals(input.InitiateEpId))) return false;
            if (this.InitiateEpName != input.InitiateEpName || (this.InitiateEpName != null && !this.InitiateEpName.Equals(input.InitiateEpName))) return false;
            if (this.OriginEpId != input.OriginEpId || (this.OriginEpId != null && !this.OriginEpId.Equals(input.OriginEpId))) return false;
            if (this.OriginEpName != input.OriginEpName || (this.OriginEpName != null && !this.OriginEpName.Equals(input.OriginEpName))) return false;
            if (this.TargetEpId != input.TargetEpId || (this.TargetEpId != null && !this.TargetEpId.Equals(input.TargetEpId))) return false;
            if (this.TargetEpName != input.TargetEpName || (this.TargetEpName != null && !this.TargetEpName.Equals(input.TargetEpName))) return false;
            if (this.ExistFailed != input.ExistFailed || (this.ExistFailed != null && !this.ExistFailed.Equals(input.ExistFailed))) return false;

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
                if (this.Associated != null) hashCode = hashCode * 59 + this.Associated.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.EventTime != null) hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.InitiateEpId != null) hashCode = hashCode * 59 + this.InitiateEpId.GetHashCode();
                if (this.InitiateEpName != null) hashCode = hashCode * 59 + this.InitiateEpName.GetHashCode();
                if (this.OriginEpId != null) hashCode = hashCode * 59 + this.OriginEpId.GetHashCode();
                if (this.OriginEpName != null) hashCode = hashCode * 59 + this.OriginEpName.GetHashCode();
                if (this.TargetEpId != null) hashCode = hashCode * 59 + this.TargetEpId.GetHashCode();
                if (this.TargetEpName != null) hashCode = hashCode * 59 + this.TargetEpName.GetHashCode();
                if (this.ExistFailed != null) hashCode = hashCode * 59 + this.ExistFailed.GetHashCode();
                return hashCode;
            }
        }
    }
}
