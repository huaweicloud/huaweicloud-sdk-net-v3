using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 脚本的基本信息。
    /// </summary>
    public class Script 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approve_info", NullValueHandling = NullValueHandling.Ignore)]
        public ApproveInfo ApproveInfo { get; set; }

        /// <summary>
        /// 创建人，比如为：张三
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 脚本描述，脚本描述,对脚本进行描述，最大长度为1000
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 脚本id，根据UUID.randomUUID生成。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 脚本名称，支持数字，下划线，大小写字母 ,中文
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 脚本中是否有已上线的版本，true表示有已上线的版本，false表示没有已上线的版本
        /// </summary>
        [JsonProperty("online_exist_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlineExistStatus { get; set; }

        /// <summary>
        /// 已上线版本id
        /// </summary>
        [JsonProperty("online_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlineId { get; set; }

        /// <summary>
        /// 租户从IAM申请到的projectid，一般为32位字符串
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rate_control", NullValueHandling = NullValueHandling.Ignore)]
        public RateControl RateControl { get; set; }

        /// <summary>
        /// 脚本语言，目前支持四种，分别是：SHELL BAT PYTHON POWER_SHELL
        /// </summary>
        [JsonProperty("script_language", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptLanguage { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty("update_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 实体的最后更新时间戳。 注意：执行创建/修改/删除操作时，update_time将更新。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Script {\n");
            sb.Append("  approveInfo: ").Append(ApproveInfo).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  onlineExistStatus: ").Append(OnlineExistStatus).Append("\n");
            sb.Append("  onlineId: ").Append(OnlineId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  rateControl: ").Append(RateControl).Append("\n");
            sb.Append("  scriptLanguage: ").Append(ScriptLanguage).Append("\n");
            sb.Append("  updateBy: ").Append(UpdateBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Script);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Script input)
        {
            if (input == null) return false;
            if (this.ApproveInfo != input.ApproveInfo || (this.ApproveInfo != null && !this.ApproveInfo.Equals(input.ApproveInfo))) return false;
            if (this.CreateBy != input.CreateBy || (this.CreateBy != null && !this.CreateBy.Equals(input.CreateBy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.OnlineExistStatus != input.OnlineExistStatus || (this.OnlineExistStatus != null && !this.OnlineExistStatus.Equals(input.OnlineExistStatus))) return false;
            if (this.OnlineId != input.OnlineId || (this.OnlineId != null && !this.OnlineId.Equals(input.OnlineId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RateControl != input.RateControl || (this.RateControl != null && !this.RateControl.Equals(input.RateControl))) return false;
            if (this.ScriptLanguage != input.ScriptLanguage || (this.ScriptLanguage != null && !this.ScriptLanguage.Equals(input.ScriptLanguage))) return false;
            if (this.UpdateBy != input.UpdateBy || (this.UpdateBy != null && !this.UpdateBy.Equals(input.UpdateBy))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.ApproveInfo != null) hashCode = hashCode * 59 + this.ApproveInfo.GetHashCode();
                if (this.CreateBy != null) hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OnlineExistStatus != null) hashCode = hashCode * 59 + this.OnlineExistStatus.GetHashCode();
                if (this.OnlineId != null) hashCode = hashCode * 59 + this.OnlineId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RateControl != null) hashCode = hashCode * 59 + this.RateControl.GetHashCode();
                if (this.ScriptLanguage != null) hashCode = hashCode * 59 + this.ScriptLanguage.GetHashCode();
                if (this.UpdateBy != null) hashCode = hashCode * 59 + this.UpdateBy.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
