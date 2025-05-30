using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数绑定日志配置。
    /// </summary>
    public class FuncLogConfig 
    {

        /// <summary>
        /// 函数绑定日志组名。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 函数绑定日志组ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 函数绑定日志流名。
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 函数绑定日志流ID。
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuncLogConfig {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuncLogConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuncLogConfig input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
