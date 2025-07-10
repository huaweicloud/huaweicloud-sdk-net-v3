using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 查询结果
    /// </summary>
    public class IssueConfigFieldsResponseBodyResult 
    {

        /// <summary>
        /// 字段配置
        /// </summary>
        [JsonProperty("config_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueConfigFieldsResponseBodyResultConfigFields> ConfigFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueConfigFieldsResponseBodyResult {\n");
            sb.Append("  configFields: ").Append(ConfigFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueConfigFieldsResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueConfigFieldsResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.ConfigFields != input.ConfigFields || (this.ConfigFields != null && input.ConfigFields != null && !this.ConfigFields.SequenceEqual(input.ConfigFields))) return false;

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
                if (this.ConfigFields != null) hashCode = hashCode * 59 + this.ConfigFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
