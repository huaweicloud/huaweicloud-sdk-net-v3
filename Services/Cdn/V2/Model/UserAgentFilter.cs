using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// UA黑白名单设置。
    /// </summary>
    public class UserAgentFilter 
    {

        /// <summary>
        /// UA黑白名单类型 off：关闭UA黑白名单; black：UA黑名单; white：UA白名单;
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 配置UA黑白名单，当type&#x3D;off时，非必传。最多配置10条规则，单条规则不超过100个字符，多条规则用“,”分割。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 是否包含空User-Agent，true:包含，false：不包含。空User-Agent是指没有User-Agent字段或者该字段的值为空。如果黑名单且该字段值为true，则表示空User-Agent不允许访问，如果是白名单且该字段值为true，则表示空User-Agent允许访问。设置User-Agent黑名单时，默认值为false，设置User-Agent白名单时，默认值为true。
        /// </summary>
        [JsonProperty("include_empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEmpty { get; set; }

        /// <summary>
        /// 配置UA黑白名单，当type&#x3D;off时，非必传。最多配置10条规则，单条规则不超过100个字符,同时配置value和ua_list时，ua_list生效。 
        /// </summary>
        [JsonProperty("ua_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UaList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAgentFilter {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  includeEmpty: ").Append(IncludeEmpty).Append("\n");
            sb.Append("  uaList: ").Append(UaList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserAgentFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserAgentFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IncludeEmpty == input.IncludeEmpty ||
                    (this.IncludeEmpty != null &&
                    this.IncludeEmpty.Equals(input.IncludeEmpty))
                ) && 
                (
                    this.UaList == input.UaList ||
                    this.UaList != null &&
                    input.UaList != null &&
                    this.UaList.SequenceEqual(input.UaList)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.IncludeEmpty != null)
                    hashCode = hashCode * 59 + this.IncludeEmpty.GetHashCode();
                if (this.UaList != null)
                    hashCode = hashCode * 59 + this.UaList.GetHashCode();
                return hashCode;
            }
        }
    }
}
