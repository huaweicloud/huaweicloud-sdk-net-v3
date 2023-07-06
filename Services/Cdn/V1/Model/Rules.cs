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
    /// 
    /// </summary>
    public class Rules 
    {

        /// <summary>
        /// 0：全部类型，表示匹配所有文件，默认值。  1：文件类型，表示按文件后缀匹配。  2：文件夹类型，表示按目录匹配。  3：文件全路径类型，表示按文件全路径匹配。 5：缓存首页。
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleType { get; set; }

        /// <summary>
        /// 缓存匹配设置。  当rule_type为0时，为空。  当rule_type为1时，为文件后缀，输入首字符为“.”，以“;”进行分隔，如.jpg;.zip;.exe，并且输入的文件名后缀总数不超过20个。 当rule_type为2时，为目录，输入要求以“/”作为首字符，以“;”进行分隔，如/test/folder01;/test/folder02，并且输入的目录路径总数不超过20个。 当rule_type为3时，为全路径，输入要求以“/”作为首字符，支持匹配指定目录下的具体文件，或者带通配符“\\*”的文件，如/test/index.html或/test/\\*.jpg。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 缓存时间。最大支持365天。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 缓存时间单位。1：秒；2：分；3：小时；4：天。
        /// </summary>
        [JsonProperty("ttl_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlType { get; set; }

        /// <summary>
        /// 此条配置的优先级, 默认值1，数值越大，优先级越高。取值范围为1-100，优先级不能相同。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rules {\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  ttlType: ").Append(TtlType).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Rules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Rules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuleType == input.RuleType ||
                    (this.RuleType != null &&
                    this.RuleType.Equals(input.RuleType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
                ) && 
                (
                    this.TtlType == input.TtlType ||
                    (this.TtlType != null &&
                    this.TtlType.Equals(input.TtlType))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.RuleType != null)
                    hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.TtlType != null)
                    hashCode = hashCode * 59 + this.TtlType.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
