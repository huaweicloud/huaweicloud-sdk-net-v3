using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 手动转储任务请求体
    /// </summary>
    public class TransferBackupRequestBody 
    {

        /// <summary>
        /// 备份id列表
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Backups { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 目标OBS桶名
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 目标前缀
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferBackupRequestBody {\n");
            sb.Append("  backups: ").Append(Backups).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferBackupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferBackupRequestBody input)
        {
            if (input == null) return false;
            if (this.Backups != input.Backups || (this.Backups != null && input.Backups != null && !this.Backups.SequenceEqual(input.Backups))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;

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
                if (this.Backups != null) hashCode = hashCode * 59 + this.Backups.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                return hashCode;
            }
        }
    }
}
