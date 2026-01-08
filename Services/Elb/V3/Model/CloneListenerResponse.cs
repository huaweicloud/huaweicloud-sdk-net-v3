using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CloneListenerResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：新监听器相关信息。
        /// </summary>
        [JsonProperty("listener_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloneListenerResp> ListenerList { get; set; }

        /// <summary>
        /// **参数解释**：请求的ID 。 **取值范围**：由数字、小写字母和中划线（-）组成的字符串，自动生成。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// **参数解释**：监听器复制任务的ID，任务详情可通过GET /v3/{project_id}/elb/jobs/{job_id}进行查询。 **取值范围**：标准的UUID格式，长度为36个字符。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneListenerResponse {\n");
            sb.Append("  listenerList: ").Append(ListenerList).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloneListenerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloneListenerResponse input)
        {
            if (input == null) return false;
            if (this.ListenerList != input.ListenerList || (this.ListenerList != null && input.ListenerList != null && !this.ListenerList.SequenceEqual(input.ListenerList))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.ListenerList != null) hashCode = hashCode * 59 + this.ListenerList.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
