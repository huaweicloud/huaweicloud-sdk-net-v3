using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 节点信息
    /// </summary>
    public class TreeNode 
    {

        /// <summary>
        /// 目录或文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 目录或文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 是否为叶子节点，true是，false不是
        /// </summary>
        [JsonProperty("is_leaf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLeaf { get; set; }

        /// <summary>
        /// 屏蔽状态，包括unchecked(不屏蔽)、all(全屏蔽)、half(半屏蔽)
        /// </summary>
        [JsonProperty("checkbox_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckboxStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TreeNode {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  isLeaf: ").Append(IsLeaf).Append("\n");
            sb.Append("  checkboxStatus: ").Append(CheckboxStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TreeNode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TreeNode input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.IsLeaf != input.IsLeaf || (this.IsLeaf != null && !this.IsLeaf.Equals(input.IsLeaf))) return false;
            if (this.CheckboxStatus != input.CheckboxStatus || (this.CheckboxStatus != null && !this.CheckboxStatus.Equals(input.CheckboxStatus))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.IsLeaf != null) hashCode = hashCode * 59 + this.IsLeaf.GetHashCode();
                if (this.CheckboxStatus != null) hashCode = hashCode * 59 + this.CheckboxStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
