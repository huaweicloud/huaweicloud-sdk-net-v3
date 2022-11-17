using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadBackupFilesReq 
    {

        /// <summary>
        /// 设置URL的有效期，必须在5分钟和24小时之内，单位为秒。
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Expiration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadBackupFilesReq {\n");
            sb.Append("  expiration: ").Append(Expiration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadBackupFilesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadBackupFilesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                return hashCode;
            }
        }
    }
}
