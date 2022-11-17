using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgencyPolicy 
    {

        /// <summary>
        /// 权限版本号，创建自定义策略时，该字段值填为“1.1”。 &gt; - 1.0：系统预置的角色。以服务为粒度，提供有限的服务相关角色用于授权。 &gt; - 1.1：策略。IAM最新提供的一种细粒度授权的能力，可以精确到具体服务的操作、资源以及请求条件等。
        /// </summary>
        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 授权语句，描述自定义策略的具体内容，不超过8个。
        /// </summary>
        [JsonProperty("Statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgencyPolicyStatement> Statement { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyPolicy {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  statement: ").Append(Statement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Statement == input.Statement ||
                    this.Statement != null &&
                    input.Statement != null &&
                    this.Statement.SequenceEqual(input.Statement)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Statement != null)
                    hashCode = hashCode * 59 + this.Statement.GetHashCode();
                return hashCode;
            }
        }
    }
}
