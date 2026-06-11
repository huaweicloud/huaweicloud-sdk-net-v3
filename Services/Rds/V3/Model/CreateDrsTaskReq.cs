using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 创建drs任务的请求体
    /// </summary>
    public class CreateDrsTaskReq 
    {

        /// <summary>
        /// 目标实例id
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 目标实例用户账号
        /// </summary>
        [JsonProperty("target_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetUserName { get; set; }

        /// <summary>
        /// 目标实例用户密码
        /// </summary>
        [JsonProperty("target_user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetUserPassword { get; set; }

        /// <summary>
        /// 源实例用户账号
        /// </summary>
        [JsonProperty("source_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUserName { get; set; }

        /// <summary>
        /// 源实例用户密码
        /// </summary>
        [JsonProperty("source_user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUserPassword { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// Drs实例规格
        /// </summary>
        [JsonProperty("drs_node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DrsNodeType { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("database_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatabaseList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDrsTaskReq {\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  targetUserName: ").Append(TargetUserName).Append("\n");
            sb.Append("  targetUserPassword: ").Append(TargetUserPassword).Append("\n");
            sb.Append("  sourceUserName: ").Append(SourceUserName).Append("\n");
            sb.Append("  sourceUserPassword: ").Append(SourceUserPassword).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  drsNodeType: ").Append(DrsNodeType).Append("\n");
            sb.Append("  databaseList: ").Append(DatabaseList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDrsTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDrsTaskReq input)
        {
            if (input == null) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;
            if (this.TargetUserName != input.TargetUserName || (this.TargetUserName != null && !this.TargetUserName.Equals(input.TargetUserName))) return false;
            if (this.TargetUserPassword != input.TargetUserPassword || (this.TargetUserPassword != null && !this.TargetUserPassword.Equals(input.TargetUserPassword))) return false;
            if (this.SourceUserName != input.SourceUserName || (this.SourceUserName != null && !this.SourceUserName.Equals(input.SourceUserName))) return false;
            if (this.SourceUserPassword != input.SourceUserPassword || (this.SourceUserPassword != null && !this.SourceUserPassword.Equals(input.SourceUserPassword))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DrsNodeType != input.DrsNodeType || (this.DrsNodeType != null && !this.DrsNodeType.Equals(input.DrsNodeType))) return false;
            if (this.DatabaseList != input.DatabaseList || (this.DatabaseList != null && input.DatabaseList != null && !this.DatabaseList.SequenceEqual(input.DatabaseList))) return false;

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
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.TargetUserName != null) hashCode = hashCode * 59 + this.TargetUserName.GetHashCode();
                if (this.TargetUserPassword != null) hashCode = hashCode * 59 + this.TargetUserPassword.GetHashCode();
                if (this.SourceUserName != null) hashCode = hashCode * 59 + this.SourceUserName.GetHashCode();
                if (this.SourceUserPassword != null) hashCode = hashCode * 59 + this.SourceUserPassword.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DrsNodeType != null) hashCode = hashCode * 59 + this.DrsNodeType.GetHashCode();
                if (this.DatabaseList != null) hashCode = hashCode * 59 + this.DatabaseList.GetHashCode();
                return hashCode;
            }
        }
    }
}
