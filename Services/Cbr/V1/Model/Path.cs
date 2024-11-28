using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Path 
    {

        /// <summary>
        /// 路径ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 路径状态，有available和remove两种状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 该路径所属于的客户端ID
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 路径详情
        /// </summary>
        [JsonProperty("dir_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DirPath { get; set; }

        /// <summary>
        /// 排除目录列表，多个路径之间以英文逗号分隔 &gt; 该特性目前处于公测阶段，部分region可能无法使用。 
        /// </summary>
        [JsonProperty("exclude_paths", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludePaths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Path {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  dirPath: ").Append(DirPath).Append("\n");
            sb.Append("  excludePaths: ").Append(ExcludePaths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Path);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Path input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.DirPath != input.DirPath || (this.DirPath != null && !this.DirPath.Equals(input.DirPath))) return false;
            if (this.ExcludePaths != input.ExcludePaths || (this.ExcludePaths != null && !this.ExcludePaths.Equals(input.ExcludePaths))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.DirPath != null) hashCode = hashCode * 59 + this.DirPath.GetHashCode();
                if (this.ExcludePaths != null) hashCode = hashCode * 59 + this.ExcludePaths.GetHashCode();
                return hashCode;
            }
        }
    }
}
