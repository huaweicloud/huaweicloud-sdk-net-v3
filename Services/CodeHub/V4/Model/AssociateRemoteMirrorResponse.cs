using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AssociateRemoteMirrorResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 仓库镜像配置ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库ID。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 同步状态。
        /// </summary>
        [JsonProperty("update_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateStatus { get; set; }

        /// <summary>
        /// **参数解释：** 最近修改时间。
        /// </summary>
        [JsonProperty("last_update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 镜像地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** 最近同步成功时间。
        /// </summary>
        [JsonProperty("last_successful_update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSuccessfulUpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 同步失败次数。
        /// </summary>
        [JsonProperty("number_of_failures", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfFailures { get; set; }

        /// <summary>
        /// **参数解释：** 开启定时同步。
        /// </summary>
        [JsonProperty("mirroring_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MirroringEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 私有镜像。
        /// </summary>
        [JsonProperty("is_private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// **参数解释：** 拓展点uuid。
        /// </summary>
        [JsonProperty("endpoint_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUuid { get; set; }

        /// <summary>
        /// **参数解释：** 最近失败信息。
        /// </summary>
        [JsonProperty("last_error", NullValueHandling = NullValueHandling.Ignore)]
        public string LastError { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateRemoteMirrorResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  updateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  lastUpdateAt: ").Append(LastUpdateAt).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  lastSuccessfulUpdateAt: ").Append(LastSuccessfulUpdateAt).Append("\n");
            sb.Append("  numberOfFailures: ").Append(NumberOfFailures).Append("\n");
            sb.Append("  mirroringEnabled: ").Append(MirroringEnabled).Append("\n");
            sb.Append("  isPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  endpointUuid: ").Append(EndpointUuid).Append("\n");
            sb.Append("  lastError: ").Append(LastError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateRemoteMirrorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateRemoteMirrorResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.UpdateStatus != input.UpdateStatus || (this.UpdateStatus != null && !this.UpdateStatus.Equals(input.UpdateStatus))) return false;
            if (this.LastUpdateAt != input.LastUpdateAt || (this.LastUpdateAt != null && !this.LastUpdateAt.Equals(input.LastUpdateAt))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.LastSuccessfulUpdateAt != input.LastSuccessfulUpdateAt || (this.LastSuccessfulUpdateAt != null && !this.LastSuccessfulUpdateAt.Equals(input.LastSuccessfulUpdateAt))) return false;
            if (this.NumberOfFailures != input.NumberOfFailures || (this.NumberOfFailures != null && !this.NumberOfFailures.Equals(input.NumberOfFailures))) return false;
            if (this.MirroringEnabled != input.MirroringEnabled || (this.MirroringEnabled != null && !this.MirroringEnabled.Equals(input.MirroringEnabled))) return false;
            if (this.IsPrivate != input.IsPrivate || (this.IsPrivate != null && !this.IsPrivate.Equals(input.IsPrivate))) return false;
            if (this.EndpointUuid != input.EndpointUuid || (this.EndpointUuid != null && !this.EndpointUuid.Equals(input.EndpointUuid))) return false;
            if (this.LastError != input.LastError || (this.LastError != null && !this.LastError.Equals(input.LastError))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.UpdateStatus != null) hashCode = hashCode * 59 + this.UpdateStatus.GetHashCode();
                if (this.LastUpdateAt != null) hashCode = hashCode * 59 + this.LastUpdateAt.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.LastSuccessfulUpdateAt != null) hashCode = hashCode * 59 + this.LastSuccessfulUpdateAt.GetHashCode();
                if (this.NumberOfFailures != null) hashCode = hashCode * 59 + this.NumberOfFailures.GetHashCode();
                if (this.MirroringEnabled != null) hashCode = hashCode * 59 + this.MirroringEnabled.GetHashCode();
                if (this.IsPrivate != null) hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.EndpointUuid != null) hashCode = hashCode * 59 + this.EndpointUuid.GetHashCode();
                if (this.LastError != null) hashCode = hashCode * 59 + this.LastError.GetHashCode();
                return hashCode;
            }
        }
    }
}
