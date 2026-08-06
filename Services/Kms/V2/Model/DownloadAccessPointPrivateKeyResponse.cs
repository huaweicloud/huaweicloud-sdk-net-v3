using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DownloadAccessPointPrivateKeyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 接入点ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("access_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// **参数解释：** 通用类型接入点私钥 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadAccessPointPrivateKeyResponse {\n");
            sb.Append("  accessPointId: ").Append(AccessPointId).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadAccessPointPrivateKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadAccessPointPrivateKeyResponse input)
        {
            if (input == null) return false;
            if (this.AccessPointId != input.AccessPointId || (this.AccessPointId != null && !this.AccessPointId.Equals(input.AccessPointId))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;

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
                if (this.AccessPointId != null) hashCode = hashCode * 59 + this.AccessPointId.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
