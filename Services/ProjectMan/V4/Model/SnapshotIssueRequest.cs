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
    /// 根据快照查询工作项信息的请求对象
    /// </summary>
    public class SnapshotIssueRequest 
    {

        /// <summary>
        /// 快照的ID数组。可以通过查询工作项快照列表接口获取，响应消息体中的id字段的值就是工作项快照ID。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 是否返回工作项简要信息。 当值为false时ids中仅支持5个快照ID；值为true时，ids最多支持50个快照ID。
        /// </summary>
        [JsonProperty("simple_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SimpleResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotIssueRequest {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  simpleResult: ").Append(SimpleResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SnapshotIssueRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SnapshotIssueRequest input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.SimpleResult != input.SimpleResult || (this.SimpleResult != null && !this.SimpleResult.Equals(input.SimpleResult))) return false;

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
                if (this.SimpleResult != null) hashCode = hashCode * 59 + this.SimpleResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
