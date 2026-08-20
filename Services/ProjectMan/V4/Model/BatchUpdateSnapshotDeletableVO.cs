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
    /// 批量更新快照可删除标识请求对象。
    /// </summary>
    public class BatchUpdateSnapshotDeletableVO 
    {

        /// <summary>
        /// 快照ID列表。通过接口查询工作项计划管理快照列表获取响应参数中的id字段。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 是否为可删除标识。
        /// </summary>
        [JsonProperty("deletable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateSnapshotDeletableVO {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  deletable: ").Append(Deletable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateSnapshotDeletableVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateSnapshotDeletableVO input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Deletable != input.Deletable || (this.Deletable != null && !this.Deletable.Equals(input.Deletable))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Deletable != null) hashCode = hashCode * 59 + this.Deletable.GetHashCode();
                return hashCode;
            }
        }
    }
}
