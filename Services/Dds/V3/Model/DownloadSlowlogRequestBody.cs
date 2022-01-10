using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadSlowlogRequestBody 
    {

        /// <summary>
        /// - 需要下载的文件的文件名列表。
        /// </summary>
        [JsonProperty("file_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FileNameList { get; set; }

        /// <summary>
        /// 节点ID列表，取空值，表示查询实例下所有允许查询的节点。使用请参考《DDS API参考》的“查询实例列表和详情”响应消息表“nodes 数据结构说明”的“id”。允许查询的节点如下： - 集群下面的 shard节点 - 副本集、单节点下面的所有节点
        /// </summary>
        [JsonProperty("node_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIdList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadSlowlogRequestBody {\n");
            sb.Append("  fileNameList: ").Append(FileNameList).Append("\n");
            sb.Append("  nodeIdList: ").Append(NodeIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadSlowlogRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadSlowlogRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileNameList == input.FileNameList ||
                    this.FileNameList != null &&
                    input.FileNameList != null &&
                    this.FileNameList.SequenceEqual(input.FileNameList)
                ) && 
                (
                    this.NodeIdList == input.NodeIdList ||
                    this.NodeIdList != null &&
                    input.NodeIdList != null &&
                    this.NodeIdList.SequenceEqual(input.NodeIdList)
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
                if (this.FileNameList != null)
                    hashCode = hashCode * 59 + this.FileNameList.GetHashCode();
                if (this.NodeIdList != null)
                    hashCode = hashCode * 59 + this.NodeIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
