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
    /// 需要删除镜像自动同步任务的信息
    /// </summary>
    public class DeleteImageSyncRepoRequestBody 
    {

        /// <summary>
        /// 目标region ID。
        /// </summary>
        [JsonProperty("remoteRegionId", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteRegionId { get; set; }

        /// <summary>
        /// 目标组织
        /// </summary>
        [JsonProperty("remoteNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteNamespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteImageSyncRepoRequestBody {\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("  remoteNamespace: ").Append(RemoteNamespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteImageSyncRepoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteImageSyncRepoRequestBody input)
        {
            if (input == null) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;
            if (this.RemoteNamespace != input.RemoteNamespace || (this.RemoteNamespace != null && !this.RemoteNamespace.Equals(input.RemoteNamespace))) return false;

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
                if (this.RemoteRegionId != null) hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                if (this.RemoteNamespace != null) hashCode = hashCode * 59 + this.RemoteNamespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
