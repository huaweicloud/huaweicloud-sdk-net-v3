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
    public class AddTestItemInfo 
    {

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 是否为特性,1:特性 2:目录
        /// </summary>
        [JsonProperty("is_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string IsFeature { get; set; }

        /// <summary>
        /// 项目uuid
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 父节点uri
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 是否忽略名称重复
        /// </summary>
        [JsonProperty("ignore_duplicate_name", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreDuplicateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTestItemInfo {\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  isFeature: ").Append(IsFeature).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  ignoreDuplicateName: ").Append(IgnoreDuplicateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddTestItemInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddTestItemInfo input)
        {
            if (input == null) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.IsFeature != input.IsFeature || (this.IsFeature != null && !this.IsFeature.Equals(input.IsFeature))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.IgnoreDuplicateName != input.IgnoreDuplicateName || (this.IgnoreDuplicateName != null && !this.IgnoreDuplicateName.Equals(input.IgnoreDuplicateName))) return false;

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
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.IsFeature != null) hashCode = hashCode * 59 + this.IsFeature.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.IgnoreDuplicateName != null) hashCode = hashCode * 59 + this.IgnoreDuplicateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
