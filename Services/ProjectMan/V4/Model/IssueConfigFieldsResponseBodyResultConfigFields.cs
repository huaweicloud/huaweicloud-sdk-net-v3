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
    public class IssueConfigFieldsResponseBodyResultConfigFields 
    {

        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [JsonProperty("show", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show { get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        [JsonProperty("show_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEditable { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; }

        /// <summary>
        /// 是否受控
        /// </summary>
        [JsonProperty("controlled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Controlled { get; set; }

        /// <summary>
        /// 可编辑的角色
        /// </summary>
        [JsonProperty("issue_roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IssueRoles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueConfigFieldsResponseBodyResultConfigFields {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  show: ").Append(Show).Append("\n");
            sb.Append("  showEditable: ").Append(ShowEditable).Append("\n");
            sb.Append("  optional: ").Append(Optional).Append("\n");
            sb.Append("  controlled: ").Append(Controlled).Append("\n");
            sb.Append("  issueRoles: ").Append(IssueRoles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueConfigFieldsResponseBodyResultConfigFields);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueConfigFieldsResponseBodyResultConfigFields input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Show != input.Show || (this.Show != null && !this.Show.Equals(input.Show))) return false;
            if (this.ShowEditable != input.ShowEditable || (this.ShowEditable != null && !this.ShowEditable.Equals(input.ShowEditable))) return false;
            if (this.Optional != input.Optional || (this.Optional != null && !this.Optional.Equals(input.Optional))) return false;
            if (this.Controlled != input.Controlled || (this.Controlled != null && !this.Controlled.Equals(input.Controlled))) return false;
            if (this.IssueRoles != input.IssueRoles || (this.IssueRoles != null && input.IssueRoles != null && !this.IssueRoles.SequenceEqual(input.IssueRoles))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Show != null) hashCode = hashCode * 59 + this.Show.GetHashCode();
                if (this.ShowEditable != null) hashCode = hashCode * 59 + this.ShowEditable.GetHashCode();
                if (this.Optional != null) hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Controlled != null) hashCode = hashCode * 59 + this.Controlled.GetHashCode();
                if (this.IssueRoles != null) hashCode = hashCode * 59 + this.IssueRoles.GetHashCode();
                return hashCode;
            }
        }
    }
}
