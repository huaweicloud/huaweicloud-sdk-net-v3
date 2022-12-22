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
    public class CreateImageSyncRepoRequestBody 
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
        /// 自动同步，默认为false
        /// </summary>
        [JsonProperty("syncAuto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncAuto { get; set; }

        /// <summary>
        /// 是否覆盖，默认为false
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageSyncRepoRequestBody {\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("  remoteNamespace: ").Append(RemoteNamespace).Append("\n");
            sb.Append("  syncAuto: ").Append(SyncAuto).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageSyncRepoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageSyncRepoRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteRegionId == input.RemoteRegionId ||
                    (this.RemoteRegionId != null &&
                    this.RemoteRegionId.Equals(input.RemoteRegionId))
                ) && 
                (
                    this.RemoteNamespace == input.RemoteNamespace ||
                    (this.RemoteNamespace != null &&
                    this.RemoteNamespace.Equals(input.RemoteNamespace))
                ) && 
                (
                    this.SyncAuto == input.SyncAuto ||
                    (this.SyncAuto != null &&
                    this.SyncAuto.Equals(input.SyncAuto))
                ) && 
                (
                    this.Override == input.Override ||
                    (this.Override != null &&
                    this.Override.Equals(input.Override))
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
                if (this.RemoteRegionId != null)
                    hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                if (this.RemoteNamespace != null)
                    hashCode = hashCode * 59 + this.RemoteNamespace.GetHashCode();
                if (this.SyncAuto != null)
                    hashCode = hashCode * 59 + this.SyncAuto.GetHashCode();
                if (this.Override != null)
                    hashCode = hashCode * 59 + this.Override.GetHashCode();
                return hashCode;
            }
        }
    }
}
