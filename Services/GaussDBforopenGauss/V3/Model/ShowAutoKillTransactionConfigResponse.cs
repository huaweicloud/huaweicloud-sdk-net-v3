using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAutoKillTransactionConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 配置类型。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**: 筛选用户名。
        /// </summary>
        [JsonProperty("usernames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Usernames { get; set; }

        /// <summary>
        /// **参数解释**: 阈值。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? Threshold { get; set; }

        /// <summary>
        /// **参数解释**: 配置是否开启。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("auto_stop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoStop { get; set; }

        /// <summary>
        /// **参数解释**: 当前实例包含的所有数据库。
        /// </summary>
        [JsonProperty("database_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatabaseNames { get; set; }

        /// <summary>
        /// **参数解释**: 筛选数据库名。
        /// </summary>
        [JsonProperty("database_names_select", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatabaseNamesSelect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoKillTransactionConfigResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  usernames: ").Append(Usernames).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  autoStop: ").Append(AutoStop).Append("\n");
            sb.Append("  databaseNames: ").Append(DatabaseNames).Append("\n");
            sb.Append("  databaseNamesSelect: ").Append(DatabaseNamesSelect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoKillTransactionConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoKillTransactionConfigResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Usernames != input.Usernames || (this.Usernames != null && input.Usernames != null && !this.Usernames.SequenceEqual(input.Usernames))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.AutoStop != input.AutoStop || (this.AutoStop != null && !this.AutoStop.Equals(input.AutoStop))) return false;
            if (this.DatabaseNames != input.DatabaseNames || (this.DatabaseNames != null && input.DatabaseNames != null && !this.DatabaseNames.SequenceEqual(input.DatabaseNames))) return false;
            if (this.DatabaseNamesSelect != input.DatabaseNamesSelect || (this.DatabaseNamesSelect != null && input.DatabaseNamesSelect != null && !this.DatabaseNamesSelect.SequenceEqual(input.DatabaseNamesSelect))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Usernames != null) hashCode = hashCode * 59 + this.Usernames.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.AutoStop != null) hashCode = hashCode * 59 + this.AutoStop.GetHashCode();
                if (this.DatabaseNames != null) hashCode = hashCode * 59 + this.DatabaseNames.GetHashCode();
                if (this.DatabaseNamesSelect != null) hashCode = hashCode * 59 + this.DatabaseNamesSelect.GetHashCode();
                return hashCode;
            }
        }
    }
}
