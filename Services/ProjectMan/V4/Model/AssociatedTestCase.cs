using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociatedTestCase 
    {

        /// <summary>
        /// 用例ID
        /// </summary>
        [JsonProperty("case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("case_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseNum { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseName { get; set; }

        /// <summary>
        /// 用例等级
        /// </summary>
        [JsonProperty("case_level", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusVo Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUser Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUser Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleProject Project { get; set; }

        /// <summary>
        /// 是否基线
        /// </summary>
        [JsonProperty("is_base_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsBaseLine { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedTestCase {\n");
            sb.Append("  caseId: ").Append(CaseId).Append("\n");
            sb.Append("  caseNum: ").Append(CaseNum).Append("\n");
            sb.Append("  caseName: ").Append(CaseName).Append("\n");
            sb.Append("  caseLevel: ").Append(CaseLevel).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  isBaseLine: ").Append(IsBaseLine).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatedTestCase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatedTestCase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaseId == input.CaseId ||
                    (this.CaseId != null &&
                    this.CaseId.Equals(input.CaseId))
                ) && 
                (
                    this.CaseNum == input.CaseNum ||
                    (this.CaseNum != null &&
                    this.CaseNum.Equals(input.CaseNum))
                ) && 
                (
                    this.CaseName == input.CaseName ||
                    (this.CaseName != null &&
                    this.CaseName.Equals(input.CaseName))
                ) && 
                (
                    this.CaseLevel == input.CaseLevel ||
                    (this.CaseLevel != null &&
                    this.CaseLevel.Equals(input.CaseLevel))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.IsBaseLine == input.IsBaseLine ||
                    (this.IsBaseLine != null &&
                    this.IsBaseLine.Equals(input.IsBaseLine))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CaseId != null)
                    hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.CaseNum != null)
                    hashCode = hashCode * 59 + this.CaseNum.GetHashCode();
                if (this.CaseName != null)
                    hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.CaseLevel != null)
                    hashCode = hashCode * 59 + this.CaseLevel.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.IsBaseLine != null)
                    hashCode = hashCode * 59 + this.IsBaseLine.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
