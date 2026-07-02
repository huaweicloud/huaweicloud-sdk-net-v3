using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Subtask 
    {

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 内部任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobId { get; set; }

        /// <summary>
        /// 命名空间名
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 制品仓库
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// 制品版本
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// sha256值
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// 老化动作， DEL
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 状态，Initialized、Pending、InProgress、Succeed、Failed、Stopped
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonProperty("status_text", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusText { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("op_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OpTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subtask {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusText: ").Append(StatusText).Append("\n");
            sb.Append("  opTime: ").Append(OpTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subtask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subtask input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.Digest != input.Digest || (this.Digest != null && !this.Digest.Equals(input.Digest))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusText != input.StatusText || (this.StatusText != null && !this.StatusText.Equals(input.StatusText))) return false;
            if (this.OpTime != input.OpTime || (this.OpTime != null && !this.OpTime.Equals(input.OpTime))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Digest != null) hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusText != null) hashCode = hashCode * 59 + this.StatusText.GetHashCode();
                if (this.OpTime != null) hashCode = hashCode * 59 + this.OpTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
