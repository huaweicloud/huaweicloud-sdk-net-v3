using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VariableRes 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("by_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ByOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeString { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currentPermission", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dynamicParamFlag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicParamFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("functionParams", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isSensitiveInfo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitiveInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isSensitiveModified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitiveModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public int? Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sensitiveInfoSetterTime", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveInfoSetterTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sensitiveInfoSetterUser", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveInfoSetterUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("update_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("update_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimeString { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("update_user", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("variableType", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariableType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableRes {\n");
            sb.Append("  byOrder: ").Append(ByOrder).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  createTimeString: ").Append(CreateTimeString).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  currentPermission: ").Append(CurrentPermission).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dynamicParamFlag: ").Append(DynamicParamFlag).Append("\n");
            sb.Append("  functionParams: ").Append(FunctionParams).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isSensitiveInfo: ").Append(IsSensitiveInfo).Append("\n");
            sb.Append("  isSensitiveModified: ").Append(IsSensitiveModified).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  parentNodeId: ").Append(ParentNodeId).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  sensitiveInfoSetterTime: ").Append(SensitiveInfoSetterTime).Append("\n");
            sb.Append("  sensitiveInfoSetterUser: ").Append(SensitiveInfoSetterUser).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  updateTimeString: ").Append(UpdateTimeString).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("  variableType: ").Append(VariableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VariableRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VariableRes input)
        {
            if (input == null) return false;
            if (this.ByOrder != input.ByOrder || (this.ByOrder != null && !this.ByOrder.Equals(input.ByOrder))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.CreateTimeString != input.CreateTimeString || (this.CreateTimeString != null && !this.CreateTimeString.Equals(input.CreateTimeString))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.CurrentPermission != input.CurrentPermission || (this.CurrentPermission != null && !this.CurrentPermission.Equals(input.CurrentPermission))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DynamicParamFlag != input.DynamicParamFlag || (this.DynamicParamFlag != null && !this.DynamicParamFlag.Equals(input.DynamicParamFlag))) return false;
            if (this.FunctionParams != input.FunctionParams || (this.FunctionParams != null && !this.FunctionParams.Equals(input.FunctionParams))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsSensitiveInfo != input.IsSensitiveInfo || (this.IsSensitiveInfo != null && !this.IsSensitiveInfo.Equals(input.IsSensitiveInfo))) return false;
            if (this.IsSensitiveModified != input.IsSensitiveModified || (this.IsSensitiveModified != null && !this.IsSensitiveModified.Equals(input.IsSensitiveModified))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ParentNodeId != input.ParentNodeId || (this.ParentNodeId != null && !this.ParentNodeId.Equals(input.ParentNodeId))) return false;
            if (this.Property != input.Property || (this.Property != null && !this.Property.Equals(input.Property))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.SensitiveInfoSetterTime != input.SensitiveInfoSetterTime || (this.SensitiveInfoSetterTime != null && !this.SensitiveInfoSetterTime.Equals(input.SensitiveInfoSetterTime))) return false;
            if (this.SensitiveInfoSetterUser != input.SensitiveInfoSetterUser || (this.SensitiveInfoSetterUser != null && !this.SensitiveInfoSetterUser.Equals(input.SensitiveInfoSetterUser))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.UpdateTimeString != input.UpdateTimeString || (this.UpdateTimeString != null && !this.UpdateTimeString.Equals(input.UpdateTimeString))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;
            if (this.VariableType != input.VariableType || (this.VariableType != null && !this.VariableType.Equals(input.VariableType))) return false;

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
                if (this.ByOrder != null) hashCode = hashCode * 59 + this.ByOrder.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.CreateTimeString != null) hashCode = hashCode * 59 + this.CreateTimeString.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.CurrentPermission != null) hashCode = hashCode * 59 + this.CurrentPermission.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DynamicParamFlag != null) hashCode = hashCode * 59 + this.DynamicParamFlag.GetHashCode();
                if (this.FunctionParams != null) hashCode = hashCode * 59 + this.FunctionParams.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsSensitiveInfo != null) hashCode = hashCode * 59 + this.IsSensitiveInfo.GetHashCode();
                if (this.IsSensitiveModified != null) hashCode = hashCode * 59 + this.IsSensitiveModified.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ParentNodeId != null) hashCode = hashCode * 59 + this.ParentNodeId.GetHashCode();
                if (this.Property != null) hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SensitiveInfoSetterTime != null) hashCode = hashCode * 59 + this.SensitiveInfoSetterTime.GetHashCode();
                if (this.SensitiveInfoSetterUser != null) hashCode = hashCode * 59 + this.SensitiveInfoSetterUser.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.UpdateTimeString != null) hashCode = hashCode * 59 + this.UpdateTimeString.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                if (this.VariableType != null) hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
