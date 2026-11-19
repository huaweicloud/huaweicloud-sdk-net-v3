using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListTrustedKeySpaceResponseBodyKeyspaces 
    {

        /// <summary>
        /// **参数解释：** 密钥空间ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间名称 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// **参数解释：** 企业项目ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间类型 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间状态 **取值范围：** 1：启用，2：冻结
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间描述信息 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间创建人 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间创建时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间最近更新时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("last_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrustedKeySpaceResponseBodyKeyspaces {\n");
            sb.Append("  keyspaceId: ").Append(KeyspaceId).Append("\n");
            sb.Append("  keyspaceName: ").Append(KeyspaceName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastModifyTime: ").Append(LastModifyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTrustedKeySpaceResponseBodyKeyspaces);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrustedKeySpaceResponseBodyKeyspaces input)
        {
            if (input == null) return false;
            if (this.KeyspaceId != input.KeyspaceId || (this.KeyspaceId != null && !this.KeyspaceId.Equals(input.KeyspaceId))) return false;
            if (this.KeyspaceName != input.KeyspaceName || (this.KeyspaceName != null && !this.KeyspaceName.Equals(input.KeyspaceName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastModifyTime != input.LastModifyTime || (this.LastModifyTime != null && !this.LastModifyTime.Equals(input.LastModifyTime))) return false;

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
                if (this.KeyspaceId != null) hashCode = hashCode * 59 + this.KeyspaceId.GetHashCode();
                if (this.KeyspaceName != null) hashCode = hashCode * 59 + this.KeyspaceName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastModifyTime != null) hashCode = hashCode * 59 + this.LastModifyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
