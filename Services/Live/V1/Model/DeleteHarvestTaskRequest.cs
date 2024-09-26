using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteHarvestTaskRequest 
    {

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-Internal访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-Internal", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-Internal", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowInternal { get; set; }

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-External访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-External", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-External", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowExternal { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHarvestTaskRequest {\n");
            sb.Append("  accessControlAllowInternal: ").Append(AccessControlAllowInternal).Append("\n");
            sb.Append("  accessControlAllowExternal: ").Append(AccessControlAllowExternal).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHarvestTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteHarvestTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessControlAllowInternal == input.AccessControlAllowInternal ||
                    (this.AccessControlAllowInternal != null &&
                    this.AccessControlAllowInternal.Equals(input.AccessControlAllowInternal))
                ) && 
                (
                    this.AccessControlAllowExternal == input.AccessControlAllowExternal ||
                    (this.AccessControlAllowExternal != null &&
                    this.AccessControlAllowExternal.Equals(input.AccessControlAllowExternal))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.AccessControlAllowInternal != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowInternal.GetHashCode();
                if (this.AccessControlAllowExternal != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowExternal.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
