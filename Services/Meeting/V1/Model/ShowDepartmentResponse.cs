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
    public class ShowDepartmentResponse : SdkResponse
    {

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 是否为叶子节点（没有子部门的称为叶子节点）。
        /// </summary>
        [JsonProperty("isLeafNodes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLeafNodes { get; set; }

        /// <summary>
        /// 子部门详情。
        /// </summary>
        [JsonProperty("childDepts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChildDeptDTO> ChildDepts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDepartmentResponse {\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  isLeafNodes: ").Append(IsLeafNodes).Append("\n");
            sb.Append("  childDepts: ").Append(ChildDepts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDepartmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDepartmentResponse input)
        {
            if (input == null) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.IsLeafNodes != input.IsLeafNodes || (this.IsLeafNodes != null && !this.IsLeafNodes.Equals(input.IsLeafNodes))) return false;
            if (this.ChildDepts != input.ChildDepts || (this.ChildDepts != null && input.ChildDepts != null && !this.ChildDepts.SequenceEqual(input.ChildDepts))) return false;

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
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.IsLeafNodes != null) hashCode = hashCode * 59 + this.IsLeafNodes.GetHashCode();
                if (this.ChildDepts != null) hashCode = hashCode * 59 + this.ChildDepts.GetHashCode();
                return hashCode;
            }
        }
    }
}
