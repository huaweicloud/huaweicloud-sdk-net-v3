using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RemoteMirrorSyncInfoDto 
    {

        /// <summary>
        /// **参数解释：** 用户名(需要base64加密)。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释：** 密码(需要base64加密)。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// **参数解释：** 拓展点uuid。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("endpoint_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUuid { get; set; }

        /// <summary>
        /// **参数解释：** 允许强制同步。 **约束限制：** 不涉及。 **取值范围：** - true，强制同步。 - false，不强制同步。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("force_fetch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceFetch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteMirrorSyncInfoDto {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  endpointUuid: ").Append(EndpointUuid).Append("\n");
            sb.Append("  forceFetch: ").Append(ForceFetch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteMirrorSyncInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteMirrorSyncInfoDto input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.EndpointUuid != input.EndpointUuid || (this.EndpointUuid != null && !this.EndpointUuid.Equals(input.EndpointUuid))) return false;
            if (this.ForceFetch != input.ForceFetch || (this.ForceFetch != null && !this.ForceFetch.Equals(input.ForceFetch))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.EndpointUuid != null) hashCode = hashCode * 59 + this.EndpointUuid.GetHashCode();
                if (this.ForceFetch != null) hashCode = hashCode * 59 + this.ForceFetch.GetHashCode();
                return hashCode;
            }
        }
    }
}
