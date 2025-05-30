using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// URL鉴权查询响应体。
    /// </summary>
    public class UrlAuthGetBody 
    {

        /// <summary>
        /// 是否开启URL鉴权，on：开启,off：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 鉴权方式， type_a：鉴权方式A， type_b：鉴权方式B， type_c1：鉴权方式C1， type_c2：鉴权方式C2。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 过期时间，单位：秒。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// 加密算法。
        /// </summary>
        [JsonProperty("sign_method", NullValueHandling = NullValueHandling.Ignore)]
        public string SignMethod { get; set; }

        /// <summary>
        /// 鉴权范围。
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inherit_config", NullValueHandling = NullValueHandling.Ignore)]
        public InheritConfigQuery InheritConfig { get; set; }

        /// <summary>
        /// 鉴权KEY。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 鉴权KEY（备）。
        /// </summary>
        [JsonProperty("backup_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupKey { get; set; }

        /// <summary>
        /// 鉴权参数。
        /// </summary>
        [JsonProperty("sign_arg", NullValueHandling = NullValueHandling.Ignore)]
        public string SignArg { get; set; }

        /// <summary>
        /// 时间格式， dec：十进制, hex：十六进制。
        /// </summary>
        [JsonProperty("time_format", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeFormat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlAuthGetBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  signMethod: ").Append(SignMethod).Append("\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  inheritConfig: ").Append(InheritConfig).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  backupKey: ").Append(BackupKey).Append("\n");
            sb.Append("  signArg: ").Append(SignArg).Append("\n");
            sb.Append("  timeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UrlAuthGetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UrlAuthGetBody input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.SignMethod != input.SignMethod || (this.SignMethod != null && !this.SignMethod.Equals(input.SignMethod))) return false;
            if (this.MatchType != input.MatchType || (this.MatchType != null && !this.MatchType.Equals(input.MatchType))) return false;
            if (this.InheritConfig != input.InheritConfig || (this.InheritConfig != null && !this.InheritConfig.Equals(input.InheritConfig))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.BackupKey != input.BackupKey || (this.BackupKey != null && !this.BackupKey.Equals(input.BackupKey))) return false;
            if (this.SignArg != input.SignArg || (this.SignArg != null && !this.SignArg.Equals(input.SignArg))) return false;
            if (this.TimeFormat != input.TimeFormat || (this.TimeFormat != null && !this.TimeFormat.Equals(input.TimeFormat))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.SignMethod != null) hashCode = hashCode * 59 + this.SignMethod.GetHashCode();
                if (this.MatchType != null) hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.InheritConfig != null) hashCode = hashCode * 59 + this.InheritConfig.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.BackupKey != null) hashCode = hashCode * 59 + this.BackupKey.GetHashCode();
                if (this.SignArg != null) hashCode = hashCode * 59 + this.SignArg.GetHashCode();
                if (this.TimeFormat != null) hashCode = hashCode * 59 + this.TimeFormat.GetHashCode();
                return hashCode;
            }
        }
    }
}
