using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreatePostPaidServersResponse : SdkResponse
    {

        /// <summary>
        /// 提交任务成功后返回的任务ID，用户可以使用该ID对任务执行情况进行查询。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 云服务器ID列表。
        /// </summary>
        [JsonProperty("serverIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePostPaidServersResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePostPaidServersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePostPaidServersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ServerIds == input.ServerIds ||
                    this.ServerIds != null &&
                    input.ServerIds != null &&
                    this.ServerIds.SequenceEqual(input.ServerIds)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ServerIds != null)
                    hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
