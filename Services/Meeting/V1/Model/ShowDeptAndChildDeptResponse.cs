using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDeptAndChildDeptResponse : SdkResponse
    {

        /// <summary>
        /// 企业ID。
        /// </summary>
        [JsonProperty("corpId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门层级。
        /// </summary>
        [JsonProperty("deptLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeptLevel { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门名路径。
        /// </summary>
        [JsonProperty("deptNamePath", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptNamePath { get; set; }

        /// <summary>
        /// 是否叶子节点。
        /// </summary>
        [JsonProperty("isLeafNode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLeafNode { get; set; }

        /// <summary>
        /// 父部门编码。
        /// </summary>
        [JsonProperty("parentDeptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentDeptCode { get; set; }

        /// <summary>
        /// 部门编码路径。
        /// </summary>
        [JsonProperty("deptCodePath", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCodePath { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// 其他用户对该部门下用户的访问权限。
        /// </summary>
        [JsonProperty("inPermission", NullValueHandling = NullValueHandling.Ignore)]
        public string InPermission { get; set; }

        /// <summary>
        /// 该部门下用户访问权限控制。
        /// </summary>
        [JsonProperty("outPermission", NullValueHandling = NullValueHandling.Ignore)]
        public string OutPermission { get; set; }

        /// <summary>
        /// 允许访问的部门列表。
        /// </summary>
        [JsonProperty("designatedOutDeptCodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdMarkDTO> DesignatedOutDeptCodes { get; set; }

        /// <summary>
        /// 子部门列表。
        /// </summary>
        [JsonProperty("childDepts", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDeptResultDTO> ChildDepts { get; set; }

        /// <summary>
        /// 部门排序号。
        /// </summary>
        [JsonProperty("sortLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeptAndChildDeptResponse {\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  deptLevel: ").Append(DeptLevel).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  deptNamePath: ").Append(DeptNamePath).Append("\n");
            sb.Append("  isLeafNode: ").Append(IsLeafNode).Append("\n");
            sb.Append("  parentDeptCode: ").Append(ParentDeptCode).Append("\n");
            sb.Append("  deptCodePath: ").Append(DeptCodePath).Append("\n");
            sb.Append("  note: ").Append(Note).Append("\n");
            sb.Append("  inPermission: ").Append(InPermission).Append("\n");
            sb.Append("  outPermission: ").Append(OutPermission).Append("\n");
            sb.Append("  designatedOutDeptCodes: ").Append(DesignatedOutDeptCodes).Append("\n");
            sb.Append("  childDepts: ").Append(ChildDepts).Append("\n");
            sb.Append("  sortLevel: ").Append(SortLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeptAndChildDeptResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeptAndChildDeptResponse input)
        {
            if (input == null) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DeptLevel != input.DeptLevel || (this.DeptLevel != null && !this.DeptLevel.Equals(input.DeptLevel))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.DeptNamePath != input.DeptNamePath || (this.DeptNamePath != null && !this.DeptNamePath.Equals(input.DeptNamePath))) return false;
            if (this.IsLeafNode != input.IsLeafNode || (this.IsLeafNode != null && !this.IsLeafNode.Equals(input.IsLeafNode))) return false;
            if (this.ParentDeptCode != input.ParentDeptCode || (this.ParentDeptCode != null && !this.ParentDeptCode.Equals(input.ParentDeptCode))) return false;
            if (this.DeptCodePath != input.DeptCodePath || (this.DeptCodePath != null && !this.DeptCodePath.Equals(input.DeptCodePath))) return false;
            if (this.Note != input.Note || (this.Note != null && !this.Note.Equals(input.Note))) return false;
            if (this.InPermission != input.InPermission || (this.InPermission != null && !this.InPermission.Equals(input.InPermission))) return false;
            if (this.OutPermission != input.OutPermission || (this.OutPermission != null && !this.OutPermission.Equals(input.OutPermission))) return false;
            if (this.DesignatedOutDeptCodes != input.DesignatedOutDeptCodes || (this.DesignatedOutDeptCodes != null && input.DesignatedOutDeptCodes != null && !this.DesignatedOutDeptCodes.SequenceEqual(input.DesignatedOutDeptCodes))) return false;
            if (this.ChildDepts != input.ChildDepts || (this.ChildDepts != null && input.ChildDepts != null && !this.ChildDepts.SequenceEqual(input.ChildDepts))) return false;
            if (this.SortLevel != input.SortLevel || (this.SortLevel != null && !this.SortLevel.Equals(input.SortLevel))) return false;

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
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DeptLevel != null) hashCode = hashCode * 59 + this.DeptLevel.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.DeptNamePath != null) hashCode = hashCode * 59 + this.DeptNamePath.GetHashCode();
                if (this.IsLeafNode != null) hashCode = hashCode * 59 + this.IsLeafNode.GetHashCode();
                if (this.ParentDeptCode != null) hashCode = hashCode * 59 + this.ParentDeptCode.GetHashCode();
                if (this.DeptCodePath != null) hashCode = hashCode * 59 + this.DeptCodePath.GetHashCode();
                if (this.Note != null) hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.InPermission != null) hashCode = hashCode * 59 + this.InPermission.GetHashCode();
                if (this.OutPermission != null) hashCode = hashCode * 59 + this.OutPermission.GetHashCode();
                if (this.DesignatedOutDeptCodes != null) hashCode = hashCode * 59 + this.DesignatedOutDeptCodes.GetHashCode();
                if (this.ChildDepts != null) hashCode = hashCode * 59 + this.ChildDepts.GetHashCode();
                if (this.SortLevel != null) hashCode = hashCode * 59 + this.SortLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
