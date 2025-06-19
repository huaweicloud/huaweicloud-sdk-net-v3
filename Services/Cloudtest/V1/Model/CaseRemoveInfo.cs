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
    public class CaseRemoveInfo 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 迭代Uri
        /// </summary>
        [JsonProperty("iterator_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorUri { get; set; }

        /// <summary>
        /// 是否移除关联的issue
        /// </summary>
        [JsonProperty("remove_associate_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveAssociateIssue { get; set; }

        /// <summary>
        /// 用例列表信息
        /// </summary>
        [JsonProperty("case_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CaseIdAndTypeInfo> CaseList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseRemoveInfo {\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  iteratorUri: ").Append(IteratorUri).Append("\n");
            sb.Append("  removeAssociateIssue: ").Append(RemoveAssociateIssue).Append("\n");
            sb.Append("  caseList: ").Append(CaseList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseRemoveInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseRemoveInfo input)
        {
            if (input == null) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.IteratorUri != input.IteratorUri || (this.IteratorUri != null && !this.IteratorUri.Equals(input.IteratorUri))) return false;
            if (this.RemoveAssociateIssue != input.RemoveAssociateIssue || (this.RemoveAssociateIssue != null && !this.RemoveAssociateIssue.Equals(input.RemoveAssociateIssue))) return false;
            if (this.CaseList != input.CaseList || (this.CaseList != null && input.CaseList != null && !this.CaseList.SequenceEqual(input.CaseList))) return false;

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
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.IteratorUri != null) hashCode = hashCode * 59 + this.IteratorUri.GetHashCode();
                if (this.RemoveAssociateIssue != null) hashCode = hashCode * 59 + this.RemoveAssociateIssue.GetHashCode();
                if (this.CaseList != null) hashCode = hashCode * 59 + this.CaseList.GetHashCode();
                return hashCode;
            }
        }
    }
}
