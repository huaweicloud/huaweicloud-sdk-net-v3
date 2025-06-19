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
    public class AddResourceInfo 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 迭代uri
        /// </summary>
        [JsonProperty("iterator_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorUri { get; set; }

        /// <summary>
        /// 资源类型, 对应serviceType
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 是否选择issues
        /// </summary>
        [JsonProperty("is_all_issues", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAllIssues { get; set; }

        /// <summary>
        /// 是否选择所有用例
        /// </summary>
        [JsonProperty("all_import", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllImport { get; set; }

        /// <summary>
        /// 按照目录引入用例
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

        /// <summary>
        /// 选择的资源列表, 对应sourceCaseUris
        /// </summary>
        [JsonProperty("simple_resourceinfo_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SimpleResourceInfo> SimpleResourceinfoList { get; set; }

        /// <summary>
        /// 反选的资源列表
        /// </summary>
        [JsonProperty("invert_simple_resourceinfo_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SimpleResourceInfo> InvertSimpleResourceinfoList { get; set; }

        /// <summary>
        /// 是否将需求添加到测试计划（不传或者true添加需求到测试计划，false就不添加）
        /// </summary>
        [JsonProperty("add_to_iterator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddToIterator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddResourceInfo {\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  iteratorUri: ").Append(IteratorUri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isAllIssues: ").Append(IsAllIssues).Append("\n");
            sb.Append("  allImport: ").Append(AllImport).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  simpleResourceinfoList: ").Append(SimpleResourceinfoList).Append("\n");
            sb.Append("  invertSimpleResourceinfoList: ").Append(InvertSimpleResourceinfoList).Append("\n");
            sb.Append("  addToIterator: ").Append(AddToIterator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddResourceInfo input)
        {
            if (input == null) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.IteratorUri != input.IteratorUri || (this.IteratorUri != null && !this.IteratorUri.Equals(input.IteratorUri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.IsAllIssues != input.IsAllIssues || (this.IsAllIssues != null && !this.IsAllIssues.Equals(input.IsAllIssues))) return false;
            if (this.AllImport != input.AllImport || (this.AllImport != null && !this.AllImport.Equals(input.AllImport))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.SimpleResourceinfoList != input.SimpleResourceinfoList || (this.SimpleResourceinfoList != null && input.SimpleResourceinfoList != null && !this.SimpleResourceinfoList.SequenceEqual(input.SimpleResourceinfoList))) return false;
            if (this.InvertSimpleResourceinfoList != input.InvertSimpleResourceinfoList || (this.InvertSimpleResourceinfoList != null && input.InvertSimpleResourceinfoList != null && !this.InvertSimpleResourceinfoList.SequenceEqual(input.InvertSimpleResourceinfoList))) return false;
            if (this.AddToIterator != input.AddToIterator || (this.AddToIterator != null && !this.AddToIterator.Equals(input.AddToIterator))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsAllIssues != null) hashCode = hashCode * 59 + this.IsAllIssues.GetHashCode();
                if (this.AllImport != null) hashCode = hashCode * 59 + this.AllImport.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.SimpleResourceinfoList != null) hashCode = hashCode * 59 + this.SimpleResourceinfoList.GetHashCode();
                if (this.InvertSimpleResourceinfoList != null) hashCode = hashCode * 59 + this.InvertSimpleResourceinfoList.GetHashCode();
                if (this.AddToIterator != null) hashCode = hashCode * 59 + this.AddToIterator.GetHashCode();
                return hashCode;
            }
        }
    }
}
