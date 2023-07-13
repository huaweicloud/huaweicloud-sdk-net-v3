using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListJobsRequest 
    {

        /// <summary>
        /// 作业来源于课堂或课程。 取值范围： classroom:课堂作业 course:课程作业
        /// </summary>
        [SDKProperty("source_from", IsQuery = true)]
        [JsonProperty("source_from", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFrom { get; set; }

        /// <summary>
        /// 课堂ID或者课程ID。
        /// </summary>
        [SDKProperty("source_id", IsQuery = true)]
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 信息记录的起始编号
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页包含的信息记录数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobsRequest {\n");
            sb.Append("  sourceFrom: ").Append(SourceFrom).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceFrom == input.SourceFrom ||
                    (this.SourceFrom != null &&
                    this.SourceFrom.Equals(input.SourceFrom))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.SourceFrom != null)
                    hashCode = hashCode * 59 + this.SourceFrom.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
