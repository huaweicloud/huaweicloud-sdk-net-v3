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
    /// 部门基本信息。
    /// </summary>
    public class DeptBasicDTO 
    {

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 企业id。
        /// </summary>
        [JsonProperty("corpId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门名称路径。
        /// </summary>
        [JsonProperty("deptNamePath", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptNamePath { get; set; }

        /// <summary>
        /// 父部门编码。
        /// </summary>
        [JsonProperty("parentDeptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentDeptCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeptBasicDTO {\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  deptNamePath: ").Append(DeptNamePath).Append("\n");
            sb.Append("  parentDeptCode: ").Append(ParentDeptCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeptBasicDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeptBasicDTO input)
        {
            if (input == null) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.DeptNamePath != input.DeptNamePath || (this.DeptNamePath != null && !this.DeptNamePath.Equals(input.DeptNamePath))) return false;
            if (this.ParentDeptCode != input.ParentDeptCode || (this.ParentDeptCode != null && !this.ParentDeptCode.Equals(input.ParentDeptCode))) return false;

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
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.DeptNamePath != null) hashCode = hashCode * 59 + this.DeptNamePath.GetHashCode();
                if (this.ParentDeptCode != null) hashCode = hashCode * 59 + this.ParentDeptCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
