using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// **参数解释**:  请求返回结果，接口不同，返回不同。 **取值范围**: 根据不同接口有不同范围。 
    /// </summary>
    public class PrivilegesResponseResult 
    {

        /// <summary>
        /// **参数解释**:  操作列表。 **取值范围**: 英文字符串，使用英文逗号分隔。 
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public string Operations { get; set; }

        /// <summary>
        /// **参数解释**:  操作序列号。 **取值范围**: 数字。 
        /// </summary>
        [JsonProperty("operationsIndex", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> OperationsIndex { get; set; }

        /// <summary>
        /// **参数解释**:  角色id。 **取值范围**: 32位英文、数字随机字符串。 
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// **参数解释**:  角色英文名称。 **取值范围**:   Project manager，Product manager，Test manager，Operation manager，System engineer，Committer，Developer，Testter，Participant，Viever及自定义角色。 
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// **参数解释**:  角色中文名称。 **取值范围**: 项目经理，产品经理，测试经理，运维经理，系统工程师，Committer，开发人员，测试人员，参与者，浏览者及自定义角色。 
        /// </summary>
        [JsonProperty("role_chinese_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleChineseName { get; set; }

        /// <summary>
        /// 项目id。 **取值范围**: 32位英文、数字随机字符串。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**:  服务。 **取值范围**: 32位英文、数字随机字符串。 
        /// </summary>
        [JsonProperty("area_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaServiceId { get; set; }

        /// <summary>
        /// **参数解释**:  授权对象路径。 **取值范围**: 英文、数字、斜线（/）、星号（*）字符串 
        /// </summary>
        [JsonProperty("granted_object_path", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantedObjectPath { get; set; }

        /// <summary>
        /// **参数解释**:  授权对象类型id。 **取值范围**: 32位英文、数字随机字符串。 
        /// </summary>
        [JsonProperty("granted_object_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantedObjectTypeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivilegesResponseResult {\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  operationsIndex: ").Append(OperationsIndex).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  roleChineseName: ").Append(RoleChineseName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  areaServiceId: ").Append(AreaServiceId).Append("\n");
            sb.Append("  grantedObjectPath: ").Append(GrantedObjectPath).Append("\n");
            sb.Append("  grantedObjectTypeId: ").Append(GrantedObjectTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivilegesResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivilegesResponseResult input)
        {
            if (input == null) return false;
            if (this.Operations != input.Operations || (this.Operations != null && !this.Operations.Equals(input.Operations))) return false;
            if (this.OperationsIndex != input.OperationsIndex || (this.OperationsIndex != null && input.OperationsIndex != null && !this.OperationsIndex.SequenceEqual(input.OperationsIndex))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.RoleChineseName != input.RoleChineseName || (this.RoleChineseName != null && !this.RoleChineseName.Equals(input.RoleChineseName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AreaServiceId != input.AreaServiceId || (this.AreaServiceId != null && !this.AreaServiceId.Equals(input.AreaServiceId))) return false;
            if (this.GrantedObjectPath != input.GrantedObjectPath || (this.GrantedObjectPath != null && !this.GrantedObjectPath.Equals(input.GrantedObjectPath))) return false;
            if (this.GrantedObjectTypeId != input.GrantedObjectTypeId || (this.GrantedObjectTypeId != null && !this.GrantedObjectTypeId.Equals(input.GrantedObjectTypeId))) return false;

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
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.OperationsIndex != null) hashCode = hashCode * 59 + this.OperationsIndex.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleChineseName != null) hashCode = hashCode * 59 + this.RoleChineseName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AreaServiceId != null) hashCode = hashCode * 59 + this.AreaServiceId.GetHashCode();
                if (this.GrantedObjectPath != null) hashCode = hashCode * 59 + this.GrantedObjectPath.GetHashCode();
                if (this.GrantedObjectTypeId != null) hashCode = hashCode * 59 + this.GrantedObjectTypeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
