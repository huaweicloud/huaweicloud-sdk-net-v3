using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowCursorTimeRequest 
    {

        /// <summary>
        /// 日志组ID，获取方式请参见：获取项目ID，获取账号ID，日志组ID、日志流ID。 缺省值：None 最小长度：36 最大长度：36
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志流ID，获取方式请参见：获取项目ID，获取账号ID，日志组ID、日志流ID 缺省值：None 最小长度：36 最大长度：36
        /// </summary>
        [SDKProperty("stream_id", IsPath = true)]
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// Shard ID
        /// </summary>
        [SDKProperty("shard_id", IsPath = true)]
        [JsonProperty("shard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardId { get; set; }

        /// <summary>
        /// 游标值
        /// </summary>
        [SDKProperty("cursor", IsQuery = true)]
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCursorTimeRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  shardId: ").Append(ShardId).Append("\n");
            sb.Append("  cursor: ").Append(Cursor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCursorTimeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCursorTimeRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;
            if (this.ShardId != input.ShardId || (this.ShardId != null && !this.ShardId.Equals(input.ShardId))) return false;
            if (this.Cursor != input.Cursor || (this.Cursor != null && !this.Cursor.Equals(input.Cursor))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.ShardId != null) hashCode = hashCode * 59 + this.ShardId.GetHashCode();
                if (this.Cursor != null) hashCode = hashCode * 59 + this.Cursor.GetHashCode();
                return hashCode;
            }
        }
    }
}
