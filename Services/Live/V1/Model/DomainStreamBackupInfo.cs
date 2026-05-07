using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainStreamBackupInfo 
    {

        /// <summary>
        /// **参数解释**： 直播推流域名 **约束限制**： 不涉及 **取值范围**： 字符长度为[1-255]位 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// **参数解释**： 主备流开关 **约束限制**： 不涉及 **取值范围**： - true： 开启主备流功能 - false：关闭主备流功能 **默认取值**： false 
        /// </summary>
        [JsonProperty("stream_backup_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StreamBackupEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainStreamBackupInfo {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  streamBackupEnable: ").Append(StreamBackupEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainStreamBackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainStreamBackupInfo input)
        {
            if (input == null) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.StreamBackupEnable != input.StreamBackupEnable || (this.StreamBackupEnable != null && !this.StreamBackupEnable.Equals(input.StreamBackupEnable))) return false;

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
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.StreamBackupEnable != null) hashCode = hashCode * 59 + this.StreamBackupEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
