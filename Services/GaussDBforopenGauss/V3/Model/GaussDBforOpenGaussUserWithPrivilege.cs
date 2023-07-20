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
    /// 用户及其权限。
    /// </summary>
    public class GaussDBforOpenGaussUserWithPrivilege 
    {

        /// <summary>
        /// 数据库帐号名称。  数据库帐号名称在1到63个字符之间，由字母、数字、或下划线组成，不能包含其他特殊字符，不能以“pg”和数字开头，不能和系统用户名称相同且帐号名称必须存在。  系统用户包括“rdsAdmin”,“ rdsMetric”, “rdsBackup”, “rdsRepl”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库帐号权限。 - true：只读。 - false：可读可写。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// schema名称。  schema名称在1到63个字符之间，由字母、数字、或下划线组成，不能包含其他特殊字符，不能以“pg”和数字开头，不能和GaussDB 模板库重名，且schema名称必须存在。  GaussDB 模板库包括postgres， template0 ，template1, public，information_schema。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussUserWithPrivilege {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussUserWithPrivilege);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussUserWithPrivilege input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                return hashCode;
            }
        }
    }
}
