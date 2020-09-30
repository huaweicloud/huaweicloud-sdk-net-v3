using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ImportBackupResponse : SdkResponse
    {

        /// <summary>
        /// 同步备份副本接口的返回信息
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupSyncRespBody> Sync { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportBackupResponse {\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportBackupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportBackupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sync == input.Sync ||
                    this.Sync != null &&
                    input.Sync != null &&
                    this.Sync.SequenceEqual(input.Sync)
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
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                return hashCode;
            }
        }
    }
}
