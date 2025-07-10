using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 录屏审计。
    /// </summary>
    public class PoliciesRecordAudit 
    {

        /// <summary>
        /// 是否开启录屏审计。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesRecordAuditRules Rules { get; set; }

        /// <summary>
        /// 存储类型。取值为： OBS：OBS桶类型。 SFTP：SFTP对接类型。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// OBS桶来源。取值为： AUTO_CREATE：自动创建。 CREATED：已创建的。
        /// </summary>
        [JsonProperty("obs_bucket_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketSource { get; set; }

        /// <summary>
        /// obs 桶名
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 录屏文件保留时长（天）。取值为1~180天，0 表示永久保留。
        /// </summary>
        [JsonProperty("retention_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesRecordAudit {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  obsBucketSource: ").Append(ObsBucketSource).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  retentionDuration: ").Append(RetentionDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesRecordAudit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesRecordAudit input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && !this.Rules.Equals(input.Rules))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.ObsBucketSource != input.ObsBucketSource || (this.ObsBucketSource != null && !this.ObsBucketSource.Equals(input.ObsBucketSource))) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;
            if (this.RetentionDuration != input.RetentionDuration || (this.RetentionDuration != null && !this.RetentionDuration.Equals(input.RetentionDuration))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.ObsBucketSource != null) hashCode = hashCode * 59 + this.ObsBucketSource.GetHashCode();
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.RetentionDuration != null) hashCode = hashCode * 59 + this.RetentionDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
