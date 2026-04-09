using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TmlogInfo 
    {

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 压缩文件列表
        /// </summary>
        [JsonProperty("file_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FileList { get; set; }

        /// <summary>
        /// TMLOG文件大小单位（MB）。
        /// </summary>
        [JsonProperty("tmlog_size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TmlogSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmlogInfo {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  fileList: ").Append(FileList).Append("\n");
            sb.Append("  tmlogSize: ").Append(TmlogSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TmlogInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TmlogInfo input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.FileList != input.FileList || (this.FileList != null && input.FileList != null && !this.FileList.SequenceEqual(input.FileList))) return false;
            if (this.TmlogSize != input.TmlogSize || (this.TmlogSize != null && !this.TmlogSize.Equals(input.TmlogSize))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.FileList != null) hashCode = hashCode * 59 + this.FileList.GetHashCode();
                if (this.TmlogSize != null) hashCode = hashCode * 59 + this.TmlogSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
